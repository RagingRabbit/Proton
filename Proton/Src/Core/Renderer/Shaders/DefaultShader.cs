﻿using System;

namespace Proton
{
	class DefaultShader
	{
		internal const string SRC_VERTEX = @"
#version 330 core

layout (location = 0) in vec3 in_Position;
layout (location = 1) in vec3 in_Normal;		
layout (location = 2) in vec2 in_Uv;

out data
{
	vec3 normal;
	vec2 uv;
} pass;

uniform mat4 un_Projection;
uniform mat4 un_View;

void main()
{
	gl_Position = un_Projection * un_View * vec4(in_Position, 1.0);
	
	pass.normal = in_Normal;
	pass.uv = in_Uv;
}
";

		internal const string SRC_FRAGMENT = @"
#version 330 core

in data
{
	vec3 normal;
	vec2 uv;
} pass;

out vec4 out_Color;

void main()
{
	out_Color = vec4(pass.uv, 1.0, 1.0);
}
";
	}
}
