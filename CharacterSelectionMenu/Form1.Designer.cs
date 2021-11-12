
namespace CharacterSelectionMenu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_player_name = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pic_character = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_character)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lbl_player_name);
            this.panel1.Controls.Add(this.pic_character);
            this.panel1.Controls.Add(this.btn_start);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 387);
            this.panel1.TabIndex = 0;
            // 
            // lbl_player_name
            // 
            this.lbl_player_name.AutoSize = true;
            this.lbl_player_name.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_player_name.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_player_name.Location = new System.Drawing.Point(141, 284);
            this.lbl_player_name.Name = "lbl_player_name";
            this.lbl_player_name.Size = new System.Drawing.Size(69, 19);
            this.lbl_player_name.TabIndex = 6;
            this.lbl_player_name.Text = "Player";
            this.lbl_player_name.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_start.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_start.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_start.Location = new System.Drawing.Point(88, 320);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(162, 43);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox2.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(23, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(44, 120);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "<";
            // 
            // pic_character
            // 
            this.pic_character.Image = global::CharacterSelectionMenu.Properties.Resources.pet1;
            this.pic_character.Location = new System.Drawing.Point(88, 86);
            this.pic_character.Name = "pic_character";
            this.pic_character.Size = new System.Drawing.Size(162, 195);
            this.pic_character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_character.TabIndex = 4;
            this.pic_character.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox3.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(274, 148);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(45, 120);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = ">";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(65, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 44);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = " Select Player";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_character)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pic_character;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_player_name;
    }
}

