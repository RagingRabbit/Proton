using Proton;
using System;
using System.Collections.Generic;

class MainClass : EngineAdapter
{
	Model model;

	public void Start()
	{
		Graphics.backgroundColor = new Color(0, 120, 215);

		model = new Model();

		ModelData data = new ModelData();
		data.vertices = new List<Vertex>
		{
			new Vertex {position = new Vector3(-0.5f, -0.5f, 0.0f)},
			new Vertex {position = new Vector3(0.5f, -0.5f, 0.0f)},
			new Vertex {position = new Vector3(0.5f, 0.5f, 0.0f)},
			new Vertex {position = new Vector3(-0.5f, 0.5f, 0.0f)}
		};
		data.triangles = new List<Triangle>
		{
			new Triangle(0, 1, 2),
			new Triangle(2, 3, 0)
		};
		model.data = data;
	}

	public void Stop()
	{
	}

	public void Update()
	{
		Renderer3D.RenderModel(model);
	}

	public static void Main(string[] args)
	{
		ProtonEngine.Launch(new MainClass(), new LaunchParams(1280, 720, ""));
	}
}
