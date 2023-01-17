
namespace fastFoodOrderProj
{
    partial class MenuItm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuItm));
            this.prudectsMenuFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.pictureBoxSearchIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // prudectsMenuFlowLayoutPanel
            // 
            this.prudectsMenuFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prudectsMenuFlowLayoutPanel.AutoScroll = true;
            this.prudectsMenuFlowLayoutPanel.AutoSize = true;
            this.prudectsMenuFlowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.prudectsMenuFlowLayoutPanel.Location = new System.Drawing.Point(-2, 45);
            this.prudectsMenuFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.prudectsMenuFlowLayoutPanel.Name = "prudectsMenuFlowLayoutPanel";
            this.prudectsMenuFlowLayoutPanel.Size = new System.Drawing.Size(1308, 1015);
            this.prudectsMenuFlowLayoutPanel.TabIndex = 2;
            // 
            // textSearch
            // 
            this.textSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textSearch.Font = new System.Drawing.Font("Verdana", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.Location = new System.Drawing.Point(269, 1);
            this.textSearch.Margin = new System.Windows.Forms.Padding(2);
            this.textSearch.Multiline = true;
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(533, 35);
            this.textSearch.TabIndex = 0;
            this.textSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textSearch_KeyUp);
            // 
            // pictureBoxSearchIcon
            // 
            this.pictureBoxSearchIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxSearchIcon.BackColor = System.Drawing.Color.White;
            this.pictureBoxSearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearchIcon.Image")));
            this.pictureBoxSearchIcon.Location = new System.Drawing.Point(756, 1);
            this.pictureBoxSearchIcon.Name = "pictureBoxSearchIcon";
            this.pictureBoxSearchIcon.Size = new System.Drawing.Size(46, 32);
            this.pictureBoxSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSearchIcon.TabIndex = 34;
            this.pictureBoxSearchIcon.TabStop = false;
            // 
            // MenuItm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1125, 787);
            this.Controls.Add(this.pictureBoxSearchIcon);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.prudectsMenuFlowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuItm";
            this.Text = "FoodForm";
            this.Shown += new System.EventHandler(this.HotDrinksForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel prudectsMenuFlowLayoutPanel;
        private System.Windows.Forms.TextBox textSearch;
        public System.Windows.Forms.PictureBox pictureBoxSearchIcon;
    }
}