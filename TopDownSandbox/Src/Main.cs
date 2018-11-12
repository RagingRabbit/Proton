using Proton;
using System;

namespace TopDownSandbox
{
    public class Main_ : EngineAdapter, KeyListener, CursorPosListener
    {
        const int WIDTH = 1280;
        const int HEIGHT = 720;
        const string TITLE = "";

        World world;
        bool wireframe;

        public void Start()
        {
            Graphics.backgroundColor = new Color(0x3420F2).Brightness(0.2f);
            Display.vsync = false;

            world = new World();

            Input.AddKeyListener(this);
            Input.AddCursorPosListener(this);
            Input.cursorMode = CursorMode.Disabled;
        }

        public void OnKeyEvent(KeyCode key, bool down, KeyMod mods)
        {
            if (key == KeyCode.X && down)
            {
                Graphics.wireframeMode = wireframe = !wireframe;
            }
        }

        public void OnCursorMove(int dx, int dy)
        {
            Camera.mainCamera.transform.rotation = Quaternion.AxisAngle(Vector3.up, dx / 10.0f) * Camera.mainCamera.transform.rotation * Quaternion.AxisAngle(Vector3.right, dy / 10.0f);
        }

        public void Update()
        {
            Vector3 delta = new Vector3();

            if (Input.GetKeyDown(KeyCode.A)) delta.x -= Time.delta;
            if (Input.GetKeyDown(KeyCode.D)) delta.x += Time.delta;
            if (Input.GetKeyDown(KeyCode.W)) delta.z -= Time.delta;
            if (Input.GetKeyDown(KeyCode.S)) delta.z += Time.delta;

            Camera.mainCamera.transform.position += (Camera.mainCamera.transform.rotation * delta.normalized * new Vector3(1, 0, 1)).normalized * delta.length;

            world.Update();
            world.Render();

            Display.title = "" + Time.fps + " fps, " + (int)Time.delta + " ms";
        }

        public void Stop()
        {
        }

        static void Main(string[] args)
        {
            ProtonEngine.Launch(new Main_(), new LaunchParams(WIDTH, HEIGHT, TITLE));
        }
    }
}
