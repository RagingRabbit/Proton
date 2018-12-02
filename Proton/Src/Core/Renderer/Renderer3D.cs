using System;
using System.Collections.Generic;

namespace Proton
{
    public class Renderer3D
    {
        static Shader defaultShader;
        static List<Model> models;

        static Renderer3D()
        {
            defaultShader = new Shader(DefaultShader.SRC_VERTEX, DefaultShader.SRC_FRAGMENT);
            models = new List<Model>();
        }

        public static void RenderModel(Model model)
        {
            models.Add(model);
        }

        internal static void Flush()
        {
            for (int i = 0; i < models.Count; i++)
            {
                Shader shader = defaultShader;
                if (models[i].material.shader != null)
                {
                    shader = models[i].material.shader;
                }
                shader.Enable();
                shader.SetVariable("un_Projection", Camera.mainCamera.projection);
                shader.SetVariable("un_View", Camera.mainCamera.view);

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

                shader.Disable();
            }

            models.Clear();
        }
    }
}
