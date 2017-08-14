using System;
using System.Collections.Generic;
using System.Text;

namespace Tree_Implementation {

    enum Colour {

        NONE, RED, BLACK
    }

    class Node {
        
        public int value  { get; set; }
        public int height { get; set; }

        public Node lChild { get; set; }
        public Node rChild { get; set; }

        public int x { get; set; }
        public int y { get; set; }

        public Colour colour { get; set; }

        /// <summary>
        /// Node class constructor
        /// </summary>
        public Node(int value) {

            this.value  = value;
            this.height = 0;
            this.colour = Colour.NONE;
        }

        /// <summary>
        /// IEnumerable method to traverse and stream all nodes in a tree
        /// </summary>
        public static IEnumerable<Node> Search(Node root) {

            if (root == null)
                yield break;

            yield return root;

            if (root.lChild != null)
                foreach (Node node in Search(root.lChild)) {

                    yield return node;
                }

            if (root.rChild != null)
                foreach (Node node in Search(root.rChild)) {

                    yield return node;
                }
        }

        /// <summary>
        /// Recursive method that calculates the position of each node
        /// </summary>
        public static int setPosition(Node root, int offset, int depth) {

            if (root == null) return 0;

            int width = 5;

            int left  = setPosition(root.lChild, offset,                depth + 1);
            int right = setPosition(root.rChild, offset + left + width, depth + 1);

            root.x = (offset + left)    * width;
            root.y = mainForm.CDiameter * depth;

            return left + right + width;
        }

        /// <summary>
        /// Returns the 'left-most' node from chosen subtree
        /// </summary>
        public static Node getLowest(Node node) {

            while (node.lChild != null)
                node = node.lChild;

            return node;
        }
    }
}
