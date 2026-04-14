using Flunt.Validations;
using GlowUp.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlowUp.Domain.ValueObjects
{
    public class Telefone : ValueObject
    {
        public Telefone(decimal ddd, decimal numero)
        {
            DDD = ddd;
            Numero = numero;

            AddNotifications(
                new Contract<Telefone>()
                    .Requires()
                    .AreEquals(TelefoneCompleto.Length, 11, "Telefone", "O telefone não está correto.")
            );
        }

        public decimal DDD { get; private set; }
        public decimal Numero { get; private set; }
        public string TelefoneCompleto => $"{DDD}{Numero}";
    }
}