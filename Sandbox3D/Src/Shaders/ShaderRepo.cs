using Proton;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class ShaderRepo
{
    public static readonly Shader BLOCK_SHADER;

    static ShaderRepo()
    {
        BLOCK_SHADER = new Shader(
            File.ReadAllText("../../Src/Shaders/block.vsh"),
            File.ReadAllText("../../Src/Shaders/block.fsh")
        );
    }
}
