using Lab07.Editor;
using Microsoft.Xna.Framework.Content;
using System.IO;

namespace Lab07.Engine.Interfaces
{
    internal interface ISerializable
    {
        public void Serialize(BinaryWriter _stream);
        public void Deserialize(BinaryReader _stream, GameEditor _game);
    }
}
