namespace Tree_Implementation {
    partial class mainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tbInsert = new System.Windows.Forms.TextBox();
            this.tbRemove = new System.Windows.Forms.TextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.BSTPage = new System.Windows.Forms.TabPage();
            this.pbBST = new Tree_Implementation.CPictureBox();
            this.AVLPage = new System.Windows.Forms.TabPage();
            this.pbAVL = new Tree_Implementation.CPictureBox();
            this.RBTPage = new System.Windows.Forms.TabPage();
            this.lbWarning = new System.Windows.Forms.Label();
            this.pbRBT = new Tree_Implementation.CPictureBox();
            this.SPLPage = new System.Windows.Forms.TabPage();
            this.pbSPL = new Tree_Implementation.CPictureBox();
            this.lbMinimap = new System.Windows.Forms.Label();
            this.pbMinimap = new Tree_Implementation.CPictureBox();
            this.btnSearch = new Tree_Implementation.CButton();
            this.btnRemove = new Tree_Implementation.CButton();
            this.btnInsert = new Tree_Implementation.CButton();
            this.tabControl.SuspendLayout();
            this.BSTPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBST)).BeginInit();
            this.AVLPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAVL)).BeginInit();
            this.RBTPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRBT)).BeginInit();
            this.SPLPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSPL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimap)).BeginInit();
            this.SuspendLayout();
            // 
            // tbInsert
            // 
            this.tbInsert.Location = new System.Drawing.Point(12, 12);
            this.tbInsert.Name = "tbInsert";
            this.tbInsert.Size = new System.Drawing.Size(120, 20);
            this.tbInsert.TabIndex = 0;
            this.tbInsert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbInsert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxControl);
            // 
            // tbRemove
            // 
            this.tbRemove.Location = new System.Drawing.Point(234, 12);
            this.tbRemove.Name = "tbRemove";
            this.tbRemove.Size = new System.Drawing.Size(120, 20);
            this.tbRemove.TabIndex = 0;
            this.tbRemove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRemove.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxControl);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(456, 12);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(120, 20);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxControl);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.BSTPage);
            this.tabControl.Controls.Add(this.AVLPage);
            this.tabControl.Controls.Add(this.RBTPage);
            this.tabControl.Controls.Add(this.SPLPage);
            this.tabControl.Location = new System.Drawing.Point(12, 39);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(978, 546);
            this.tabControl.TabIndex = 2;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabChange);
            // 
            // BSTPage
            // 
            this.BSTPage.Controls.Add(this.pbBST);
            this.BSTPage.Location = new System.Drawing.Point(4, 22);
            this.BSTPage.Name = "BSTPage";
            this.BSTPage.Padding = new System.Windows.Forms.Padding(3);
            this.BSTPage.Size = new System.Drawing.Size(970, 520);
            this.BSTPage.TabIndex = 0;
            this.BSTPage.Text = "Binary Search Tree";
            this.BSTPage.UseVisualStyleBackColor = true;
            // 
            // pbBST
            // 
            this.pbBST.BorderColor = System.Drawing.Color.IndianRed;
            this.pbBST.Location = new System.Drawing.Point(-511, -10);
            this.pbBST.Name = "pbBST";
            this.pbBST.Size = new System.Drawing.Size(2000, 1500);
            this.pbBST.TabIndex = 0;
            this.pbBST.TabStop = false;
            // 
            // AVLPage
            // 
            this.AVLPage.Controls.Add(this.pbAVL);
            this.AVLPage.Location = new System.Drawing.Point(4, 22);
            this.AVLPage.Name = "AVLPage";
            this.AVLPage.Padding = new System.Windows.Forms.Padding(3);
            this.AVLPage.Size = new System.Drawing.Size(970, 520);
            this.AVLPage.TabIndex = 1;
            this.AVLPage.Text = "AVL Tree";
            this.AVLPage.UseVisualStyleBackColor = true;
            // 
            // pbAVL
            // 
            this.pbAVL.BorderColor = System.Drawing.Color.IndianRed;
            this.pbAVL.Location = new System.Drawing.Point(-511, -10);
            this.pbAVL.Name = "pbAVL";
            this.pbAVL.Size = new System.Drawing.Size(2000, 1500);
            this.pbAVL.TabIndex = 0;
            this.pbAVL.TabStop = false;
            // 
            // RBTPage
            // 
            this.RBTPage.Controls.Add(this.lbWarning);
            this.RBTPage.Controls.Add(this.pbRBT);
            this.RBTPage.Location = new System.Drawing.Point(4, 22);
            this.RBTPage.Name = "RBTPage";
            this.RBTPage.Padding = new System.Windows.Forms.Padding(3);
            this.RBTPage.Size = new System.Drawing.Size(970, 520);
            this.RBTPage.TabIndex = 2;
            this.RBTPage.Text = "Red/Black Tree";
            this.RBTPage.UseVisualStyleBackColor = true;
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbWarning.ForeColor = System.Drawing.Color.Red;
            this.lbWarning.Location = new System.Drawing.Point(415, 181);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(173, 25);
            this.lbWarning.TabIndex = 1;
            this.lbWarning.Text = "Not Implemented";
            // 
            // pbRBT
            // 
            this.pbRBT.BorderColor = System.Drawing.Color.IndianRed;
            this.pbRBT.Location = new System.Drawing.Point(-511, -10);
            this.pbRBT.Name = "pbRBT";
            this.pbRBT.Size = new System.Drawing.Size(2000, 1500);
            this.pbRBT.TabIndex = 0;
            this.pbRBT.TabStop = false;
            // 
            // SPLPage
            // 
            this.SPLPage.Controls.Add(this.pbSPL);
            this.SPLPage.Location = new System.Drawing.Point(4, 22);
            this.SPLPage.Name = "SPLPage";
            this.SPLPage.Padding = new System.Windows.Forms.Padding(3);
            this.SPLPage.Size = new System.Drawing.Size(970, 520);
            this.SPLPage.TabIndex = 3;
            this.SPLPage.Text = "Splay Tree";
            this.SPLPage.UseVisualStyleBackColor = true;
            // 
            // pbSPL
            // 
            this.pbSPL.BorderColor = System.Drawing.Color.IndianRed;
            this.pbSPL.Location = new System.Drawing.Point(-511, -10);
            this.pbSPL.Name = "pbSPL";
            this.pbSPL.Size = new System.Drawing.Size(2000, 1500);
            this.pbSPL.TabIndex = 0;
            this.pbSPL.TabStop = false;
            // 
            // lbMinimap
            // 
            this.lbMinimap.AutoSize = true;
            this.lbMinimap.BackColor = System.Drawing.Color.White;
            this.lbMinimap.Location = new System.Drawing.Point(771, 66);
            this.lbMinimap.Name = "lbMinimap";
            this.lbMinimap.Size = new System.Drawing.Size(46, 13);
            this.lbMinimap.TabIndex = 4;
            this.lbMinimap.Text = "Minimap";
            // 
            // pbMinimap
            // 
            this.pbMinimap.BackColor = System.Drawing.Color.White;
            this.pbMinimap.BorderColor = System.Drawing.Color.DarkGray;
            this.pbMinimap.Location = new System.Drawing.Point(774, 79);
            this.pbMinimap.Name = "pbMinimap";
            this.pbMinimap.Size = new System.Drawing.Size(200, 150);
            this.pbMinimap.TabIndex = 3;
            this.pbMinimap.TabStop = false;
            this.pbMinimap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMinimap_MouseDown);
            this.pbMinimap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMinimap_MouseMove);
            this.pbMinimap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbMinimap_MouseUp);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(582, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(360, 10);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(138, 10);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(90, 23);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 597);
            this.Controls.Add(this.pbMinimap);
            this.Controls.Add(this.lbMinimap);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.tbRemove);
            this.Controls.Add(this.tbInsert);
            this.DoubleBuffered = true;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tree Like Data Structures";
            this.tabControl.ResumeLayout(false);
            this.BSTPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBST)).EndInit();
            this.AVLPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAVL)).EndInit();
            this.RBTPage.ResumeLayout(false);
            this.RBTPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRBT)).EndInit();
            this.SPLPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSPL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInsert;
        private CButton btnInsert;
        private System.Windows.Forms.TextBox tbRemove;
        private CButton btnRemove;
        private System.Windows.Forms.TextBox tbSearch;
        private CButton btnSearch;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage BSTPage;
        private System.Windows.Forms.TabPage AVLPage;
        private System.Windows.Forms.TabPage RBTPage;
        private System.Windows.Forms.TabPage SPLPage;
        private CPictureBox pbMinimap;
        private System.Windows.Forms.Label lbMinimap;
        private CPictureBox pbBST;
        private CPictureBox pbAVL;
        private CPictureBox pbRBT;
        private CPictureBox pbSPL;
        private System.Windows.Forms.Label lbWarning;
    }
}

