using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoDatos.Entidades;
using Comun.Atributos;
using System.Security.Policy;

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

        public DataTable Buscar(string Buscar)
        {
            DataTable td = new DataTable();
            td = persona.Buscar(Buscar);    
            return td;
        }

        public void Insertar(AtributosPersonas obj)
        {
            persona.Insertar (obj); 
        }

        public void Modificar(AtributosPersonas obj)
        {
            persona.Modificar(obj);
        }
        public void Eliminar(AtributosPersonas obj)
        {
            persona.Eliminar(obj);
        }
    }
}
