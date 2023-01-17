
namespace fastFoodOrderProj.Pic
{
    partial class Compo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compo));
            this.panelitem = new System.Windows.Forms.Panel();
            this.amountUpDown = new System.Windows.Forms.NumericUpDown();
            this.myItemspictureBox = new System.Windows.Forms.PictureBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblIttemName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelitem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myItemspictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelitem
            // 
            this.panelitem.BackColor = System.Drawing.Color.White;
            this.panelitem.Controls.Add(this.amountUpDown);
            this.panelitem.Controls.Add(this.myItemspictureBox);
            this.panelitem.Controls.Add(this.lblCost);
            this.panelitem.Controls.Add(this.lblIttemName);
            this.panelitem.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelitem.Location = new System.Drawing.Point(4, 0);
            this.panelitem.Margin = new System.Windows.Forms.Padding(4);
            this.panelitem.Name = "panelitem";
            this.panelitem.Size = new System.Drawing.Size(395, 131);
            this.panelitem.TabIndex = 0;
            this.panelitem.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // amountUpDown
            // 
            this.amountUpDown.BackColor = System.Drawing.SystemColors.Highlight;
            this.amountUpDown.Location = new System.Drawing.Point(181, 91);
            this.amountUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.amountUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountUpDown.Name = "amountUpDown";
            this.amountUpDown.Size = new System.Drawing.Size(62, 29);
            this.amountUpDown.TabIndex = 3;
            this.amountUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // myItemspictureBox
            // 
            this.myItemspictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myItemspictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myItemspictureBox.Image = ((System.Drawing.Image)(resources.GetObject("myItemspictureBox.Image")));
            this.myItemspictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("myItemspictureBox.InitialImage")));
            this.myItemspictureBox.Location = new System.Drawing.Point(248, 10);
            this.myItemspictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.myItemspictureBox.Name = "myItemspictureBox";
            this.myItemspictureBox.Size = new System.Drawing.Size(143, 111);
            this.myItemspictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myItemspictureBox.TabIndex = 2;
            this.myItemspictureBox.TabStop = false;
            this.myItemspictureBox.Click += new System.EventHandler(this.myItemspictureBox_Click);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCost.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCost.Location = new System.Drawing.Point(1, 84);
            this.lblCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(82, 45);
            this.lblCost.TabIndex = 1;
            this.lblCost.Text = "$5.0";
            // 
            // lblIttemName
            // 
            this.lblIttemName.AutoSize = true;
            this.lblIttemName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblIttemName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIttemName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblIttemName.Location = new System.Drawing.Point(7, 12);
            this.lblIttemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIttemName.Name = "lblIttemName";
            this.lblIttemName.Size = new System.Drawing.Size(73, 25);
            this.lblIttemName.TabIndex = 0;
            this.lblIttemName.Text = "Caffe";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Compo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelitem);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Compo";
            this.Size = new System.Drawing.Size(398, 131);
            this.panelitem.ResumeLayout(false);
            this.panelitem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myItemspictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelitem;
        public System.Windows.Forms.PictureBox myItemspictureBox;
        public System.Windows.Forms.Label lblCost;
        public System.Windows.Forms.Label lblIttemName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.NumericUpDown amountUpDown;
    }
}
