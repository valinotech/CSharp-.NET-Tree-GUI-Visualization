using System;
using System.Collections.Generic;
using System.Text;

namespace Tree_Implementation {

    class CPictureBox : System.Windows.Forms.PictureBox {

        public System.Drawing.Color BorderColor { get; set; }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e) {

            e.Graphics.DrawRectangle(new System.Drawing.Pen(BorderColor),
                0, 0, this.Width - 1, this.Height - 1);

            base.OnPaint(e);
        }
    }
}
