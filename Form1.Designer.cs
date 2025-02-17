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
            this.PBImage = new System.Windows.Forms.PictureBox();
            this.LBResposta = new System.Windows.Forms.GroupBox();
            this.LBTextoAlternativas = new System.Windows.Forms.Label();
            this.LBPontos = new System.Windows.Forms.Label();
            this.RTBoxRespostas = new System.Windows.Forms.RichTextBox();
            this.RTBoxPergunta = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBQuestao = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PBE = new System.Windows.Forms.PictureBox();
            this.PBD = new System.Windows.Forms.PictureBox();
            this.PBC = new System.Windows.Forms.PictureBox();
            this.PBB = new System.Windows.Forms.PictureBox();
            this.PBA = new System.Windows.Forms.PictureBox();
            this.RBE = new System.Windows.Forms.RadioButton();
            this.RBD = new System.Windows.Forms.RadioButton();
            this.RBC = new System.Windows.Forms.RadioButton();
            this.RBB = new System.Windows.Forms.RadioButton();
            this.RBA = new System.Windows.Forms.RadioButton();
            this.LBResultado = new System.Windows.Forms.Label();
            this.BTConferir = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BTVoltar = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timerFocus = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).BeginInit();
            this.LBResposta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBA)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
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
            // LBResposta
            // 
            this.LBResposta.Controls.Add(this.LBTextoAlternativas);
            this.LBResposta.Controls.Add(this.LBPontos);
            this.LBResposta.Controls.Add(this.RTBoxRespostas);
            this.LBResposta.Location = new System.Drawing.Point(424, -4);
            this.LBResposta.Name = "LBResposta";
            this.LBResposta.Size = new System.Drawing.Size(415, 416);
            this.LBResposta.TabIndex = 2;
            this.LBResposta.TabStop = false;
            // 
            // LBTextoAlternativas
            // 
            this.LBTextoAlternativas.AutoSize = true;
            this.LBTextoAlternativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTextoAlternativas.ForeColor = System.Drawing.Color.Cyan;
            this.LBTextoAlternativas.Location = new System.Drawing.Point(6, 12);
            this.LBTextoAlternativas.Name = "LBTextoAlternativas";
            this.LBTextoAlternativas.Size = new System.Drawing.Size(114, 20);
            this.LBTextoAlternativas.TabIndex = 2;
            this.LBTextoAlternativas.Text = "Alternativas: ";
            this.LBTextoAlternativas.Click += new System.EventHandler(this.label2_Click);
            // 
            // LBPontos
            // 
            this.LBPontos.AutoSize = true;
            this.LBPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPontos.ForeColor = System.Drawing.Color.Cyan;
            this.LBPontos.Location = new System.Drawing.Point(286, 12);
            this.LBPontos.Name = "LBPontos";
            this.LBPontos.Size = new System.Drawing.Size(97, 24);
            this.LBPontos.TabIndex = 0;
            this.LBPontos.Text = "Pontos: 0";
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
            this.groupBox1.Controls.Add(this.LBQuestao);
            this.groupBox1.Controls.Add(this.RTBoxPergunta);
            this.groupBox1.Location = new System.Drawing.Point(3, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 314);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // LBQuestao
            // 
            this.LBQuestao.AutoSize = true;
            this.LBQuestao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBQuestao.ForeColor = System.Drawing.Color.Cyan;
            this.LBQuestao.Location = new System.Drawing.Point(6, 12);
            this.LBQuestao.Name = "LBQuestao";
            this.LBQuestao.Size = new System.Drawing.Size(158, 20);
            this.LBQuestao.TabIndex = 3;
            this.LBQuestao.Text = "Pergunta - 1 de 10";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PBE);
            this.groupBox4.Controls.Add(this.PBD);
            this.groupBox4.Controls.Add(this.PBC);
            this.groupBox4.Controls.Add(this.PBB);
            this.groupBox4.Controls.Add(this.RBE);
            this.groupBox4.Controls.Add(this.PBA);
            this.groupBox4.Controls.Add(this.RBD);
            this.groupBox4.Controls.Add(this.RBC);
            this.groupBox4.Controls.Add(this.RBB);
            this.groupBox4.Controls.Add(this.RBA);
            this.groupBox4.Controls.Add(this.LBResultado);
            this.groupBox4.Location = new System.Drawing.Point(424, 410);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(415, 97);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // PBE
            // 
            this.PBE.Image = ((System.Drawing.Image)(resources.GetObject("PBE.Image")));
            this.PBE.Location = new System.Drawing.Point(357, 43);
            this.PBE.Name = "PBE";
            this.PBE.Size = new System.Drawing.Size(26, 25);
            this.PBE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBE.TabIndex = 15;
            this.PBE.TabStop = false;
            // 
            // PBD
            // 
            this.PBD.Image = ((System.Drawing.Image)(resources.GetObject("PBD.Image")));
            this.PBD.Location = new System.Drawing.Point(272, 43);
            this.PBD.Name = "PBD";
            this.PBD.Size = new System.Drawing.Size(26, 25);
            this.PBD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBD.TabIndex = 14;
            this.PBD.TabStop = false;
            // 
            // PBC
            // 
            this.PBC.Image = ((System.Drawing.Image)(resources.GetObject("PBC.Image")));
            this.PBC.Location = new System.Drawing.Point(185, 43);
            this.PBC.Name = "PBC";
            this.PBC.Size = new System.Drawing.Size(26, 25);
            this.PBC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBC.TabIndex = 13;
            this.PBC.TabStop = false;
            // 
            // PBB
            // 
            this.PBB.Image = ((System.Drawing.Image)(resources.GetObject("PBB.Image")));
            this.PBB.Location = new System.Drawing.Point(99, 43);
            this.PBB.Name = "PBB";
            this.PBB.Size = new System.Drawing.Size(26, 25);
            this.PBB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBB.TabIndex = 12;
            this.PBB.TabStop = false;
            // 
            // PBA
            // 
            this.PBA.Image = global::QuizEA.Properties.Resources.Planta;
            this.PBA.Location = new System.Drawing.Point(18, 43);
            this.PBA.Name = "PBA";
            this.PBA.Size = new System.Drawing.Size(26, 25);
            this.PBA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBA.TabIndex = 11;
            this.PBA.TabStop = false;
            // 
            // RBE
            // 
            this.RBE.AutoSize = true;
            this.RBE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBE.ForeColor = System.Drawing.Color.Cyan;
            this.RBE.Location = new System.Drawing.Point(366, 46);
            this.RBE.Name = "RBE";
            this.RBE.Size = new System.Drawing.Size(39, 24);
            this.RBE.TabIndex = 10;
            this.RBE.TabStop = true;
            this.RBE.Text = "E";
            this.RBE.UseVisualStyleBackColor = true;
            this.RBE.CheckedChanged += new System.EventHandler(this.RBE_CheckedChanged);
            // 
            // RBD
            // 
            this.RBD.AutoSize = true;
            this.RBD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBD.ForeColor = System.Drawing.Color.Cyan;
            this.RBD.Location = new System.Drawing.Point(285, 46);
            this.RBD.Name = "RBD";
            this.RBD.Size = new System.Drawing.Size(40, 24);
            this.RBD.TabIndex = 9;
            this.RBD.TabStop = true;
            this.RBD.Text = "D";
            this.RBD.UseVisualStyleBackColor = true;
            this.RBD.CheckedChanged += new System.EventHandler(this.RBD_CheckedChanged);
            // 
            // RBC
            // 
            this.RBC.AutoSize = true;
            this.RBC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBC.ForeColor = System.Drawing.Color.Cyan;
            this.RBC.Location = new System.Drawing.Point(198, 46);
            this.RBC.Name = "RBC";
            this.RBC.Size = new System.Drawing.Size(39, 24);
            this.RBC.TabIndex = 8;
            this.RBC.TabStop = true;
            this.RBC.Text = "C";
            this.RBC.UseVisualStyleBackColor = true;
            this.RBC.CheckedChanged += new System.EventHandler(this.RBC_CheckedChanged);
            // 
            // RBB
            // 
            this.RBB.AutoSize = true;
            this.RBB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBB.ForeColor = System.Drawing.Color.Cyan;
            this.RBB.Location = new System.Drawing.Point(112, 46);
            this.RBB.Name = "RBB";
            this.RBB.Size = new System.Drawing.Size(39, 24);
            this.RBB.TabIndex = 7;
            this.RBB.TabStop = true;
            this.RBB.Text = "B";
            this.RBB.UseVisualStyleBackColor = true;
            this.RBB.CheckedChanged += new System.EventHandler(this.RBB_CheckedChanged);
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
            this.RBA.CheckedChanged += new System.EventHandler(this.RBA_CheckedChanged);
            // 
            // LBResultado
            // 
            this.LBResultado.AutoSize = true;
            this.LBResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBResultado.ForeColor = System.Drawing.Color.Cyan;
            this.LBResultado.Location = new System.Drawing.Point(6, 11);
            this.LBResultado.Name = "LBResultado";
            this.LBResultado.Size = new System.Drawing.Size(96, 20);
            this.LBResultado.TabIndex = 5;
            this.LBResultado.Text = "Resposta :";
            // 
            // BTConferir
            // 
            this.BTConferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTConferir.Location = new System.Drawing.Point(161, 32);
            this.BTConferir.Name = "BTConferir";
            this.BTConferir.Size = new System.Drawing.Size(101, 23);
            this.BTConferir.TabIndex = 5;
            this.BTConferir.Text = "Conferir";
            this.BTConferir.UseVisualStyleBackColor = true;
            this.BTConferir.Click += new System.EventHandler(this.button1_Click);
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
            // BTVoltar
            // 
            this.BTVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTVoltar.Location = new System.Drawing.Point(24, 32);
            this.BTVoltar.Name = "BTVoltar";
            this.BTVoltar.Size = new System.Drawing.Size(101, 23);
            this.BTVoltar.TabIndex = 6;
            this.BTVoltar.Text = "Voltar";
            this.BTVoltar.UseVisualStyleBackColor = true;
            this.BTVoltar.Click += new System.EventHandler(this.BTVoltar_Click);
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(45, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Mudar questão";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // timerFocus
            // 
            this.timerFocus.Tick += new System.EventHandler(this.timerFocus_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(841, 582);
            this.Controls.Add(this.LBResposta);
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
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).EndInit();
            this.LBResposta.ResumeLayout(false);
            this.LBResposta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBA)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox LBResposta;
        private System.Windows.Forms.PictureBox PBImage;
        private System.Windows.Forms.Label LBPontos;
        private System.Windows.Forms.RichTextBox RTBoxRespostas;
        private System.Windows.Forms.Label LBTextoAlternativas;
        private System.Windows.Forms.RichTextBox RTBoxPergunta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label LBResultado;
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
        private System.Windows.Forms.Label LBQuestao;
        private System.Windows.Forms.PictureBox PBE;
        private System.Windows.Forms.PictureBox PBD;
        private System.Windows.Forms.PictureBox PBC;
        private System.Windows.Forms.PictureBox PBB;
        private System.Windows.Forms.PictureBox PBA;
        private System.Windows.Forms.Button button1;
    }
}

