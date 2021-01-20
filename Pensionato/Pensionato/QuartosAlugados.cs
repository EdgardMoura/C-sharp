using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pensionato
{
    class QuartosAlugados
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }
    
    public QuartosAlugados(string name, string mail, int bedroom) { 
    
        Name = name;
        Email = mail;
        Quarto = bedroom;
    }

        public override string ToString()
        {
            return Quarto + ": " + Name + ", " +Email;
        }
    }
}
