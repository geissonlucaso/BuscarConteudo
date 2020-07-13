using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FerramentasHtml
{
    public static class TratamentoDados
    {
        // Métodos.

        /**
         * Método para contar o numero de referencias de uma palavra chave
         */
        public static int ContarCitacoes(string strText, string word)
        {
            if (!String.IsNullOrEmpty(strText))
            {
                int quantidade = 0;
                quantidade = Regex.Matches(strText, string.Format(@"\b{0}\b", Regex.Escape(word)), RegexOptions.IgnoreCase).Count;  // Ignora letras Maiusc. e Minusc.

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
            TratamentoDados.RemoverTagsBody(ref html, "script");
            TratamentoDados.RemoverTagsBody(ref html, "style");

            // Remoção das demais tags. [Onde o conteúdo está visível no Browser].
            html = Regex.Replace(html, "<.*?>", " ");
            html = RemoverEspacoVazio(html);
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

        private static String RemoverEspacoVazio(String inString)
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
