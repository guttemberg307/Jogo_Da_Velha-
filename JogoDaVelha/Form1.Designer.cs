namespace JogoDaVelha
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.b11 = new System.Windows.Forms.Button();
            this.b12 = new System.Windows.Forms.Button();
            this.b13 = new System.Windows.Forms.Button();
            this.b21 = new System.Windows.Forms.Button();
            this.b22 = new System.Windows.Forms.Button();
            this.b23 = new System.Windows.Forms.Button();
            this.b31 = new System.Windows.Forms.Button();
            this.b32 = new System.Windows.Forms.Button();
            this.b33 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b11
            // 
            this.b11.Location = new System.Drawing.Point(80, 74);
            this.b11.Name = "b11";
            this.b11.Size = new System.Drawing.Size(50, 50);
            this.b11.TabIndex = 0;
            this.b11.UseVisualStyleBackColor = true;
           
            // 
            // b12
            // 
            this.b12.Location = new System.Drawing.Point(80, 130);
            this.b12.Name = "b12";
            this.b12.Size = new System.Drawing.Size(50, 50);
            this.b12.TabIndex = 3;
            this.b12.UseVisualStyleBackColor = true;
            // 
            // b13
            // 
            this.b13.Location = new System.Drawing.Point(80, 186);
            this.b13.Name = "b13";
            this.b13.Size = new System.Drawing.Size(50, 50);
            this.b13.TabIndex = 5;
            this.b13.UseVisualStyleBackColor = true;
            // 
            // b21
            // 
            this.b21.Location = new System.Drawing.Point(136, 74);
            this.b21.Name = "b21";
            this.b21.Size = new System.Drawing.Size(50, 50);
            this.b21.TabIndex = 1;
            this.b21.UseVisualStyleBackColor = true;
            // 
            // b22
            // 
            this.b22.Location = new System.Drawing.Point(136, 130);
            this.b22.Name = "b22";
            this.b22.Size = new System.Drawing.Size(50, 50);
            this.b22.TabIndex = 4;
            this.b22.UseVisualStyleBackColor = true;
            // 
            // b23
            // 
            this.b23.Location = new System.Drawing.Point(136, 186);
            this.b23.Name = "b23";
            this.b23.Size = new System.Drawing.Size(50, 50);
            this.b23.TabIndex = 7;
            this.b23.UseVisualStyleBackColor = true;
            // 
            // b31
            // 
            this.b31.Location = new System.Drawing.Point(192, 74);
            this.b31.Name = "b31";
            this.b31.Size = new System.Drawing.Size(50, 50);
            this.b31.TabIndex = 2;
            this.b31.UseVisualStyleBackColor = true;
            // 
            // b32
            // 
            this.b32.Location = new System.Drawing.Point(192, 130);
            this.b32.Name = "b32";
            this.b32.Size = new System.Drawing.Size(50, 50);
            this.b32.TabIndex = 6;
            this.b32.UseVisualStyleBackColor = true;
            // 
            // b33
            // 
            this.b33.Location = new System.Drawing.Point(192, 186);
            this.b33.Name = "b33";
            this.b33.Size = new System.Drawing.Size(50, 50);
            this.b33.TabIndex = 8;
            this.b33.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(55, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "X,  é a sua vez.";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b33);
            this.Controls.Add(this.b23);
            this.Controls.Add(this.b32);
            this.Controls.Add(this.b13);
            this.Controls.Add(this.b22);
            this.Controls.Add(this.b12);
            this.Controls.Add(this.b31);
            this.Controls.Add(this.b21);
            this.Controls.Add(this.b11);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Velha ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b11;
        private System.Windows.Forms.Button b21;
        private System.Windows.Forms.Button b31;
        private System.Windows.Forms.Button b12;
        private System.Windows.Forms.Button b22;
        private System.Windows.Forms.Button b13;
        private System.Windows.Forms.Button b32;
        private System.Windows.Forms.Button b23;
        private System.Windows.Forms.Button b33;
        private System.Windows.Forms.Button button1;
    }
}

