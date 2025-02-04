namespace QuizEA
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RTBoxRespostas = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RTBoxPergunta = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BTConferir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BTVoltar = new System.Windows.Forms.Button();
            this.RBA = new System.Windows.Forms.RadioButton();
            this.RBB = new System.Windows.Forms.RadioButton();
            this.RBC = new System.Windows.Forms.RadioButton();
            this.RBD = new System.Windows.Forms.RadioButton();
            this.RBE = new System.Windows.Forms.RadioButton();
            this.timerFocus = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.PBImage = new System.Windows.Forms.PictureBox();
            this.PBE = new System.Windows.Forms.PictureBox();
            this.PBD = new System.Windows.Forms.PictureBox();
            this.PBC = new System.Windows.Forms.PictureBox();
            this.PBB = new System.Windows.Forms.PictureBox();
            this.PBA = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PBImage);
            this.groupBox2.Location = new System.Drawing.Point(3, -4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.RTBoxRespostas);
            this.groupBox3.Location = new System.Drawing.Point(424, -4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(415, 416);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // RTBoxRespostas
            // 
            this.RTBoxRespostas.BackColor = System.Drawing.Color.Black;
            this.RTBoxRespostas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTBoxRespostas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBoxRespostas.ForeColor = System.Drawing.Color.Cyan;
            this.RTBoxRespostas.Location = new System.Drawing.Point(7, 69);
            this.RTBoxRespostas.Name = "RTBoxRespostas";
            this.RTBoxRespostas.Size = new System.Drawing.Size(398, 341);
            this.RTBoxRespostas.TabIndex = 1;
            this.RTBoxRespostas.Text = "Qual das seguintes opções NÃO é uma consequência direta das mudanças climáticas?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(286, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pontos: 40";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alternativas: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RTBoxPergunta
            // 
            this.RTBoxPergunta.BackColor = System.Drawing.Color.Black;
            this.RTBoxPergunta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTBoxPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBoxPergunta.ForeColor = System.Drawing.Color.Cyan;
            this.RTBoxPergunta.Location = new System.Drawing.Point(6, 44);
            this.RTBoxPergunta.Name = "RTBoxPergunta";
            this.RTBoxPergunta.Size = new System.Drawing.Size(403, 262);
            this.RTBoxPergunta.TabIndex = 0;
            this.RTBoxPergunta.Text = "Qual das seguintes opções NÃO é uma consequência direta das mudanças climáticas?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.RTBoxPergunta);
            this.groupBox1.Location = new System.Drawing.Point(3, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 314);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PBE);
            this.groupBox4.Controls.Add(this.PBD);
            this.groupBox4.Controls.Add(this.PBC);
            this.groupBox4.Controls.Add(this.PBB);
            this.groupBox4.Controls.Add(this.PBA);
            this.groupBox4.Controls.Add(this.RBE);
            this.groupBox4.Controls.Add(this.RBD);
            this.groupBox4.Controls.Add(this.RBC);
            this.groupBox4.Controls.Add(this.RBB);
            this.groupBox4.Controls.Add(this.RBA);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(424, 410);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(415, 97);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // BTConferir
            // 
            this.BTConferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTConferir.Location = new System.Drawing.Point(234, 32);
            this.BTConferir.Name = "BTConferir";
            this.BTConferir.Size = new System.Drawing.Size(101, 23);
            this.BTConferir.TabIndex = 5;
            this.BTConferir.Text = "Conferir";
            this.BTConferir.UseVisualStyleBackColor = true;
            this.BTConferir.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(6, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resposta :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BTVoltar);
            this.groupBox5.Location = new System.Drawing.Point(3, 505);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(415, 75);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.BTConferir);
            this.groupBox6.Location = new System.Drawing.Point(424, 505);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(415, 75);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            // 
            // BTVoltar
            // 
            this.BTVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTVoltar.Location = new System.Drawing.Point(24, 32);
            this.BTVoltar.Name = "BTVoltar";
            this.BTVoltar.Size = new System.Drawing.Size(101, 23);
            this.BTVoltar.TabIndex = 6;
            this.BTVoltar.Text = "Voltar";
            this.BTVoltar.UseVisualStyleBackColor = true;
            // 
            // RBA
            // 
            this.RBA.AutoSize = true;
            this.RBA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBA.ForeColor = System.Drawing.Color.Cyan;
            this.RBA.Location = new System.Drawing.Point(29, 46);
            this.RBA.Name = "RBA";
            this.RBA.Size = new System.Drawing.Size(39, 24);
            this.RBA.TabIndex = 6;
            this.RBA.TabStop = true;
            this.RBA.Text = "A";
            this.RBA.UseVisualStyleBackColor = true;
            // 
            // RBB
            // 
            this.RBB.AutoSize = true;
            this.RBB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBB.ForeColor = System.Drawing.Color.Cyan;
            this.RBB.Location = new System.Drawing.Point(107, 46);
            this.RBB.Name = "RBB";
            this.RBB.Size = new System.Drawing.Size(39, 24);
            this.RBB.TabIndex = 7;
            this.RBB.TabStop = true;
            this.RBB.Text = "B";
            this.RBB.UseVisualStyleBackColor = true;
            // 
            // RBC
            // 
            this.RBC.AutoSize = true;
            this.RBC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBC.ForeColor = System.Drawing.Color.Cyan;
            this.RBC.Location = new System.Drawing.Point(189, 46);
            this.RBC.Name = "RBC";
            this.RBC.Size = new System.Drawing.Size(39, 24);
            this.RBC.TabIndex = 8;
            this.RBC.TabStop = true;
            this.RBC.Text = "C";
            this.RBC.UseVisualStyleBackColor = true;
            // 
            // RBD
            // 
            this.RBD.AutoSize = true;
            this.RBD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBD.ForeColor = System.Drawing.Color.Cyan;
            this.RBD.Location = new System.Drawing.Point(276, 46);
            this.RBD.Name = "RBD";
            this.RBD.Size = new System.Drawing.Size(40, 24);
            this.RBD.TabIndex = 9;
            this.RBD.TabStop = true;
            this.RBD.Text = "D";
            this.RBD.UseVisualStyleBackColor = true;
            // 
            // RBE
            // 
            this.RBE.AutoSize = true;
            this.RBE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBE.ForeColor = System.Drawing.Color.Cyan;
            this.RBE.Location = new System.Drawing.Point(355, 46);
            this.RBE.Name = "RBE";
            this.RBE.Size = new System.Drawing.Size(39, 24);
            this.RBE.TabIndex = 10;
            this.RBE.TabStop = true;
            this.RBE.Text = "E";
            this.RBE.UseVisualStyleBackColor = true;
            // 
            // timerFocus
            // 
            this.timerFocus.Tick += new System.EventHandler(this.timerFocus_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(6, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pergunta - nivel 1: ";
            // 
            // PBImage
            // 
            this.PBImage.Image = global::QuizEA.Properties.Resources.mudanças2;
            this.PBImage.Location = new System.Drawing.Point(6, 12);
            this.PBImage.Name = "PBImage";
            this.PBImage.Size = new System.Drawing.Size(403, 177);
            this.PBImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBImage.TabIndex = 0;
            this.PBImage.TabStop = false;
            // 
            // PBE
            // 
            this.PBE.Image = ((System.Drawing.Image)(resources.GetObject("PBE.Image")));
            this.PBE.Location = new System.Drawing.Point(346, 43);
            this.PBE.Name = "PBE";
            this.PBE.Size = new System.Drawing.Size(26, 25);
            this.PBE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBE.TabIndex = 15;
            this.PBE.TabStop = false;
            // 
            // PBD
            // 
            this.PBD.Image = ((System.Drawing.Image)(resources.GetObject("PBD.Image")));
            this.PBD.Location = new System.Drawing.Point(263, 43);
            this.PBD.Name = "PBD";
            this.PBD.Size = new System.Drawing.Size(26, 25);
            this.PBD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBD.TabIndex = 14;
            this.PBD.TabStop = false;
            // 
            // PBC
            // 
            this.PBC.Image = ((System.Drawing.Image)(resources.GetObject("PBC.Image")));
            this.PBC.Location = new System.Drawing.Point(176, 43);
            this.PBC.Name = "PBC";
            this.PBC.Size = new System.Drawing.Size(26, 25);
            this.PBC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBC.TabIndex = 13;
            this.PBC.TabStop = false;
            // 
            // PBB
            // 
            this.PBB.Image = ((System.Drawing.Image)(resources.GetObject("PBB.Image")));
            this.PBB.Location = new System.Drawing.Point(94, 43);
            this.PBB.Name = "PBB";
            this.PBB.Size = new System.Drawing.Size(26, 25);
            this.PBB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBB.TabIndex = 12;
            this.PBB.TabStop = false;
            // 
            // PBA
            // 
            this.PBA.Image = ((System.Drawing.Image)(resources.GetObject("PBA.Image")));
            this.PBA.Location = new System.Drawing.Point(18, 43);
            this.PBA.Name = "PBA";
            this.PBA.Size = new System.Drawing.Size(26, 25);
            this.PBA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBA.TabIndex = 11;
            this.PBA.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(107, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Mudar questão";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(841, 582);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Educação Ambiental - Mudanças Climáticas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox PBImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RTBoxRespostas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RTBoxPergunta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTConferir;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BTVoltar;
        private System.Windows.Forms.RadioButton RBA;
        private System.Windows.Forms.RadioButton RBE;
        private System.Windows.Forms.RadioButton RBD;
        private System.Windows.Forms.RadioButton RBC;
        private System.Windows.Forms.RadioButton RBB;
        private System.Windows.Forms.Timer timerFocus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PBE;
        private System.Windows.Forms.PictureBox PBD;
        private System.Windows.Forms.PictureBox PBC;
        private System.Windows.Forms.PictureBox PBB;
        private System.Windows.Forms.PictureBox PBA;
        private System.Windows.Forms.Button button1;
    }
}

