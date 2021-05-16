﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urnaEletronica
{
    class Candidato
    {
        public string nome { get; set; }
        public int numeroCandidato { get; set; }
        public string foto { get; set; }
        public string partido { get; set; }

        public Candidato (){ }

        public Candidato(string nome, int numeroCandidato, string foto, string partido)
        {
            this.nome = nome;
            this.numeroCandidato = numeroCandidato;
            this.foto = foto;
            this.partido = partido;
        }
    }
}
