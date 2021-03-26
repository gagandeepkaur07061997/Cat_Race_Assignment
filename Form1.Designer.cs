
using System;

namespace Cat_Race_Assignment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonAl = new System.Windows.Forms.RadioButton();
            this.radioButtonBob = new System.Windows.Forms.RadioButton();
            this.radioButtonjoe = new System.Windows.Forms.RadioButton();
            this.Placebet = new System.Windows.Forms.Button();
            this.Race = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cat1 = new System.Windows.Forms.PictureBox();
            this.cat2 = new System.Windows.Forms.PictureBox();
            this.cat4 = new System.Windows.Forms.PictureBox();
            this.cat3 = new System.Windows.Forms.PictureBox();
            this.Endgame = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButtonAl);
            this.groupBox1.Controls.Add(this.radioButtonBob);
            this.groupBox1.Controls.Add(this.radioButtonjoe);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(243, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting system";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(157, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Minimum bet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(468, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Al has not placed bet ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(468, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bob has not placed bet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(468, 23);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Joe has not placed bet ";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(304, 65);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 6;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.White;
            this.numericUpDown1.Location = new System.Drawing.Point(303, 24);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "#";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "$";
            // 
            // radioButtonAl
            // 
            this.radioButtonAl.AutoSize = true;
            this.radioButtonAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radioButtonAl.Location = new System.Drawing.Point(6, 65);
            this.radioButtonAl.Name = "radioButtonAl";
            this.radioButtonAl.Size = new System.Drawing.Size(36, 17);
            this.radioButtonAl.TabIndex = 2;
            this.radioButtonAl.TabStop = true;
            this.radioButtonAl.Text = "Al";
            this.radioButtonAl.UseVisualStyleBackColor = false;
            // 
            // radioButtonBob
            // 
            this.radioButtonBob.AutoSize = true;
            this.radioButtonBob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radioButtonBob.Location = new System.Drawing.Point(6, 42);
            this.radioButtonBob.Name = "radioButtonBob";
            this.radioButtonBob.Size = new System.Drawing.Size(47, 17);
            this.radioButtonBob.TabIndex = 1;
            this.radioButtonBob.TabStop = true;
            this.radioButtonBob.Text = "Bob";
            this.radioButtonBob.UseVisualStyleBackColor = false;
            // 
            // radioButtonjoe
            // 
            this.radioButtonjoe.AutoSize = true;
            this.radioButtonjoe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radioButtonjoe.Location = new System.Drawing.Point(6, 19);
            this.radioButtonjoe.Name = "radioButtonjoe";
            this.radioButtonjoe.Size = new System.Drawing.Size(45, 17);
            this.radioButtonjoe.TabIndex = 0;
            this.radioButtonjoe.TabStop = true;
            this.radioButtonjoe.Text = "Joe";
            this.radioButtonjoe.UseVisualStyleBackColor = false;
            // 
            // Placebet
            // 
            this.Placebet.BackColor = System.Drawing.Color.Yellow;
            this.Placebet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Placebet.Location = new System.Drawing.Point(12, 372);
            this.Placebet.Name = "Placebet";
            this.Placebet.Size = new System.Drawing.Size(93, 66);
            this.Placebet.TabIndex = 1;
            this.Placebet.Text = "Place bet";
            this.Placebet.UseVisualStyleBackColor = false;
            this.Placebet.Click += new System.EventHandler(this.Placebet_Click);
            // 
            // Race
            // 
            this.Race.BackColor = System.Drawing.Color.Yellow;
            this.Race.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Race.Location = new System.Drawing.Point(128, 372);
            this.Race.Name = "Race";
            this.Race.Size = new System.Drawing.Size(89, 66);
            this.Race.TabIndex = 2;
            this.Race.Text = "Race";
            this.Race.UseVisualStyleBackColor = false;
            this.Race.Click += new System.EventHandler(this.Race_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(817, 340);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // cat1
            // 
            this.cat1.Image = global::Cat_Race_Assignment.Properties.Resources.cat2;
            this.cat1.Location = new System.Drawing.Point(31, 30);
            this.cat1.Name = "cat1";
            this.cat1.Size = new System.Drawing.Size(112, 74);
            this.cat1.TabIndex = 4;
            this.cat1.TabStop = false;
            // 
            // cat2
            // 
            this.cat2.Image = global::Cat_Race_Assignment.Properties.Resources.cat2;
            this.cat2.Location = new System.Drawing.Point(31, 110);
            this.cat2.Name = "cat2";
            this.cat2.Size = new System.Drawing.Size(112, 71);
            this.cat2.TabIndex = 5;
            this.cat2.TabStop = false;
            this.cat2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // cat4
            // 
            this.cat4.Image = global::Cat_Race_Assignment.Properties.Resources.cat2;
            this.cat4.Location = new System.Drawing.Point(31, 270);
            this.cat4.Name = "cat4";
            this.cat4.Size = new System.Drawing.Size(112, 78);
            this.cat4.TabIndex = 6;
            this.cat4.TabStop = false;
            // 
            // cat3
            // 
            this.cat3.Image = global::Cat_Race_Assignment.Properties.Resources.cat2;
            this.cat3.Location = new System.Drawing.Point(31, 187);
            this.cat3.Name = "cat3";
            this.cat3.Size = new System.Drawing.Size(112, 77);
            this.cat3.TabIndex = 7;
            this.cat3.TabStop = false;
            // 
            // Endgame
            // 
            this.Endgame.Location = new System.Drawing.Point(45, 449);
            this.Endgame.Name = "Endgame";
            this.Endgame.Size = new System.Drawing.Size(125, 45);
            this.Endgame.TabIndex = 11;
            this.Endgame.Text = "End game";
            this.Endgame.UseVisualStyleBackColor = true;
            this.Endgame.Click += new System.EventHandler(this.Endgame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(916, 510);
            this.Controls.Add(this.Endgame);
            this.Controls.Add(this.cat3);
            this.Controls.Add(this.cat4);
            this.Controls.Add(this.cat2);
            this.Controls.Add(this.cat1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Race);
            this.Controls.Add(this.Placebet);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat3)).EndInit();
            this.ResumeLayout(false);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonAl;
        private System.Windows.Forms.RadioButton radioButtonBob;
        private System.Windows.Forms.RadioButton radioButtonjoe;
        private System.Windows.Forms.Button Placebet;
        private System.Windows.Forms.Button Race;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox cat1;
        private System.Windows.Forms.PictureBox cat2;
        private System.Windows.Forms.PictureBox cat4;
        private System.Windows.Forms.PictureBox cat3;
        private System.Windows.Forms.Button Endgame;
    }
}

