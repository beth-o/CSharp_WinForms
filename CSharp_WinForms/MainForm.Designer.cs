namespace CSharp_WinForms
{
    partial class MainForm
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
            this.BtnMyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMyButton
            // 
            this.BtnMyButton.Location = new System.Drawing.Point(77, 54);
            this.BtnMyButton.Name = "BtnMyButton";
            this.BtnMyButton.Size = new System.Drawing.Size(75, 23);
            this.BtnMyButton.TabIndex = 0;
            this.BtnMyButton.Text = "My Button";
            this.BtnMyButton.UseVisualStyleBackColor = true;
            this.BtnMyButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnMyButton);
            this.Name = "MainForm";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMyButton;
    }
}

