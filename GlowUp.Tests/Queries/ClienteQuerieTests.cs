using GlowUp.Domain.Entities;
using GlowUp.Domain.Enums;
using GlowUp.Domain.Queries;
using GlowUp.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlowUp.Tests.Queries
{
    [TestClass]
    public class ClienteQuerieTests
    {
        private IList<Clientes> _clientes;

        public ClienteQuerieTests()
        {
            _clientes = new List<Clientes>();

            _clientes.Add(new Clientes (new NomeSobrenome("Rychard", "Lima"), new Documento("06748788099"), new Endereco("rua", "123", "01228101", "São Paulo", "SEI LA", "SP", null), new FichaTecnica(ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Sim, 2, ENaoSim.Nao, ENaoSim.Nao, EFuncionamentoIntestinal.MaisDeQuatroSemana, EQualidade.Regular, 6, 4, EQualidade.Boa, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Sim, 6, ENaoSim.Nao, null, null, ENaoSim.Nao, ENaoSim.Nao, 0, DateTime.Now.AddDays(-600), ENaoSim.Sim, ENaoSim.Sim, ENaoSim.Nao, null, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, 0, ENaoSim.Nao, ENivel.Medio, ENivel.Baixo, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, ENaoSim.Nao, null, ENaoSim.Nao, null, null, null), new Telefone(11, 980382794), DateTime.Now, 1, EEstadoCivil.Solteiro, new EnderecoEmail("ryc@gmail.com"), "Garoto de programa", null));
            _clientes.Add(new Clientes (new NomeSobrenome("Rychard", "Lima"), new Documento("31686209045"), new Endereco("rua", "123", "01228101", "São Paulo", "SEI LA", "SP", null), new FichaTecnica(ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Sim, 2, ENaoSim.Nao, ENaoSim.Nao, EFuncionamentoIntestinal.MaisDeQuatroSemana, EQualidade.Regular, 6, 4, EQualidade.Boa, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Sim, 6, ENaoSim.Nao, null, null, ENaoSim.Nao, ENaoSim.Nao, 0, DateTime.Now.AddDays(-600), ENaoSim.Sim, ENaoSim.Sim, ENaoSim.Nao, null, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, 0, ENaoSim.Nao, ENivel.Medio, ENivel.Baixo, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, ENaoSim.Nao, null, ENaoSim.Nao, null, null, null), new Telefone(11, 980382794), DateTime.Now, 1, EEstadoCivil.Solteiro, new EnderecoEmail("ryc@outlook.com"), "Garoto de programa", null));
            _clientes.Add(new Clientes (new NomeSobrenome("Rychard", "Lima"), new Documento("91020554061"), new Endereco("rua", "123", "01228101", "São Paulo", "SEI LA", "SP", null), new FichaTecnica(ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Sim, 2, ENaoSim.Nao, ENaoSim.Nao, EFuncionamentoIntestinal.MaisDeQuatroSemana, EQualidade.Regular, 6, 4, EQualidade.Boa, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Sim, 6, ENaoSim.Nao, null, null, ENaoSim.Nao, ENaoSim.Nao, 0, DateTime.Now.AddDays(-600), ENaoSim.Sim, ENaoSim.Sim, ENaoSim.Nao, null, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, 0, ENaoSim.Nao, ENivel.Medio, ENivel.Baixo, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, ENaoSim.Nao, null, ENaoSim.Nao, null, null, null), new Telefone(11, 980382794), DateTime.Now, 1, EEstadoCivil.Solteiro, new EnderecoEmail("ryc@icloud.com"), "Garoto de programa", null));
            _clientes.Add(new Clientes (new NomeSobrenome("Rychard", "Lima"), new Documento("94113788030"), new Endereco("rua", "123", "01228101", "São Paulo", "SEI LA", "SP", null), new FichaTecnica(ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Sim, 2, ENaoSim.Nao, ENaoSim.Nao, EFuncionamentoIntestinal.MaisDeQuatroSemana, EQualidade.Regular, 6, 4, EQualidade.Boa, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Sim, 6, ENaoSim.Nao, null, null, ENaoSim.Nao, ENaoSim.Nao, 0, DateTime.Now.AddDays(-600), ENaoSim.Sim, ENaoSim.Sim, ENaoSim.Nao, null, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, 0, ENaoSim.Nao, ENivel.Medio, ENivel.Baixo, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, ENaoSim.Nao, null, ENaoSim.Nao, null, null, null), new Telefone(11, 980382794), DateTime.Now, 1, EEstadoCivil.Solteiro, new EnderecoEmail("ryc@teste.com"), "Garoto de programa", null));
            _clientes.Add(new Clientes (new NomeSobrenome("Rychard", "Lima"), new Documento("18958083085"), new Endereco("rua", "123", "01228101", "São Paulo", "SEI LA", "SP", null), new FichaTecnica(ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Sim, 2, ENaoSim.Nao, ENaoSim.Nao, EFuncionamentoIntestinal.MaisDeQuatroSemana, EQualidade.Regular, 6, 4, EQualidade.Boa, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Sim, 6, ENaoSim.Nao, null, null, ENaoSim.Nao, ENaoSim.Nao, 0, DateTime.Now.AddDays(-600), ENaoSim.Sim, ENaoSim.Sim, ENaoSim.Nao, null, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, 0, ENaoSim.Nao, ENivel.Medio, ENivel.Baixo, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, ENaoSim.Nao, null, ENaoSim.Nao, null, null, null), new Telefone(11, 980382794), DateTime.Now, 1, EEstadoCivil.Solteiro, new EnderecoEmail("ryc@glowup.com"), "Garoto de programa", null));
            _clientes.Add(new Clientes (new NomeSobrenome("Rychard", "Lima"), new Documento("66379374019"), new Endereco("rua", "123", "01228101", "São Paulo", "SEI LA", "SP", null), new FichaTecnica(ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Sim, 2, ENaoSim.Nao, ENaoSim.Nao, EFuncionamentoIntestinal.MaisDeQuatroSemana, EQualidade.Regular, 6, 4, EQualidade.Boa, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Sim, 6, ENaoSim.Nao, null, null, ENaoSim.Nao, ENaoSim.Nao, 0, DateTime.Now.AddDays(-600), ENaoSim.Sim, ENaoSim.Sim, ENaoSim.Nao, null, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, 0, ENaoSim.Nao, ENivel.Medio, ENivel.Baixo, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, ENaoSim.Nao, null, ENaoSim.Nao, null, null, null), new Telefone(11, 980382794), DateTime.Now, 1, EEstadoCivil.Solteiro, new EnderecoEmail("ryc@email.com"), "Garoto de programa", null));
        }

        [TestMethod]
        public void DeveRetornarNuloQuandoCpfNaoExistir()
        {
            var exp = ClienteQueries.GetByCpf("11122233344");
            var cliente = _clientes.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreEqual(null, cliente);
        }

        [TestMethod]
        public void DeveRetornarNuloQuandoEmailNaoExistir()
        {
            var exp = ClienteQueries.GetByCpf("email@email.com");
            var cliente = _clientes.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreEqual(null, cliente);
        }
    }
}
