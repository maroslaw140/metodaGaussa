namespace LAB01_metody_num
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
            this.macierzA = new System.Windows.Forms.DataGridView();
            this.macierzX = new System.Windows.Forms.DataGridView();
            this.macierzB = new System.Windows.Forms.DataGridView();
            this.wymiaryMacierzy = new System.Windows.Forms.NumericUpDown();
            this.labelN = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelRownosc = new System.Windows.Forms.Label();
            this.generacjaLiczb = new System.Windows.Forms.Button();
            this.labelLiczby = new System.Windows.Forms.Label();
            this.labelZakresOd = new System.Windows.Forms.Label();
            this.labelZakresDo = new System.Windows.Forms.Label();
            this.minimum = new System.Windows.Forms.NumericUpDown();
            this.maksimum = new System.Windows.Forms.NumericUpDown();
            this.gaussTest = new System.Windows.Forms.Button();
            this.wynik = new System.Windows.Forms.Button();
            this.tryb = new System.Windows.Forms.GroupBox();
            this.rzeczywiste = new System.Windows.Forms.RadioButton();
            this.zespolone = new System.Windows.Forms.RadioButton();
            this.wymmac = new System.Windows.Forms.Label();
            this.dokladnosc = new System.Windows.Forms.Label();
            this.zaokraglanie = new System.Windows.Forms.NumericUpDown();
            this.mrzec = new System.Windows.Forms.Label();
            this.autorzy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.macierzA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macierzX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macierzB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wymiaryMacierzy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maksimum)).BeginInit();
            this.tryb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zaokraglanie)).BeginInit();
            this.SuspendLayout();
            // 
            // macierzA
            // 
            this.macierzA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.macierzA.Location = new System.Drawing.Point(12, 171);
            this.macierzA.Name = "macierzA";
            this.macierzA.RowHeadersWidth = 51;
            this.macierzA.RowTemplate.Height = 29;
            this.macierzA.Size = new System.Drawing.Size(481, 300);
            this.macierzA.TabIndex = 0;
            // 
            // macierzX
            // 
            this.macierzX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.macierzX.Location = new System.Drawing.Point(579, 171);
            this.macierzX.Name = "macierzX";
            this.macierzX.RowHeadersWidth = 51;
            this.macierzX.RowTemplate.Height = 29;
            this.macierzX.Size = new System.Drawing.Size(180, 300);
            this.macierzX.TabIndex = 1;
            // 
            // macierzB
            // 
            this.macierzB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.macierzB.Location = new System.Drawing.Point(848, 171);
            this.macierzB.Name = "macierzB";
            this.macierzB.RowHeadersWidth = 51;
            this.macierzB.RowTemplate.Height = 29;
            this.macierzB.Size = new System.Drawing.Size(180, 300);
            this.macierzB.TabIndex = 2;
            // 
            // wymiaryMacierzy
            // 
            this.wymiaryMacierzy.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wymiaryMacierzy.Location = new System.Drawing.Point(127, 40);
            this.wymiaryMacierzy.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.wymiaryMacierzy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wymiaryMacierzy.Name = "wymiaryMacierzy";
            this.wymiaryMacierzy.Size = new System.Drawing.Size(150, 38);
            this.wymiaryMacierzy.TabIndex = 3;
            this.wymiaryMacierzy.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.wymiaryMacierzy.ValueChanged += new System.EventHandler(this.wymiaryMacierzy_ValueChanged);
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelN.Location = new System.Drawing.Point(54, 40);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(67, 38);
            this.labelN.TabIndex = 4;
            this.labelN.Text = "N =";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelX.Location = new System.Drawing.Point(499, 282);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(74, 81);
            this.labelX.TabIndex = 5;
            this.labelX.Text = "X";
            // 
            // labelRownosc
            // 
            this.labelRownosc.AutoSize = true;
            this.labelRownosc.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRownosc.Location = new System.Drawing.Point(765, 282);
            this.labelRownosc.Name = "labelRownosc";
            this.labelRownosc.Size = new System.Drawing.Size(77, 81);
            this.labelRownosc.TabIndex = 6;
            this.labelRownosc.Text = "=";
            // 
            // generacjaLiczb
            // 
            this.generacjaLiczb.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.generacjaLiczb.Location = new System.Drawing.Point(524, 85);
            this.generacjaLiczb.Name = "generacjaLiczb";
            this.generacjaLiczb.Size = new System.Drawing.Size(284, 67);
            this.generacjaLiczb.TabIndex = 7;
            this.generacjaLiczb.Text = "Generacja Liczb";
            this.generacjaLiczb.UseVisualStyleBackColor = true;
            this.generacjaLiczb.Click += new System.EventHandler(this.generacjaLiczb_Click);
            // 
            // labelLiczby
            // 
            this.labelLiczby.AutoSize = true;
            this.labelLiczby.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelLiczby.Location = new System.Drawing.Point(621, 7);
            this.labelLiczby.Name = "labelLiczby";
            this.labelLiczby.Size = new System.Drawing.Size(187, 31);
            this.labelLiczby.TabIndex = 8;
            this.labelLiczby.Text = "Liczby z zakresu";
            // 
            // labelZakresOd
            // 
            this.labelZakresOd.AutoSize = true;
            this.labelZakresOd.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelZakresOd.Location = new System.Drawing.Point(528, 43);
            this.labelZakresOd.Name = "labelZakresOd";
            this.labelZakresOd.Size = new System.Drawing.Size(45, 31);
            this.labelZakresOd.TabIndex = 9;
            this.labelZakresOd.Text = "Od";
            // 
            // labelZakresDo
            // 
            this.labelZakresDo.AutoSize = true;
            this.labelZakresDo.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelZakresDo.Location = new System.Drawing.Point(674, 43);
            this.labelZakresDo.Name = "labelZakresDo";
            this.labelZakresDo.Size = new System.Drawing.Size(44, 31);
            this.labelZakresDo.TabIndex = 10;
            this.labelZakresDo.Text = "Do";
            // 
            // minimum
            // 
            this.minimum.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimum.Location = new System.Drawing.Point(579, 41);
            this.minimum.Maximum = new decimal(new int[] {
            46340,
            0,
            0,
            0});
            this.minimum.Minimum = new decimal(new int[] {
            46340,
            0,
            0,
            -2147483648});
            this.minimum.Name = "minimum";
            this.minimum.Size = new System.Drawing.Size(84, 38);
            this.minimum.TabIndex = 11;
            this.minimum.Value = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.minimum.ValueChanged += new System.EventHandler(this.minimum_ValueChanged);
            // 
            // maksimum
            // 
            this.maksimum.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maksimum.Location = new System.Drawing.Point(724, 41);
            this.maksimum.Maximum = new decimal(new int[] {
            46340,
            0,
            0,
            0});
            this.maksimum.Minimum = new decimal(new int[] {
            46340,
            0,
            0,
            -2147483648});
            this.maksimum.Name = "maksimum";
            this.maksimum.Size = new System.Drawing.Size(84, 38);
            this.maksimum.TabIndex = 12;
            this.maksimum.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.maksimum.ValueChanged += new System.EventHandler(this.maksimum_ValueChanged);
            // 
            // gaussTest
            // 
            this.gaussTest.Enabled = false;
            this.gaussTest.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.gaussTest.Location = new System.Drawing.Point(369, 10);
            this.gaussTest.Name = "gaussTest";
            this.gaussTest.Size = new System.Drawing.Size(149, 67);
            this.gaussTest.TabIndex = 13;
            this.gaussTest.Text = "Gauss Test";
            this.gaussTest.UseVisualStyleBackColor = true;
            this.gaussTest.Click += new System.EventHandler(this.gaussTest_Click);
            // 
            // wynik
            // 
            this.wynik.Enabled = false;
            this.wynik.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.wynik.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.wynik.Location = new System.Drawing.Point(369, 85);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(149, 67);
            this.wynik.TabIndex = 14;
            this.wynik.Text = "Policz";
            this.wynik.UseVisualStyleBackColor = true;
            this.wynik.Click += new System.EventHandler(this.wynik_Click_1);
            // 
            // tryb
            // 
            this.tryb.Controls.Add(this.rzeczywiste);
            this.tryb.Controls.Add(this.zespolone);
            this.tryb.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tryb.Location = new System.Drawing.Point(826, 9);
            this.tryb.Name = "tryb";
            this.tryb.Size = new System.Drawing.Size(202, 143);
            this.tryb.TabIndex = 15;
            this.tryb.TabStop = false;
            this.tryb.Text = "Liczby";
            // 
            // rzeczywiste
            // 
            this.rzeczywiste.AutoSize = true;
            this.rzeczywiste.Location = new System.Drawing.Point(6, 88);
            this.rzeczywiste.Name = "rzeczywiste";
            this.rzeczywiste.Size = new System.Drawing.Size(198, 45);
            this.rzeczywiste.TabIndex = 1;
            this.rzeczywiste.Text = "Rzeczywiste";
            this.rzeczywiste.UseVisualStyleBackColor = true;
            this.rzeczywiste.CheckedChanged += new System.EventHandler(this.rzeczywiste_CheckedChanged);
            // 
            // zespolone
            // 
            this.zespolone.AutoSize = true;
            this.zespolone.Checked = true;
            this.zespolone.Location = new System.Drawing.Point(6, 47);
            this.zespolone.Name = "zespolone";
            this.zespolone.Size = new System.Drawing.Size(177, 45);
            this.zespolone.TabIndex = 0;
            this.zespolone.TabStop = true;
            this.zespolone.Text = "Zespolone";
            this.zespolone.UseVisualStyleBackColor = true;
            this.zespolone.CheckedChanged += new System.EventHandler(this.zespolone_CheckedChanged);
            // 
            // wymmac
            // 
            this.wymmac.AutoSize = true;
            this.wymmac.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.wymmac.Location = new System.Drawing.Point(12, 10);
            this.wymmac.Name = "wymmac";
            this.wymmac.Size = new System.Drawing.Size(188, 28);
            this.wymmac.TabIndex = 16;
            this.wymmac.Text = "Wymiary macierzy";
            // 
            // dokladnosc
            // 
            this.dokladnosc.AutoSize = true;
            this.dokladnosc.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.dokladnosc.Location = new System.Drawing.Point(18, 95);
            this.dokladnosc.Name = "dokladnosc";
            this.dokladnosc.Size = new System.Drawing.Size(264, 28);
            this.dokladnosc.TabIndex = 17;
            this.dokladnosc.Text = "Dokładność zaokrągleń do";
            // 
            // zaokraglanie
            // 
            this.zaokraglanie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zaokraglanie.Location = new System.Drawing.Point(60, 126);
            this.zaokraglanie.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.zaokraglanie.Name = "zaokraglanie";
            this.zaokraglanie.Size = new System.Drawing.Size(61, 27);
            this.zaokraglanie.TabIndex = 18;
            this.zaokraglanie.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.zaokraglanie.ValueChanged += new System.EventHandler(this.zaokraglanie_ValueChanged);
            // 
            // mrzec
            // 
            this.mrzec.AutoSize = true;
            this.mrzec.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.mrzec.Location = new System.Drawing.Point(127, 125);
            this.mrzec.Name = "mrzec";
            this.mrzec.Size = new System.Drawing.Size(195, 28);
            this.mrzec.TabIndex = 19;
            this.mrzec.Text = "miejsc po przecinku";
            // 
            // autorzy
            // 
            this.autorzy.AutoSize = true;
            this.autorzy.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.autorzy.Location = new System.Drawing.Point(948, 474);
            this.autorzy.Name = "autorzy";
            this.autorzy.Size = new System.Drawing.Size(82, 17);
            this.autorzy.TabIndex = 20;
            this.autorzy.Text = "Müller Marek";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 492);
            this.Controls.Add(this.autorzy);
            this.Controls.Add(this.mrzec);
            this.Controls.Add(this.zaokraglanie);
            this.Controls.Add(this.dokladnosc);
            this.Controls.Add(this.wymmac);
            this.Controls.Add(this.tryb);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.gaussTest);
            this.Controls.Add(this.maksimum);
            this.Controls.Add(this.minimum);
            this.Controls.Add(this.labelZakresDo);
            this.Controls.Add(this.labelZakresOd);
            this.Controls.Add(this.labelLiczby);
            this.Controls.Add(this.generacjaLiczb);
            this.Controls.Add(this.labelRownosc);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.wymiaryMacierzy);
            this.Controls.Add(this.macierzB);
            this.Controls.Add(this.macierzX);
            this.Controls.Add(this.macierzA);
            this.Name = "Form1";
            this.Text = "Rozwiązywania układów równań liniowych";
            ((System.ComponentModel.ISupportInitialize)(this.macierzA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macierzX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macierzB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wymiaryMacierzy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maksimum)).EndInit();
            this.tryb.ResumeLayout(false);
            this.tryb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zaokraglanie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView macierzA;
        private DataGridView macierzX;
        private DataGridView macierzB;
        private NumericUpDown wymiaryMacierzy;
        private Label labelN;
        private Label labelX;
        private Label labelRownosc;
        private Button generacjaLiczb;
        private Label labelLiczby;
        private Label labelZakresOd;
        private Label labelZakresDo;
        private NumericUpDown minimum;
        private NumericUpDown maksimum;
        private Button gaussTest;
        private Button wynik;
        private GroupBox tryb;
        private RadioButton rzeczywiste;
        private RadioButton zespolone;
        private Label wymmac;
        private Label dokladnosc;
        private NumericUpDown zaokraglanie;
        private Label mrzec;
        private Label autorzy;
    }
}