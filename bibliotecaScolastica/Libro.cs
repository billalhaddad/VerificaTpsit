using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaScolastica
{
    class Libro
    {
        public string _autore { get; set; }
        public string _titolo { get; set; }
        public DateTime _annoPubblicazione { get; set; }
        public string _editore { get; set; }
        public int _nPagine{get;set;}
        public Libro(string autore,string titolo,DateTime annoPUb,string editore,int nPag)
        {
            _autore = autore;
            _titolo = titolo;
            _annoPubblicazione = annoPUb;
            _editore = editore;
            _nPagine = nPag;
        }
        public override string ToString()
        {
            return _autore + _titolo + _annoPubblicazione + _editore + _nPagine;
        }
        public string readingTine()
        {
            if (_nPagine < 100)
                return "1h";
            else if (_nPagine > 100 && _nPagine < 200)
                return "2h";
            else
                return "superiore alle 2h";
        }

    }
}
