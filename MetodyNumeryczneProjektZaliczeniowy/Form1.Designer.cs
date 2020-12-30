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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // parametersTextBox
            // 
            this.parametersTextBox.Location = new System.Drawing.Point(206, 36);
            this.parametersTextBox.Name = "parametersTextBox";
            this.parametersTextBox.Size = new System.Drawing.Size(100, 22);
            this.parametersTextBox.TabIndex = 1;
            // 
            // labelPodajWielomian
            // 
            this.labelPodajWielomian.AutoSize = true;
            this.labelPodajWielomian.Location = new System.Drawing.Point(82, 36);
            this.labelPodajWielomian.Name = "labelPodajWielomian";
            this.labelPodajWielomian.Size = new System.Drawing.Size(97, 17);
            this.labelPodajWielomian.TabIndex = 2;
            this.labelPodajWielomian.Text = "Podaj funkcje:";
            // 
            // label1PodajPunktStartowy
            // 
            this.label1PodajPunktStartowy.AutoSize = true;
            this.label1PodajPunktStartowy.Location = new System.Drawing.Point(39, 85);
            this.label1PodajPunktStartowy.Name = "label1PodajPunktStartowy";
            this.label1PodajPunktStartowy.Size = new System.Drawing.Size(161, 17);
            this.label1PodajPunktStartowy.TabIndex = 3;
            this.label1PodajPunktStartowy.Text = "Podaj punkt startowy x0:";
            // 
            // pointXTextBox
            // 
            this.pointXTextBox.Location = new System.Drawing.Point(206, 85);
            this.pointXTextBox.Name = "pointXTextBox";
            this.pointXTextBox.Size = new System.Drawing.Size(100, 22);
            this.pointXTextBox.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "0.000001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Precyzja pierwiastka epsilon:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(385, 51);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Oblicz";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 507);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pointXTextBox);
            this.Controls.Add(this.label1PodajPunktStartowy);
            this.Controls.Add(this.labelPodajWielomian);
            this.Controls.Add(this.parametersTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox parametersTextBox;
        private System.Windows.Forms.Label labelPodajWielomian;
        private System.Windows.Forms.Label label1PodajPunktStartowy;
        private System.Windows.Forms.TextBox pointXTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculateButton;
    }
}

