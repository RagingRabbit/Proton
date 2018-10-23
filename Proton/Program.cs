using System;
using Proton;

class MainClass : EngineAdapter
{
	public void Start()
	{
		Console.WriteLine("Engine has started");
	}

	public void Stop()
	{
		Console.WriteLine("Engine has stopped");
	}

	public void Update()
	{
		Console.WriteLine("Updating");
	}

	public static void Main(string[] args)
	{
		ProtonEngine.Launch(new MainClass(), new LaunchParams(1280, 720, ""));
		Console.ReadKey();	}
}
