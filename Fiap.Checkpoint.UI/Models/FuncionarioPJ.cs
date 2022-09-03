﻿using Fiap.Checkpoint.UI.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Checkpoint.UI.Models
{
    internal class FuncionarioPJ : Funcionario
    {
        public int Id { get; set; }
        public decimal ValorHora { get; set; }
        public int QtdHorasCadastrada { get; set; }
        public string CnpjDaEmpresa { get; set; }

        public FuncionarioPJ(string nome, GeneroEnum genero,int id, decimal valorHora,
            int qtdHorasCadastrada, string cnpjDaEmpresa) : base(nome, genero)
        {
            Id = id;
            ValorHora = valorHora;
            QtdHorasCadastrada = qtdHorasCadastrada;
            CnpjDaEmpresa = cnpjDaEmpresa;
        }
        public decimal CustoTotalMensalPJ()
        {
            return ValorHora * QtdHorasCadastrada;
        }
        public decimal CustoTotalMensalPJ(int horasExtras)
        {
            if(horasExtras < 0)
            {
                throw new ArgumentException("Horas extras nescessita ser maior de 0");
            }
            else
            {
                return (horasExtras + QtdHorasCadastrada) * ValorHora;
            }
        }
        public override string ExibirDados()
        {
            return $"Nome: {Nome}";
        }
        public override string ToString()
        {
            return base.ToString() + $", ID: {Id}, Valor por hora: {ValorHora}, " +
                $"Quantidade de horas cadastradas: {QtdHorasCadastrada}, CNPJ: {CnpjDaEmpresa}";
        }
    }
}