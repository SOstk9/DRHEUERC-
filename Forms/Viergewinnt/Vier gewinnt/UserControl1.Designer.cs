namespace Vier_gewinnt
{
    partial class UserControl1
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.user1Eingabe = new System.Windows.Forms.Button();
            this.user2Eingabe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(42, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 20);
            this.textBox2.TabIndex = 1;
            // 
            // user1Eingabe
            // 
            this.user1Eingabe.Location = new System.Drawing.Point(387, 71);
            this.user1Eingabe.Name = "user1Eingabe";
            this.user1Eingabe.Size = new System.Drawing.Size(75, 23);
            this.user1Eingabe.TabIndex = 2;
            this.user1Eingabe.Text = "User 1";
            this.user1Eingabe.UseVisualStyleBackColor = true;
            this.user1Eingabe.Click += new System.EventHandler(this.user1Eingabe_Click);
            // 
            // user2Eingabe
            // 
            this.user2Eingabe.Location = new System.Drawing.Point(387, 137);
            this.user2Eingabe.Name = "user2Eingabe";
            this.user2Eingabe.Size = new System.Drawing.Size(75, 23);
            this.user2Eingabe.TabIndex = 3;
            this.user2Eingabe.Text = "User 2";
            this.user2Eingabe.UseVisualStyleBackColor = true;
            this.user2Eingabe.Click += new System.EventHandler(this.user2Eingabe_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.user2Eingabe);
            this.Controls.Add(this.user1Eingabe);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(636, 241);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button user1Eingabe;
        private System.Windows.Forms.Button user2Eingabe;
    }
}
