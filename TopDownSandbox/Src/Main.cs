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
            world = new World();

            Input.AddKeyListener(this);
            Input.AddCursorPosListener(this);
            //Input.cursorMode = CursorMode.Disabled;
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
            Camera.mainCamera.transform.rotation.eulerAngles += new Vector3(0, 1.0f, 0);
            //Camera.mainCamera.transform.rotation *= Quaternion.AxisAngle(0, 1, 0, 1.0f);
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.A)) Camera.mainCamera.transform.position.x -= Time.delta;
            if (Input.GetKeyDown(KeyCode.D)) Camera.mainCamera.transform.position.x += Time.delta;
            if (Input.GetKeyDown(KeyCode.W)) Camera.mainCamera.transform.position.z -= Time.delta;
            if (Input.GetKeyDown(KeyCode.S)) Camera.mainCamera.transform.position.z += Time.delta;

            world.Update();
            world.Render();
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
