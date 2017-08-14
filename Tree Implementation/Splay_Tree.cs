using System;
using System.Collections.Generic;
using System.Text;

namespace Tree_Implementation {

    static class Splay_Tree {

        public static Node Insert(Node root, int value) {

            if (root == null)
                return new Node(value) {

                    lChild = null,
                    rChild = null
                };

            root = Splay(root, value);

            Node node = new Node(value) { lChild = null, rChild = null };

            if (root.value > value) {

                node.rChild = root;
                node.lChild = root.lChild;
                root.lChild = null;
            }

            else {

                node.lChild = root;
                node.rChild = root.rChild;
                root.rChild = null;
            }

            return node;
        }

        public static Node Remove(Node root, int value) {

            Node ptrTemp;

            if (root == null)
                return null;

            root = Splay(root, value);

            if (value != root.value)
                return root;

            else {

                if (root.rChild == null) {

                    ptrTemp = root;

                    root = root.rChild;
                }
                else {

                    ptrTemp = root;

                    root = Splay(root.lChild, value);
                    root.rChild = ptrTemp.rChild;
                }

                ptrTemp = null;

                return root;
            }
        }

        public static Node Splay(Node root, int value) {

            if (root == null || root.value == value)
                return root;

            if (root.value > value) {

                if (root.lChild == null)
                    return root;

                // Zig-Zag (Left->Left)
                if (root.lChild.value > value) {

                    root.lChild.lChild = Splay(root.lChild.lChild, value);
                    root = AVL_Tree.rightRotate(root);
                }

                // Zig-Zag (Left->Right)
                else if (root.lChild.value < value) {

                    root.lChild.rChild = Splay(root.lChild.rChild, value);

                    if (root.lChild.rChild != null)
                        root.lChild = AVL_Tree.leftRotate(root.lChild);
                }

                // Do second rotation for root
                return (root.lChild == null) ? root : AVL_Tree.rightRotate(root);
            }

            else {

                if (root.rChild == null)
                    return root;

                // Zig-Zag (Right Left)
                if (root.rChild.value > value) {
                    root.rChild.lChild = Splay(root.rChild.lChild, value);

                    if (root.rChild.lChild != null)
                        root.rChild = AVL_Tree.rightRotate(root.rChild);
                }
                else if (root.rChild.value < value)// Zag-Zag (Right Right)
                {
                    root.rChild.rChild = Splay(root.rChild.rChild, value);
                    root = AVL_Tree.leftRotate(root);
                }

                // Do second rotation for root
                return (root.rChild == null) ? root : AVL_Tree.leftRotate(root);
            }
        }
    }
}
