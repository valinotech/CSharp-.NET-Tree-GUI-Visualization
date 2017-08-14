using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Tree_Implementation {

    enum Tab {

        BST, AVL, RBT, SPL
    }

    public partial class mainForm : Form {

        public const int CDiameter = 40;
        public const int CRadius   = 20;

        private Node bst_root { get; set; }
        private Node avl_root { get; set; }
        private Node rbt_root { get; set; }
        private Node spl_root { get; set; }

        private Tab        activeTab = Tab.BST;
        private Node       activeRoot = null;
        private PictureBox activePictureBox = null;

        private int minimap_x = 51;
        private int minimap_y = 1;

        /// <summary>
        /// Returns total nodes in active tree
        /// </summary>
        private int total_nodes {

            get {

                int count = 0;
                foreach (Node node in Node.Search(activeRoot)) {

                    count++;
                }

                return count;
            }
        }

        /// <summary>
        /// mainForm entry
        /// </summary>
        public mainForm() {

            InitializeComponent();

            // Minimap visualization onPaint EventHandler
            this.pbMinimap.Paint += (object sender, PaintEventArgs e) => {

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                foreach (Node node in Node.Search(activeRoot)) {

                    if (node.lChild != null)
                        e.Graphics.DrawLine(new Pen(Color.Black), (node.x + CDiameter / 2) / 10, (node.y + CDiameter / 2) / 10, (node.lChild.x + CDiameter / 2) / 10, (node.lChild.y + CDiameter / 2) / 10);

                    if (node.rChild != null)
                        e.Graphics.DrawLine(new Pen(Color.Black), (node.x + CDiameter / 2) / 10, (node.y + CDiameter / 2) / 10, (node.rChild.x + CDiameter / 2) / 10, (node.rChild.y + CDiameter / 2) / 10);

                    e.Graphics.FillEllipse(new SolidBrush(Color.White), node.x / 10, node.y / 10, CDiameter / 10, CDiameter / 10);
                    e.Graphics.DrawEllipse(new Pen(Color.Black),        node.x / 10, node.y / 10, CDiameter / 10, CDiameter / 10);
                }

                e.Graphics.DrawRectangle(new Pen(Color.IndianRed), minimap_x, minimap_y, 97, 52);
            };

            this.activeRoot       = bst_root;
            this.activePictureBox = pbBST;

            this.pbBST.Paint += Tree_Visualization;
            this.pbAVL.Paint += Tree_Visualization;
            this.pbRBT.Paint += Tree_Visualization;
            this.pbSPL.Paint += Tree_Visualization;
        }

        /// <summary>
        /// Tree Visualization
        /// </summary>
        private void Tree_Visualization(object sender, PaintEventArgs e) {

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Node.setPosition(activeRoot, 0, 1);

            if (activeRoot != null) {

                int centerX = activePictureBox.Size.Width / 2 - CRadius;
                int Increment = centerX > activeRoot.x ? centerX - activeRoot.x : activeRoot.x - centerX;

                foreach (Node node in Node.Search(activeRoot)) {

                    node.x += Increment;
                }
            }

            foreach (Node node in Node.Search(activeRoot)) {

                // Connection Lines Reconstruction
                if (node.lChild != null)
                    e.Graphics.DrawLine(new Pen(Color.Black), node.x + CDiameter / 2, node.y + CDiameter / 2, node.lChild.x + CDiameter / 2, node.lChild.y + CDiameter / 2);

                if (node.rChild != null)
                    e.Graphics.DrawLine(new Pen(Color.Black), node.x + CDiameter / 2, node.y + CDiameter / 2, node.rChild.x + CDiameter / 2, node.rChild.y + CDiameter / 2);

                // Node Circle Reconstruction
                e.Graphics.FillEllipse(new SolidBrush(Color.White), node.x, node.y, CDiameter, CDiameter);
                e.Graphics.DrawEllipse(new Pen(Color.Black),        node.x, node.y, CDiameter, CDiameter);

                // Node Value Label Reconstruction
                if (node.value >= 0)
                    e.Graphics.DrawString(string.Format("{0,4:0000}", node.value), new Font("Roboto Condensed", 9, FontStyle.Regular), new SolidBrush(Color.Black), node.x + 6, node.y + 12);

                else
                    e.Graphics.DrawString(string.Format("{0,4}", node.value), new Font("Roboto Condensed", 9, FontStyle.Regular), new SolidBrush(Color.Black), node.x + 6, node.y + 12);

                // AVL Tree Case: (Height Labels Reconstruction)
                if (this.activeTab == Tab.AVL) {

                    if (node == activeRoot)
                        e.Graphics.DrawString(node.height.ToString(), new Font("Roboto Condensed", 7, FontStyle.Regular), new SolidBrush(Color.Black), node.x, node.y - 10);

                    if (node.lChild != null)
                        e.Graphics.DrawString(node.lChild.height.ToString(), new Font("Roboto Condensed", 7, FontStyle.Regular), new SolidBrush(Color.Black), node.lChild.x, node.lChild.y - 10);

                    if (node.rChild != null)
                        e.Graphics.DrawString(node.rChild.height.ToString(), new Font("Roboto Condensed", 7, FontStyle.Regular), new SolidBrush(Color.Black), node.rChild.x + 30, node.rChild.y - 10);
                }
            }

            pbMinimap.Invalidate();
        }

        #region Operations (Insert, Remove, Search)

        /// <summary>
        /// Insert button click handler
        /// Inserts a value into chosen tree
        /// </summary>
        private void btnInsert_Click(object sender, EventArgs e) {

            try {

                int value = Convert.ToInt32(tbInsert.Text);

                if (value > 9999 || value < -999)
                    throw new OverflowException("Please enter number between [-999;9999].");

                switch (this.activeTab) {

                    case Tab.BST:

                        if (this.total_nodes > 35) {

                            MessageBox.Show("Node limit is set to 35!", "Warning");
                            return; 
                        }

                        activeRoot = Binary_Search_Tree.Insert(activeRoot, value);
                        bst_root = activeRoot;

                        break;

                    case Tab.AVL:

                        if (this.total_nodes > 60) {

                            MessageBox.Show("Node limit is set to 60!", "Warning");
                            return;
                        }

                        activeRoot = AVL_Tree.Insert(activeRoot, value);
                        avl_root = activeRoot;

                        break;

                    case Tab.RBT: break;
                    case Tab.SPL:

                        if (this.total_nodes > 35) {

                            MessageBox.Show("Node limit is set to 35!", "Warning");
                            return;
                        }

                        activeRoot = Splay_Tree.Insert(activeRoot, value);
                        spl_root = activeRoot;

                        break;
                }

                activePictureBox.Invalidate();
            }

            catch (OverflowException ex) {

                MessageBox.Show(ex.Message, ex.GetType().Name);
            }

            catch (FormatException) { }
            tbInsert.Text = string.Empty;
        }

        /// <summary>
        /// Remove button click handler
        /// Removes entered value from chosen tree
        /// </summary>
        private void btnRemove_Click(object sender, EventArgs e) {

            try {

                int value = Convert.ToInt32(tbRemove.Text);

                if (value > 9999 || value < -999)
                    throw new OverflowException("Please enter number between [-999;9999].");

                switch (this.activeTab) {

                    case Tab.BST:

                        activeRoot = Binary_Search_Tree.Remove(activeRoot, value);
                        bst_root = activeRoot;

                        break;

                    case Tab.AVL:

                        activeRoot = AVL_Tree.Remove(activeRoot, value);
                        avl_root = activeRoot;

                        break;

                    case Tab.RBT: break;
                    case Tab.SPL:

                        activeRoot = AVL_Tree.Remove(spl_root, value);
                        spl_root = activeRoot;

                        break;
                }

                activePictureBox.Invalidate();
            }

            catch (OverflowException ex) {

                MessageBox.Show(ex.Message, ex.GetType().Name);
            }

            catch (FormatException) { }
            tbRemove.Text = string.Empty;
        }

        /// <summary>
        /// Search button click handler
        /// Finds and marks node if found
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e) {

            activePictureBox.Invalidate();

            try {

                int value = Convert.ToInt32(tbSearch.Text);

                if (value > 9999 || value < -999)
                    throw new OverflowException("Please enter number between [-999;9999].");

                Node ptrTemp = null;

                ptrTemp = (from node in Node.Search(activeRoot) where node.value == value select node).FirstOrDefault();

                if (ptrTemp == null) MessageBox.Show("Entered value does not exist!", "Search Result");

                else {

                    // SPlay
                    if (activeRoot == spl_root) {

                        activeRoot = Splay_Tree.Splay(activeRoot, value);
                        spl_root = activeRoot;

                        tbSearch.Text = string.Empty;

                        return;
                    }

                    else {

                        // Camera Focus
                        minimap_x = (ptrTemp.x / 10) - 97 / 2;
                        minimap_y = (ptrTemp.y / 10) - 51 / 2 + CRadius;
                    }
                    
                    this.activePictureBox.Location = new Point(minimap_x * -10, minimap_y * -10 + CRadius);

                    // Marking found node
                    using (var graphics = activePictureBox.CreateGraphics()) {

                        activePictureBox.Update();

                        graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        graphics.DrawEllipse(new Pen(Color.Red, 3), ptrTemp.x, ptrTemp.y, CDiameter, CDiameter);
                    }

                    pbMinimap.Invalidate();
                }
            }

            catch (OverflowException ex) {

                MessageBox.Show(ex.Message, ex.GetType().Name);
            }

            catch (FormatException) { }
            tbSearch.Text = string.Empty;
        }

        #endregion

        /// <summary>
        /// Tab Change Event Handler
        /// </summary>
        private void TabChange(object sender, EventArgs e) {

            switch (this.tabControl.SelectedIndex) {

                case 0: activeTab = Tab.BST; activeRoot = bst_root; activePictureBox = pbBST; break;
                case 1: activeTab = Tab.AVL; activeRoot = avl_root; activePictureBox = pbAVL; break;
                case 2: activeTab = Tab.RBT; activeRoot = rbt_root; activePictureBox = pbRBT; break;
                case 3: activeTab = Tab.SPL; activeRoot = spl_root; activePictureBox = pbSPL; break;
            }

            activePictureBox.Location = new Point(-511, -10);
            minimap_x = 51;
            minimap_y = 1;

            activePictureBox.Invalidate();
            pbMinimap.Invalidate();
        }

        /// <summary>
        /// Minimap navigation by MouseDown
        /// </summary>
        private bool onHold = false;
        private void pbMinimap_MouseDown(object sender, MouseEventArgs e) {

            onHold = true;

            minimap_x = e.Location.X - 97 / 2;
            minimap_y = e.Location.Y - 51 / 2;

            this.activePictureBox.Location = new Point(minimap_x * -10, minimap_y * -10);
        }

        /// <summary>
        /// Mainimap navigation by MouseDown + MouseMove
        /// </summary>
        private void pbMinimap_MouseMove(object sender, MouseEventArgs e) {

            if (onHold) {

                minimap_x = e.Location.X - 97 / 2;
                minimap_y = e.Location.Y - 51 / 2;

                this.activePictureBox.Location = new Point(minimap_x * -10, minimap_y * -10);
            }
        }

        /// <summary>
        /// Mouse release on Minimap event handler
        /// </summary>
        private void pbMinimap_MouseUp(object sender, MouseEventArgs e) {

            onHold = false;
        }

        /// <summary>
        /// Method that only allows digits and one '-' symbol in textboxes
        /// </summary>
        private void textboxControl(object sender, KeyPressEventArgs e) {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-')) {

                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1)) {

                e.Handled = true;
            }
        }
    }
}
