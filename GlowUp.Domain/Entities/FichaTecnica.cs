using GlowUp.Domain.Enums;
using GlowUp.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlowUp.Domain.Entities
{
    public class FichaTecnica : Entity
    {
        public FichaTecnica(ENaoSim tratamentoEsteticoAnterior, string? quaisTratamentos, ENaoSim tratamentoEsteticoQueNaoAgradou, string? quaisTratamentosEsteticosQueNaoAgradaram, ENaoSim tratamentoDermatologicosAnterior, string? quaisTratamentosDermatologicos, ENaoSim utilizaCosmeticos, string? quaisCosmeticos, ENaoSim fumante, int? quantosCigarros, ENaoSim frequenteExposicaoAoSol, ENaoSim utilizaLenteDeContato, EFuncionamentoIntestinal funcionamentoIntestinal, EQualidade qualidadeSono, int horasDeSono, int ingestaoAgua, EQualidade alimentacao, ENaoSim vegana, ENaoSim vegetariana, ENaoSim praticaAtividadeFisca, int frequenciaAtividadeFisica, ENaoSim utilizaAnticoncepcional, string? qualAnticoncepcional, DateTime? dataUltimaMenstruacao, ENaoSim gestante, ENaoSim temFilhos, int quantosFilhos, DateTime ultimosExameRotina, ENaoSim utilizaMedicamentos, ENaoSim temConvenioMedico, ENaoSim alergia, string? quaisAlergias, ENaoSim possuiMarcaPasso, ENaoSim possuiAlteracoesCardiacas, ENaoSim possuiAlteracoesNeurologicas, ENaoSim possuiDisturbioCirculatorio, ENaoSim possuiDisturbioRenal, ENaoSim possuiDisturbioHormonal, ENaoSim possuiEplepciaOuConvulsao, int frequenciaEplepciaOuConvulsao, ENaoSim possuiAlteracoesPsicologicasOuPsiquiatras, ENivel nivelEstresse, ENivel nivelAnsidedade, ENaoSim antecedentesOncologicos, string? quaisAntecedentesOncologicos, ENaoSim diabetes, ETipoDiabetes? tipoDiabetes, ENaoSim doencasTransmissiveis, string? quaisDoencasTransmissiveis, ENaoSim possuiImplanteDentario, ENaoSim cirurgiaPlastica, string? quaisCirurgiasPlasticas, ENaoSim possuiPreenchimentoDefinitivo, string? qualLocalaPossuiPreenchimentoDefinitivo, DateTime? quandoFoiRealizadoPreenchimentoDefinitivo, string? algoRelevanteQueNaoFoiPerguntado)
        {
            Id = Guid.NewGuid();
            TratamentoEsteticoAnterior = tratamentoEsteticoAnterior;
            QuaisTratamentos = quaisTratamentos;
            TratamentoEsteticoQueNaoAgradou = tratamentoEsteticoQueNaoAgradou;
            QuaisTratamentosEsteticosQueNaoAgradaram = quaisTratamentosEsteticosQueNaoAgradaram;
            TratamentoDermatologicosAnterior = tratamentoDermatologicosAnterior;
            QuaisTratamentosDermatologicos = quaisTratamentosDermatologicos;
            UtilizaCosmeticos = utilizaCosmeticos;
            QuaisCosmeticos = quaisCosmeticos;
            Fumante = fumante;
            QuantosCigarros = quantosCigarros;
            FrequenteExposicaoAoSol = frequenteExposicaoAoSol;
            UtilizaLenteDeContato = utilizaLenteDeContato;
            FuncionamentoIntestinal = funcionamentoIntestinal;
            QualidadeSono = qualidadeSono;
            HorasDeSono = horasDeSono;
            IngestaoAgua = ingestaoAgua;
            Alimentacao = alimentacao;
            Vegana = vegana;
            Vegetariana = vegetariana;
            PraticaAtividadeFisca = praticaAtividadeFisca;
            FrequenciaAtividadeFisica = frequenciaAtividadeFisica;
            UtilizaAnticoncepcional = utilizaAnticoncepcional;
            QualAnticoncepcional = qualAnticoncepcional;
            DataUltimaMenstruacao = dataUltimaMenstruacao;
            Gestante = gestante;
            TemFilhos = temFilhos;
            QuantosFilhos = quantosFilhos;
            UltimosExameRotina = ultimosExameRotina;
            UtilizaMedicamentos = utilizaMedicamentos;
            TemConvenioMedico = temConvenioMedico;
            Alergia = alergia;
            QuaisAlergias = quaisAlergias;
            PossuiMarcaPasso = possuiMarcaPasso;
            PossuiAlteracoesCardiacas = possuiAlteracoesCardiacas;
            PossuiAlteracoesNeurologicas = possuiAlteracoesNeurologicas;
            PossuiDisturbioCirculatorio = possuiDisturbioCirculatorio;
            PossuiDisturbioRenal = possuiDisturbioRenal;
            PossuiDisturbioHormonal = possuiDisturbioHormonal;
            PossuiEplepciaOuConvulsao = possuiEplepciaOuConvulsao;
            FrequenciaEplepciaOuConvulsao = frequenciaEplepciaOuConvulsao;
            PossuiAlteracoesPsicologicasOuPsiquiatras = possuiAlteracoesPsicologicasOuPsiquiatras;
            NivelEstresse = nivelEstresse;
            NivelAnsidedade = nivelAnsidedade;
            AntecedentesOncologicos = antecedentesOncologicos;
            QuaisAntecedentesOncologicos = quaisAntecedentesOncologicos;
            Diabetes = diabetes;
            TipoDiabetes = tipoDiabetes;
            DoencasTransmissiveis = doencasTransmissiveis;
            QuaisDoencasTransmissiveis = quaisDoencasTransmissiveis;
            PossuiImplanteDentario = possuiImplanteDentario;
            CirurgiaPlastica = cirurgiaPlastica;
            QuaisCirurgiasPlasticas = quaisCirurgiasPlasticas;
            PossuiPreenchimentoDefinitivo = possuiPreenchimentoDefinitivo;
            QualLocalaPossuiPreenchimentoDefinitivo = qualLocalaPossuiPreenchimentoDefinitivo;
            QuandoFoiRealizadoPreenchimentoDefinitivo = quandoFoiRealizadoPreenchimentoDefinitivo;
            AlgoRelevanteQueNaoFoiPerguntado = algoRelevanteQueNaoFoiPerguntado;
        }

        public Guid Id { get; private set; }

        public ENaoSim TratamentoEsteticoAnterior { get; private set; }
        public string? QuaisTratamentos{ get; private set; }

        public ENaoSim TratamentoEsteticoQueNaoAgradou { get; private set; }
        public string? QuaisTratamentosEsteticosQueNaoAgradaram { get; private set; }

        public ENaoSim TratamentoDermatologicosAnterior { get; private set; }
        public string? QuaisTratamentosDermatologicos { get; private set; }

        public ENaoSim UtilizaCosmeticos { get; private set; }
        public string? QuaisCosmeticos { get; private set; }

        public ENaoSim Fumante { get; private set; }
        public int? QuantosCigarros { get; private set; }

        public ENaoSim FrequenteExposicaoAoSol { get; private set; }

        public ENaoSim UtilizaLenteDeContato { get; private set; }

        public EFuncionamentoIntestinal FuncionamentoIntestinal { get; private set; }

        public EQualidade QualidadeSono { get; private set; }
        public int HorasDeSono { get; private set; }

        public int IngestaoAgua { get; private set; }
        public EQualidade Alimentacao { get; private set; }

        public ENaoSim Vegana { get; private set; }
        public ENaoSim Vegetariana { get; private set; }

        public ENaoSim PraticaAtividadeFisca { get; private set; }
        public int? FrequenciaAtividadeFisica { get; private set; }

        #region Relacionado a mulheres
        public ENaoSim UtilizaAnticoncepcional { get; private set; }
        public string? QualAnticoncepcional { get; private set; }
        public DateTime? DataUltimaMenstruacao { get; private set; }

        public ENaoSim Gestante { get; private set; }
        public ENaoSim TemFilhos { get; private set; }
        public int QuantosFilhos { get; private set; }
        #endregion

        public DateTime UltimosExameRotina { get; private set; }

        public ENaoSim UtilizaMedicamentos { get; private set; }
        public ENaoSim TemConvenioMedico { get; private set; }

        public ENaoSim Alergia { get; private set; }
        public string? QuaisAlergias { get; private set; }

        public ENaoSim PossuiMarcaPasso { get; private set; }
        public ENaoSim PossuiAlteracoesCardiacas { get; private set; }
        public ENaoSim PossuiAlteracoesNeurologicas { get; private set; }
        public ENaoSim PossuiDisturbioCirculatorio { get; private set; }
        public ENaoSim PossuiDisturbioRenal { get; private set; }
        public ENaoSim PossuiDisturbioHormonal { get; private set; }
        public ENaoSim PossuiEplepciaOuConvulsao { get; private set; }
        public int FrequenciaEplepciaOuConvulsao { get; private set; }

        public ENaoSim PossuiAlteracoesPsicologicasOuPsiquiatras { get; private set; }

        public ENivel NivelEstresse { get; private set; }
        public ENivel NivelAnsidedade { get; private set; }

        public ENaoSim AntecedentesOncologicos { get; private set; }
        public string? QuaisAntecedentesOncologicos { get; private set; }

        public ENaoSim Diabetes { get; private set; }
        public ETipoDiabetes? TipoDiabetes { get; private set; }

        public ENaoSim DoencasTransmissiveis { get; private set; }
        public string? QuaisDoencasTransmissiveis { get; private set; }

        public ENaoSim PossuiImplanteDentario { get; private set; }

        public ENaoSim CirurgiaPlastica { get; private set; }
        public string? QuaisCirurgiasPlasticas { get; private set; }

        public ENaoSim PossuiPreenchimentoDefinitivo { get; private set; }
        public string? QualLocalaPossuiPreenchimentoDefinitivo { get; private set; }
        public DateTime? QuandoFoiRealizadoPreenchimentoDefinitivo { get; private set; }

        public string? AlgoRelevanteQueNaoFoiPerguntado { get; private set; }

    }
}
