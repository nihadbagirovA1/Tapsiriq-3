namespace Tapsiriq_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            yer = new TextBox();
            saat = new MaskedTextBox();
            tarix = new MaskedTextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            button2 = new Button();
            email = new TextBox();
            fin = new TextBox();
            adsoyad = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            telefon = new MaskedTextBox();
            button3 = new Button();
            button4 = new Button();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(7, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(259, 46);
            label1.Name = "label1";
            label1.Size = new Size(273, 35);
            label1.TabIndex = 2;
            label1.Text = "SUMQAYIT-BMU";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(596, -10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(189, 135);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlDarkDark;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(yer);
            groupBox1.Controls.Add(saat);
            groupBox1.Controls.Add(tarix);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(12, 142);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 238);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Location = new Point(276, 23);
            button1.Name = "button1";
            button1.Size = new Size(27, 68);
            button1.TabIndex = 10;
            button1.Text = "><";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // yer
            // 
            yer.Location = new Point(91, 174);
            yer.Name = "yer";
            yer.Size = new Size(125, 27);
            yer.TabIndex = 9;
            // 
            // saat
            // 
            saat.Location = new Point(91, 138);
            saat.Mask = "90:00";
            saat.Name = "saat";
            saat.Size = new Size(125, 27);
            saat.TabIndex = 8;
            saat.ValidatingType = typeof(DateTime);
            // 
            // tarix
            // 
            tarix.Location = new Point(91, 101);
            tarix.Mask = "00/00/0000";
            tarix.Name = "tarix";
            tarix.Size = new Size(125, 27);
            tarix.TabIndex = 7;
            tarix.ValidatingType = typeof(DateTime);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 138);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 6;
            label6.Text = "Saat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 174);
            label5.Name = "label5";
            label5.Size = new Size(29, 20);
            label5.TabIndex = 5;
            label5.Text = "Yer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 101);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 4;
            label4.Text = "Tarix";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 66);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 3;
            label3.Text = "Haraya";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 26);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 2;
            label2.Text = "Haradan";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Seki", "Celilabad", "Imisli", "Quba" });
            comboBox2.Location = new Point(91, 63);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Baki", "Sumqayit", "Xirdalan", "Abseron" });
            comboBox1.Location = new Point(91, 23);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlDarkDark;
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(email);
            groupBox2.Controls.Add(fin);
            groupBox2.Controls.Add(adsoyad);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(telefon);
            groupBox2.Location = new Point(438, 142);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(358, 238);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Location = new Point(247, 203);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 16;
            button2.Text = "Bilet Al";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // email
            // 
            email.Location = new Point(156, 164);
            email.Name = "email";
            email.Size = new Size(125, 27);
            email.TabIndex = 15;
            // 
            // fin
            // 
            fin.Location = new Point(156, 72);
            fin.Name = "fin";
            fin.Size = new Size(125, 27);
            fin.TabIndex = 14;
            // 
            // adsoyad
            // 
            adsoyad.Location = new Point(156, 30);
            adsoyad.Name = "adsoyad";
            adsoyad.Size = new Size(125, 27);
            adsoyad.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 167);
            label10.Name = "label10";
            label10.Size = new Size(46, 20);
            label10.TabIndex = 12;
            label10.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 116);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 11;
            label9.Text = "Telefon";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 75);
            label8.Name = "label8";
            label8.Size = new Size(28, 20);
            label8.TabIndex = 10;
            label8.Text = "Fin";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 33);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 9;
            label7.Text = "Ad ve Soyad";
            // 
            // telefon
            // 
            telefon.Location = new Point(156, 113);
            telefon.Mask = "(999) 000-00-00";
            telefon.Name = "telefon";
            telefon.Size = new Size(125, 27);
            telefon.TabIndex = 8;
            // 
            // button3
            // 
            button3.BackColor = Color.Brown;
            button3.Location = new Point(12, 470);
            button3.Name = "button3";
            button3.Size = new Size(170, 38);
            button3.TabIndex = 5;
            button3.Text = " Delete ticket";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Brown;
            button4.Location = new Point(635, 470);
            button4.Name = "button4";
            button4.Size = new Size(170, 38);
            button4.TabIndex = 6;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 386);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(793, 84);
            listBox1.TabIndex = 7;
            listBox1.Tag = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(817, 520);
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox yer;
        private MaskedTextBox saat;
        private MaskedTextBox tarix;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private MaskedTextBox telefon;
        private TextBox email;
        private TextBox fin;
        private TextBox adsoyad;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button2;
        private ListBox listBox1;
    }
}
