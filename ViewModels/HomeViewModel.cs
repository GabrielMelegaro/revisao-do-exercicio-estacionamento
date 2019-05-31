using System.Collections.Generic;
using Ex.Estacionamento.Models;

namespace Ex.Estacionamento.ViewModels
{
    public class HomeViewModel
    {
        public List<ModeloModel> Modelos{get;set;}

        public List<MarcaModel> Marcas{get;set;}
    }
}