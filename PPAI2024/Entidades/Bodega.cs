using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2024.Entidades
{
    internal class Bodega
    {
        //atributos
        private string descripcion;
        private string historia;
        private string nombre;
        private string periodoActualizacion;
    

        //metodo constructor
        public Bodega(string nom, string hist, string descrip, string peract)
        {
            nombre = nom;
            historia = hist;
            descripcion = descrip;
            periodoActualizacion = peract;
        }
        

        //propiedades get set

        public string Descripcion { get { return descripcion; } set { descripcion = value; }}
        public string Historia { get { return historia; } set { historia = value; }}
        public string Nombre { get {  return nombre; } set {  nombre = value; }}
        public string PeriodoActualizacion { get { return periodoActualizacion; } set {  periodoActualizacion = value; }}

    }

}
