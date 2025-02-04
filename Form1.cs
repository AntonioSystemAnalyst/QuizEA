using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
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


        public Form1()
        {
            InitializeComponent();
            timerFocus.Enabled = true;

            // Carrega as perguntas ao iniciar o formulário
            perguntas = CarregarPerguntas(filePath);

            SelecionarQuestaoAleatoria();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
