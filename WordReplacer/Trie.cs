using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordReplacer
{
    public class Trie<T> : IEnumerable<T[]>
    {

        private class TrieEnumerator : IEnumerator<T[]>
        {

            List<T> current = new List<T>();
            Trie<T> trie;
            Stack<Trie<T>> stack;

            public TrieEnumerator(Trie<T> trie)
            {
                this.trie = trie;
            }

            public T[] Current => current.ToArray();

            object IEnumerator.Current => current.ToArray();

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                if (stack == null)
                {
                    stack = new Stack<Trie<T>>();
                    stack.Push(trie);
                } else
                {
                    Trie<T> cur = stack.Pop();
                    if (!cur.IsLeaf)
                    {
                        /*foreach (Dictionary<T, Trie<T>> child in cur.Children)
                        {

                        }*/
                    }
                }
                return stack.Count > 0;
            }

            public void Reset()
            {
                stack = null;
                current.Clear();
            }
        }

        private Dictionary<T, Trie<T>> children = new Dictionary<T, Trie<T>>();
        private T[] replacement;

        public Trie()
        {

        }

        public Trie(T[] replacement)
        {
            this.replacement = replacement;
        }

        public void Add(T t, Trie<T> child)
        {
            children[t] = child;
        }

        public void Add(T t)
        {
            children[t] = new Trie<T>();
        }

        public bool Contains(T t)
        {
            foreach (T key in children.Keys) {
                if (key.Equals(t))
                {
                    return true;
                }
            }
            return false;
        }

        public Trie<T> GetChild(T t)
        {
            return children[t];
        }

        public void SetChild(T t, Trie<T> child)
        {
            children[t] = child;
        }

        public IEnumerator<T[]> GetEnumerator()
        {
            return null; 
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public Dictionary<T, Trie<T>> Children { get => children; }

        public T[] Replacement { get => replacement; set => replacement = value; }

        public bool IsLeaf { get => children.Count == 0; }
        
        public bool HasReplacementMapping { get => replacement != null; }

    }
}
