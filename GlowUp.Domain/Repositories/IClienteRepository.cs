using GlowUp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlowUp.Domain.Repositories
{
    public interface IClienteRepository
    {
        bool ExisteCpf(string cpf);
        bool EmailExiste(string email);
        void CriarCliente(Clientes cliente);
        void CriarFichaTecnica(FichaTecnica fichaTecnica);
    }
}
