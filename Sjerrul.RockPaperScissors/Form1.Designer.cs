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
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonRock = new System.Windows.Forms.Button();
            this.buttonPaper = new System.Windows.Forms.Button();
            this.buttonScissor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(47, 31);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(685, 314);
            this.textBox.TabIndex = 0;
            // 
            // buttonRock
            // 
            this.buttonRock.Location = new System.Drawing.Point(751, 31);
            this.buttonRock.Name = "buttonRock";
            this.buttonRock.Size = new System.Drawing.Size(75, 23);
            this.buttonRock.TabIndex = 1;
            this.buttonRock.Text = "buttonRock";
            this.buttonRock.UseVisualStyleBackColor = true;
            this.buttonRock.Click += new System.EventHandler(this.buttonRock_Click);
            // 
            // buttonPaper
            // 
            this.buttonPaper.Location = new System.Drawing.Point(751, 61);
            this.buttonPaper.Name = "buttonPaper";
            this.buttonPaper.Size = new System.Drawing.Size(75, 23);
            this.buttonPaper.TabIndex = 2;
            this.buttonPaper.Text = "buttonPaper";
            this.buttonPaper.UseVisualStyleBackColor = true;
            this.buttonPaper.Click += new System.EventHandler(this.buttonPaper_Click);
            // 
            // buttonScissor
            // 
            this.buttonScissor.Location = new System.Drawing.Point(751, 91);
            this.buttonScissor.Name = "buttonScissor";
            this.buttonScissor.Size = new System.Drawing.Size(75, 23);
            this.buttonScissor.TabIndex = 3;
            this.buttonScissor.Text = "buttonScissor";
            this.buttonScissor.UseVisualStyleBackColor = true;
            this.buttonScissor.Click += new System.EventHandler(this.buttonScissor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 385);
            this.Controls.Add(this.buttonScissor);
            this.Controls.Add(this.buttonPaper);
            this.Controls.Add(this.buttonRock);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonRock;
        private System.Windows.Forms.Button buttonPaper;
        private System.Windows.Forms.Button buttonScissor;
    }
}

