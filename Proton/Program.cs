using Proton;
using System;

class MainClass : EngineAdapter
{
	VertexArray vao;

	public void Start()
	{
		Graphics.backgroundColor = new Color(0, 120, 215);

		vao = new VertexArray();
		vao.Bind();
		vao.AddBuffer(0, 2, new float[] { -0.5f, -0.5f, 0.5f, -0.5f, 0.5f, 0.5f, -0.5f, 0.5f }, BufferUsage.StaticDraw);
		vao.AddElementBuffer(new int[] { 0, 1, 2, 2, 3, 0 }, BufferUsage.StaticDraw);
		vao.Unbind();
	}

	public void Stop()
	{
		vao.Dispose();
	}

	public void Update()
	{
		vao.Bind();
		vao.EnableAttributes();
		vao.Draw();
		vao.DisableAttributes();
		vao.Unbind();
	}

	public static void Main(string[] args)
	{
		ProtonEngine.Launch(new MainClass(), new LaunchParams(1280, 720, ""));
		Console.ReadKey();	}
}
