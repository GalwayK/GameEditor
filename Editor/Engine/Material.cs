using Microsoft.Xna.Framework.Graphics;

namespace Lab07.Engine
{
    internal class Material
    {
        public Material() { }
        public Texture Diffuse {  get; set; }
        public Effect Effect { get; set; }
    }
}
