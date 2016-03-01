namespace ClassLibrary1
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
            this.B_Ajouter = new System.Windows.Forms.Button();
            this.B_Modifier = new System.Windows.Forms.Button();
            this.B_Suppr = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // B_Ajouter
            // 
            this.B_Ajouter.Location = new System.Drawing.Point(197, 12);
            this.B_Ajouter.Name = "B_Ajouter";
            this.B_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.B_Ajouter.TabIndex = 0;
            this.B_Ajouter.Text = "Ajouter";
            this.B_Ajouter.UseVisualStyleBackColor = true;
            // 
            // B_Modifier
            // 
            this.B_Modifier.Location = new System.Drawing.Point(197, 41);
            this.B_Modifier.Name = "B_Modifier";
            this.B_Modifier.Size = new System.Drawing.Size(75, 23);
            this.B_Modifier.TabIndex = 1;
            this.B_Modifier.Text = "Modifier";
            this.B_Modifier.UseVisualStyleBackColor = true;
            this.B_Modifier.Click += new System.EventHandler(this.B_Modifier_Click);
            // 
            // B_Suppr
            // 
            this.B_Suppr.Location = new System.Drawing.Point(197, 70);
            this.B_Suppr.Name = "B_Suppr";
            this.B_Suppr.Size = new System.Drawing.Size(75, 23);
            this.B_Suppr.TabIndex = 2;
            this.B_Suppr.Text = "Suppr.";
            this.B_Suppr.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 238);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.B_Suppr);
            this.Controls.Add(this.B_Modifier);
            this.Controls.Add(this.B_Ajouter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_Ajouter;
        private System.Windows.Forms.Button B_Modifier;
        private System.Windows.Forms.Button B_Suppr;
        private System.Windows.Forms.ListBox listBox1;
    }
}