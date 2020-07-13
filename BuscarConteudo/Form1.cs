using FerramentasHtml;
using iTextSharp.text.pdf.parser;
using System;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace BuscarConteudo
{
    public partial class Form1 : Form
    {
        private int contador = 0;
        string strConteudoPDF = "";

        public Form1()
        {
            InitializeComponent();
        }

        // Carregamento da página
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Adicionar uma URL como item do ListView.
        private void btnAdicionarURL_Click(object sender, EventArgs e)
        {
            contador++;
            string urlTexto = txtURL.Text;

            if (contador > 9)
                lblContador.Text = contador.ToString();
            else
                lblContador.Text = "0" + contador.ToString();

            txtURL.Clear();     // Limpar o texto e dar foco.
            txtURL.Focus();

            lvwReults.Items.Clear();  // Remover resultados anteriores.

            ListViewItem lvwItem = new ListViewItem(urlTexto, 0);
            lvwURLs.Items.Add(lvwItem);
        }

        // Remover um item do listview.
        private void btnRemover_Click(object sender, EventArgs e)
        {
            // Verifica se existem itens, e se ao menos um está selecionado.
            if (lvwURLs.SelectedItems.Count != 0)
            {
                if (lvwURLs.SelectedItems[0].Selected)
                {
                    ListViewItem lvwItem = lvwURLs.SelectedItems[0];
                    lvwURLs.Items.Remove(lvwItem);

                    contador--;
                    if (contador > 9)
                        lblContador.Text = contador.ToString();
                    else
                        lblContador.Text = "0" + contador.ToString();
                }
            }
        }

        // Pesquisar citações - URL.
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // Leitura e tratamento de cada url contida no listview.
            lerURLs(lvwURLs);
            lvwURLs.Items.Clear();


            int totalResultadosURL = somarResultados(lvwReults);
            if (totalResultadosURL > 0)
                lblURLCount.Text = $"Foram encontradas {totalResultadosURL} citações.";
            else
                lblURLCount.Text = $"Não foram encontradas citações.";
        }

        // Botão para abrir o documento pdf.
        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter="PDF files|*.pdf", 
                ValidateNames = true, Multiselect = false})
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader(ofd.FileName);
                        StringBuilder sb = new StringBuilder();

                        for (int i = 1; i <= reader.NumberOfPages; i++)
                        {
                            sb.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                        }

                        strConteudoPDF = sb.ToString();

                        richTextBox1.Text = sb.ToString();
                        reader.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Pesquisar texto em PDF.
        private void btnPesquisarPdf_Click(object sender, EventArgs e)
        {
            int contagem = TratamentoDados.ContarCitacoes(strConteudoPDF, txtPalavraPDF.Text);
            if (contagem > 99)
                lblPdfResult.Text = contagem.ToString();
            else if(contagem > 9)
                lblPdfResult.Text = "0" + contagem.ToString();
            else
                lblPdfResult.Text = "00" + contagem.ToString();
        }

        // ==============================================================================================================
        // Métodos adicionais.

        // Método para ler todas as urls que foram inseridas.
        private void lerURLs(ListView vlw)
        {
            foreach (ListViewItem item in lvwURLs.Items)
            {
                
                using (var cliente = new WebClient() { Encoding = System.Text.Encoding.UTF8 })
                {
                    int contagem = 0;
                    string url = item.Text;

                    string strConteudo = cliente.DownloadString(url);                               // HTML.
                    strConteudo = TratamentoDados.ObterConteudoUtil(strConteudo);               // Body.
                    contagem = TratamentoDados.ContarCitacoes(strConteudo, txtPalavra.Text);    // Quantidade de citações.

                    string[] row = { contagem.ToString() };
                    lvwReults.Items.Add(url).SubItems.AddRange(row);
                }
            }
        }

        // Método para calcular a quantidade total de resultados - URL.
        private int somarResultados(ListView lvw)
        {
            int total = 0;

            for (int i = 0; i < lvwReults.Items.Count; i++)
            {
                total += int.Parse(lvwReults.Items[i].SubItems[1].Text);
            }

            return total;
        }

        private void VisitPage(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(lvwReults.SelectedItems[0].Text);
            Process.Start(sInfo);
        }

        private void ShowTextURL(object sender, EventArgs e)
        {
            
        }
    }
}
