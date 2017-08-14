using System;
using System.Collections.Generic;
using System.Text;

namespace Tree_Implementation {

    static class AVL_Tree {

        public static Node Insert(Node root, int value) {

            // Performing Standart BST Insertion (TODO: Fix static BST class insertion link with AVL)
            if (root == null)
                return new Node(value) {

                    lChild = null,
                    rChild = null
                };

            else if (root.value > value)
                root.lChild = Insert(root.lChild, value);

            else
                root.rChild = Insert(root.rChild, value);

            // -----------------------------------------------------------------------------

            root.height = 1 + Math.Max(getHeight(root.lChild), getHeight(root.rChild));
            int balance = getBalance(root);

            // Left Left Case
            if (balance > 1 && value < root.lChild.value)
                return rightRotate(root);

            // Right Right Case
            if (balance < -1 && value >= root.rChild.value)
                return leftRotate(root);

            // Left Right Case
            if (balance > 1 && value >= root.lChild.value) {

                root.lChild = leftRotate(root.lChild);
                return rightRotate(root);
            }

            // Right Left Case
            if (balance < -1 && value <= root.rChild.value) {

                root.rChild = rightRotate(root.rChild);
                return leftRotate(root);
            }

            return root;
        }

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

                    root.value = Node.getLowest(root.rChild).value;
                    root.rChild = Remove(root.rChild, root.value);
                }
            }

            if (root == null) { }

            else {

                root.height = 1 + Math.Max(getHeight(root.lChild), getHeight(root.rChild));

                int balance = getBalance(root);

                // Left Left Case
                if (balance > 1 && getBalance(root.lChild) >= 0)
                    return rightRotate(root);

                // Right Right Case
                if (balance < -1 && getBalance(root.rChild) < 0)
                    return leftRotate(root);

                // Left Right Case
                if (balance > 1 && getBalance(root.lChild) <= 0) {

                    root.lChild = leftRotate(root.lChild);
                    return rightRotate(root);
                }

                // Right Left Case
                if (balance < -1 && getBalance(root.rChild) > 0) {

                    root.rChild = rightRotate(root.rChild);
                    return leftRotate(root);
                }
            }

            return root;
        }

        private static int getHeight(Node node) {

            return node != null ? node.height : -1;
        }

        private static int getBalance(Node node) {

            return node != null ? getHeight(node.lChild) - getHeight(node.rChild) : 0;
        }

        public static Node leftRotate(Node node_x) {

            Node node_y = node_x.rChild;
            Node ptrTemp = node_y.lChild;

            // Perform rotation
            node_y.lChild = node_x;
            node_x.rChild = ptrTemp;

            //  Update heights
            node_x.height = Math.Max(getHeight(node_x.lChild), getHeight(node_x.rChild)) + 1;
            node_y.height = Math.Max(getHeight(node_y.lChild), getHeight(node_y.rChild)) + 1;

            return node_y;
        }

        public static Node rightRotate(Node node_y) {

            Node node_x = node_y.lChild;
            Node ptrTemp = node_x.rChild;

            // Perform rotation
            node_x.rChild = node_y;
            node_y.lChild = ptrTemp;

            // Update heights
            node_y.height = Math.Max(getHeight(node_y.lChild), getHeight(node_y.rChild)) + 1;
            node_x.height = Math.Max(getHeight(node_x.lChild), getHeight(node_x.rChild)) + 1;

            return node_x;
        }
    }
}
