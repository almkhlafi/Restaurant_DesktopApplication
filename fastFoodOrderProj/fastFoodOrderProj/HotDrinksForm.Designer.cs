
namespace fastFoodOrderProj
{
    partial class HotDrinksForm
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
            this.prudectsHotDrinksFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // prudectsHotDrinksFlowLayoutPanel
            // 
            this.prudectsHotDrinksFlowLayoutPanel.AutoScroll = true;
            this.prudectsHotDrinksFlowLayoutPanel.Location = new System.Drawing.Point(3, 12);
            this.prudectsHotDrinksFlowLayoutPanel.Name = "prudectsHotDrinksFlowLayoutPanel";
            this.prudectsHotDrinksFlowLayoutPanel.Size = new System.Drawing.Size(1262, 870);
            this.prudectsHotDrinksFlowLayoutPanel.TabIndex = 0;
            // 
            // HotDrinksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 880);
            this.Controls.Add(this.prudectsHotDrinksFlowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HotDrinksForm";
            this.Text = "FoodForm";
            this.Shown += new System.EventHandler(this.HotDrinksForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel prudectsHotDrinksFlowLayoutPanel;
    }
}