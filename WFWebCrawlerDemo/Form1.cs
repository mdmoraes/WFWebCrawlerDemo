using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Diagnostics;

namespace WFWebCrawlerDemo
{
    public partial class frmWebCrawler : Form
    {
        public frmWebCrawler()
        {
            InitializeComponent();
        }

        /// <summary>
        /// vou usar a Classe WebClient e o package HtmlAgilityPack no método abaixo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtualizarLista_Click(object sender, EventArgs e)
        {
            /*
             * link da chamada raíz....
            //https://social.msdn.microsoft.com/forums/pt-br/
            */
            
            var wc = new WebClient();
            string pagina = wc.DownloadString("https://social.msdn.microsoft.com/forums/pt-br/");
            //repeti o namespace abaixo, para evitar ambiguidade 
            var htmldocument = new HtmlAgilityPack.HtmlDocument();
            htmldocument.LoadHtml(pagina);

            dataGridView1.Rows.Clear();

            string id = string.Empty;
            string titulo = string.Empty;
            string postagem = string.Empty;
            string exibicao = string.Empty;
            string resposta = string.Empty;
            string link = string.Empty;


            //elementos abaixo, foram capturados ao inspecionar a página da URL MSDN para o Scrapping.
            foreach (HtmlNode node in htmldocument.GetElementbyId("threadList").ChildNodes)
            {
                if (node.Attributes.Count> 0)
                {
                    id = node.Attributes["data-threadid"].Value;
                    link = "https://social.msdn.microsoft.com/forums/pt-br/" + id;


                    // decodificando para string
                    titulo = WebUtility.HtmlDecode(node.Descendants().First(x => x.Id.Equals("threadTitle_" + id)).InnerText);
                    postagem = WebUtility.HtmlDecode(node.Descendants().First(x => x.Attributes["class"] != null && x.Attributes["class"].Value.Equals("lastpost")).InnerText.Replace("\n", "").Replace("  ",""));
                    exibicao = WebUtility.HtmlDecode(node.Descendants().First(x => x.Attributes["class"] != null && x.Attributes["class"].Value.Equals("viewcount")).InnerText);
                    resposta = WebUtility.HtmlDecode(node.Descendants().First(x => x.Attributes["class"] != null && x.Attributes["class"].Value.Equals("replycount")).InnerText);

                    //verificando se o título não está vazio..
                    if (!string.IsNullOrEmpty(titulo))
                    {
                        dataGridView1.Rows.Add(titulo, postagem, exibicao, resposta, link);

                    }



                }



            }

        }

        //envento para acessar o link clicado....
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                Process.Start(new ProcessStartInfo(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()));
            }

        }
    }
}
