using Ex.Estacionamento.Models;
using Ex.Estacionamento.Repositorios;
using Ex.Estacionamento.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ex.Estacionamento.Controllers
{
    public class HomeController : Controller
    {
        ModeloRepositorio modeloRepositorio = new ModeloRepositorio();
        MarcaRepositorio marcaRepositorio = new MarcaRepositorio();
        RegistroRepositorio registroRepositorio = new RegistroRepositorio();
        [HttpGet]
        public IActionResult Index(){
            var listaDeModelos = modeloRepositorio.ListarModelos();
            var listaDeMarcas = marcaRepositorio.ListarMarcas();

            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.Modelos = listaDeModelos;
            homeViewModel.Marcas = listaDeMarcas;

            return View(homeViewModel);
        }
        [HttpPost]
        public IActionResult RegistrarEntrada(IFormCollection form){
            RegistroModel registro = new RegistroModel();
            registro.Nome = form["nome"];

            var modelo = new ModeloModel();
            modelo.Nome = form["modelo"];

            registro.Modelo = modelo;

            MarcaModel marca = new MarcaModel();
            marca.Nome = form["marca"];

            registro.Marca = marca;

            registro.Placa = form["placa"];

            registroRepositorio.RegistrarNoCSV(registro);

            return RedirectToAction("Index","Home");
        } 
    }
}