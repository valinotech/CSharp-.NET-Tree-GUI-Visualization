using System;
using System.Collections.Generic;
using System.Text;

namespace Tree_Implementation {

    static class Binary_Search_Tree {

        /// <summary>
        /// BST recursive insertion method
        /// </summary>
        public static Node Insert(Node root, int value) {

            if (root == null)
                return new Node(value) {

                    lChild = null,
                    rChild = null
                };

            else if (root.value > value)
                root.lChild = Insert(root.lChild, value);

            else
                root.rChild = Insert(root.rChild, value);

            return root;
        }

        /// <summary>
        /// BST recursive deletion method
        /// </summary>
        public static Node Remove(Node root, int value) {

            if (root == null) return null;

            else if (root.value > value)
                root.lChild = Remove(root.lChild, value);

            else if (root.value < value)
                root.rChild = Remove(root.rChild, value);

            else {

                if (root.lChild == null && root.rChild == null) return null;

                else if (root.lChild == null || root.rChild == null)
                    return root.lChild != null ? root.lChild : root.rChild;

                else {

                    root.value  = Node.getLowest(root.rChild).value;
                    root.rChild = Remove(root.rChild, root.value);
                }
            }

            return root;
        }
    }
}
