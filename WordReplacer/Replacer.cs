using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordReplacer
{
    public abstract class Replacer<T>
    {

        public abstract class Observer
        {

            public abstract void ReportProgress(int percent);

        }

        public Replacer(int bufferSize)
        {

        }

        public abstract Trie<T> ParseReplacementFile(FileStream inStream, T delimiter, T[] lineDelimiter);

        public abstract void Replace(FileStream inStream, FileStream outStream, Trie<T> map, Observer observer);

    }
}
