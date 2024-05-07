namespace Pomodoro_App
{
    partial class Odaklanma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxodakH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxodakM = new System.Windows.Forms.TextBox();
            this.textBoxodakS = new System.Windows.Forms.TextBox();
            this.textBoxmolaS = new System.Windows.Forms.TextBox();
            this.textBoxmolaM = new System.Windows.Forms.TextBox();
            this.textBoxmolaH = new System.Windows.Forms.TextBox();
            this.buttonreset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odaklanma Süresi";
            // 
            // textBoxodakH
            // 
            this.textBoxodakH.Location = new System.Drawing.Point(168, 47);
            this.textBoxodakH.MaxLength = 3;
            this.textBoxodakH.Name = "textBoxodakH";
            this.textBoxodakH.Size = new System.Drawing.Size(40, 20);
            this.textBoxodakH.TabIndex = 2;
            this.textBoxodakH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mola Süresi";
            // 
            // textBoxodakM
            // 
            this.textBoxodakM.Location = new System.Drawing.Point(240, 47);
            this.textBoxodakM.MaxLength = 3;
            this.textBoxodakM.Name = "textBoxodakM";
            this.textBoxodakM.Size = new System.Drawing.Size(40, 20);
            this.textBoxodakM.TabIndex = 5;
            this.textBoxodakM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // textBoxodakS
            // 
            this.textBoxodakS.Location = new System.Drawing.Point(312, 47);
            this.textBoxodakS.MaxLength = 3;
            this.textBoxodakS.Name = "textBoxodakS";
            this.textBoxodakS.Size = new System.Drawing.Size(40, 20);
            this.textBoxodakS.TabIndex = 6;
            this.textBoxodakS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // textBoxmolaS
            // 
            this.textBoxmolaS.Location = new System.Drawing.Point(312, 99);
            this.textBoxmolaS.MaxLength = 3;
            this.textBoxmolaS.Name = "textBoxmolaS";
            this.textBoxmolaS.Size = new System.Drawing.Size(40, 20);
            this.textBoxmolaS.TabIndex = 9;
            this.textBoxmolaS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // textBoxmolaM
            // 
            this.textBoxmolaM.Location = new System.Drawing.Point(240, 99);
            this.textBoxmolaM.MaxLength = 3;
            this.textBoxmolaM.Name = "textBoxmolaM";
            this.textBoxmolaM.Size = new System.Drawing.Size(40, 20);
            this.textBoxmolaM.TabIndex = 8;
            this.textBoxmolaM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // textBoxmolaH
            // 
            this.textBoxmolaH.Location = new System.Drawing.Point(168, 99);
            this.textBoxmolaH.MaxLength = 3;
            this.textBoxmolaH.Name = "textBoxmolaH";
            this.textBoxmolaH.Size = new System.Drawing.Size(40, 20);
            this.textBoxmolaH.TabIndex = 7;
            this.textBoxmolaH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // buttonreset
            // 
            this.buttonreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(130)))), ((int)(((byte)(196)))));
            this.buttonreset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonreset.ForeColor = System.Drawing.Color.White;
            this.buttonreset.Location = new System.Drawing.Point(136, 160);
            this.buttonreset.Name = "buttonreset";
            this.buttonreset.Size = new System.Drawing.Size(150, 50);
            this.buttonreset.TabIndex = 10;
            this.buttonreset.Text = "Sıfırla";
            this.buttonreset.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(172, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Saat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(235, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dakika";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(309, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Saniye";
            // 
            // Odaklanma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(398, 267);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonreset);
            this.Controls.Add(this.textBoxmolaS);
            this.Controls.Add(this.textBoxmolaM);
            this.Controls.Add(this.textBoxmolaH);
            this.Controls.Add(this.textBoxodakS);
            this.Controls.Add(this.textBoxodakM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxodakH);
            this.Controls.Add(this.label1);
            this.Name = "Odaklanma";
            this.Text = "Odaklanma";
            this.Load += new System.EventHandler(this.Odaklanma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxodakH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxodakM;
        private System.Windows.Forms.TextBox textBoxodakS;
        private System.Windows.Forms.TextBox textBoxmolaS;
        private System.Windows.Forms.TextBox textBoxmolaM;
        private System.Windows.Forms.TextBox textBoxmolaH;
        private System.Windows.Forms.Button buttonreset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}