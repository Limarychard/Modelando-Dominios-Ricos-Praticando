using Flunt.Notifications;
using GlowUp.Domain.Commands;
using GlowUp.Domain.Entities;
using GlowUp.Domain.Enums;
using GlowUp.Domain.Repositories;
using GlowUp.Domain.Services;
using GlowUp.Domain.ValueObjects;
using GlowUp.Shared.Commands;
using GlowUp.Shared.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlowUp.Domain.Handlers
{
    public class ClienteHandler : Notifiable<Notification>, IHandler<CriarClienteComFichaTecnicaCommand>
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailService _emailService;

        public ClienteHandler(IClienteRepository clienteRepository,
            IEmailService emailService)
        {
            _clienteRepository = clienteRepository;
            _emailService = emailService;
        }

        public ICommandResult Handle(CriarClienteComFichaTecnicaCommand command)
        {
            // Fail Fast Validations

            command.Validate();

            if (!command.IsValid)
            {
                AddNotifications(command);
                return new CommandResult(false, "Não foi possível realizar o cadastros");
            }
                
            // Verificar se o cpf já existe
             bool existeCpf = _clienteRepository.ExisteCpf(command.NumeroDocumento);

            // Verificar se o email já existe
            bool existeEmail = _clienteRepository.EmailExiste(command.Email);

            if (existeCpf || existeEmail)
            {
                AddNotification("Cliente", "CPF ou Email já cadastrado");
                return new CommandResult(false, "Já existe um cadastro.");
            }
                

            // Gerar os VOs
            var nome = new NomeSobrenome(command.Nome, command.Sobrenome);
            var documento = new Documento(command.NumeroDocumento);
            var endereco = new Endereco(command.Rua, command.NumeroEndereco, command.CEP, command.Cidade, command.Bairro, command.Estado, null);
            var email = new EnderecoEmail(command.Email);
            var telefone = new Telefone(command.DDD, command.Numero);

            // Gerar as Entidades
            var fichaTecnica = new FichaTecnica(
                    ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Sim, 2, ENaoSim.Nao, ENaoSim.Nao, EFuncionamentoIntestinal.MaisDeQuatroSemana,
                    EQualidade.Regular, 6, 4, EQualidade.Boa, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Sim, 6, ENaoSim.Nao, null, null, ENaoSim.Nao, ENaoSim.Nao, 0, DateTime.Now.AddDays(-600),
                    ENaoSim.Sim, ENaoSim.Sim, ENaoSim.Nao, null, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, ENaoSim.Nao, 0, ENaoSim.Nao, ENivel.Medio,
                    ENivel.Baixo, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, null, ENaoSim.Nao, ENaoSim.Nao, null, ENaoSim.Nao, null, null, null
            );

            var cliente = new Clientes(nome, documento, endereco, fichaTecnica, telefone, DateTime.Now.AddYears(-18), 18, EEstadoCivil.Solteiro, email, "Garoto de programa", null);

            // Relacionamentos
            //---------------

            // Aplicar validações
            AddNotifications(nome, documento, email, endereco, telefone, fichaTecnica);

            if (!cliente.IsValid)
                return new CommandResult(false, "Não foi possível realizar o cadastro do cliente");

            // Salvar as informações
            _clienteRepository.CriarCliente(cliente);
            _clienteRepository.CriarFichaTecnica(fichaTecnica);

            // Enviar email para administrador
            _emailService.Send(cliente.Nome.NomeCompleto, "admin@gmail.com", "Novo Cliente", "Foi criado um novo cliente com uma ficha técnica preenchida");

            // Retornar resultado
            return new CommandResult(true, "Formulário enviado para");

        }
    }
}
