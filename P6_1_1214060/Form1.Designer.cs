namespace P6_1_1214060
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
            this.vbButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.csButton = new System.Windows.Forms.Label();
            this.csharp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vbButton
            // 
            this.vbButton.BackColor = System.Drawing.Color.Lime;
            this.vbButton.Font = new System.Drawing.Font("Minion Pro", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vbButton.Location = new System.Drawing.Point(164, 207);
            this.vbButton.Name = "vbButton";
            this.vbButton.Size = new System.Drawing.Size(151, 33);
            this.vbButton.TabIndex = 0;
            this.vbButton.Text = "Visual Basic";
            this.vbButton.UseVisualStyleBackColor = false;
            this.vbButton.Click += new System.EventHandler(this.vbButton_Click);
            this.vbButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.vbButton_MouseMove);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Minion Pro SmBd", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(12, 394);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(147, 44);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // csButton
            // 
            this.csButton.AutoSize = true;
            this.csButton.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csButton.Location = new System.Drawing.Point(52, 40);
            this.csButton.Name = "csButton";
            this.csButton.Size = new System.Drawing.Size(695, 44);
            this.csButton.TabIndex = 3;
            this.csButton.Text = "Which do you think is better, Visual Basic or C#";
            this.csButton.Click += new System.EventHandler(this.label1_Click);
            // 
            // csharp
            // 
            this.csharp.BackColor = System.Drawing.Color.Red;
            this.csharp.Font = new System.Drawing.Font("Minion Pro", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csharp.Location = new System.Drawing.Point(467, 207);
            this.csharp.Name = "csharp";
            this.csharp.Size = new System.Drawing.Size(151, 34);
            this.csharp.TabIndex = 4;
            this.csharp.Text = "C#";
            this.csharp.UseVisualStyleBackColor = false;
            this.csharp.Click += new System.EventHandler(this.csharp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.csharp);
            this.Controls.Add(this.csButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.vbButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vbButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label csButton;
        private System.Windows.Forms.Button csharp;
    }
}

