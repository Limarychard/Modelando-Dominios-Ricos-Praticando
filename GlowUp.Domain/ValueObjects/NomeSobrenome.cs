using Flunt.Validations;
using GlowUp.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlowUp.Domain.ValueObjects
{
    public class NomeSobrenome : ValueObject
    {
        public NomeSobrenome(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;

            AddNotifications(
                new Contract<NomeSobrenome>()
                .Requires()
                .IsGreaterThan(Nome.Length, 2, "NomeSobrenome.Nome", "O nome é pequeno demais.")
                .IsGreaterThan(Sobrenome.Length, 2, "NomeSobremenome.Sobrenome", "O sobrenome é pequeno demais.")
            );
        }

        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}";
    }
}
