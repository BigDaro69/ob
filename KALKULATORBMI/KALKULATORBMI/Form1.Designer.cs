namespace KALKULATORBMI
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mezczyzna = new System.Windows.Forms.RadioButton();
            this.kobieta = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.wiek = new System.Windows.Forms.NumericUpDown();
            this.waga = new System.Windows.Forms.NumericUpDown();
            this.wzrost = new System.Windows.Forms.NumericUpDown();
            this.lista = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wiek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wzrost)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(241, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "KALKULATOR       BMI ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Podaj płeć:";
            // 
            // mezczyzna
            // 
            this.mezczyzna.AutoSize = true;
            this.mezczyzna.Location = new System.Drawing.Point(358, 87);
            this.mezczyzna.Name = "mezczyzna";
            this.mezczyzna.Size = new System.Drawing.Size(34, 17);
            this.mezczyzna.TabIndex = 2;
            this.mezczyzna.TabStop = true;
            this.mezczyzna.Text = "M";
            this.mezczyzna.UseVisualStyleBackColor = true;
            // 
            // kobieta
            // 
            this.kobieta.AutoSize = true;
            this.kobieta.Location = new System.Drawing.Point(412, 87);
            this.kobieta.Name = "kobieta";
            this.kobieta.Size = new System.Drawing.Size(32, 17);
            this.kobieta.TabIndex = 3;
            this.kobieta.TabStop = true;
            this.kobieta.Text = "K";
            this.kobieta.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Podaj wiek:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Podaj wagę:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Podaj wzrost:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Poziom aktywności fizycznej:";
            // 
            // wiek
            // 
            this.wiek.Location = new System.Drawing.Point(358, 127);
            this.wiek.Name = "wiek";
            this.wiek.Size = new System.Drawing.Size(120, 20);
            this.wiek.TabIndex = 8;
            this.wiek.ValueChanged += new System.EventHandler(this.wiek_ValueChanged);
            // 
            // waga
            // 
            this.waga.Location = new System.Drawing.Point(358, 168);
            this.waga.Name = "waga";
            this.waga.Size = new System.Drawing.Size(120, 20);
            this.waga.TabIndex = 9;
            this.waga.ValueChanged += new System.EventHandler(this.waga_ValueChanged);
            // 
            // wzrost
            // 
            this.wzrost.Location = new System.Drawing.Point(358, 207);
            this.wzrost.Name = "wzrost";
            this.wzrost.Size = new System.Drawing.Size(120, 20);
            this.wzrost.TabIndex = 10;
            this.wzrost.ValueChanged += new System.EventHandler(this.wzrost_ValueChanged);
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Items.AddRange(new object[] {
            "Brak aktywności",
            "Bardzo lekka aktywność (1 dzień w tygodniu)",
            "Lekka aktywność (2-3 dni w tygodniu)",
            "Średnia aktywność (4-5 dni w tygodniu)",
            "Duża aktywność (codziennie)",
            "Bardzo duża aktywność"});
            this.lista.Location = new System.Drawing.Point(323, 266);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(140, 21);
            this.lista.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(484, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "(18-99)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(484, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "kg";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(484, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "cm";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Zapisz i oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.wzrost);
            this.Controls.Add(this.waga);
            this.Controls.Add(this.wiek);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kobieta);
            this.Controls.Add(this.mezczyzna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.wiek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wzrost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton mezczyzna;
        private System.Windows.Forms.RadioButton kobieta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown wiek;
        private System.Windows.Forms.NumericUpDown waga;
        private System.Windows.Forms.NumericUpDown wzrost;
        private System.Windows.Forms.ComboBox lista;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}

