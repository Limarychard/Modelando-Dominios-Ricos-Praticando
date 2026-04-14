using Flunt.Notifications;
using Flunt.Validations;
using GlowUp.Domain.Entities;
using GlowUp.Domain.Enums;
using GlowUp.Domain.ValueObjects;
using GlowUp.Shared.Commands;
using GlowUp.Shared.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GlowUp.Domain.Commands
{
    public class CriarClienteComFichaTecnicaCommand : Notifiable<Notification>, ICommand
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string NumeroDocumento { get; set; }
        public ETipoDocumento TipoDocumento { get; set; } = ETipoDocumento.CPF;
        public string Rua { get; set; }
        public string NumeroEndereco { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string? Complemento { get; set; }
        public decimal DDD { get; set; }
        public decimal Numero { get; set; }
        public string TelefoneCompleto => $"{DDD}{Numero}";
        public Guid IdFicha { get; set; }

        public ENaoSim TratamentoEsteticoAnterior { get; set; }
        public string? QuaisTratamentos { get; set; }

        public ENaoSim TratamentoEsteticoQueNaoAgradou { get; set; }
        public string? QuaisTratamentosEsteticosQueNaoAgradaram { get; set; }

        public ENaoSim TratamentoDermatologicosAnterior { get; set; }
        public string? QuaisTratamentosDermatologicos { get; set; }

        public ENaoSim UtilizaCosmeticos { get; set; }
        public string? QuaisCosmeticos { get; set; }

        public ENaoSim Fumante { get; set; }
        public int? QuantosCigarros { get; set; }

        public ENaoSim FrequenteExposicaoAoSol { get; set; }

        public ENaoSim UtilizaLenteDeContato { get; set; }

        public EFuncionamentoIntestinal FuncionamentoIntestinal { get; set; }

        public EQualidade QualidadeSono { get; set; }
        public int HorasDeSono { get; set; }

        public int IngestaoAgua { get; set; }
        public EQualidade Alimentacao { get; set; }

        public ENaoSim Vegana { get; set; }
        public ENaoSim Vegetariana { get; set; }

        public ENaoSim PraticaAtividadeFisca { get; set; }
        public int? FrequenciaAtividadeFisica { get; set; }

        #region Relacionado a mulheres
        public ENaoSim UtilizaAnticoncepcional { get; set; }
        public string? QualAnticoncepcional { get; set; }
        public DateTime? DataUltimaMenstruacao { get; set; }

        public ENaoSim Gestante { get; set; }
        public ENaoSim TemFilhos { get; set; }
        public int QuantosFilhos { get; set; }
        #endregion

        public DateTime UltimosExameRotina { get; set; }

        public ENaoSim UtilizaMedicamentos { get; set; }
        public ENaoSim TemConvenioMedico { get; set; }

        public ENaoSim Alergia { get; set; }
        public string? QuaisAlergias { get; set; }

        public ENaoSim PossuiMarcaPasso { get; set; }
        public ENaoSim PossuiAlteracoesCardiacas { get; set; }
        public ENaoSim PossuiAlteracoesNeurologicas { get; set; }
        public ENaoSim PossuiDisturbioCirculatorio { get; set; }
        public ENaoSim PossuiDisturbioRenal { get; set; }
        public ENaoSim PossuiDisturbioHormonal { get; set; }
        public ENaoSim PossuiEplepciaOuConvulsao { get; set; }
        public int? FrequenciaEplepciaOuConvulsao { get; set; }

        public ENaoSim PossuiAlteracoesPsicologicasOuPsiquiatras { get; set; }

        public ENivel NivelEstresse { get; set; }
        public ENivel NivelAnsidedade { get; set; }

        public ENaoSim AntecedentesOncologicos { get; set; }
        public string? QuaisAntecedentesOncologicos { get; set; }

        public ENaoSim Diabetes { get; set; }
        public ETipoDiabetes? TipoDiabetes { get; set; }

        public ENaoSim DoencasTransmissiveis { get; set; }
        public string? QuaisDoencasTransmissiveis { get; set; }

        public ENaoSim PossuiImplanteDentario { get; set; }

        public ENaoSim CirurgiaPlastica { get; set; }
        public string? QuaisCirurgiasPlasticas { get; set; }

        public ENaoSim PossuiPreenchimentoDefinitivo { get; set; }
        public string? QualLocalaPossuiPreenchimentoDefinitivo { get; set; }
        public DateTime? QuandoFoiRealizadoPreenchimentoDefinitivo { get; set; }

        public string? AlgoRelevanteQueNaoFoiPerguntado { get; set; }
        public DateTime DataNacimento { get; set; }
        public int Idade { get; set; }
        public EEstadoCivil EstadoCivil { get; set; }
        public string Email { get; set; }
        public string Profissao { get; set; }
        public string? QualSeuSigno { get; set; }
        public string? QualSeuRobbie { get; set; }
        public string? EstiloMusical { get; set; }
        public string? ComoMeConheceu { get; set; }
        public string? QualSuaExpectativa { get; set; }
        public string? OqueBuscaPorAqui { get; set; }

        public void Validate()
        {            
            ValidarTextoCondicional(TratamentoEsteticoAnterior, QuaisTratamentos, "QuaisTratamentos");
            ValidarTextoCondicional(TratamentoEsteticoQueNaoAgradou, QuaisTratamentosEsteticosQueNaoAgradaram, "QuaisTratamentosEsteticosQueNaoAgradaram");
            ValidarTextoCondicional(UtilizaCosmeticos, QuaisCosmeticos, "QuaisCosmeticos");
            ValidarTextoCondicional(UtilizaAnticoncepcional, QualAnticoncepcional, "QualAnticoncepcional");
            ValidarTextoCondicional(Alergia, QuaisAlergias, "QuaisAlergias");
            ValidarTextoCondicional(AntecedentesOncologicos, QuaisAntecedentesOncologicos, "QuaisAntecedentesOncologicos");
            ValidarTextoCondicional(DoencasTransmissiveis, QuaisDoencasTransmissiveis, "QuaisDoencasTransmissiveis");
            ValidarTextoCondicional(CirurgiaPlastica, QuaisCirurgiasPlasticas, "QuaisCirurgiasPlasticas");
            ValidarTextoCondicional(PossuiPreenchimentoDefinitivo, QualLocalaPossuiPreenchimentoDefinitivo, "QualLocalaPossuiPreenchimentoDefinitivo");

            ValidarNumeroCondicional(Fumante, QuantosCigarros, "QuantosCigarros");
            ValidarNumeroCondicional(PraticaAtividadeFisca, FrequenciaAtividadeFisica, "QuantosCigarros");
            ValidarNumeroCondicional(PossuiEplepciaOuConvulsao, FrequenciaEplepciaOuConvulsao, "QuantosCigarros");
        }

        private void ValidarTextoCondicional(ENaoSim resposta, string? campo, string nomeCampo)
        {
            if (resposta == ENaoSim.Sim && string.IsNullOrWhiteSpace(campo))
                AddNotification($"{campo}", $"O {nomeCampo} deve ser preenchido.");
        }

        private void ValidarNumeroCondicional(ENaoSim resposta, int? campo, string nomeCampo)
        {
            if (resposta == ENaoSim.Sim && !campo.HasValue)
                AddNotification($"{campo}", $"O {nomeCampo} deve ser preenchido.");
        }

        private bool IdadeCompativel(int idade, DateTime dataNascimento)
        {
            int AnoAtual = DateTime.Now.Year;
            int AnoNascimento = dataNascimento.Year;

            if (AnoAtual - AnoNascimento == idade)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
