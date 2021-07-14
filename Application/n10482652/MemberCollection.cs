using System;
using System.Collections.Generic;

namespace n10482652
{
    class Node
    {
        public iMember member;
        public Node lchild;
        public Node rchild;

    }

    class BST
    {

        public Node root;
        

        public BST()
        {
            root = null;
        }

        public void InsertMember(iMember member)
        {
            Node newNode = new Node();
            newNode.member = member;

            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (member.FirstName.CompareTo(current.member.FirstName) < 0 && member.LastName.CompareTo(current.member.LastName) < 0)
                    {
                        current = current.lchild;
                        if (current == null)
                        {
                            parent.lchild = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.rchild;
                        if (current == null)
                        {
                            parent.rchild = newNode;
                            break;
                        }
                    }
                }
            }
        }

        public bool DeleteMember(iMember member)
        {
            Node current = root;
            Node parent = root;
            bool isLeftChild = true;

            if (current == null)
            {
                return false;
            }

            while (current.member.FirstName != member.FirstName && current.member.LastName != member.LastName)
            {

                parent = current;
                if (current.member.FirstName.CompareTo(member.FirstName) > 0 && current.member.LastName.CompareTo(member.LastName) > 0)
                {
                    isLeftChild = true;
                    current = current.lchild;
                }
                else
                {
                    isLeftChild = false;
                    current = current.rchild;
                }
                if (current == null)
                    return false;
            }
            if ((current.lchild == null) && (current.rchild == null))
                if (current == root)
                    root = null;
                else if (isLeftChild)
                    parent.lchild = null;
                else
                    parent.rchild = null;
            else if (current.rchild == null)
                if (current == root)
                    root = current.lchild;
                else if (isLeftChild)
                    parent.lchild = current.lchild;
                else
                    parent.rchild = current.rchild;
            else if (current.lchild == null)
                if (current == root)
                    root = current.rchild;
                else if (isLeftChild)
                    parent.lchild = parent.rchild;
                else
                    parent.rchild = current.rchild;
            else
            {
                Node successor = GetNextNode(current);

                if (current == root)
                    root = successor;

                else if (isLeftChild)
                    parent.lchild = successor;
                else
                    parent.rchild = successor;
                successor.lchild = current.lchild;
            }
            return true;
        }

        public Node GetNextNode(Node node)
        {
            Node successorParent = node;
            Node successor = node;
            Node current = node.rchild;
            while (current != null)
            {

                successorParent = current;
                successor = current;
                current = current.lchild;
            }
            if (successor != node.rchild)
            {
                successorParent.lchild = successor.rchild;
                successor.rchild = node.rchild;
            }
            return successor;
        }

        public List<iMember> PostOrder(Node Root)
        {
            List<iMember> members = new List<iMember>();
            if (Root != null)
            {
                PostOrder(Root.lchild);
                PostOrder(Root.rchild);
                members.Add(Root.member);
            }

            return members;
        }
    }

    class MemberCollection : iMemberCollection
    {
        public int Number => throw new NotImplementedException();

        BST memberTree = new BST();

        public void add(iMember aMember)
        {
            memberTree.InsertMember(aMember);
        }

        public void delete(iMember aMember)
        {
            memberTree.DeleteMember(aMember);
        }

        public bool search(iMember aMember)
        {
            iMember[] members = toArray();
            while (members != null)
            {
                foreach (var member in members)
                {
                    if (member.FirstName == aMember.FirstName && member.LastName == aMember.LastName)
                        return true;
                }
                return false;
            }
            return false;
        }

        public bool login(iMember aMember)
        {
            iMember[] members = toArray();
            while (members != null)
            {
                foreach (var member in members)
                {
                    if (member.FirstName == aMember.FirstName && member.LastName == aMember.LastName && member.PIN == aMember.PIN)
                        return true;
                }
                return false;
            }
            return false;
        }

        public iMember[] toArray()
        {
            List<iMember> list = memberTree.PostOrder(memberTree.root);
            return list.ToArray();
        }
    }
}