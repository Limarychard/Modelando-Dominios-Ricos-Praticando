using GlowUp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GlowUp.Domain.Queries
{
    public static class ClienteQueries
    {
        public static Expression<Func<Clientes, bool>> GetByEmail(string email)
        {
            return x => x.Email.Email == email;
        }

        public static Expression<Func<Clientes, bool>> GetByCpf(string cpf)
        {
            return x => x.Documento.Numero == cpf;
        }   
    }
}
