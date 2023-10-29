namespace Telefon_Rehberi
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
            groupBox1 = new GroupBox();
            buttonSil = new Button();
            buttonRehber = new Button();
            buttonKaydet = new Button();
            textBoxTelefonNo = new TextBox();
            textBoxKisiAdi = new TextBox();
            labelTelNo = new Label();
            labelKisi = new Label();
            REHBER = new ListBox();
            labelRehber = new Label();
            buttonAra = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(buttonSil);
            groupBox1.Controls.Add(buttonRehber);
            groupBox1.Controls.Add(buttonKaydet);
            groupBox1.Controls.Add(textBoxTelefonNo);
            groupBox1.Controls.Add(textBoxKisiAdi);
            groupBox1.Controls.Add(labelTelNo);
            groupBox1.Controls.Add(labelKisi);
            groupBox1.Location = new Point(74, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(261, 343);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kisi Ekle";
            // 
            // buttonSil
            // 
            buttonSil.BackColor = Color.Fuchsia;
            buttonSil.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSil.Location = new Point(179, 254);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(75, 50);
            buttonSil.TabIndex = 6;
            buttonSil.Text = "Sil";
            buttonSil.UseVisualStyleBackColor = false;
            buttonSil.Click += button3_Click;
            // 
            // buttonRehber
            // 
            buttonRehber.BackColor = Color.FromArgb(255, 192, 128);
            buttonRehber.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRehber.Location = new Point(98, 254);
            buttonRehber.Name = "buttonRehber";
            buttonRehber.Size = new Size(75, 50);
            buttonRehber.TabIndex = 5;
            buttonRehber.Text = "Rehbere Ekle";
            buttonRehber.UseVisualStyleBackColor = false;
            buttonRehber.Click += buttonRehber_Click;
            // 
            // buttonKaydet
            // 
            buttonKaydet.BackColor = Color.FromArgb(128, 255, 128);
            buttonKaydet.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonKaydet.Location = new Point(17, 254);
            buttonKaydet.Name = "buttonKaydet";
            buttonKaydet.Size = new Size(75, 50);
            buttonKaydet.TabIndex = 4;
            buttonKaydet.Text = "Kaydet";
            buttonKaydet.UseVisualStyleBackColor = false;
            buttonKaydet.Click += buttonKaydet_Click;
            // 
            // textBoxTelefonNo
            // 
            textBoxTelefonNo.Location = new Point(138, 94);
            textBoxTelefonNo.Name = "textBoxTelefonNo";
            textBoxTelefonNo.Size = new Size(100, 23);
            textBoxTelefonNo.TabIndex = 3;
            // 
            // textBoxKisiAdi
            // 
            textBoxKisiAdi.Location = new Point(138, 51);
            textBoxKisiAdi.Name = "textBoxKisiAdi";
            textBoxKisiAdi.Size = new Size(100, 23);
            textBoxKisiAdi.TabIndex = 2;
            // 
            // labelTelNo
            // 
            labelTelNo.AutoSize = true;
            labelTelNo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTelNo.Location = new Point(17, 100);
            labelTelNo.Name = "labelTelNo";
            labelTelNo.Size = new Size(121, 17);
            labelTelNo.TabIndex = 1;
            labelTelNo.Text = "Telefon Numarası:";
            // 
            // labelKisi
            // 
            labelKisi.AutoSize = true;
            labelKisi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelKisi.Location = new Point(17, 57);
            labelKisi.Name = "labelKisi";
            labelKisi.Size = new Size(59, 17);
            labelKisi.TabIndex = 0;
            labelKisi.Text = "Kişi Adı:";
            // 
            // REHBER
            // 
            REHBER.FormattingEnabled = true;
            REHBER.ItemHeight = 15;
            REHBER.Location = new Point(466, 69);
            REHBER.Name = "REHBER";
            REHBER.Size = new Size(221, 319);
            REHBER.TabIndex = 1;
            // 
            // labelRehber
            // 
            labelRehber.AutoSize = true;
            labelRehber.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelRehber.Location = new Point(466, 40);
            labelRehber.Name = "labelRehber";
            labelRehber.Size = new Size(81, 25);
            labelRehber.TabIndex = 2;
            labelRehber.Text = "Rehber:";
            // 
            // buttonAra
            // 
            buttonAra.BackColor = Color.Red;
            buttonAra.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAra.Location = new Point(601, 340);
            buttonAra.Name = "buttonAra";
            buttonAra.Size = new Size(75, 37);
            buttonAra.TabIndex = 3;
            buttonAra.Text = "Ara";
            buttonAra.UseVisualStyleBackColor = false;
            buttonAra.Click += buttonAra_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAra);
            Controls.Add(labelRehber);
            Controls.Add(REHBER);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Telefon Rehberi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox REHBER;
        private Button buttonSil;
        private Button buttonRehber;
        private Button buttonKaydet;
        private TextBox textBoxTelefonNo;
        private TextBox textBoxKisiAdi;
        private Label labelTelNo;
        private Label labelKisi;
        private Label labelRehber;
        private Button buttonAra;
    }
}