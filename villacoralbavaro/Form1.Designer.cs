namespace villacoralbavaro
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
            GP = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            GP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // GP
            // 
            GP.Controls.Add(checkBox1);
            GP.Controls.Add(textBox2);
            GP.Controls.Add(textBox1);
            GP.Controls.Add(numericUpDown1);
            GP.Controls.Add(label3);
            GP.Controls.Add(label2);
            GP.Controls.Add(label1);
            GP.Location = new Point(12, 29);
            GP.Name = "GP";
            GP.Size = new Size(458, 251);
            GP.TabIndex = 6;
            GP.TabStop = false;
            GP.Text = "Cotizador";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 45);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Huesped";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 112);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Noches";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 176);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 2;
            label3.Text = "Tarifa por noche ";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(147, 110);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 27);
            textBox1.TabIndex = 4;
            textBox1.Text = "Ponga el nombre aqui";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(147, 173);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 303);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(458, 198);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Totales";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 38);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 0;
            label4.Text = "Subtotal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 107);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 1;
            label5.Text = "ITBIS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 175);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 2;
            label6.Text = "TOTAL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 142);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 3;
            label7.Text = "Servicio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 75);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 4;
            label8.Text = "Descuento";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = Color.Red;
            button1.Location = new Point(358, 75);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.ForeColor = Color.FromArgb(0, 0, 192);
            button2.Location = new Point(358, 120);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(171, 221);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(190, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Temporada Alta (+25%)";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 553);
            Controls.Add(groupBox1);
            Controls.Add(GP);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cotizador Villa Coral - Fabio De Rosa 2026-0502";
            Load += Form1_Load;
            GP.ResumeLayout(false);
            GP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GP;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button2;
        private Button button1;
        private CheckBox checkBox1;
    }
}
