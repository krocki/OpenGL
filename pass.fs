#version 410
in vec2 coords;
uniform sampler2D tx;
out vec4 frag_color;
void main () {
  frag_color = texture (tx, vec2(coords.xy));
}
