#version 330 core
out vec4 FragColor;  
//in vec3 ourColor;

//void main()
//{
//    FragColor = vec4(ourColor, 1.0);
//}

in vec3 outPosition;

void main()
{
	FragColor = vec4(outPosition, 1.0);
}