﻿using System;
using System.Collections.Generic;

namespace Proton
{
	public class Renderer3D
	{
		static Shader shader;
		static List<Model> models;

		static Renderer3D()
		{
			shader = new Shader(DefaultShader.SRC_VERTEX, DefaultShader.SRC_FRAGMENT);
			models = new List<Model>();
		}

		public static void RenderModel(Model model)
		{
			models.Add(model);
		}

		internal static void Flush()
		{
			shader.Enable();
			shader.SetVariable("un_Projection", Camera.mainCamera.projection);
			shader.SetVariable("un_View", Camera.mainCamera.view);
			for (int i = 0; i < models.Count; i++)
			{
				if (models[i].material.texture != null)
				{
					shader.BindTexture("un_Texture", models[i].material.texture, 0);
				}
				shader.SetVariable("un_HasTexture", models[i].material.texture != null);

				models[i].vao.Bind();
				models[i].vao.EnableAttributes();
				models[i].vao.Draw();
				models[i].vao.DisableAttributes();
				models[i].vao.Unbind();

				if (models[i].material.texture != null)
				{
					models[i].material.texture.Unbind();
				}
			}
			shader.Disable();

			models.Clear();
		}
	}
}
