namespace CefGlue.Demo.WindowsForms
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
            this.cefWebBrowser1 = new Xilium.CefGlue.WindowsForms.CefWebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cefWebBrowser1
            // 
            this.cefWebBrowser1.BrowserSettings = null;
            this.cefWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cefWebBrowser1.Location = new System.Drawing.Point(0, 0);
            this.cefWebBrowser1.Name = "cefWebBrowser1";
            this.cefWebBrowser1.Size = new System.Drawing.Size(818, 429);
            this.cefWebBrowser1.StartUrl = "https://www.google.lk";
            this.cefWebBrowser1.TabIndex = 0;
            this.cefWebBrowser1.Text = "cefWebBrowser1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 429);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cefWebBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Xilium.CefGlue.WindowsForms.CefWebBrowser cefWebBrowser1;
        private System.Windows.Forms.Button button1;
    }
}

