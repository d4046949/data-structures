using System;

namespace DataStructures.LinkedList
{
    public class LinkedList<T>
    {
        private INode<T> _head;
        private INode<T> _tail;

        public void Insert(INode<T> node)
        {
            if (_head == null)
            {
                //first element 
                _head = node;
                _tail = node;
                return;
            }

            this.Append(node);
        }

        public void Delete(INode<T> node)
        {
            if(node == null) throw new ArgumentNullException($"Node cannot be null");


            //find node to delete
            var iterator = this._head;
            INode<T> previousNode = null;

            while (iterator.HasNext)
            {
               if (iterator.Equals(node))
                {
                    Console.WriteLine("I've found it!!");
                    if (previousNode != null)
                    {
                        previousNode.Next = iterator.Next;
                    }

                    return;
                }

                previousNode = iterator;
                iterator = iterator.Next;
            }

            //check last node
            if (iterator.Equals(node))
            {
                Console.WriteLine("I've found it!!");
                var nodeToDelete = node;
                
                return;
            }

           Console.WriteLine("Failed to find element");
        }

        public void PrintNodeList()
        {
            if (_head == null)
            {
                Console.WriteLine("Data structure is empty");
                return;
            }

            var iterator = this._head;

            Console.WriteLine(iterator.Data);

            while (iterator.HasNext)
            {
                iterator = iterator.Next;
                Console.WriteLine(iterator.Data);  
            }
        }

        public void RecursiveSearch(T searchItem)
        {
            var item = this.FindRecursively(this._head, searchItem);

            if (item != null)
            {
                Console.WriteLine("Found item recursively");
            }

        }

        private void Append(INode<T> node)
        {
            var iterator = this._head;

            while (iterator.HasNext)
            {
                iterator = iterator.Next;
            }

            iterator.Next = node;
        }

        private INode<T> FindRecursively(INode<T> node, T searchItem)
        {
            if (node == null) return null;

            if (node.Data.Equals(searchItem))
            {
                return node;
            }

            return FindRecursively(node.Next, searchItem);
        }
    }
}
