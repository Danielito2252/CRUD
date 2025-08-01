using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoDatos.Entidades;
using Comun.Atributos;

namespace Dominio.Crud
{
    public class CPersonas
    {
        Persona persona = new Persona();

        public DataTable Mostrar()
        {
            DataTable td = new DataTable();
            td = persona.Mostrar();
            return td;
        } 

        public void Insertar(AtributosPersonas obj)
        {
            persona.Insertar (obj); 
        }

    }
}
