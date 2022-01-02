using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localiza.Frotas5.Infra.Facade
{
    public class DetranOptions
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string BaseUrl { get; set; }
        public string VistoriaUri { get; set; }
        public int QuantidadeDiasParaAgendamento { get; set; }

    }
}
