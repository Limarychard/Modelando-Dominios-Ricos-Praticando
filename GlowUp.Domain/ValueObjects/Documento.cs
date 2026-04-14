using Flunt.Validations;
using GlowUp.Domain.Enums;
using GlowUp.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlowUp.Domain.ValueObjects
{
    public class Documento : ValueObject
    {
        public Documento(string numero, ETipoDocumento tipoDocumento = ETipoDocumento.CPF)
        {
            Numero = numero.Replace(".", "").Replace("-", "").Replace("/", "").Trim();
            TipoDocumento = tipoDocumento;
          
            AddNotifications(
                new Contract<Documento>()
                    .Requires()
                    .AreEquals(Numero.Length, 11, "Documento.Numero", "O número do documento deve conter 11 caracteres.")
                    .AreNotEquals(Numero, "00000000000", "Documento.Numero", "O número do documento inválido.")
                    .AreNotEquals(Numero, "11111111111", "Documento.Numero", "O número do documento inválido.")
                    .AreNotEquals(Numero, "22222222222", "Documento.Numero", "O número do documento inválido.")
                    .AreNotEquals(Numero, "33333333333", "Documento.Numero", "O número do documento inválido.")
                    .AreNotEquals(Numero, "44444444444", "Documento.Numero", "O número do documento inválido.")
                    .AreNotEquals(Numero, "55555555555", "Documento.Numero", "O número do documento inválido.")
                    .AreNotEquals(Numero, "66666666666", "Documento.Numero", "O número do documento inválido.")
                    .AreNotEquals(Numero, "77777777777", "Documento.Numero", "O número do documento inválido.")
                    .AreNotEquals(Numero, "88888888888", "Documento.Numero", "O número do documento inválido.")
                    .AreNotEquals(Numero, "99999999999", "Documento.Numero", "O número do documento inválido.")
                    .IsTrue(ValidaCPFeCNPJ(), "Documento.Numero", "O número do documento é inválido.")
            );
        }

        public string Numero { get; private set; }
        public ETipoDocumento TipoDocumento { get; private set; }

        private static bool ValidarCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf;
            string digito;

            int soma;
            int resto;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
                    
        }

        private static bool ValidarCNPJ(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma;
            int resto;

            string digito;
            string tempCnpj;

            tempCnpj = cnpj.Substring(0, 12);

            soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCnpj = tempCnpj + digito;

            soma = 0;

            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }

        private bool ValidaCPFeCNPJ()
        {
            if (TipoDocumento == ETipoDocumento.CPF && Numero.Length == 11)
                return ValidarCPF(Numero);

            if (TipoDocumento == ETipoDocumento.CNPJ && Numero.Length == 14)
                return ValidarCNPJ(Numero);

            return false;
        }
    }
}
