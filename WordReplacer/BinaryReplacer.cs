using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordReplacer
{
    public class BinaryReplacer : Replacer<byte>
    {

        private byte[] buffer;

        public BinaryReplacer(int bufferSize) : base(bufferSize)
        {
            buffer = new byte[bufferSize];
        }

        public override Trie<byte> ParseReplacementFile(FileStream inStream, byte delimiter, byte[] lineDelimiter)
        {
            Trie<byte> trie = new Trie<byte>();
            Trie<byte> cur = trie;
            using (inStream)
            {
                List<byte> dest = new List<byte>();
                int count;
                bool writingSource = true;
                int lineDelimiterIndex = 0;

                // read in a chunk of data and parse it
                while ((count = inStream.Read(buffer, 0, buffer.Length)) != 0) {

                    // iterate through the loaded data
                    for (int i = 0; i < count; i++)
                    {

                        // pull out byte
                        byte b = buffer[i];

                        // check if the byte is equal to the delimiter
                        if (b == delimiter)
                        {

                            // switch to reading the bytes as the destination replacement
                            lineDelimiterIndex = 0;
                            writingSource = false;

                        }

                        // check to see if the byte is equal to the current line delimiter
                        else if (b == lineDelimiter[lineDelimiterIndex])
                        {

                            // increment the line delimiter index
                            lineDelimiterIndex++;

                            // check to see if the byte string matches the line delimiter exactly
                            if (lineDelimiterIndex == lineDelimiter.Length)
                            {

                                // add the mapping to the trie and start again
                                cur.Replacement = dest.ToArray();
                                cur = trie;
                                dest.Clear();
                                lineDelimiterIndex = 0;
                                writingSource = true;
                            }
                        }

                        // check if the byte should go in the source trie
                        else if (writingSource)
                        {

                            // add it to the trie
                            lineDelimiterIndex = 0;
                            cur.Add(b);
                            
                            // add a child trie to the trie if there is a need
                            if (cur.GetChild(b) == null)
                            {
                                cur.SetChild(b, new Trie<byte>());
                            }

                            // move the cur reference to the child trie
                            cur = cur.GetChild(b);
                        }

                        // add the byte to the destination array
                        else
                        {
                            lineDelimiterIndex = 0;
                            dest.Add(b);
                        }
                    }
                }
            }
            return trie;
        }

        public override void Replace(FileStream inStream, FileStream outStream, Trie<byte> map, Observer observer)
        {
            //Dictionary<long, Trie<byte>> matches = new Dictionary<long, Trie<byte>>();
            Dictionary<List<byte>, Trie<byte>> matches = new Dictionary<List<byte>, Trie<byte>>();
            int count = 0;
            using (inStream)
            {
                using (outStream)
                {
                    while ((count = inStream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            byte b = buffer[i];
                            Dictionary<List<byte>, Trie<byte>> temp = new Dictionary<List<byte>, Trie<byte>>();
                            foreach (KeyValuePair<List<byte>, Trie<byte>> pair in matches)
                            {
                                if (pair.Value.Contains(b))
                                {
                                    List<byte> key = pair.Key;
                                    key.Add(b);
                                    temp[key] = pair.Value.GetChild(b);
                                }
                                else if (pair.Value.IsLeaf)
                                {
                                    outStream.Write(pair.Value.Replacement, 0, pair.Value.Replacement.Length);
                                }
                                else
                                {
                                    outStream.Write(pair.Key.ToArray(), 0, pair.Key.Count);
                                }
                            }
                            matches = temp;
                            if (map.Contains(b))
                            {
                                matches[new List<byte>(new byte[] { b })] = map.GetChild(b);
                            } else
                            {
                                outStream.Write(new byte[] { b }, 0, 1);
                            }
                            
                        }
                        /*if (outputBuffer.Count >= buffer.Length)
                        {
                            outStream.Write(outputBuffer.ToArray(), 0, outputBuffer.Count);
                            outputBuffer.Clear();
                        }*/
                    }
                }
            }
        }
    }
}
