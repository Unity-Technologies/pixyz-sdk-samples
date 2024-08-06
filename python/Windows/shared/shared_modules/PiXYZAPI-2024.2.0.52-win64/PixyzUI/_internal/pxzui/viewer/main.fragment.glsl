#version 330
in vec2 TexCoords;
uniform sampler2D compositedTexture;
out vec4 colorBuffer;

void main()
{
   colorBuffer = texture2D(compositedTexture, TexCoords);
}
