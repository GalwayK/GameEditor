using Lab07.Editor;

namespace Lab07.Engine.Interfaces
{
    internal interface IMaterial
    {
        Material Material { get; }
        void SetTexture(GameEditor _game, string _texture);
        void SetShader(GameEditor _game, string _shader);

    }
}
