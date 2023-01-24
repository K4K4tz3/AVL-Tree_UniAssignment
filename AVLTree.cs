using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL_Tree
{
    internal class AVLTree
    {
        private string _listName;

        private DateTime _creationDate;
        private DateTime _modificationDate;

        private List<Node> _nodes;
        private Type _dataType;
        private int _depth = 0;

        public string ListName { get { return _listName; } }
        public DateTime CreationDate { get { return _creationDate; } }
        public DateTime ModificationDate { get { return _modificationDate; } }
        public List<Node> Nodes { get { return _nodes; } }
        public AVLTree(Type type)
        {
            _dataType = type;
            _listName = "";
            _creationDate = DateTime.Now;
            _nodes = new List<Node>();
        }
        public void Add(dynamic data)
        {
            Node newNode = null;
            if (_dataType == null)
            {
                _dataType = data.GetType();
                newNode = new Node(data);
            }
            else if(data.GetType() == _dataType)
            {
                newNode = new Node(data);
            }
            if(newNode != null) _nodes.Add(newNode);
        }
    }
}
