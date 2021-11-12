using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaScolastica
{
    class Biblioteca
    {
        public string _nome { get; set; }
        public string _indirizzio { get; set; }
        public int Time { get; set; }
        public int TimeChiusura { get; set; }
        public List<Libro> _libri { get; set; }
        public Biblioteca(string nome,string indirizzo,int time,int tempoChius,List<Libro> libri)
        {
            _nome = nome;
            _indirizzio = indirizzo;
            Time = time;
            TimeChiusura = tempoChius;
            _libri = libri;
        }
        public Biblioteca(string nome, string indirizzo, int time, int tempoChius)
        {
            _nome = nome;
            _indirizzio = indirizzo;
            Time = time;
            TimeChiusura = tempoChius;
            _libri = new List<Libro>();
        }
        public void AggiuntaLibro(Libro l)
        {
            _libri.Add(l);
        }
        public Libro ricercaLibroConTitolo(string Titolo)
        {
            Libro libro=new Libro("unknown",Titolo,new DateTime(2000,1,1),"unknown",100);
            foreach (Libro l in _libri)
            {
                if (l._titolo == Titolo)
                {
                    libro = l;
                }
            }
            return libro;
        }
        public List<Libro> ricercaLibriAutore(string autore)
        {
            List<Libro> libriAutore = new List<Libro>();
            foreach (Libro l in _libri)
                if (l._autore == autore)
                    libriAutore.Add(l);
            return libriAutore;
        }
        public int numeroLibri()
        {
            return _libri.Count;
        }
    }
}
