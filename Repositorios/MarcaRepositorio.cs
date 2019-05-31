using System.Collections.Generic;
using System.IO;
using Ex.Estacionamento.Models;

namespace Ex.Estacionamento.Repositorios
{
    public class MarcaRepositorio
    {
        private const string PATH = "Database/Marcas.csv";

        private List<MarcaModel> listaDeMarcas = new List<MarcaModel>();

        public List<MarcaModel> ListarMarcas(){

            string[] marcas = File.ReadAllLines(PATH);
            
            foreach (var item in marcas)
            {
                if(item != null){
                    string[] dados = item.Split(";");
                    var marca = new MarcaModel();
                    marca.Id = int.Parse(dados[0]);
                    marca.Nome = dados[1];
                    
                    listaDeMarcas.Add(marca);
                }//fim if
            }// fim foreach
            return listaDeMarcas;
        }
    }
}