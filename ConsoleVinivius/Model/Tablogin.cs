using System;
using System.Collections.Generic;

namespace ConsoleVinivius.Model
{
    public partial class Tablogin
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Situacao { get; set; }
    }
}
