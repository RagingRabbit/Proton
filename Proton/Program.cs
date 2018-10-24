using Proton;
using System;

class MainClass : EngineAdapter
{
    public void Start()
    {
        Graphics.backgroundColor = new Color(0, 120, 215);
    }

    public void Stop()
    {
    }

    public void Update()
    {
    }

    public static void Main(string[] args)
    {
        ProtonEngine.Launch(new MainClass(), new LaunchParams(1280, 720, ""));
        Console.ReadKey();    }
}
