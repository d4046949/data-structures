using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{
    public interface INode<T>
    {
        INode<T> Next { get; set; }

        bool HasNext { get; }
        T Data { get; }
        bool Equals(object value);
    }

    public class Node<T> : INode<T>
    {
        private T _data;
        public Node(T data)
        {
            this._data = data;
        }

        public INode<T> Next { get ; set; }

        public bool HasNext => Next != null;
        public T Data => _data;

        public override bool Equals(object obj)
        {
            INode<T> node = obj as INode<T>;

            if (node == null) return false;


            return this.Data.Equals(node.Data);
        }
    }
}
