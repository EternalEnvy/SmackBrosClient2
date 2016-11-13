using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.IO;
using System.Drawing;
using System.Media;
using System.Reflection;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using Assimp;
using Assimp.Configs;
using NeptuneRenderEngine.Engine;
using NeptuneRenderEngine.Engine.Interface;
using NeptuneRenderEngine.Engine.Interface.Buffers;
using NeptuneRenderEngine.Engine.Interface.Drawing;
using NeptuneRenderEngine.Engine.Interface.Shaders;
using NeptuneRenderEngine.Engine.Utilities;
using OpenTK;
using OpenTK.Graphics;
using SmackBrosClient2.Screens;
using SmackBrosClient2.Networking;
using SmackBrosClient2.DirectX;
using SmackBrosClient2.GameObjects;
using SmackBrosClient2.OpenGL;
using Mesh = Assimp.Mesh;

namespace SmackBrosClient2.Screens
{
    public class GameplayScreen : Screen
    {
        public string ServerIP;
        private bool DebugMode = true;

        //Network based
        static bool serverInitialized = false;
        static int port1 = 1521;
        static int port2 = 1522;
        static int port3 = 1523;
        static UdpClient client;
        static UdpClient client2;
        static UdpClient client3;
        static Thread ReceivingThread;
        static Thread GameUpdateThread;
        static Thread InputThread;
        
        static List<string> clientIPList = new List<string>();
        static readonly object packetProcessQueueLock = new object();
        static Queue<Packet> packetProcessQueue = new Queue<Packet>();
        static DateTime lastUpdateInputThread = DateTime.Now;
        static DateTime lastUpdateUpdateThread = DateTime.Now;
        const int BufferStateLength = 4;

        private VertexArray vertexArray;

        //The current rotation.
        private float rotation = 0.0f;
        private bool TexturesInitialised = false;
        private uint[] gtexture = new uint[1];

        private Assimp.Scene m_model;
        private Vector3 m_sceneCenter, m_sceneMin, m_sceneMax;
        //private float m_angle;
        //private int m_displayList;
        //private int m_texId;

        //Collections
        public Dictionary<string, SoundPlayer> songs = new Dictionary<string, SoundPlayer>();
        public Dictionary<string, SoundPlayer> effects = new Dictionary<string, SoundPlayer>();
        public Dictionary<string, Bitmap> images = new Dictionary<string, Bitmap>();

        AssimpContext Importer = new AssimpContext();

        List<Smacker> smackers = new List<Smacker>();
        private List<Inputs> inputlist = new List<Inputs>();

        private NeptuneRenderEngine.Engine.Utilities.Mesh mesh;

        //Temporary; for fun
        public bool songStarted = false;

        private void playSimpleSound()
        {
            if (!songStarted)
            {
                songs["Melee Menu"].Play();
            }
            songStarted = true;
        }
        public void LoadContent()
        {
            songs.Add("Melee Menu", new SoundPlayer(@"C:\Users\Lee\Documents\GitHub\SmackBrosClient\SmackBrosClient\files\menu.wav"));
            //String fileName = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "duck.dae");
            //AssimpContext importer = new AssimpContext();
            //importer.SetConfig(new NormalSmoothingAngleConfig(66.0f));
            //m_model = importer.ImportFile(fileName, PostProcessPreset.TargetRealTimeMaximumQuality);
            
            mesh = MeshLoader.LoadMesh(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "duck.dae");
            ShaderProgram program = new ShaderProgram("vertshaderTemp.vert", "fragShaderTemp.frag");
            vertexArray = new VertexArray();
            vertexArray.SetLayout(program, mesh.VertexBuffer, mesh.GetBindings("position", "normal", "texcoord"));

            //ComputeBoundingBox();
        }
        public void Initialize()
        {
            if (!songStarted)
            {
                playSimpleSound();
                songStarted = true;
            }
            StartThreads();
            LoadContent();
            InitializeTexture();
        }
        private void InitializeTexture()
        {
            TexturesInitialised = true;
        }

        public override void Initialize(ref ScreenManager manager)
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }

        public override void UpdateInput()
        {
            throw new NotImplementedException();
        }

        public override void UpdateMouse()
        {
            throw new NotImplementedException();
        }

