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
            AreaTextoElementos = new ListBox();
            AreaTextoReglas = new ListBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            AreaTextoOraciones = new ListBox();
            label3 = new Label();
            AreaTextoComponentesLexicos = new ListBox();
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
            pictureBox1.Location = new Point(88, 23);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = Properties.Resources._2;
            pictureBox2.Location = new Point(244, 23);
            pictureBox2.Margin = new Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(152, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = Properties.Resources._3;
            pictureBox3.Location = new Point(88, 126);
            pictureBox3.Margin = new Padding(2, 2, 2, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(152, 100);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Image = Properties.Resources._4;
            pictureBox4.Location = new Point(244, 126);
            pictureBox4.Margin = new Padding(2, 2, 2, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(152, 100);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // AreaTextoElementos
            // 
            AreaTextoElementos.FormattingEnabled = true;
            AreaTextoElementos.HorizontalScrollbar = true;
            AreaTextoElementos.ImeMode = ImeMode.NoControl;
            AreaTextoElementos.ItemHeight = 15;
            AreaTextoElementos.Location = new Point(476, 38);
            AreaTextoElementos.Margin = new Padding(2, 2, 2, 2);
            AreaTextoElementos.Name = "AreaTextoElementos";
            AreaTextoElementos.ScrollAlwaysVisible = true;
            AreaTextoElementos.Size = new Size(372, 154);
            AreaTextoElementos.TabIndex = 4;
            // 
            // AreaTextoReglas
            // 
            AreaTextoReglas.FormattingEnabled = true;
            AreaTextoReglas.HorizontalScrollbar = true;
            AreaTextoReglas.ImeMode = ImeMode.NoControl;
            AreaTextoReglas.ItemHeight = 15;
            AreaTextoReglas.Location = new Point(476, 222);
            AreaTextoReglas.Margin = new Padding(2, 2, 2, 2);
            AreaTextoReglas.Name = "AreaTextoReglas";
            AreaTextoReglas.ScrollAlwaysVisible = true;
            AreaTextoReglas.Size = new Size(372, 154);
            AreaTextoReglas.TabIndex = 5;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(48, 239);
            richTextBox1.Margin = new Padding(2, 2, 2, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(396, 119);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(585, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 7;
            label1.Text = " Elementos de la Oración";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(620, 205);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 8;
            label2.Text = " Reglas Correctas";
            // 
            // button1
            // 
            button1.Location = new Point(193, 363);
            button1.Name = "button1";
            button1.Size = new Size(107, 23);
            button1.TabIndex = 9;
            button1.Text = " Ingresar texto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AreaTextoOraciones
            // 
            AreaTextoOraciones.FormattingEnabled = true;
            AreaTextoOraciones.HorizontalScrollbar = true;
            AreaTextoOraciones.ImeMode = ImeMode.NoControl;
            AreaTextoOraciones.ItemHeight = 15;
            AreaTextoOraciones.Location = new Point(873, 38);
            AreaTextoOraciones.Margin = new Padding(2, 2, 2, 2);
            AreaTextoOraciones.Name = "AreaTextoOraciones";
            AreaTextoOraciones.ScrollAlwaysVisible = true;
            AreaTextoOraciones.Size = new Size(336, 154);
            AreaTextoOraciones.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1010, 16);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 11;
            label3.Text = " Oraciones";
            // 
            // AreaTextoComponentesLexicos
            // 
            AreaTextoComponentesLexicos.FormattingEnabled = true;
            AreaTextoComponentesLexicos.HorizontalScrollbar = true;
            AreaTextoComponentesLexicos.ItemHeight = 15;
            AreaTextoComponentesLexicos.Location = new Point(873, 223);
            AreaTextoComponentesLexicos.Margin = new Padding(2, 2, 2, 2);
            AreaTextoComponentesLexicos.Name = "AreaTextoComponentesLexicos";
            AreaTextoComponentesLexicos.ScrollAlwaysVisible = true;
            AreaTextoComponentesLexicos.Size = new Size(336, 154);
            AreaTextoComponentesLexicos.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1010, 205);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 13;
            label4.Text = "Componentes lexicos";
            // 
            // FrmLiteratura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 389);
            Controls.Add(label4);
            Controls.Add(AreaTextoComponentesLexicos);
            Controls.Add(label3);
            Controls.Add(AreaTextoOraciones);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(AreaTextoReglas);
            Controls.Add(AreaTextoElementos);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmLiteratura";
            Text = "Caperucita Roja";
            Load += FrmLiteratura_Load;
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
        private ListBox AreaTextoElementos;
        private ListBox AreaTextoReglas;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private ListBox AreaTextoOraciones;
        private Label label3;
        private ListBox AreaTextoComponentesLexicos;
        private Label label4;
    }
}