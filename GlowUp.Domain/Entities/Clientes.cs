using Flunt.Validations;
using GlowUp.Domain.Enums;
using GlowUp.Domain.ValueObjects;
using GlowUp.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlowUp.Domain.Entities
{
    public class Clientes : Entity
    {
        public Clientes(NomeSobrenome nome, Documento documento, Endereco endereco, FichaTecnica ficha, Telefone telefone, DateTime dataNacimento, int idade, EEstadoCivil estadoCivil, EnderecoEmail email, string profissao, PerguntasAleatorias? perguntasAleatoriias)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Documento = documento;
            Endereco = endereco;
            Ficha = ficha;
            DataNacimento = dataNacimento;
            Idade = idade;
            EstadoCivil = estadoCivil;
            Email = email;
            Profissao = profissao;
            PerguntasAleatoriias = perguntasAleatoriias;
            Telefone = telefone;

            
            AddNotifications(Nome, Documento, Endereco, Email, Telefone);

            AddNotifications(
                new Contract<Clientes>()
                    .Requires()
                    .IsNotNull(Ficha, "Cliente.Ficha", "A Ficha Técnica deve ser preenchida.")
                    .IsFalse(IdadeCompativel(Idade, DataNacimento), "Cliente.Idade", "A idade não confere com a Data de Nascimento.")
            );
        }

        public Guid Id { get; private set; }
        public NomeSobrenome Nome { get; private set; }
        public Documento Documento { get; private set; }
        public Endereco Endereco { get; private set; }
        public FichaTecnica Ficha { get; private set; }
        public Telefone Telefone { get; private set; }
        public DateTime DataNacimento { get; private set; }
        public int Idade { get; private set; }
        public EEstadoCivil EstadoCivil { get; private set; }
        public EnderecoEmail Email { get; private set; }
        public string Profissao { get; private set; }
        public PerguntasAleatorias? PerguntasAleatoriias { get; private set; }

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
