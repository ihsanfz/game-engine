#version 330 core
out vec4 FragColor;
  
in vec3 ourColor;
in vec2 TexCoord;

uniform sampler2D newTexture;

void main()
{
    FragColor = texture(newTexture, TexCoord);
}