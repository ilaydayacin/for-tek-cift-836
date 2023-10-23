namespace deneme_for_sorusu__836
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
            this.lbTek = new System.Windows.Forms.ListBox();
            this.lbÇift = new System.Windows.Forms.ListBox();
            this.btnHesap = new System.Windows.Forms.Button();
            this.txtSinir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTek
            // 
            this.lbTek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbTek.FormattingEnabled = true;
            this.lbTek.ItemHeight = 20;
            this.lbTek.Location = new System.Drawing.Point(265, 47);
            this.lbTek.Name = "lbTek";
            this.lbTek.Size = new System.Drawing.Size(120, 244);
            this.lbTek.TabIndex = 0;
            // 
            // lbÇift
            // 
            this.lbÇift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbÇift.FormattingEnabled = true;
            this.lbÇift.ItemHeight = 20;
            this.lbÇift.Location = new System.Drawing.Point(391, 47);
            this.lbÇift.Name = "lbÇift";
            this.lbÇift.Size = new System.Drawing.Size(120, 244);
            this.lbÇift.TabIndex = 1;
            // 
            // btnHesap
            // 
            this.btnHesap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesap.Location = new System.Drawing.Point(67, 146);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(145, 101);
            this.btnHesap.TabIndex = 2;
            this.btnHesap.Text = "button1";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // txtSinir
            // 
            this.txtSinir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSinir.Location = new System.Drawing.Point(66, 101);
            this.txtSinir.Name = "txtSinir";
            this.txtSinir.Size = new System.Drawing.Size(176, 26);
            this.txtSinir.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(63, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sınır sayısı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSinir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHesap);
            this.Controls.Add(this.lbÇift);
            this.Controls.Add(this.lbTek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTek;
        private System.Windows.Forms.ListBox lbÇift;
        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.TextBox txtSinir;
        private System.Windows.Forms.Label label1;
    }
}

