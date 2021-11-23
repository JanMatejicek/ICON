
namespace Úkol_3
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox = new System.Windows.Forms.TextBox();
            this.btn_vypocitej = new System.Windows.Forms.Button();
            this.lbl_a = new System.Windows.Forms.Label();
            this.lbl_b = new System.Windows.Forms.Label();
            this.lbl_c = new System.Windows.Forms.Label();
            this.lbl_d = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox.ForeColor = System.Drawing.Color.White;
            this.textBox.Location = new System.Drawing.Point(34, 30);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(125, 370);
            this.textBox.TabIndex = 0;
            // 
            // btn_vypocitej
            // 
            this.btn_vypocitej.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btn_vypocitej.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_vypocitej.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_vypocitej.ForeColor = System.Drawing.Color.White;
            this.btn_vypocitej.Location = new System.Drawing.Point(330, 345);
            this.btn_vypocitej.Name = "btn_vypocitej";
            this.btn_vypocitej.Size = new System.Drawing.Size(207, 55);
            this.btn_vypocitej.TabIndex = 1;
            this.btn_vypocitej.Text = "Vypočítej";
            this.btn_vypocitej.UseVisualStyleBackColor = false;
            this.btn_vypocitej.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_a.ForeColor = System.Drawing.Color.White;
            this.lbl_a.Location = new System.Drawing.Point(193, 30);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(33, 25);
            this.lbl_a.TabIndex = 2;
            this.lbl_a.Text = "A)";
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_b.ForeColor = System.Drawing.Color.White;
            this.lbl_b.Location = new System.Drawing.Point(193, 114);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(32, 25);
            this.lbl_b.TabIndex = 3;
            this.lbl_b.Text = "B)";
            // 
            // lbl_c
            // 
            this.lbl_c.AutoSize = true;
            this.lbl_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_c.ForeColor = System.Drawing.Color.White;
            this.lbl_c.Location = new System.Drawing.Point(193, 189);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(34, 25);
            this.lbl_c.TabIndex = 4;
            this.lbl_c.Text = "C)";
            // 
            // lbl_d
            // 
            this.lbl_d.AutoSize = true;
            this.lbl_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_d.ForeColor = System.Drawing.Color.White;
            this.lbl_d.Location = new System.Drawing.Point(193, 270);
            this.lbl_d.Name = "lbl_d";
            this.lbl_d.Size = new System.Drawing.Size(33, 25);
            this.lbl_d.TabIndex = 5;
            this.lbl_d.Text = "D)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(738, 433);
            this.Controls.Add(this.lbl_d);
            this.Controls.Add(this.lbl_c);
            this.Controls.Add(this.lbl_b);
            this.Controls.Add(this.lbl_a);
            this.Controls.Add(this.btn_vypocitej);
            this.Controls.Add(this.textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(756, 480);
            this.MinimumSize = new System.Drawing.Size(756, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Úkol 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btn_vypocitej;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.Label lbl_c;
        private System.Windows.Forms.Label lbl_d;
    }
}

