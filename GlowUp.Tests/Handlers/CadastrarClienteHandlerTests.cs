using GlowUp.Domain.Commands;
using GlowUp.Domain.Enums;
using GlowUp.Domain.Handlers;
using GlowUp.Tests.Fakes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlowUp.Tests.Handlers
{
    [TestClass]
    public class CadastrarClienteHandlerTests
    {

        [TestMethod]
        public void DeveRetornarErroQuandoCpfExiste()
        {
            var handler = new ClienteHandler(new FakeClienteRepository(), new FakeEmailService());
            var command = new CriarClienteComFichaTecnicaCommand();

            command.Nome = "Rychard";
            command.Sobrenome = "Lima";
            command.NumeroDocumento = "80661170004";
            command.TipoDocumento = ETipoDocumento.CPF;
            command.Rua = "Rua tal";
            command.NumeroEndereco = "432";
            command.CEP = "03728912";
            command.Cidade = "São Paulo";
            command.Bairro = "Penha";
            command.Estado = "SP";
            command.DDD = 11;
            command.Numero = 980382785;
            command.Idade = 18;
            command.DataNacimento = DateTime.Parse("27/08/2004");
            command.Profissao = "Garoto de Programa";

            #region Ficha Técnica
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
            #endregion

            handler.Handle(command);
            Assert.AreEqual(false, handler.IsValid);
        }

        [TestMethod]
        public void DeveRetornarSucessoQuandoCpfOuEmailNaoExistirem()
        {
            var handler = new ClienteHandler(new FakeClienteRepository(), new FakeEmailService());
            var command = new CriarClienteComFichaTecnicaCommand();

            command.Nome = "Rychard";
            command.Sobrenome = "Lima";
            command.NumeroDocumento = "02735739007";
            command.Email = "rychard.lima@gmail.com";
            command.TipoDocumento = ETipoDocumento.CPF;
            command.Rua = "Rua tal";
            command.NumeroEndereco = "432";
            command.CEP = "03728912";
            command.Cidade = "São Paulo";
            command.Bairro = "Penha";
            command.Estado = "SP";
            command.DDD = 11;
            command.Numero = 980382785;
            command.Idade = 18;
            command.DataNacimento = DateTime.Parse("27/08/2004");
            command.Profissao = "Garoto de Programa";

            #region Ficha Técnica
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
            #endregion

            handler.Handle(command);
            Assert.AreEqual(true, handler.IsValid);
        }
    }
}
