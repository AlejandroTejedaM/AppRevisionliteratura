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
            listaElementos = new ListBox();
            listaReglas = new ListBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            listaOraciones = new ListBox();
            label3 = new Label();
            listaComponentesLexicos = new ListBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources._1;
            pictureBox1.Location = new Point(126, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = Properties.Resources._2;
            pictureBox2.Location = new Point(349, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(215, 164);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = Properties.Resources._3;
            pictureBox3.Location = new Point(126, 210);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(215, 164);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Image = Properties.Resources._4;
            pictureBox4.Location = new Point(349, 210);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(215, 164);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // listaElementos
            // 
            listaElementos.FormattingEnabled = true;
            listaElementos.ItemHeight = 25;
            listaElementos.Location = new Point(680, 63);
            listaElementos.Name = "listaElementos";
            listaElementos.Size = new Size(530, 254);
            listaElementos.TabIndex = 4;
            // 
            // listaReglas
            // 
            listaReglas.FormattingEnabled = true;
            listaReglas.ItemHeight = 25;
            listaReglas.Location = new Point(680, 370);
            listaReglas.Name = "listaReglas";
            listaReglas.Size = new Size(530, 254);
            listaReglas.TabIndex = 5;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(69, 398);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(564, 196);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(836, 27);
            label1.Name = "label1";
            label1.Size = new Size(209, 25);
            label1.TabIndex = 7;
            label1.Text = " Elementos de la Oración";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(886, 342);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 8;
            label2.Text = " Reglas Correctas";
            // 
            // button1
            // 
            button1.Location = new Point(276, 605);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(153, 38);
            button1.TabIndex = 9;
            button1.Text = " Ingresar texto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listaOraciones
            // 
            listaOraciones.FormattingEnabled = true;
            listaOraciones.ItemHeight = 25;
            listaOraciones.Location = new Point(1247, 63);
            listaOraciones.Name = "listaOraciones";
            listaOraciones.Size = new Size(479, 254);
            listaOraciones.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1443, 27);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 11;
            label3.Text = " Oraciones";
            // 
            // listaComponentesLexicos
            // 
            listaComponentesLexicos.FormattingEnabled = true;
            listaComponentesLexicos.ItemHeight = 25;
            listaComponentesLexicos.Location = new Point(1247, 370);
            listaComponentesLexicos.Name = "listaComponentesLexicos";
            listaComponentesLexicos.Size = new Size(479, 254);
            listaComponentesLexicos.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1443, 342);
            label4.Name = "label4";
            label4.Size = new Size(181, 25);
            label4.TabIndex = 13;
            label4.Text = "Componentes lexicos";
            // 
            // FrmLiteratura
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1773, 648);
            Controls.Add(label4);
            Controls.Add(listaComponentesLexicos);
            Controls.Add(label3);
            Controls.Add(listaOraciones);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(listaReglas);
            Controls.Add(listaElementos);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 3, 4, 3);
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
        private ListBox listaElementos;
        private ListBox listaReglas;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private ListBox listaOraciones;
        private Label label3;
        private ListBox listaComponentesLexicos;
        private Label label4;
    }
}