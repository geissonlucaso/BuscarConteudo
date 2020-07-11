using FerramentasHtml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscarConteudo
{
    public partial class Form1 : Form
    {
        private int contador = 0;

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

        // Pesquisar citações.
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            using (var cliente = new WebClient() { Encoding = System.Text.Encoding.UTF8})
            {
                int contagem = 0;
                string subdomain = null;
                string url = txtURL.Text;
                var regex = @"/(?:http[s]*\:\/\/)*(.*?)\.(?=[^\/]*\..{2,5})/i";

                string strConteudo = cliente.DownloadString(url);                       // HTML.
                strConteudo = TratamentoDadosHtml.ObterConteudoUtil(strConteudo);               // Body.
                contagem = TratamentoDadosHtml.ContarCitacoes(strConteudo, txtPalavra.Text);    // Quantidade de citações.

                subdomain = Regex.(url, @"\bhttps?://[.0-9A-Za-z-]+\.[A-Za-z]{2,63}(?::[0-9]{1,5})?(?:/[!$'()*+,.0-9A-Z_a-z-]+){0,9}(?:/[!$'()*+,.0-9A-Z_a-z-]*)?(?:\?[!$&'()*+,.0-9=A-Z_a-z-]*)?|regexmagic");


                //ListViewItem lvwItem = new ListViewItem(urlTexto, 0);
                //lvwURLs.Items.Add(lvwItem);

                Uri uri = new Uri(url);
                lblQ.Text = contagem.ToString();
                txtH.Text = strConteudo;
                lblH.Text = uri..ToString();
            }
        }
        // ==============================================================================================================
        // Métodos adicionais.

    }
}
