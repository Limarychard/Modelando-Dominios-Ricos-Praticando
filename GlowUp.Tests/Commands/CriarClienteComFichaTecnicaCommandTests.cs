using GlowUp.Domain.Commands;
using GlowUp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlowUp.Tests.Commands
{
    [TestClass]
    public class CriarClienteComFichaTecnicaCommandTests
    {
        [TestMethod]
        public void DeveRetornarErroQuandoFichaTecnicaEstiverIncompleta()
        {
            var command = new CriarClienteComFichaTecnicaCommand();
            command.TratamentoEsteticoAnterior = ENaoSim.Sim;
            command.QuaisTratamentos = "Botox no rosto";
            command.TratamentoEsteticoQueNaoAgradou = ENaoSim.Nao;
            command.QuaisTratamentosEsteticosQueNaoAgradaram = null;
            command.UtilizaCosmeticos = ENaoSim.Nao;
            command.QuaisCosmeticos = null;
            command.UtilizaAnticoncepcional = ENaoSim.Nao;
            command.Alergia = ENaoSim.Nao;
            command.QuaisAlergias = null;
            command.AntecedentesOncologicos = ENaoSim.Nao;
            command.QuaisAntecedentesOncologicos = null;
            command.DoencasTransmissiveis = ENaoSim.Nao;
            command.QuaisDoencasTransmissiveis = null;
            command.CirurgiaPlastica = ENaoSim.Nao;
            command.QuaisCirurgiasPlasticas = null;
            command.PossuiPreenchimentoDefinitivo = ENaoSim.Nao;
            command.QualLocalaPossuiPreenchimentoDefinitivo = null;

            command.Fumante = ENaoSim.Sim;
            command.QuantosCigarros = 1;
            command.PraticaAtividadeFisca = ENaoSim.Sim;
            command.FrequenciaAtividadeFisica = null; //Vai gerar erro;
            command.PossuiEplepciaOuConvulsao = ENaoSim.Nao;
            command.FrequenciaEplepciaOuConvulsao = null;



            command.Validate();
            Assert.AreEqual(false, command.IsValid);
        }

        [TestMethod]
        public void DeveRetornarSucessoQuandoFichaTecnicaEstiverCompleta()
        {
            var command = new CriarClienteComFichaTecnicaCommand();
            command.TratamentoEsteticoAnterior = ENaoSim.Sim;
            command.QuaisTratamentos = "Botox no rosto";
            command.TratamentoEsteticoQueNaoAgradou = ENaoSim.Nao;
            command.QuaisTratamentosEsteticosQueNaoAgradaram = null;
            command.UtilizaCosmeticos = ENaoSim.Nao;
            command.QuaisCosmeticos = null;
            command.UtilizaAnticoncepcional = ENaoSim.Nao;
            command.Alergia = ENaoSim.Nao;
            command.QuaisAlergias = null;
            command.AntecedentesOncologicos = ENaoSim.Nao;
            command.QuaisAntecedentesOncologicos = null;
            command.DoencasTransmissiveis = ENaoSim.Nao;
            command.QuaisDoencasTransmissiveis = null;
            command.CirurgiaPlastica = ENaoSim.Nao;
            command.QuaisCirurgiasPlasticas = null;
            command.PossuiPreenchimentoDefinitivo = ENaoSim.Nao;
            command.QualLocalaPossuiPreenchimentoDefinitivo = null;

            command.Fumante = ENaoSim.Sim;
            command.QuantosCigarros = 1;
            command.PraticaAtividadeFisca = ENaoSim.Sim;
            command.FrequenciaAtividadeFisica = 6;
            command.PossuiEplepciaOuConvulsao = ENaoSim.Nao;
            command.FrequenciaEplepciaOuConvulsao = null;



            command.Validate();
            Assert.AreEqual(true, command.IsValid);
        }
    }
}
