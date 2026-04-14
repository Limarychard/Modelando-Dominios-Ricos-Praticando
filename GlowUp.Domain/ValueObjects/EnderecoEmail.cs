using Flunt.Validations;
using GlowUp.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlowUp.Domain.ValueObjects
{
    public class EnderecoEmail : ValueObject
    {
        public EnderecoEmail(string email)
        {
            Email = email;

            AddNotifications(
                new Contract<EnderecoEmail>()
                .Requires()
                .IsEmail(Email, "EnderecoEmail.Email", "O e-mail não é válido.")
            );
        }

        public string Email { get; private set; }
    }
}
