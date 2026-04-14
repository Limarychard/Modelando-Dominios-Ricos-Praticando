using GlowUp.Domain.Entities;
using GlowUp.Domain.Enums;
using GlowUp.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlowUp.Tests.Entities
{
    [TestClass]
    public class ClienteTests
    {
        private NomeSobrenome _nome = new NomeSobrenome("Rychard", "Lima");
        private Documento _documento = new Documento("80661170004");
        private Endereco _endereco = new Endereco("Rua Antonia", "604", "03728210", "São Paulo", "Jardins", "SP", null);
        private FichaTecnica _fichaTecnica = 
                new FichaTecnica(
                        ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Sim, 2, ENaoSim.Nao, ENaoSim.Nao, EFuncionamentoIntestinal.MaisDeQuatroSemana,
                        EQualidade.Regular, 6, 4, EQualidade.Boa, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Sim, 6, ENaoSim.Nao, null, null, ENaoSim.Nao, ENaoSim.Nao, 0, DateTime.Now.AddDays(-600), 
                        ENaoSim.Sim, ENaoSim.Sim, ENaoSim.Nao, null, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, 0, ENaoSim.Nao, ENivel.Medio, 
                        ENivel.Baixo, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, ENaoSim.Nao, null, ENaoSim.Nao, null, null, null
                );
        private EnderecoEmail _email = new EnderecoEmail("ry.lima2708@icloud.com");
        private Telefone _telefone = new Telefone(11, 987654321);

        [TestMethod]
        public void DeveRetornarErroQuandoNaoExistirFichaTecnica()
        {
            var cliente = new Clientes(_nome, _documento, _endereco, null, _telefone, DateTime.Parse("27/08/2004"), 18, EEstadoCivil.Solteiro, _email, "Garoto de programa", null);
            Assert.IsTrue(!cliente.IsValid);
        }

        [TestMethod]
        public void DeveRetornarErroQuandoIdadeNaoForCompativelComDataNascimento()
        {
            var cliente = new Clientes(_nome, _documento, _endereco, _fichaTecnica, _telefone, DateTime.Parse("27/08/2004"), 18, EEstadoCivil.Solteiro, _email, "Garoto de programa", null);
            Assert.IsTrue(!cliente.IsValid);
        }
    }
}
