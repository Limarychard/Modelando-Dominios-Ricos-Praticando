using Flunt.Validations;
using GlowUp.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlowUp.Domain.ValueObjects
{
    public class Endereco : ValueObject
    {
        public Endereco(string rua, string numero, string cep, string cidade, string bairro, string estado, string? complemento)
        {
            cep = cep.Replace("-", "");

            Rua = rua;
            Numero = numero;
            CEP = cep;
            Cidade = cidade;
            Bairro = bairro;
            Estado = estado;
            Complemento = complemento;

            AddNotifications(
                    new Contract<Endereco>()
                    .Requires()
                    .IsGreaterThan(CEP.Length, 7, "Endereco.CEP", "O CEP não contém 7 dígitos.")
            );
        }

        public string Rua { get; private set; }
        public string Numero { get; private set; }
        public string CEP { get; private set; }
        public string Cidade { get; private set; }
        public string Bairro { get; private set; }
        public string Estado { get; private set; }
        public string? Complemento { get; private set; }
    }
}
