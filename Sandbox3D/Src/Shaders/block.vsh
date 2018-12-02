#version 330 core

layout(location = 0) in vec3 in_Position;
layout(location = 1) in vec3 in_Normal;
layout(location = 2) in vec2 in_Uv;

out data
{
	vec3 position;
	vec3 normal;
	vec2 uv;
} pass;

uniform mat4 un_Projection;
uniform mat4 un_View;

void main()
{
	gl_Position = un_Projection * un_View * vec4(in_Position, 1.0);

	pass.position = in_Position;
	pass.normal = in_Normal;
	pass.uv = in_Uv;
}