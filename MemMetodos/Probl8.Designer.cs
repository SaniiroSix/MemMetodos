namespace MemMetodos
{
    partial class Probl8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Probl8));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RButt1 = new System.Windows.Forms.RadioButton();
            this.RButt2 = new System.Windows.Forms.RadioButton();
            this.RButt3 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arista 2.0", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Problema ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 216);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resuelva el siguiente problema:\r\n\r\n\r\nx - 3y + 5z = 5\r\n8x - y - z = 8 \r\n-2x + 4y +" +
    " z = 4\r\n\r\n\r\n\r\nElija la respuesta correcta.\r\n\r\n\r\n";
            // 
            // RButt1
            // 
            this.RButt1.AutoSize = true;
            this.RButt1.BackColor = System.Drawing.Color.Transparent;
            this.RButt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RButt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RButt1.ForeColor = System.Drawing.Color.White;
            this.RButt1.Location = new System.Drawing.Point(12, 251);
            this.RButt1.Name = "RButt1";
            this.RButt1.Size = new System.Drawing.Size(294, 20);
            this.RButt1.TabIndex = 2;
            this.RButt1.Text = "x = 1.351045449, y = 1.2982079, z = 1.50871565";
            this.RButt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RButt1.UseVisualStyleBackColor = false;
            // 
            // RButt2
            // 
            this.RButt2.AutoSize = true;
            this.RButt2.BackColor = System.Drawing.Color.Transparent;
            this.RButt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RButt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RButt2.ForeColor = System.Drawing.Color.White;
            this.RButt2.Location = new System.Drawing.Point(12, 283);
            this.RButt2.Name = "RButt2";
            this.RButt2.Size = new System.Drawing.Size(294, 20);
            this.RButt2.TabIndex = 3;
            this.RButt2.Text = "x = 1.389273800, y = 1.2294743, z = 1.72800279";
            this.RButt2.UseVisualStyleBackColor = false;
            // 
            // RButt3
            // 
            this.RButt3.AutoSize = true;
            this.RButt3.BackColor = System.Drawing.Color.Transparent;
            this.RButt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RButt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RButt3.ForeColor = System.Drawing.Color.White;
            this.RButt3.Location = new System.Drawing.Point(12, 316);
            this.RButt3.Name = "RButt3";
            this.RButt3.Size = new System.Drawing.Size(294, 20);
            this.RButt3.TabIndex = 4;
            this.RButt3.Text = "x = 1.298370111, y = 1.2319954, z = 1.38373201";
            this.RButt3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(296, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Confirmar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Probl8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(382, 429);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RButt3);
            this.Controls.Add(this.RButt2);
            this.Controls.Add(this.RButt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Probl8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Probl";
            this.Load += new System.EventHandler(this.Probl8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RButt1;
        private System.Windows.Forms.RadioButton RButt2;
        private System.Windows.Forms.RadioButton RButt3;
        private System.Windows.Forms.Button button2;
    }
}