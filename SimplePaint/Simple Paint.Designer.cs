namespace SimplePaint
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
            EspessuraCaneta = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            Salvar = new Button();
            Limpar = new Button();
            Borracha = new Button();
            CorCaneta = new Button();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(EspessuraCaneta);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Salvar);
            groupBox1.Controls.Add(Limpar);
            groupBox1.Controls.Add(Borracha);
            groupBox1.Controls.Add(CorCaneta);
            groupBox1.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(859, 81);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configurações";
            // 
            // EspessuraCaneta
            // 
            EspessuraCaneta.FormattingEnabled = true;
            EspessuraCaneta.Location = new Point(429, 36);
            EspessuraCaneta.Name = "EspessuraCaneta";
            EspessuraCaneta.Size = new Size(107, 29);
            EspessuraCaneta.TabIndex = 6;
            EspessuraCaneta.SelectedIndexChanged += EspessuraCaneta_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 39);
            label2.Name = "label2";
            label2.Size = new Size(181, 21);
            label2.TabIndex = 5;
            label2.Text = "Espessura da Caneta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(127, 21);
            label1.TabIndex = 4;
            label1.Text = "Cor da Caneta";
            // 
            // Salvar
            // 
            Salvar.BackColor = SystemColors.ButtonFace;
            Salvar.FlatStyle = FlatStyle.Flat;
            Salvar.Location = new Point(756, 34);
            Salvar.Name = "Salvar";
            Salvar.Size = new Size(97, 30);
            Salvar.TabIndex = 3;
            Salvar.Text = "Salvar";
            Salvar.UseVisualStyleBackColor = false;
            // 
            // Limpar
            // 
            Limpar.BackColor = SystemColors.ButtonFace;
            Limpar.FlatStyle = FlatStyle.Flat;
            Limpar.Location = new Point(653, 34);
            Limpar.Name = "Limpar";
            Limpar.Size = new Size(97, 30);
            Limpar.TabIndex = 2;
            Limpar.Text = "Limpar";
            Limpar.UseVisualStyleBackColor = false;
            Limpar.Click += Limpar_Click;
            // 
            // Borracha
            // 
            Borracha.BackColor = SystemColors.ButtonFace;
            Borracha.FlatStyle = FlatStyle.Flat;
            Borracha.Location = new Point(550, 34);
            Borracha.Name = "Borracha";
            Borracha.Size = new Size(97, 30);
            Borracha.TabIndex = 1;
            Borracha.Text = "Borracha";
            Borracha.UseVisualStyleBackColor = false;
            Borracha.Click += Borracha_Click;
            // 
            // CorCaneta
            // 
            CorCaneta.BackColor = SystemColors.ActiveCaptionText;
            CorCaneta.FlatStyle = FlatStyle.Flat;
            CorCaneta.Location = new Point(139, 34);
            CorCaneta.Name = "CorCaneta";
            CorCaneta.Size = new Size(97, 30);
            CorCaneta.TabIndex = 0;
            CorCaneta.UseVisualStyleBackColor = false;
            CorCaneta.Click += CorCaneta_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Control;
            panel1.Location = new Point(11, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(859, 336);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(882, 450);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "Form1";
            ShowIcon = false;
            Text = "Simple Paint";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button Salvar;
        private Button Limpar;
        private Button Borracha;
        private Button CorCaneta;
        private ComboBox EspessuraCaneta;
        private Panel panel1;
    }
}
