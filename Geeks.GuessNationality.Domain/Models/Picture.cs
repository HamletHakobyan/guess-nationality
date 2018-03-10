using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geeks.GuessNationality.Domain.Models
{
    class Picture
    {
        public int Id { get; set; }
        public Nationality Nationality { get; set; }
    }
}
