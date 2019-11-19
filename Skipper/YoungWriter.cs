using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections;

namespace Rico
{
    public class YoungWriter
    {
        public void WriteToFile(BinaryWriter youngWriter, int command, ArrayList inputs)
        {
            //BinaryWriter youngWriter = new BinaryWriter(File.Open(filename, FileMode.Create));

            foreach (object obj in inputs)
            {
                WriteCommand(youngWriter, (byte)command, obj);
            }
        }

        public void WriteCommand(BinaryWriter youngWriter, byte command, object obj)
        {
            //BinaryWriter youngWriter = new BinaryWriter(File.Open(filename, FileMode.Open), Encoding.ASCII, true);
            youngWriter.Write(command);
            if (obj is byte)
                youngWriter.Write((byte)obj);
            else if (obj is int)
                youngWriter.Write((int)obj);
            else if (obj is char)
                youngWriter.Write((char)obj);
            else if (obj is double)
                youngWriter.Write((double)obj);
            else if (obj is string)
                youngWriter.Write((string)obj);
            else if (obj is bool)
                youngWriter.Write((bool)obj);
            else if (obj is short)
                youngWriter.Write((short)obj);
        }

        public void WriteByte(BinaryWriter youngWriter, byte command)
        {
            //BinaryWriter youngWriter = new BinaryWriter(File.Open(filename, FileMode.Open));
            youngWriter.Write(command);
            //youngWriter.Close();

        }

        public static byte[] ObjectToByteArray(object obj)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        public void ICanReadToo(string filename)
        {
            byte[] buffer;
            FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            try
            {
                int length = (int)fileStream.Length;  // get file length
                buffer = new byte[length];            // create buffer
                int count;                            // actual number of bytes read
                int sum = 0;                          // total number of bytes read

                // read until Read method returns 0 (end of the stream has been reached)
                while ((count = fileStream.Read(buffer, sum, length - sum)) > 0)
                {
                    Console.WriteLine((int)buffer[sum] + "\n");
                    sum += count;  // sum is a buffer offset for next reading
                }
            }
            finally
            {
                fileStream.Close();
            }
            //return buffer;
        }
    }

}
