using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesafioFundamentos.Models;


namespace Tests
{
  [TestClass]
  public class EstacionamentoTest
  {
    [TestMethod]
    public void TestAddVeiculo()
    {
      decimal precoInicial = 2;
      decimal precoPorHora = 4;
      string placa = "ebx-2121";
      int horaEntrada = 2;

      Estacionamento estacionar = new Estacionamento(precoInicial,precoPorHora);

      Veiculo veiculo = estacionar.AdicionarVeiculo(placa,horaEntrada);

      Assert.AreEqual(placa,veiculo.Placa);


    }
  }
}