        public override void Draw()
        {
            if (!TexturesInitialised)
            {
                InitializeTexture();
            }
            
            BindingHelper<ArrayBuffer>.Push(mesh.VertexBuffer);
            BindingHelper<VertexArray>.Push(vertexArray);
            GL.DrawArrays(OpenTK.Graphics.OpenGL.BeginMode.Triangles, 0, mesh.Length);
            BindingHelper<VertexArray>.Pop();
            BindingHelper<ArrayBuffer>.Pop();

            
        } 
        private void ComputeBoundingBox()
        {
            m_sceneMin = new Vector3(1e10f, 1e10f, 1e10f);
            m_sceneMax = new Vector3(-1e10f, -1e10f, -1e10f);

            m_sceneCenter.X = (m_sceneMin.X + m_sceneMax.X) / 2.0f;
            m_sceneCenter.Y = (m_sceneMin.Y + m_sceneMax.Y) / 2.0f;
            m_sceneCenter.Z = (m_sceneMin.Z + m_sceneMax.Z) / 2.0f;
        }
        private void ComputeBoundingBox(Node node, ref Vector3 min, ref Vector3 max, ref Matrix4 trafo)
        {
        }
        protected void OnUnload()
        {

        }
        //Handles the Resized event of the openGLControl1 control 
        private void Resized(double Width, double Height)
        {

        }
        private bool LoadModelAsset(string path)
        {
            path = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), path);
            return true;
        }
        void Get_Bounding_Box(Vector3 min, Vector3 max)
        {

            Matrix4x4 trafo = Matrix4x4.Identity;
            min.X = min.Y = min.Z = 1e10f;
            max.X = max.Y = max.Z = -1e10f;
            Get_Bounding_Box_For_Node(m_model.RootNode, min, max, trafo);
        }
        void Get_Bounding_Box_For_Node(Node nd, Vector3 min, Vector3 max, Matrix4x4 trafo)
        {
            Matrix4x4 prev = trafo;
            trafo = trafo * nd.Transform;
            for (int n = 0; n < nd.MeshCount; ++n)
            {
                Mesh mesh = m_model.Meshes[nd.MeshIndices[n]];
                for (int t = 0; t < mesh.VertexCount; ++t)
                {
                    Vector3 tmp = FromVector(mesh.Vertices[t]);
                    tmp = Vector3.Transform(tmp, FromMatrix(trafo));
                    min.X = Math.Min(min.X, tmp.X);
                    min.Y = Math.Min(min.Y, tmp.Y);
                    min.Z = Math.Min(min.Z, tmp.Z);

                    max.X = Math.Max(max.X, tmp.X);
                    max.Y = Math.Max(max.Y, tmp.Y);
                    max.Z = Math.Max(max.Z, tmp.Z);
                }
            }
            for (int k = 0; k < nd.ChildCount; ++k)
            {
                Get_Bounding_Box_For_Node(nd.Children[k], min, max, trafo);
            }
            trafo = prev;
        }
        
        
        void set_float4(float[] f, float a, float b, float c, float d)
        {
            f[0] = a;
            f[1] = b;
            f[2] = c;
            f[3] = d;
        }
        void color4_to_float4(Color4 c, float[] f)
        {
            f[0] = c.R;
            f[1] = c.G;
            f[2] = c.B;
            f[3] = c.A;
        }
        private float[] FloatFromMatrix(Matrix4 mat)
        {
            float[] f = new float[16];
            f[0] = mat.M11;
            f[1] = mat.M12;
            f[2] = mat.M13;
            f[3] = mat.M14;
            f[4] = mat.M21;
            f[5] = mat.M22;
            f[6] = mat.M23;
            f[7] = mat.M24;
            f[8] = mat.M31;
            f[9] = mat.M32;
            f[10] = mat.M33;
            f[11] = mat.M34;
            f[12] = mat.M41;
            f[13] = mat.M42;
            f[14] = mat.M43;
            f[15] = mat.M44;
            return f;
        }
        private Matrix4 FromMatrix(Matrix4x4 mat)
        {
            Matrix4 m = new Matrix4();
            m.M11 = mat.A1;
            m.M12 = mat.A2;
            m.M13 = mat.A3;
            m.M14 = mat.A4;
            m.M21 = mat.B1;
            m.M22 = mat.B2;
            m.M23 = mat.B3;
            m.M24 = mat.B4;
            m.M31 = mat.C1;
            m.M32 = mat.C2;
            m.M33 = mat.C3;
            m.M34 = mat.C4;
            m.M41 = mat.D1;
            m.M42 = mat.D2;
            m.M43 = mat.D3;
            m.M44 = mat.D4;
            return m;
        }
        void StartThreads()
        {
            new Task(() =>
            {
                client = client ?? new UdpClient(port1, AddressFamily.InterNetwork);
                client2 = client2 ?? new UdpClient(port2, AddressFamily.InterNetwork);
                client3 = client3 ?? new UdpClient(port3, AddressFamily.InterNetwork);
                IPHostEntry host;
                string localIP = "?";
                host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        localIP = ip.ToString();
                    }
                }
                ServerIP = localIP;
                ReceivingThread = new Thread(() => PacketQueue.Instance.ReceivingLoop(client2, new IPEndPoint(IPAddress.Any, port2), packetProcessQueue, packetProcessQueueLock));
                ReceivingThread.IsBackground = true;
                ReceivingThread.Start();
            }).Start(); 
            serverInitialized = true;
        }
        private void UpdateToState(GameStatePacket statePacket)
        {
            for (int i = 0, len = smackers.Count(); i < len; i++)
            {
                if(smackers[i].smackerID == statePacket.Smackers[i].Item1)
                {
                    smackers[i].EnumeratedState = statePacket.Smackers[i].Item2;
                    smackers[i].Position = statePacket.Smackers[i].Item3;
                }
                else
                {
                    Console.WriteLine("Network ordering error.");
                }
            }
        }
        private void LinearInterpolateUpdateToState(GameStatePacket statePacket1, GameStatePacket statePacket2, long targetSequence)
        {
            float weight = (targetSequence - statePacket1.Sequence) / (statePacket2.Sequence - statePacket1.Sequence);
            for (int i = 0; i < smackers.Count(); i++)
            {
                smackers[i].EnumeratedState = statePacket2.Smackers[i].Item2;
                smackers[i].Position = Vector2.Lerp(statePacket1.Smackers[i].Item3, statePacket2.Smackers[i].Item3, weight);
            }
        }
        private Vector3 FromVector(Vector3D vec)
        {
            Vector3 v = new Vector3(vec.X, vec.Y, vec.Z);
            return v;
        }

        private Color4 FromColor(Color4D color)
        {
            Color4 c;
            c.R = color.R;
            c.G = color.G;
            c.B = color.B;
            c.A = color.A;
            return c;
        }
    }
}
