using System;
using System.Collections;
using System.Collections.Generic;

namespace data
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class BinaryTree
    {
        static List<int> output;
        public BinaryTree()
        {
            TreeNode node =
            //new TreeNode(1, new TreeNode(2, new TreeNode(4), null), new TreeNode(3, null, new TreeNode(5)));
            new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
            var response = BreadthFirstSearch(node);

            //TreeNode node = new TreeNode(1, null, new TreeNode(2, new TreeNode(3)));
            //Console.WriteLine(string.Join(",", PreOrderTransversal(node)));
            //output = new List<int>();
            //GetDataIn(node);
            //Console.WriteLine(string.Join(",", output));
            //Console.WriteLine(string.Join(",", InorderTraversal(node)));
        }


        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> values = new List<IList<int>>();
            LevelOrder(root, 1, values);
            return values;
        }

        public void LevelOrder(TreeNode node, int depth, IList<IList<int>> values)
        {
            if (node != null)
            {
                if (values.Count < depth)
                {
                    values.Add(new List<int> { node.val });
                }
                else
                {
                    values[depth - 1].Add(node.val);
                }

                LevelOrder(node.left, depth + 1, values);
                LevelOrder(node.right, depth + 1, values);
            }
        }

        public static bool BreadthFirstSearchSymetric(TreeNode node)
        {
            bool isTheSame = true;

            Queue<TreeNode> data = new Queue<TreeNode>();
            Queue<TreeNode> Mirror = new Queue<TreeNode>();
            TreeNode newMirror;
            if (node == null)
                isTheSame = false;

            data.Enqueue(node);
            newMirror = new TreeNode(node.val);
            while (data.Count > 0)
            {
                int lenght = data.Count;

                while (lenght > 0)
                {
                    var current = data.Dequeue();
                    if (current.left != null)
                    {
                        data.Enqueue(current.left);

                    }
                    if (current.right != null)
                    {
                        data.Enqueue(current.right);
                    }


                    lenght--;

                }
            }
            return isTheSame;
        }

        public static IList<IList<int>> BreadthFirstSearch(TreeNode node)
        {
            IList<IList<int>> main = new List<IList<int>>();
            List<int> subInt;
            Queue<TreeNode> data = new Queue<TreeNode>();
            if (node == null)
                return new List<IList<int>>();
            if (node != null)
            {
                main.Add(new List<int>()
                {
                    node.val
                });
            }
            data.Enqueue(node);
            while (data.Count > 0)
            {
                int lenght = data.Count;
                subInt = new List<int>();
                while (lenght > 0)
                {
                    var current = data.Dequeue();
                    if (current.left != null)
                    {
                        data.Enqueue(current.left);
                        subInt.Add(current.left.val);
                    }
                    if (current.right != null)
                    {
                        data.Enqueue(current.right);
                        subInt.Add(current.right.val);
                    }
                    lenght--;

                }
                if (subInt.Count > 0)
                    main.Add(subInt);
            }
            return main;
        }

        public static IList<int> InorderTraversal(TreeNode root)
        {
            output = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                var last = stack.Pop();


            }
            return output;
        }
        public static IList<int> PreOrderTransversal(TreeNode node)
        {
            output = new List<int>();
            GetDataPre(node);
            return output;
        }
        //using recussion
        static void GetDataPre(TreeNode node)
        {
            if (node == null)
                return;
            output.Add(node.val);
            GetDataPre(node.left);
            GetDataPre(node.right);
        }
        static void GetDataIn(TreeNode node)
        {
            if (node == null)
                return;
            GetDataIn(node.left);
            output.Add(node.val);
            GetDataIn(node.right);
        }
        //using stack
        static void GetDataUsingStack(TreeNode node)
        {
            output = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(node);

            while (stack.Count > 0)
            {
                var last = stack.Pop();
                output.Add(last.val);
                if (last.right != null)
                    stack.Push(last.right);
                if (last.left != null)
                    stack.Push(last.left);
            }
        }

        public static IList<int> InOrderTransversal(TreeNode node)
        {
            List<int> output = new List<int>();

            return output;
        }

        public static IList<int> PostOrderTransversal(TreeNode node)
        {
            List<int> output = new List<int>();

            return output;
        }
    }
}
