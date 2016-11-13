using System;
using OpenTK;
using OpenTK.Input;

namespace NeptuneRenderEngine.Engine.Utilities
{
    public abstract class Perspective : ISized
    {
        public Matrix4 Matrix { get; protected set; }

        public abstract void Resize(int width, int height);
    }

    public class OrthographicPerspective : Perspective
    {
        public float ZNear = 0.1f, ZFar = 500f;

        public override void Resize(int width, int height)
        {
            Matrix = Matrix4.CreateOrthographic(width, height, ZNear, ZFar);
        }
    }

    public class ProjectionPerspective : Perspective
    {
        public float ZNear = 0.1f, ZFar = 500f;

        public override void Resize(int width, int height)
        {
            Matrix = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, (float)width / (float)height, ZNear, ZFar);
        }
    }

    public class Camera : ISized
    {
        public Perspective Perspective;

        public Matrix4 ViewMatrix;

        public Vector3 Forward { get; private set; }
        public Vector3 Backward { get; private set; }
        public Vector3 Up { get; private set; }
        public Vector3 Down { get; private set; }
        public Vector3 Right { get; private set; }
        public Vector3 Left { get; private set; }

        public Vector3 Position { get; private set; }
        public Vector3 Rotation { get; private set; }

        public void Resize(int width, int height)
        {
            Perspective.Resize(width, height);
        }

        public void SetPosition(Vector3 position)
        {
            Position = position;
            Update();
        }

        public void AddPosition(Vector3 delta)
        {
            Position += delta;
            Update();
        }

        public void SetPosition(float x, float y, float z)
        {
            Position = new Vector3(x, y, z);
            Update();
        }

        public void AddPosition(float x, float y, float z)
        {
            Position += new Vector3(x, y, z);
            Update();
        }

        public void SetRotation(Vector3 eulerAngles)
        {
            Rotation = eulerAngles;
            Update();
        }

        public void SetRotation(float pitch, float yaw, float roll)
        {
            Rotation = new Vector3(pitch, yaw, roll); ;
            Update();
        }

        public void AddRotation(Vector3 delta)
        {
            Rotation += delta;
            Update();
        }

        public void AddRotation(float pitch, float yaw, float roll)
        {
            Rotation += new Vector3(pitch, yaw, roll);
            Update();
        }

        public void Update()
        {
            Forward = new Vector3
            {
                X = (float)(Math.Sin((float)Rotation.X) * Math.Cos((float)Rotation.Y)),
                Y = (float)Math.Sin((float)Rotation.Y),
                Z = (float)(Math.Cos((float)Rotation.X) * Math.Cos((float)Rotation.Y))
            };
            Forward.Normalize();
            Backward = -Forward;
            Right = Vector3.Cross(Forward, Vector3.UnitY);
            Right.Normalize();
            Left = -Right;
            Up = -Vector3.Cross(Forward, Right);
            Up.Normalize();
            Down = -Up;

            ViewMatrix = Matrix4.LookAt(Position, Position + Forward, Vector3.UnitY);
        }

        public virtual void Update(MouseDevice mouse, KeyboardDevice keyboard)
        {
            
        }
    }
}
