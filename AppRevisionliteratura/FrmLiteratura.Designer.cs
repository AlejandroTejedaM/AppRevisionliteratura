namespace AppRevisionliteratura
{
    partial class FrmLiteratura
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1;
            pictureBox1.Location = new Point(126, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._2;
            pictureBox2.Location = new Point(349, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(217, 166);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._3;
            pictureBox3.Location = new Point(126, 210);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(217, 166);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._4;
            pictureBox4.Location = new Point(349, 210);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(217, 166);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(680, 63);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(530, 254);
            listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(680, 370);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(530, 254);
            listBox2.TabIndex = 5;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(68, 398);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(564, 217);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(836, 26);
            label1.Name = "label1";
            label1.Size = new Size(209, 25);
            label1.TabIndex = 7;
            label1.Text = " Elementos de la Oración";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(885, 342);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 8;
            label2.Text = " Reglas Correctas";
            // 
            // FrmLiteratura
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 649);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(4);
            Name = "FrmLiteratura";
            Text = "Caperucita Rojaa";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private ListBox listBox1;
        private ListBox listBox2;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
    }
}