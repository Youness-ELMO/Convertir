namespace somme1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombre1TextBox = new System.Windows.Forms.TextBox();
            this.nombre2TextBox = new System.Windows.Forms.TextBox();
            this.CalculTextBox = new System.Windows.Forms.TextBox();
            this.CalculButton = new System.Windows.Forms.Button();
            this.AnnulerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "nombre 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "nombre 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "nombre 3";
            // 
            // nombre1TextBox
            // 
            this.nombre1TextBox.Location = new System.Drawing.Point(287, 62);
            this.nombre1TextBox.Name = "nombre1TextBox";
            this.nombre1TextBox.Size = new System.Drawing.Size(205, 20);
            this.nombre1TextBox.TabIndex = 4;
            // 
            // nombre2TextBox
            // 
            this.nombre2TextBox.Location = new System.Drawing.Point(287, 112);
            this.nombre2TextBox.Name = "nombre2TextBox";
            this.nombre2TextBox.Size = new System.Drawing.Size(205, 20);
            this.nombre2TextBox.TabIndex = 5;
            // 
            // CalculTextBox
            // 
            this.CalculTextBox.Enabled = false;
            this.CalculTextBox.Location = new System.Drawing.Point(287, 160);
            this.CalculTextBox.Name = "CalculTextBox";
            this.CalculTextBox.Size = new System.Drawing.Size(205, 20);
            this.CalculTextBox.TabIndex = 6;
            // 
            // CalculButton
            // 
            this.CalculButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculButton.Location = new System.Drawing.Point(187, 236);
            this.CalculButton.Name = "CalculButton";
            this.CalculButton.Size = new System.Drawing.Size(86, 36);
            this.CalculButton.TabIndex = 7;
            this.CalculButton.Text = "calcule";
            this.CalculButton.UseVisualStyleBackColor = true;
            this.CalculButton.Click += new System.EventHandler(this.CalculButton_Click);
            // 
            // AnnulerButton
            // 
            this.AnnulerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnulerButton.Location = new System.Drawing.Point(381, 236);
            this.AnnulerButton.Name = "AnnulerButton";
            this.AnnulerButton.Size = new System.Drawing.Size(98, 36);
            this.AnnulerButton.TabIndex = 8;
            this.AnnulerButton.Text = "annulee";
            this.AnnulerButton.UseVisualStyleBackColor = true;
            this.AnnulerButton.Click += new System.EventHandler(this.AnnulerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(664, 393);
            this.Controls.Add(this.AnnulerButton);
            this.Controls.Add(this.CalculButton);
            this.Controls.Add(this.CalculTextBox);
            this.Controls.Add(this.nombre2TextBox);
            this.Controls.Add(this.nombre1TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "calcule du somme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombre1TextBox;
        private System.Windows.Forms.TextBox nombre2TextBox;
        private System.Windows.Forms.TextBox CalculTextBox;
        private System.Windows.Forms.Button CalculButton;
        private System.Windows.Forms.Button AnnulerButton;
    }
}

