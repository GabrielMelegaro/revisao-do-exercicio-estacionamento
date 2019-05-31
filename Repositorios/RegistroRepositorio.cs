using System;
using System.IO;
using Ex.Estacionamento.Models;

namespace Ex.Estacionamento.Repositorios
{
    public class RegistroRepositorio
    {
        private const string PATH = "Database/Registros.csv";
        public void RegistrarNoCSV(RegistroModel registro){
            if(File.Exists(PATH)){
                registro.Id = File.ReadAllLines(PATH).Length + 1;
            }else{
                registro.Id = 1;
            }
            StreamWriter sw = new StreamWriter(PATH, true);

            sw.WriteLine($"{registro.Id};{registro.Nome};{registro.Marca.Nome};{registro.Modelo};{registro.Placa};{DateTime.Now}");
            sw.Close();
        }
    }
}