using System;
using System.Collections.Generic;
using System.Text;

namespace ResultSearchModel
{
    class SiteEntity
    {
        // Propriedades
        public Guid Id { get; private set; }
        public string Url { get; set; }
        public int NumCitacao { get; set; }


        // Construtores
        public SiteEntity(string url, int numCitacao)
        {
            this.Id = System.Guid.NewGuid();
            this.Url = url;
            this.NumCitacao = numCitacao;
        }
    }
}
