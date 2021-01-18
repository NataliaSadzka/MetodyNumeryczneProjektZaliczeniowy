namespace MetodyNumeryczneProjektZaliczeniowy
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
            this.parametersTextBox = new System.Windows.Forms.TextBox();
            this.labelPodajWielomian = new System.Windows.Forms.Label();
            this.label1PodajPunktStartowy = new System.Windows.Forms.Label();
            this.pointXTextBox = new System.Windows.Forms.TextBox();
            this.epsilonTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deltaTextBox = new System.Windows.Forms.TextBox();
            this.iterationsTextBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.logRichTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.zeroPlaceTextBox = new System.Windows.Forms.TextBox();
            this.IsCorrectButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // parametersTextBox
            // 
            this.parametersTextBox.Location = new System.Drawing.Point(289, 52);
            this.parametersTextBox.Name = "parametersTextBox";
            this.parametersTextBox.Size = new System.Drawing.Size(115, 22);
            this.parametersTextBox.TabIndex = 1;
            // 
            // labelPodajWielomian
            // 
            this.labelPodajWielomian.AutoSize = true;
            this.labelPodajWielomian.Location = new System.Drawing.Point(165, 52);
            this.labelPodajWielomian.Name = "labelPodajWielomian";
            this.labelPodajWielomian.Size = new System.Drawing.Size(97, 17);
            this.labelPodajWielomian.TabIndex = 2;
            this.labelPodajWielomian.Text = "Podaj funkcje:";
            // 
            // label1PodajPunktStartowy
            // 
            this.label1PodajPunktStartowy.AutoSize = true;
            this.label1PodajPunktStartowy.Location = new System.Drawing.Point(101, 98);
            this.label1PodajPunktStartowy.Name = "label1PodajPunktStartowy";
            this.label1PodajPunktStartowy.Size = new System.Drawing.Size(161, 17);
            this.label1PodajPunktStartowy.TabIndex = 3;
            this.label1PodajPunktStartowy.Text = "Podaj punkt startowy x0:";
            // 
            // pointXTextBox
            // 
            this.pointXTextBox.Location = new System.Drawing.Point(289, 98);
            this.pointXTextBox.Name = "pointXTextBox";
            this.pointXTextBox.Size = new System.Drawing.Size(115, 22);
            this.pointXTextBox.TabIndex = 4;
            // 
            // epsilonTextBox
            // 
            this.epsilonTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.epsilonTextBox.Location = new System.Drawing.Point(289, 143);
            this.epsilonTextBox.Name = "epsilonTextBox";
            this.epsilonTextBox.Size = new System.Drawing.Size(115, 22);
            this.epsilonTextBox.TabIndex = 5;
            this.epsilonTextBox.Text = "0,000001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dokładność porównania z zerem:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(151, 318);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 35);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Oblicz";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dokładność wyznaczania pierwiastka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Maksymalna liczba iteracji:";
            // 
            // deltaTextBox
            // 
            this.deltaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.deltaTextBox.Location = new System.Drawing.Point(289, 185);
            this.deltaTextBox.Name = "deltaTextBox";
            this.deltaTextBox.Size = new System.Drawing.Size(115, 22);
            this.deltaTextBox.TabIndex = 10;
            this.deltaTextBox.Text = "0,000001";
            // 
            // iterationsTextBox
            // 
            this.iterationsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.iterationsTextBox.Location = new System.Drawing.Point(289, 228);
            this.iterationsTextBox.Name = "iterationsTextBox";
            this.iterationsTextBox.Size = new System.Drawing.Size(115, 22);
            this.iterationsTextBox.TabIndex = 11;
            this.iterationsTextBox.Text = "100";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(354, 318);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 35);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "Resetuj";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // logRichTextBox
            // 
            this.logRichTextBox.Location = new System.Drawing.Point(467, 40);
            this.logRichTextBox.Name = "logRichTextBox";
            this.logRichTextBox.Size = new System.Drawing.Size(428, 337);
            this.logRichTextBox.TabIndex = 13;
            this.logRichTextBox.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(917, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Miejsce zerowe:";
            // 
            // zeroPlaceTextBox
            // 
            this.zeroPlaceTextBox.Location = new System.Drawing.Point(289, 273);
            this.zeroPlaceTextBox.Name = "zeroPlaceTextBox";
            this.zeroPlaceTextBox.ReadOnly = true;
            this.zeroPlaceTextBox.Size = new System.Drawing.Size(115, 22);
            this.zeroPlaceTextBox.TabIndex = 17;
            // 
            // IsCorrectButton
            // 
            this.IsCorrectButton.Location = new System.Drawing.Point(249, 318);
            this.IsCorrectButton.Name = "IsCorrectButton";
            this.IsCorrectButton.Size = new System.Drawing.Size(83, 35);
            this.IsCorrectButton.TabIndex = 18;
            this.IsCorrectButton.Text = "Sprawdź";
            this.IsCorrectButton.UseVisualStyleBackColor = true;
            this.IsCorrectButton.Click += new System.EventHandler(this.IsCorrectButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(917, 536);
            this.Controls.Add(this.IsCorrectButton);
            this.Controls.Add(this.zeroPlaceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.logRichTextBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.iterationsTextBox);
            this.Controls.Add(this.deltaTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.epsilonTextBox);
            this.Controls.Add(this.pointXTextBox);
            this.Controls.Add(this.label1PodajPunktStartowy);
            this.Controls.Add(this.labelPodajWielomian);
            this.Controls.Add(this.parametersTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox parametersTextBox;
        private System.Windows.Forms.Label labelPodajWielomian;
        private System.Windows.Forms.Label label1PodajPunktStartowy;
        private System.Windows.Forms.TextBox pointXTextBox;
        private System.Windows.Forms.TextBox epsilonTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox deltaTextBox;
        private System.Windows.Forms.TextBox iterationsTextBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.RichTextBox logRichTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox zeroPlaceTextBox;
        private System.Windows.Forms.Button IsCorrectButton;
    }
}

