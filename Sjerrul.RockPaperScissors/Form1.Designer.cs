namespace Sjerrul.RockPaperScissors
{
    partial class Form1
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
            this.txtGameLog = new System.Windows.Forms.TextBox();
            this.buttonRock = new System.Windows.Forms.Button();
            this.buttonPaper = new System.Windows.Forms.Button();
            this.buttonScissor = new System.Windows.Forms.Button();
            this.txtStrategyMap = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtGameLog
            // 
            this.txtGameLog.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameLog.Location = new System.Drawing.Point(63, 42);
            this.txtGameLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtGameLog.Multiline = true;
            this.txtGameLog.Name = "txtGameLog";
            this.txtGameLog.ReadOnly = true;
            this.txtGameLog.Size = new System.Drawing.Size(668, 439);
            this.txtGameLog.TabIndex = 0;
            // 
            // buttonRock
            // 
            this.buttonRock.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonRock.Location = new System.Drawing.Point(739, 42);
            this.buttonRock.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRock.Name = "buttonRock";
            this.buttonRock.Size = new System.Drawing.Size(100, 28);
            this.buttonRock.TabIndex = 1;
            this.buttonRock.Text = "Rock";
            this.buttonRock.UseVisualStyleBackColor = true;
            this.buttonRock.Click += new System.EventHandler(this.buttonRock_Click);
            // 
            // buttonPaper
            // 
            this.buttonPaper.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonPaper.Location = new System.Drawing.Point(739, 78);
            this.buttonPaper.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPaper.Name = "buttonPaper";
            this.buttonPaper.Size = new System.Drawing.Size(100, 28);
            this.buttonPaper.TabIndex = 2;
            this.buttonPaper.Text = "Paper";
            this.buttonPaper.UseVisualStyleBackColor = true;
            this.buttonPaper.Click += new System.EventHandler(this.buttonPaper_Click);
            // 
            // buttonScissor
            // 
            this.buttonScissor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonScissor.Location = new System.Drawing.Point(739, 114);
            this.buttonScissor.Margin = new System.Windows.Forms.Padding(4);
            this.buttonScissor.Name = "buttonScissor";
            this.buttonScissor.Size = new System.Drawing.Size(100, 28);
            this.buttonScissor.TabIndex = 3;
            this.buttonScissor.Text = "Scissors";
            this.buttonScissor.UseVisualStyleBackColor = true;
            this.buttonScissor.Click += new System.EventHandler(this.buttonScissor_Click);
            // 
            // txtStrategyMap
            // 
            this.txtStrategyMap.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStrategyMap.Location = new System.Drawing.Point(739, 150);
            this.txtStrategyMap.Margin = new System.Windows.Forms.Padding(4);
            this.txtStrategyMap.Multiline = true;
            this.txtStrategyMap.Name = "txtStrategyMap";
            this.txtStrategyMap.ReadOnly = true;
            this.txtStrategyMap.Size = new System.Drawing.Size(364, 331);
            this.txtStrategyMap.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 494);
            this.Controls.Add(this.txtStrategyMap);
            this.Controls.Add(this.buttonScissor);
            this.Controls.Add(this.buttonPaper);
            this.Controls.Add(this.buttonRock);
            this.Controls.Add(this.txtGameLog);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtStrategyMap;

        #endregion

        private System.Windows.Forms.TextBox txtGameLog;
        private System.Windows.Forms.Button buttonRock;
        private System.Windows.Forms.Button buttonPaper;
        private System.Windows.Forms.Button buttonScissor;
    }
}

