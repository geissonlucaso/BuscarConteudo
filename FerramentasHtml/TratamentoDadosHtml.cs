using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FerramentasHtml
{
    public static class TratamentoDadosHtml
    {
        // Métodos.

        /**
         * Método para contar o numero de referencias de uma palavra chave em um 
         * documento HTML
         */
        public static int ContarCitacoes(string htmlPage, string word)
        {
            if (!String.IsNullOrEmpty(htmlPage))
            {
                int quantidade = 0;
                quantidade = Regex.Matches(htmlPage, word, RegexOptions.IgnoreCase).Count;  // Ignora letras Maiusc. e Minusc.

                return quantidade;
            }
            else
            {
                return 0;
            }
        }

        /**
         * Método para obter o <body></body> de uma página HTML.
         */
        public static string ObterConteudoUtil(string html)
        {
            // Isolamento do conteudo do body.
            if (!String.IsNullOrEmpty(html))
            {
                int inicioIndex = html.IndexOf("<body");
                int finalIndex = html.LastIndexOf("</body>");

                html = html.Substring(inicioIndex, finalIndex - inicioIndex);
            }
            else
            {
                return null;
            }

            // Remoção dos scripts, styles e seus respectivos conteudos.
            TratamentoDadosHtml.RemoverTagsBody(ref html, "script");
            TratamentoDadosHtml.RemoverTagsBody(ref html, "style");

            // Remoção das demais tags. [Onde o conteúdo está visível no Browser].
            html = Regex.Replace(html, "<.*?>", " ");
            //html = SingleSpacedTrim(html);
            return html;
        }

        /**
         * Método para remover o conteudo das tags do <body>
         */
        private static void RemoverTagsBody(ref string html, string tag)
        {
            if (!String.IsNullOrEmpty(html))
            {
                while (html.Contains($"<{tag}"))
                {
                    int inicioIndex = html.IndexOf($"<{tag}");
                    int finalIndex = html.IndexOf($"</{tag}>");

                    string strRemove = html.Substring(inicioIndex, finalIndex - inicioIndex + tag.Length+3);

                    html = html.Replace(strRemove, "");
                }
            }
        }

        private static String SingleSpacedTrim(String inString)
        {
            StringBuilder sb = new StringBuilder();
            Boolean inBlanks = false;
            foreach (Char c in inString)
            {
                switch (c)
                {
                    case '\r':
                    case '\n':
                    case '\t':
                    case ' ':
                        if (!inBlanks)
                        {
                            inBlanks = true;
                            sb.Append(' ');
                        }
                        continue;
                    default:
                        inBlanks = false;
                        sb.Append(c);
                        break;
                }
            }
            return sb.ToString().Trim();
        }
    }
}
