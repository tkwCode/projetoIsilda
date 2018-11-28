using System;

namespace Sino_Automatizado
{
    public class TemposAula
    {
        public int Id_Coluna { get; set; }
        public ConfigInicial Periodo { get; set; }
        public int Tempo { get; set; }
        public DateTime Hora_Inicial { get; set; }
        public DateTime Hora_Final { get; set; }
        public DateTime Inicio_Intervalo { get; set; }
        public DateTime Fim_Intervalo { get; set; }
        public Arquivo CodArquivo { get; set; }
    }
}
