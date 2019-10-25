using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    class Inventario
    {
        private int existencias;
        private string disponible;
        public Inventario(int existencias)
        {
            this.existencias = existencias;
            SetDisponible();
        }
        public int GetExistencias() { return existencias; }
        public void SetExistencias(int num)
        {
            existencias = existencias - num;
            SetDisponible();
        }

        private void SetDisponible()
        {
            if (existencias == 0)
            {
                disponible = "\nNO ESTA DISPONIBLE ";
            }
            else disponible = "";
        }

        public string GetDisponible() { return disponible; }
    }
}
