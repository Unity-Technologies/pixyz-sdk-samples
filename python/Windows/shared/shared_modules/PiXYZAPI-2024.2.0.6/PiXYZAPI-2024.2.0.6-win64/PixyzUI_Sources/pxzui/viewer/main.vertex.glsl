#version 330
const vec2 quadVertices[4] = vec2[4](vec2(0.0f, 1.0f), vec2(0.0f, 0.0f), vec2(1.0f, 1.0f), vec2(1.0f, 0.0f));
layout(location = 0) in vec2 aTexCoords;
out vec2 TexCoords;

void main()
{
   TexCoords = quadVertices[gl_VertexID];
   gl_Position = vec4(quadVertices[gl_VertexID] * 2. - vec2(1., 1.), 0., 1.0);
}
