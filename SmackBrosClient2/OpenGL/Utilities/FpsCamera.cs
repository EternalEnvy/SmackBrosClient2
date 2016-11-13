using System;
using OpenTK;
using OpenTK.Input;

namespace NeptuneRenderEngine.Engine.Utilities
{
    public class FpsCamera : Camera
    {
        public float MouseSensitivity = 0.015f;
        public float MoveSpeed = 1f;

        private Vector2 _lastMousePos;

        public FpsCamera()
        {
            SetRotation((float) Math.PI, 0f, 0f);
        }

        public void Move(float x, float y, float z)
        {
            var offset = new Vector3();

            /*var forward = new Vector3((float)Math.Sin((float)Rotation.X), 0, (float)Math.Cos((float)Rotation.X));
            var right = new Vector3(-forward.Z, 0, forward.X);*/

            offset += x * Right;
            offset += z * Forward;
            offset.Y += y;

            offset = Vector3.Multiply(offset, MoveSpeed);

            AddPosition(offset);
        }

        public void AddMouseRotation(float x, float y)
        {
            x = x * MouseSensitivity;
            y = y * MouseSensitivity;

            var rotation = Rotation;
            rotation.X = (rotation.X + x) % ((float)Math.PI * 2.0f);
            rotation.Y = Math.Max(Math.Min(rotation.Y + y, (float)Math.PI / 2.0f - 0.1f), (float)-Math.PI / 2.0f + 0.1f);

            SetRotation(rotation);
        }

        private float[] _mouseDelta = new float[2];
        public override void Update(MouseDevice mouse, KeyboardDevice keyboard)
        {
            if (mouse[MouseButton.Middle])
            {
                Vector2 delta = _lastMousePos - new Vector2(mouse.X, mouse.Y);
                _mouseDelta[0] += delta.X;
                _mouseDelta[1] += delta.Y;

                _mouseDelta[0] *= 0.25f;
                _mouseDelta[1] *= 0.25f;

                AddMouseRotation(_mouseDelta[0], _mouseDelta[1]);
            }
            _lastMousePos = new Vector2(mouse.X, mouse.Y);

            float distance = keyboard[Key.ControlLeft] ? 0.1f : keyboard[Key.ShiftLeft] ? 5f : 0.7f;
            if (keyboard[Key.W]) //
                Move(0f, 0f, distance);
            if (keyboard[Key.A]) //   case 'a':
                Move(-distance, 0f, 0f);
            if (keyboard[Key.S]) //   case 's':
                Move(0f, 0f, -distance);
            if (keyboard[Key.D]) //   case 'd':
                Move(distance, 0f, 0f);
            if (keyboard[Key.Q]) //   case 'q':
                Move(0f, distance, 0f);
            if (keyboard[Key.E]) //    case 'e':
                Move(0f, -distance, 0f);
        }
    }
}
