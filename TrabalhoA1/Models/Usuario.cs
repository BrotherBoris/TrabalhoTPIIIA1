using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabalhoA1.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public Cidade Cidade { get; set; }
        public Carro[] Carro{ get; set; }
}
}