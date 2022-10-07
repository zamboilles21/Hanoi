
namespace HANOI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbtn_end_2 = new System.Windows.Forms.RadioButton();
            this.rdbtn_end_3 = new System.Windows.Forms.RadioButton();
            this.rdbtn_end_1 = new System.Windows.Forms.RadioButton();
            this.ERB = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbtn_start_1 = new System.Windows.Forms.RadioButton();
            this.rdbtn_start_3 = new System.Windows.Forms.RadioButton();
            this.rdbtn_start_2 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbtn_disc_1 = new System.Windows.Forms.RadioButton();
            this.rdbtn_disc_3 = new System.Windows.Forms.RadioButton();
            this.rdbtn_disc_2 = new System.Windows.Forms.RadioButton();
            this.start_btn = new System.Windows.Forms.Button();
            this.ERB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korongok száma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kezdő oszlop:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "Érkező oszlop:";
            // 
            // rdbtn_end_2
            // 
            this.rdbtn_end_2.AutoSize = true;
            this.rdbtn_end_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbtn_end_2.Location = new System.Drawing.Point(56, 13);
            this.rdbtn_end_2.Name = "rdbtn_end_2";
            this.rdbtn_end_2.Size = new System.Drawing.Size(44, 33);
            this.rdbtn_end_2.TabIndex = 12;
            this.rdbtn_end_2.TabStop = true;
            this.rdbtn_end_2.Text = "2";
            this.rdbtn_end_2.UseVisualStyleBackColor = true;
            this.rdbtn_end_2.CheckedChanged += new System.EventHandler(this.rdbtn_end_2_CheckedChanged);
            // 
            // rdbtn_end_3
            // 
            this.rdbtn_end_3.AutoSize = true;
            this.rdbtn_end_3.Checked = true;
            this.rdbtn_end_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbtn_end_3.Location = new System.Drawing.Point(106, 12);
            this.rdbtn_end_3.Name = "rdbtn_end_3";
            this.rdbtn_end_3.Size = new System.Drawing.Size(44, 33);
            this.rdbtn_end_3.TabIndex = 11;
            this.rdbtn_end_3.TabStop = true;
            this.rdbtn_end_3.Text = "3";
            this.rdbtn_end_3.UseVisualStyleBackColor = true;
            this.rdbtn_end_3.CheckedChanged += new System.EventHandler(this.rdbtn_end_3_CheckedChanged);
            // 
            // rdbtn_end_1
            // 
            this.rdbtn_end_1.AutoSize = true;
            this.rdbtn_end_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbtn_end_1.Location = new System.Drawing.Point(6, 13);
            this.rdbtn_end_1.Name = "rdbtn_end_1";
            this.rdbtn_end_1.Size = new System.Drawing.Size(44, 33);
            this.rdbtn_end_1.TabIndex = 10;
            this.rdbtn_end_1.Text = "1";
            this.rdbtn_end_1.UseVisualStyleBackColor = true;
            this.rdbtn_end_1.CheckedChanged += new System.EventHandler(this.rdbtn_end_1_CheckedChanged);
            // 
            // ERB
            // 
            this.ERB.Controls.Add(this.rdbtn_end_1);
            this.ERB.Controls.Add(this.rdbtn_end_3);
            this.ERB.Controls.Add(this.rdbtn_end_2);
            this.ERB.Location = new System.Drawing.Point(286, 168);
            this.ERB.Name = "ERB";
            this.ERB.Size = new System.Drawing.Size(150, 49);
            this.ERB.TabIndex = 13;
            this.ERB.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbtn_start_1);
            this.groupBox2.Controls.Add(this.rdbtn_start_3);
            this.groupBox2.Controls.Add(this.rdbtn_start_2);
            this.groupBox2.Location = new System.Drawing.Point(286, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 49);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // rdbtn_start_1
            // 
            this.rdbtn_start_1.AutoSize = true;
            this.rdbtn_start_1.Checked = true;
            this.rdbtn_start_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbtn_start_1.Location = new System.Drawing.Point(6, 12);
            this.rdbtn_start_1.Name = "rdbtn_start_1";
            this.rdbtn_start_1.Size = new System.Drawing.Size(44, 33);
            this.rdbtn_start_1.TabIndex = 10;
            this.rdbtn_start_1.TabStop = true;
            this.rdbtn_start_1.Text = "1";
            this.rdbtn_start_1.UseVisualStyleBackColor = true;
            this.rdbtn_start_1.CheckedChanged += new System.EventHandler(this.rdbtn_start_1_CheckedChanged);
            // 
            // rdbtn_start_3
            // 
            this.rdbtn_start_3.AutoSize = true;
            this.rdbtn_start_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbtn_start_3.Location = new System.Drawing.Point(106, 12);
            this.rdbtn_start_3.Name = "rdbtn_start_3";
            this.rdbtn_start_3.Size = new System.Drawing.Size(44, 33);
            this.rdbtn_start_3.TabIndex = 11;
            this.rdbtn_start_3.TabStop = true;
            this.rdbtn_start_3.Text = "3";
            this.rdbtn_start_3.UseVisualStyleBackColor = true;
            this.rdbtn_start_3.CheckedChanged += new System.EventHandler(this.rdbtn_start_3_CheckedChanged);
            // 
            // rdbtn_start_2
            // 
            this.rdbtn_start_2.AutoSize = true;
            this.rdbtn_start_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbtn_start_2.Location = new System.Drawing.Point(56, 13);
            this.rdbtn_start_2.Name = "rdbtn_start_2";
            this.rdbtn_start_2.Size = new System.Drawing.Size(44, 33);
            this.rdbtn_start_2.TabIndex = 12;
            this.rdbtn_start_2.TabStop = true;
            this.rdbtn_start_2.Text = "2";
            this.rdbtn_start_2.UseVisualStyleBackColor = true;
            this.rdbtn_start_2.CheckedChanged += new System.EventHandler(this.rdbtn_start_2_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbtn_disc_1);
            this.groupBox3.Controls.Add(this.rdbtn_disc_3);
            this.groupBox3.Controls.Add(this.rdbtn_disc_2);
            this.groupBox3.Location = new System.Drawing.Point(286, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 49);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // rdbtn_disc_1
            // 
            this.rdbtn_disc_1.AutoSize = true;
            this.rdbtn_disc_1.Checked = true;
            this.rdbtn_disc_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbtn_disc_1.Location = new System.Drawing.Point(6, 13);
            this.rdbtn_disc_1.Name = "rdbtn_disc_1";
            this.rdbtn_disc_1.Size = new System.Drawing.Size(44, 33);
            this.rdbtn_disc_1.TabIndex = 10;
            this.rdbtn_disc_1.TabStop = true;
            this.rdbtn_disc_1.Text = "3";
            this.rdbtn_disc_1.UseVisualStyleBackColor = true;
            this.rdbtn_disc_1.CheckedChanged += new System.EventHandler(this.rdbtn_disc_1_CheckedChanged);
            // 
            // rdbtn_disc_3
            // 
            this.rdbtn_disc_3.AutoSize = true;
            this.rdbtn_disc_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbtn_disc_3.Location = new System.Drawing.Point(106, 12);
            this.rdbtn_disc_3.Name = "rdbtn_disc_3";
            this.rdbtn_disc_3.Size = new System.Drawing.Size(44, 33);
            this.rdbtn_disc_3.TabIndex = 11;
            this.rdbtn_disc_3.Text = "7";
            this.rdbtn_disc_3.UseVisualStyleBackColor = true;
            this.rdbtn_disc_3.CheckedChanged += new System.EventHandler(this.rdbtn_disc_3_CheckedChanged);
            // 
            // rdbtn_disc_2
            // 
            this.rdbtn_disc_2.AutoSize = true;
            this.rdbtn_disc_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbtn_disc_2.Location = new System.Drawing.Point(56, 13);
            this.rdbtn_disc_2.Name = "rdbtn_disc_2";
            this.rdbtn_disc_2.Size = new System.Drawing.Size(44, 33);
            this.rdbtn_disc_2.TabIndex = 12;
            this.rdbtn_disc_2.Text = "5";
            this.rdbtn_disc_2.UseVisualStyleBackColor = true;
            this.rdbtn_disc_2.CheckedChanged += new System.EventHandler(this.rdbtn_disc_2_CheckedChanged);
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(200, 229);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(80, 30);
            this.start_btn.TabIndex = 16;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 271);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ERB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(480, 310);
            this.MinimumSize = new System.Drawing.Size(480, 310);
            this.Name = "Form1";
            this.Text = "Hanoi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ERB.ResumeLayout(false);
            this.ERB.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbtn_end_2;
        private System.Windows.Forms.RadioButton rdbtn_end_3;
        private System.Windows.Forms.RadioButton rdbtn_end_1;
        private System.Windows.Forms.GroupBox ERB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbtn_start_1;
        private System.Windows.Forms.RadioButton rdbtn_start_3;
        private System.Windows.Forms.RadioButton rdbtn_start_2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbtn_disc_1;
        private System.Windows.Forms.RadioButton rdbtn_disc_3;
        private System.Windows.Forms.RadioButton rdbtn_disc_2;
        private System.Windows.Forms.Button start_btn;
    }
}

