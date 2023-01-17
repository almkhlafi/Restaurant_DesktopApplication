
namespace fastFoodOrderProj
{
    partial class FoodForm
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
            this.prudectsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // prudectsFlowLayoutPanel
            // 
            this.prudectsFlowLayoutPanel.AutoScroll = true;
            this.prudectsFlowLayoutPanel.Location = new System.Drawing.Point(2, 12);
            this.prudectsFlowLayoutPanel.Name = "prudectsFlowLayoutPanel";
            this.prudectsFlowLayoutPanel.Size = new System.Drawing.Size(1260, 1232);
            this.prudectsFlowLayoutPanel.TabIndex = 0;
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 880);
            this.Controls.Add(this.prudectsFlowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FoodForm";
            this.Text = "FoodForm";
            this.Shown += new System.EventHandler(this.FoodForm_Shwn);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel prudectsFlowLayoutPanel;
    }
}