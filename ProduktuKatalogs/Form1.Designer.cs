namespace ProduktuKatalogs
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
            pievienotGramatu = new Button();
            pievienotElektroniku = new Button();
            katalogs = new ListBox();
            katalogaVertiba = new Label();
            gramatasNosaukums = new TextBox();
            gramatasAutors = new TextBox();
            gramatasCena = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            elektronikasNosaukums = new TextBox();
            elektronikasGarantija = new TextBox();
            elektronikasCena = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // pievienotGramatu
            // 
            pievienotGramatu.Location = new Point(487, 37);
            pievienotGramatu.Name = "pievienotGramatu";
            pievienotGramatu.Size = new Size(137, 23);
            pievienotGramatu.TabIndex = 0;
            pievienotGramatu.Text = "Pievienot Grāmatu";
            pievienotGramatu.UseVisualStyleBackColor = true;
            pievienotGramatu.Click += pievienotGramatu_Click;
            // 
            // pievienotElektroniku
            // 
            pievienotElektroniku.Location = new Point(487, 91);
            pievienotElektroniku.Name = "pievienotElektroniku";
            pievienotElektroniku.Size = new Size(137, 23);
            pievienotElektroniku.TabIndex = 1;
            pievienotElektroniku.Text = "Pievienot Elektroniku";
            pievienotElektroniku.UseVisualStyleBackColor = true;
            pievienotElektroniku.Click += pievienotElektroniku_Click;
            // 
            // katalogs
            // 
            katalogs.FormattingEnabled = true;
            katalogs.ItemHeight = 15;
            katalogs.Location = new Point(175, 129);
            katalogs.Name = "katalogs";
            katalogs.Size = new Size(536, 244);
            katalogs.TabIndex = 2;
            // 
            // katalogaVertiba
            // 
            katalogaVertiba.AutoSize = true;
            katalogaVertiba.Location = new Point(566, 385);
            katalogaVertiba.Name = "katalogaVertiba";
            katalogaVertiba.Size = new Size(145, 15);
            katalogaVertiba.TabIndex = 3;
            katalogaVertiba.Text = "Kopējā kataloga vērtība 0€";
            // 
            // gramatasNosaukums
            // 
            gramatasNosaukums.Location = new Point(89, 38);
            gramatasNosaukums.Name = "gramatasNosaukums";
            gramatasNosaukums.Size = new Size(147, 23);
            gramatasNosaukums.TabIndex = 4;
            // 
            // gramatasAutors
            // 
            gramatasAutors.Location = new Point(242, 38);
            gramatasAutors.Name = "gramatasAutors";
            gramatasAutors.Size = new Size(133, 23);
            gramatasAutors.TabIndex = 5;
            // 
            // gramatasCena
            // 
            gramatasCena.Location = new Point(381, 38);
            gramatasCena.Name = "gramatasCena";
            gramatasCena.Size = new Size(100, 23);
            gramatasCena.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 17);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 7;
            label1.Text = "Gramatas nosaukums";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 17);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 8;
            label2.Text = "Grāmatas autors";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(381, 17);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 9;
            label3.Text = "Cena (€)";
            // 
            // elektronikasNosaukums
            // 
            elektronikasNosaukums.Location = new Point(89, 92);
            elektronikasNosaukums.Name = "elektronikasNosaukums";
            elektronikasNosaukums.Size = new Size(147, 23);
            elektronikasNosaukums.TabIndex = 10;
            elektronikasNosaukums.TextChanged += textBox4_TextChanged;
            // 
            // elektronikasGarantija
            // 
            elektronikasGarantija.Location = new Point(242, 92);
            elektronikasGarantija.Name = "elektronikasGarantija";
            elektronikasGarantija.Size = new Size(133, 23);
            elektronikasGarantija.TabIndex = 11;
            // 
            // elektronikasCena
            // 
            elektronikasCena.Location = new Point(381, 92);
            elektronikasCena.Name = "elektronikasCena";
            elektronikasCena.Size = new Size(100, 23);
            elektronikasCena.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 75);
            label4.Name = "label4";
            label4.Size = new Size(134, 15);
            label4.TabIndex = 13;
            label4.Text = "Elektronikas nosaukums";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(242, 74);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 14;
            label5.Text = "Garantija (mēnešos)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(381, 74);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 15;
            label6.Text = "Cena (€)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(elektronikasCena);
            Controls.Add(elektronikasGarantija);
            Controls.Add(elektronikasNosaukums);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gramatasCena);
            Controls.Add(gramatasAutors);
            Controls.Add(gramatasNosaukums);
            Controls.Add(katalogaVertiba);
            Controls.Add(katalogs);
            Controls.Add(pievienotElektroniku);
            Controls.Add(pievienotGramatu);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button pievienotGramatu;
        private Button pievienotElektroniku;
        private ListBox katalogs;
        private Label katalogaVertiba;
        private TextBox gramatasNosaukums;
        private TextBox gramatasAutors;
        private TextBox gramatasCena;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox elektronikasNosaukums;
        private TextBox elektronikasGarantija;
        private TextBox elektronikasCena;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
