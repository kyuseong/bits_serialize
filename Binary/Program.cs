using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Man c = new Man();
            c.hair = 1;
            c.face = 2;
            c.nose = 3;
            c.lip = 4;

            byte[] bin1 = c.Write();

            Man c1 = new Man();
            c1.Read(bin1);
        }
    }

    public class Man
    {
        public byte hair;
        public byte face;
        public byte nose;
        public byte lip;

        public void Read(byte[] bin)
        {
            BinaryReader reader = new BinaryReader(bin);
            hair = (byte)reader.ReadInt(5);
            face = (byte)reader.ReadInt(5);
            nose = (byte)reader.ReadInt(5);
            lip = (byte)reader.ReadInt(5);
            
        }

        public byte[] Write()
        {
            BinaryWriter writer = new BinaryWriter(16);
            writer.WriteInt(hair, 5);
            writer.WriteInt(face, 5);
            writer.WriteInt(nose, 5);
            writer.WriteInt(lip, 5);
            return writer.Buffer;
        }
    }


}
