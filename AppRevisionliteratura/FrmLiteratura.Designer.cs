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
            button1 = new Button();
            txtPalabra = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(304, 256);
            button1.Name = "button1";
            button1.Size = new Size(296, 115);
            button1.TabIndex = 0;
            button1.Text = "btn_Validar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtPalabra
            // 
            txtPalabra.Location = new Point(304, 194);
            txtPalabra.Name = "txtPalabra";
            txtPalabra.Size = new Size(296, 31);
            txtPalabra.TabIndex = 1;
            // 
            // FrmLiteratura
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 649);
            Controls.Add(txtPalabra);
            Controls.Add(button1);
            Margin = new Padding(4);
            Name = "FrmLiteratura";
            Text = "Caperucita Rojaa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtPalabra;
    }
}