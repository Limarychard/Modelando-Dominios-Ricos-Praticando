using GlowUp.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlowUp.Domain.ValueObjects
{
    public class PerguntasAleatorias : ValueObject
    {
        public PerguntasAleatorias(string? qualSeuSigno, string? qualSeuRobbie, string? estiloMusical, string? comoMeConheceu, string? qualSuaExpectativa, string? oqueBuscaPorAqui)
        {
            QualSeuSigno = qualSeuSigno;
            QualSeuRobbie = qualSeuRobbie;
            EstiloMusical = estiloMusical;
            ComoMeConheceu = comoMeConheceu;
            QualSuaExpectativa = qualSuaExpectativa;
            OqueBuscaPorAqui = oqueBuscaPorAqui;
        }

        public string? QualSeuSigno { get; private set; }
        public string? QualSeuRobbie { get; private set; }
        public string? EstiloMusical { get; private set; }
        public string? ComoMeConheceu { get; private set; }
        public string? QualSuaExpectativa { get; private set; }
        public string? OqueBuscaPorAqui { get; private set; }
    }
}
