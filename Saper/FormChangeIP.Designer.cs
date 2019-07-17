namespace Saper
{
    partial class FormChangeIP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxip = new System.Windows.Forms.TextBox();
            this.textBoxport = new System.Windows.Forms.TextBox();
            this.buttonok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New port";
            // 
            // textBoxip
            // 
            this.textBoxip.Location = new System.Drawing.Point(115, 78);
            this.textBoxip.Name = "textBoxip";
            this.textBoxip.Size = new System.Drawing.Size(184, 20);
            this.textBoxip.TabIndex = 2;
            // 
            // textBoxport
            // 
            this.textBoxport.Location = new System.Drawing.Point(115, 137);
            this.textBoxport.Name = "textBoxport";
            this.textBoxport.Size = new System.Drawing.Size(100, 20);
            this.textBoxport.TabIndex = 3;
            this.textBoxport.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonok
            // 
            this.buttonok.Location = new System.Drawing.Point(152, 207);
            this.buttonok.Name = "buttonok";
            this.buttonok.Size = new System.Drawing.Size(100, 50);
            this.buttonok.TabIndex = 4;
            this.buttonok.Text = "OK";
            this.buttonok.UseVisualStyleBackColor = true;
            this.buttonok.Click += new System.EventHandler(this.buttonok_Click);
            // 
            // FormChangeIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 299);
            this.Controls.Add(this.buttonok);
            this.Controls.Add(this.textBoxport);
            this.Controls.Add(this.textBoxip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormChangeIP";
            this.Text = "FormChangeIP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxip;
        private System.Windows.Forms.TextBox textBoxport;
        private System.Windows.Forms.Button buttonok;
    }
}