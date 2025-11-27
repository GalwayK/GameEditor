using Microsoft.Xna.Framework.Graphics;

namespace Lab08.Engine
{
    internal class Material
    {
        public Material() { }
        public Texture Diffuse {  get; set; }
        public Effect Effect { get; set; }
    }
}
