#version 330 core

in data
{
	vec3 position;
	vec3 normal;
	vec2 uv;
} pass;

out vec4 out_Color;

uniform bool un_HasTexture;
uniform sampler2D un_Texture;

void main()
{
	float brightness = pass.position.y / 16.0;
	vec4 texColor = texture(un_Texture, pass.uv);
	if (un_HasTexture)
	{
		out_Color = texColor * brightness;
	}
	else
	{
		out_Color = vec4(0.7, 0.7, 0.7, 1.0);
	}
}