
namespace CSharp_Form_FunctionCalculator
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFaktoriyelAl = new System.Windows.Forms.Button();
            this.btnCosinusAl = new System.Windows.Forms.Button();
            this.btnTanAl = new System.Windows.Forms.Button();
            this.btnUsOperatoru = new System.Windows.Forms.Button();
            this.btnSinusAl = new System.Windows.Forms.Button();
            this.btnKarekok = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.btnKareAl = new System.Windows.Forms.Button();
            this.btnPiSayisi = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btnAllClear = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFaktoriyelAl
            // 
            this.btnFaktoriyelAl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFaktoriyelAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFaktoriyelAl.Location = new System.Drawing.Point(24, 368);
            this.btnFaktoriyelAl.Name = "btnFaktoriyelAl";
            this.btnFaktoriyelAl.Size = new System.Drawing.Size(100, 60);
            this.btnFaktoriyelAl.TabIndex = 66;
            this.btnFaktoriyelAl.Text = "x!";
            this.btnFaktoriyelAl.UseVisualStyleBackColor = false;
            this.btnFaktoriyelAl.Click += new System.EventHandler(this.btnFaktoriyelAl_Click);
            // 
            // btnCosinusAl
            // 
            this.btnCosinusAl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCosinusAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCosinusAl.Location = new System.Drawing.Point(24, 170);
            this.btnCosinusAl.Name = "btnCosinusAl";
            this.btnCosinusAl.Size = new System.Drawing.Size(100, 60);
            this.btnCosinusAl.TabIndex = 65;
            this.btnCosinusAl.Text = "cos";
            this.btnCosinusAl.UseVisualStyleBackColor = false;
            this.btnCosinusAl.Click += new System.EventHandler(this.btnCosinusAl_Click);
            // 
            // btnTanAl
            // 
            this.btnTanAl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTanAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTanAl.Location = new System.Drawing.Point(24, 236);
            this.btnTanAl.Name = "btnTanAl";
            this.btnTanAl.Size = new System.Drawing.Size(100, 60);
            this.btnTanAl.TabIndex = 64;
            this.btnTanAl.Text = "tan";
            this.btnTanAl.UseVisualStyleBackColor = false;
            this.btnTanAl.Click += new System.EventHandler(this.btnTanAl_Click);
            // 
            // btnUsOperatoru
            // 
            this.btnUsOperatoru.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUsOperatoru.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUsOperatoru.Location = new System.Drawing.Point(130, 235);
            this.btnUsOperatoru.Name = "btnUsOperatoru";
            this.btnUsOperatoru.Size = new System.Drawing.Size(100, 60);
            this.btnUsOperatoru.TabIndex = 63;
            this.btnUsOperatoru.Text = "xʸ";
            this.btnUsOperatoru.UseVisualStyleBackColor = false;
            this.btnUsOperatoru.Click += new System.EventHandler(this.Rakamlar);
            // 
            // btnSinusAl
            // 
            this.btnSinusAl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSinusAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSinusAl.Location = new System.Drawing.Point(24, 104);
            this.btnSinusAl.Name = "btnSinusAl";
            this.btnSinusAl.Size = new System.Drawing.Size(100, 60);
            this.btnSinusAl.TabIndex = 62;
            this.btnSinusAl.Text = "sin";
            this.btnSinusAl.UseVisualStyleBackColor = false;
            this.btnSinusAl.Click += new System.EventHandler(this.btnSinusAl_Click);
            // 
            // btnKarekok
            // 
            this.btnKarekok.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKarekok.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKarekok.Location = new System.Drawing.Point(130, 368);
            this.btnKarekok.Name = "btnKarekok";
            this.btnKarekok.Size = new System.Drawing.Size(100, 60);
            this.btnKarekok.TabIndex = 61;
            this.btnKarekok.Text = "√";
            this.btnKarekok.UseVisualStyleBackColor = false;
            this.btnKarekok.Click += new System.EventHandler(this.btnKarekok_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button18.Location = new System.Drawing.Point(130, 170);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(100, 60);
            this.button18.TabIndex = 60;
            this.button18.Text = "e";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.Rakamlar);
            // 
            // btnKareAl
            // 
            this.btnKareAl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKareAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKareAl.Location = new System.Drawing.Point(130, 302);
            this.btnKareAl.Name = "btnKareAl";
            this.btnKareAl.Size = new System.Drawing.Size(100, 60);
            this.btnKareAl.TabIndex = 59;
            this.btnKareAl.Text = "x²";
            this.btnKareAl.UseVisualStyleBackColor = false;
            this.btnKareAl.Click += new System.EventHandler(this.btnKareAl_Click);
            // 
            // btnPiSayisi
            // 
            this.btnPiSayisi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPiSayisi.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPiSayisi.Location = new System.Drawing.Point(24, 302);
            this.btnPiSayisi.Name = "btnPiSayisi";
            this.btnPiSayisi.Size = new System.Drawing.Size(100, 60);
            this.btnPiSayisi.TabIndex = 58;
            this.btnPiSayisi.Text = "π";
            this.btnPiSayisi.UseVisualStyleBackColor = false;
            this.btnPiSayisi.Click += new System.EventHandler(this.Rakamlar);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button13.Location = new System.Drawing.Point(130, 104);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(100, 60);
            this.button13.TabIndex = 57;
            this.button13.Text = "Ans";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.Rakamlar);
            // 
            // txtAns
            // 
            this.txtAns.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAns.Location = new System.Drawing.Point(24, 22);
            this.txtAns.Name = "txtAns";
            this.txtAns.ReadOnly = true;
            this.txtAns.Size = new System.Drawing.Size(632, 23);
            this.txtAns.TabIndex = 56;
            this.txtAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button11.Location = new System.Drawing.Point(344, 104);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 60);
            this.button11.TabIndex = 55;
            this.button11.Text = ")";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.Rakamlar);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button12.Location = new System.Drawing.Point(236, 104);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 60);
            this.button12.TabIndex = 54;
            this.button12.Text = "(";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.Rakamlar);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button20.Location = new System.Drawing.Point(344, 368);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(100, 60);
            this.button20.TabIndex = 53;
            this.button20.Text = ".";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.Rakamlar);
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSqrt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSqrt.Location = new System.Drawing.Point(451, 104);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(100, 60);
            this.btnSqrt.TabIndex = 52;
            this.btnSqrt.Text = "%";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.Rakamlar);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button17.Location = new System.Drawing.Point(556, 368);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(100, 60);
            this.button17.TabIndex = 51;
            this.button17.Text = "/";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.Rakamlar);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button16.Location = new System.Drawing.Point(556, 302);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(100, 60);
            this.button16.TabIndex = 50;
            this.button16.Text = "*";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.Rakamlar);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button15.Location = new System.Drawing.Point(556, 236);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(100, 60);
            this.button15.TabIndex = 49;
            this.button15.Text = "-";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.Rakamlar);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button14.Location = new System.Drawing.Point(557, 170);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(100, 60);
            this.button14.TabIndex = 48;
            this.button14.Text = "+";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.Rakamlar);
            // 
            // btnAllClear
            // 
            this.btnAllClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAllClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAllClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAllClear.Location = new System.Drawing.Point(557, 104);
            this.btnAllClear.Name = "btnAllClear";
            this.btnAllClear.Size = new System.Drawing.Size(100, 60);
            this.btnAllClear.TabIndex = 47;
            this.btnAllClear.Text = "AC";
            this.btnAllClear.UseVisualStyleBackColor = false;
            this.btnAllClear.Click += new System.EventHandler(this.btnAllClear_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEqual.Location = new System.Drawing.Point(450, 368);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(100, 60);
            this.btnEqual.TabIndex = 46;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.Location = new System.Drawing.Point(236, 368);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 60);
            this.button10.TabIndex = 45;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.Rakamlar);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(451, 170);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 60);
            this.button7.TabIndex = 44;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Rakamlar);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Location = new System.Drawing.Point(342, 170);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 60);
            this.button8.TabIndex = 43;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Rakamlar);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Location = new System.Drawing.Point(236, 170);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 60);
            this.button9.TabIndex = 42;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Rakamlar);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(451, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 60);
            this.button4.TabIndex = 41;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Rakamlar);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(342, 236);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 60);
            this.button5.TabIndex = 40;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Rakamlar);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(236, 236);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 60);
            this.button6.TabIndex = 39;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Rakamlar);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(451, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 60);
            this.button3.TabIndex = 38;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Rakamlar);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(342, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 60);
            this.button2.TabIndex = 37;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Rakamlar);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(236, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 60);
            this.button1.TabIndex = 36;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Rakamlar);
            // 
            // txtSonuc
            // 
            this.txtSonuc.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.txtSonuc.Location = new System.Drawing.Point(24, 55);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(632, 38);
            this.txtSonuc.TabIndex = 35;
            this.txtSonuc.Text = "0";
            this.txtSonuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSonuc.TextChanged += new System.EventHandler(this.txtSonuc_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 444);
            this.Controls.Add(this.btnFaktoriyelAl);
            this.Controls.Add(this.btnCosinusAl);
            this.Controls.Add(this.btnTanAl);
            this.Controls.Add(this.btnUsOperatoru);
            this.Controls.Add(this.btnSinusAl);
            this.Controls.Add(this.btnKarekok);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.btnKareAl);
            this.Controls.Add(this.btnPiSayisi);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.btnAllClear);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSonuc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFaktoriyelAl;
        private System.Windows.Forms.Button btnCosinusAl;
        private System.Windows.Forms.Button btnTanAl;
        private System.Windows.Forms.Button btnUsOperatoru;
        private System.Windows.Forms.Button btnSinusAl;
        private System.Windows.Forms.Button btnKarekok;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button btnKareAl;
        private System.Windows.Forms.Button btnPiSayisi;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox txtAns;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btnAllClear;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSonuc;
    }
}

