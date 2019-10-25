using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    class Envio
    {
        private Carrito pedido;
        private string nombreCuenta;
        private string domicilio;
        private int telefono;
        private string nombreRecibe;
        private string correoContacto;

        public Envio(Carrito pedido, string nombreCuenta, string domicilio, int telefono, string nombreRecibe, string correoContacto)
        {
            this.pedido = pedido;
            this.nombreCuenta = nombreCuenta;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.nombreRecibe = nombreRecibe;
            this.correoContacto = correoContacto;
        }

        public override string ToString()
        {
            string cad = "";
            // cad = pedido.MostrarProductos();
            cad = "Nombre:" + nombreCuenta + "\n";
            cad = "Domicilio:" + domicilio + "\n";
            cad = "Telefono de contacto:" + telefono + "\n";
            cad = "Persona que recibe:" + nombreRecibe + "\n";
            cad = "Correo de contacto:" + correoContacto + "\n";
            return cad;
        }
    }
}
