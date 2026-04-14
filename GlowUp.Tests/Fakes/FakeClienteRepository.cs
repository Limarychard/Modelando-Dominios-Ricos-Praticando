using GlowUp.Domain.Entities;
using GlowUp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlowUp.Tests.Fakes
{
    public class FakeClienteRepository : IClienteRepository
    {
        public void CriarCliente(Clientes cliente)
        {
        }

        public void CriarFichaTecnica(FichaTecnica fichaTecnica)
        {
        }

        public bool EmailExiste(string email)
        {
            if (email == "email@teste.com.br")
                return true;

            return false;
        }

        public bool ExisteCpf(string cpf)
        {
            if (cpf == "80661170004")
                return true;

            return false;
        }
    }
}
