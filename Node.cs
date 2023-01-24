using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL_Tree
{
    internal class Node
    {
        private bool _isRoot;
        private dynamic _data; //defined by the avl tree, if the tree should save int's, then all nodes can only save int value's
        private int _height = 0; // balanced: -1(has only subLeftNode), 0(no subNodes), 1(has only subRightNode)

        private Node _rootNode; // if _isRoot = true -> _rootNode stays empty
        private Node _subTreeLeft;
        private Node _subTreeRight;

        public dynamic Data { get { return _data; }}

        private Random _rnd = new Random();
        public Node(dynamic data, Node rootNode = null, Node subTreeLeft = null, Node subTreeRight = null)
        {
            _rootNode = rootNode;
            _isRoot = (_rootNode == null) ? true : false;
            _data = data;
            _subTreeLeft = subTreeLeft;
            _subTreeRight = subTreeRight;
        }
        public void SetSubNode(Node newSubTree)
        {
            if (_height == 0)
            {
                int pos = _rnd.Next(0, 1);
                if (pos == 0) _subTreeLeft = newSubTree;
                else if (pos == 1) _subTreeRight = newSubTree;
            }
            else if (_height == 1) _subTreeLeft = newSubTree;
            else if (_height == -1) _subTreeRight = newSubTree;
        }
        public void UpdateNodeInt()
        {
            bool sorted = false;
            while (!sorted)
            {
                if (_subTreeLeft._data < _data && _data < _subTreeRight._data) break;

                if(_subTreeLeft._data > _data)
                {
                    dynamic tempData = _data;
                    _data = _subTreeLeft._data;
                    _subTreeLeft._data = tempData;
                }
                else if(_subTreeRight._data < _data)
                {
                    dynamic tempData = _data;
                    _data = _subTreeRight._data;
                    _subTreeRight._data = tempData;
                }
            }
        }
        public void UpdateNodeString()
        {
            bool sorted = false;
            while (!sorted)
            {
                //ToDo: Sort by alphabetic order
            }
        }
    }
}
