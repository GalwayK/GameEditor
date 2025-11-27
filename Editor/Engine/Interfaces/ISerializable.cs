using Lab08.Editor;
using Microsoft.Xna.Framework.Content;
using System.IO;

namespace Lab08.Engine.Interfaces
{
    internal interface ISerializable
    {
        public void Serialize(BinaryWriter _stream);
        public void Deserialize(BinaryReader _stream, GameEditor _game);
    }
}
