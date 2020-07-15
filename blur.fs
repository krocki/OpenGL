#version 410
in vec2 coords;
uniform sampler2D tx;
out vec4 frag_color;
void main () {
  float inc = 1.0f/64.0f;
  int radius=5;
  float area = radius * radius;
  vec4 mean = vec4(0.0,0.0,0.0,0.0);
  for (int i=-radius/2; i<=radius/2; i++)
  for (int j=-radius/2; j<=radius/2; j++)
     mean += texture (tx, vec2(coords.x+inc*i, coords.y+inc*j));
  frag_color = mean / area;
}
