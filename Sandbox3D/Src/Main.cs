using Proton;
using System;

public class Main_ : EngineAdapter, KeyListener
{
    const int WIDTH = 1280;
    const int HEIGHT = 720;
    const string TITLE = "";

    World world;
    bool wireframe;

    public void Start()
    {
        Graphics.backgroundColor = new Color(0x3420F2).Brightness(1.9f);
        Graphics.depthTesting = true;
        Graphics.backfaceCulling = true;
        Display.vsync = false;
        Camera.mainCamera.fovy = 90.0f;

        world = new World();

        Input.AddKeyListener(this);
        Input.cursorMode = CursorMode.Disabled;
    }

    public void OnKeyEvent(KeyCode key, bool down, KeyMod mods)
    {
        if (key == KeyCode.X && down)
        {
            Graphics.wireframeMode = wireframe = !wireframe;
        }
    }

    public void Update()
    {
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
