using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace QuizEA
{
    public partial class Form1 : Form
    {
        public string filePath = Program.path; // Caminho do arquivo
        private Dictionary<string, (List<string>, int, string)> perguntas;
        private Random random = new Random(); // Objeto para sorteio aleatório
        private string caminhoImagens = "resources\\imagens\\"; // Pasta onde estão as imagens
        private int respostaCerta; // Variável global para armazenar a resposta correta
        private int qtdQuestoes = 1;
        private int respostaUser = 0;
        private int pontos = 0;
        private bool isConferir = true;
        private bool isEndgame  = false;
        public Form1()
        {
            InitializeComponent();
            timerFocus.Enabled = true;

            // Carrega as perguntas ao iniciar o formulário
            perguntas = CarregarPerguntas(filePath);

            SelecionarQuestaoAleatoria();
            SelecionarAlternativaAleatoria();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(isConferir)
            {
                qtdQuestoes++;
                ConferirResposta();
                BTConferir.Text = "Continuar";
                isConferir = false;
                if(isEndgame)
                {
                    isEndgame = false;
                    resetGame();
                }
            }
            else
            {
                SelecionarQuestaoAleatoria();
                SelecionarAlternativaAleatoria();
                LBResultado .Text = "Resposta :";
                BTConferir.Text = "Conferir";
                isConferir = true;
                if (qtdQuestoes == 11)
                {
                    LBQuestao.Text = "Pergunta - 10 de 10.";
                    qtdQuestoes = 0;
                    endGame();
                    BTConferir.Text = "Recomeçar";
                    isEndgame = true;
                }
                else
                {
                    LBQuestao.Text = "Pergunta - " + qtdQuestoes + " de 10.";
                }

            }
          
        }
        private void resetGame()
        {
            SelecionarQuestaoAleatoria();
            SelecionarAlternativaAleatoria();
            LBResultado.Text = "Resposta :";
            BTConferir.Text = "Conferir";
            LBTextoAlternativas.Text = "Alternativas: ";
            LBPontos.Text = "Pontos: 0";
            pontos = 0;
            LBQuestao.Text = "Pergunta - 1 de 10";
            isConferir = true;
        }
        private void endGame()
        {
            RTBoxRespostas.Text = "   Chegou ao fim, seus pontos foram: " + pontos;
            RTBoxPergunta.Text  = "";
            LBQuestao.Text      = "";
            LBTextoAlternativas.Text = "";
            LBPontos.Text = "";
        }
        private void ConferirResposta()
        {
            if(respostaCerta == respostaUser)
            {
                pontos += 10;
                LBPontos.Text = "Pontos: " + pontos;
                LBResultado.Text = "Acertou !!!";
            }
            else
            {
                LBResultado.Text = "Errou !!! Resposta certa: " + valorLetra(respostaCerta);
            }
        }
        private void SelecionarAlternativaAleatoria()
        {
            int escolha = random.Next(1, 6); // Gera um número entre 1 e 5

            switch (escolha)
            {
                case 1:
                    RBA.Checked = true;
                    break;
                case 2:
                    RBB.Checked = true;
                    break;
                case 3:
                    RBC.Checked = true;
                    break;
                case 4:
                    RBD.Checked = true;
                    break;
                case 5:
                    RBE.Checked = true;
                    break;
            }
        }

        private string valorLetra (int valor)
        {
            string letra = " ";

            if(valor == 1)
            {
                letra = "A";
            }
            if (valor == 2)
            {
                letra = "B";
            }
            if (valor == 3)
            {
                letra = "C";
            }
            if (valor == 4)
            {
                letra = "D";
            }
            if (valor == 5)
            {
                letra = "E";
            }
            return letra;
        }
        private void timerFocus_Tick(object sender, EventArgs e)
        {
            BTConferir.Focus();
            timerFocus.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private static Dictionary<string, (List<string>, int, string)> CarregarPerguntas(string filePath)
        {
            var perguntas = new Dictionary<string, (List<string>, int, string)>();

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Arquivo de perguntas não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return perguntas;
            }

            foreach (var linha in File.ReadAllLines(filePath))
            {
                var partes = linha.Split(':');
                if (partes.Length < 4) continue; // Verifica se há todos os campos necessários

                string questao = partes[0].Trim();
                List<string> respostas = new List<string>(partes[1].Split('|'));
                if (!int.TryParse(partes[2].Trim(), out int respostaCorreta))
                {
                    MessageBox.Show($"Erro ao processar a pergunta: {questao}", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }
                string imagem = partes[3].Trim();

                perguntas[questao] = (respostas, respostaCorreta, imagem);
            }

            return perguntas;
        }
        private void SelecionarQuestaoAleatoria()
        {
            if (perguntas.Count == 0)
            {
                MessageBox.Show("Nenhuma pergunta carregada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seleciona uma pergunta aleatória
            var questaoAleatoria = perguntas.ElementAt(random.Next(perguntas.Count));

            string pergunta = questaoAleatoria.Key;
            List<string> respostas = questaoAleatoria.Value.Item1;
            respostaCerta = questaoAleatoria.Value.Item2; // Guarda a resposta correta na variável global
            string nomeImagem = questaoAleatoria.Value.Item3; // Nome da imagem salva no dicionário

            // Exibe a pergunta no RichTextBox
            RTBoxPergunta.Text = pergunta;

            // Formata e exibe as respostas no RichTextBox, adicionando uma linha extra entre cada resposta
            RTBoxRespostas.Text = string.Join("\n\n", respostas.Select((res, index) => $"{(char)('A' + index)}) {res}"));


            RBA.ForeColor = Color.Cyan;
            RBB.ForeColor = Color.Cyan;
            RBC.ForeColor = Color.Cyan;
            RBD.ForeColor = Color.Cyan;
            RBE.ForeColor = Color.Cyan;

            PBA.Image = Properties.Resources.Planta;
            PBB.Image = Properties.Resources.Planta;
            PBC.Image = Properties.Resources.Planta;
            PBD.Image = Properties.Resources.Planta;
            PBE.Image = Properties.Resources.Planta;


            // Caminho completo da imagem
            string caminhoImagemCompleto = Path.Combine(caminhoImagens, nomeImagem + ".jpg");

            // Verifica se a imagem existe antes de tentar carregar
            if (File.Exists(caminhoImagemCompleto))
            {
                PBImage.Image = Image.FromFile(caminhoImagemCompleto);
            }
            else
            {
                PBImage.Image = null; // Remove a imagem se não encontrar
                MessageBox.Show($"Imagem não encontrada: {caminhoImagemCompleto}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SelecionarQuestaoAleatoria();
        }

        private void RBA_CheckedChanged(object sender, EventArgs e)
        {
            if(RBA.Checked)
            {
                    RBA.ForeColor = Color.Green;
                    RBB.ForeColor = Color.Cyan;
                    RBC.ForeColor = Color.Cyan;
                    RBD.ForeColor = Color.Cyan;
                    RBE.ForeColor = Color.Cyan;

                    PBA.Image = Properties.Resources.PlantaSelecionada;
                    PBB.Image = Properties.Resources.Planta;
                    PBC.Image = Properties.Resources.Planta;
                    PBD.Image = Properties.Resources.Planta;
                    PBE.Image = Properties.Resources.Planta;

                    respostaUser = 1;
            }
        }

        private void RBB_CheckedChanged(object sender, EventArgs e)
        {
            if (RBB.Checked)
            {
                RBA.ForeColor = Color.Cyan;
                RBB.ForeColor = Color.Green;
                RBC.ForeColor = Color.Cyan;
                RBD.ForeColor = Color.Cyan;
                RBE.ForeColor = Color.Cyan;

                PBA.Image = Properties.Resources.Planta;
                PBB.Image = Properties.Resources.PlantaSelecionada;
                PBC.Image = Properties.Resources.Planta;
                PBD.Image = Properties.Resources.Planta;
                PBE.Image = Properties.Resources.Planta;
                respostaUser = 2;
            }
        }

        private void RBC_CheckedChanged(object sender, EventArgs e)
        {
            if (RBC.Checked)
            {
                RBA.ForeColor = Color.Cyan;
                RBB.ForeColor = Color.Cyan;
                RBC.ForeColor = Color.Green;
                RBD.ForeColor = Color.Cyan;
                RBE.ForeColor = Color.Cyan;

                PBA.Image = Properties.Resources.Planta;
                PBB.Image = Properties.Resources.Planta;
                PBC.Image = Properties.Resources.PlantaSelecionada;
                PBD.Image = Properties.Resources.Planta;
                PBE.Image = Properties.Resources.Planta;
                respostaUser = 3;
            }
        }

        private void RBD_CheckedChanged(object sender, EventArgs e)
        {
            if (RBD.Checked)
            {
                RBA.ForeColor = Color.Cyan;
                RBB.ForeColor = Color.Cyan;
                RBC.ForeColor = Color.Cyan;
                RBD.ForeColor = Color.Green;
                RBE.ForeColor = Color.Cyan;

                PBA.Image = Properties.Resources.Planta;
                PBB.Image = Properties.Resources.Planta;
                PBC.Image = Properties.Resources.Planta;
                PBD.Image = Properties.Resources.PlantaSelecionada;
                PBE.Image = Properties.Resources.Planta;
                respostaUser = 4;
            }
        }

        private void RBE_CheckedChanged(object sender, EventArgs e)
        {
            if (RBE.Checked)
            {
                RBA.ForeColor = Color.Cyan;
                RBB.ForeColor = Color.Cyan;
                RBC.ForeColor = Color.Cyan;
                RBD.ForeColor = Color.Cyan;
                RBE.ForeColor = Color.Green;

                PBA.Image = Properties.Resources.Planta;
                PBB.Image = Properties.Resources.Planta;
                PBC.Image = Properties.Resources.Planta;
                PBD.Image = Properties.Resources.Planta;
                PBE.Image = Properties.Resources.PlantaSelecionada;
                respostaUser = 5;
            }
        }

        private void BTVoltar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
