
namespace fastFoodOrderProj
{
    partial class ColdDrinksForm
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
            this.prudectsColdDrinksFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // prudectsColdDrinksFlowLayoutPanel
            // 
            this.prudectsColdDrinksFlowLayoutPanel.AutoScroll = true;
            this.prudectsColdDrinksFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prudectsColdDrinksFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.prudectsColdDrinksFlowLayoutPanel.Name = "prudectsColdDrinksFlowLayoutPanel";
            this.prudectsColdDrinksFlowLayoutPanel.Size = new System.Drawing.Size(1262, 880);
            this.prudectsColdDrinksFlowLayoutPanel.TabIndex = 0;
            // 
            // ColdDrinksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 880);
            this.Controls.Add(this.prudectsColdDrinksFlowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ColdDrinksForm";
            this.Text = "FoodForm";
            this.Shown += new System.EventHandler(this.ColdDrinksForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel prudectsColdDrinksFlowLayoutPanel;
    }
}