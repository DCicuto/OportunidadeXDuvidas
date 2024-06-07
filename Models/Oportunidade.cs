﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Oportunidade : DbContext
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataEntrega { get; set; }
        public string NivelSurtos { get; set; }
        public int QtdHoras { get; set; }
        public long QtdErros { get; set; }
        public long Aprendizado { get; set; }
        public long HorasDeSono { get; set; }
        public int Folga { get; set; }
    }
   
}
