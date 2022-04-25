using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TesteJPVEntityV2.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        [StringLength(50)]
        public string Nome { get; set; }

        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal ValorRenda { get; set; }
    }
}
