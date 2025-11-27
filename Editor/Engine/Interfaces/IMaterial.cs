using Lab06.Editor;

namespace Lab06.Engine.Interfaces
{
    internal interface IMaterial
    {
        Material Material { get; }
        void SetTexture(GameEditor _game, string _texture);
        void SetShader(GameEditor _game, string _shader);

    }
}
