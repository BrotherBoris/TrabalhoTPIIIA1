using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabalhoA1.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public Motor Motor { get; set; }
        public Marca Marca { get; set; }
    }
}