using System;
using System.Collections.Generic;

namespace DioJogos
{
    public class SystemRequirements : EntidadeBase
    {
        // Atributos
        public string CPU { get; set; }
        public int MemoriaGb { get; set; }
        public string GPU { get; set; }
        public string Armazenamento { get; set; }

        public SystemRequirements(int id, string CPU, int MemoriaGb, string GPU, string Armazenamento) 
        {
            this.CPU = CPU;
            this.MemoriaGb = MemoriaGb;
            this.GPU = GPU;
            this.Armazenamento = Armazenamento;
        }
        public override string ToString()
        {
            string print = "";
            print += "CPU" + this.CPU + Environment.NewLine;
            print += "CPU" + this.CPU + Environment.NewLine;
            print += "CPU" + this.CPU + Environment.NewLine;
            print += "CPU" + this.CPU + Environment.NewLine;
            print += "Excluido: " + this.Excluido + Environment.NewLine;
            return print;
        }
        public string retornaCPU()
        {
            return this.CPU;
        }
        public int retornaId()
        {
            return this.Id;
        }
        public string retornaGPU()
        {
            return this.GPU;
        }
        public string retornaArmazenamento()
        {
            return this.Armazenamento;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }  
    }
}