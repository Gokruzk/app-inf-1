using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppArray
{
    internal class ClArray
    {
        int[] array;
        int sz = 0;
        int min = 0;
        int posMin = 0;

        public ClArray(int[] v, int sz)
        {
            array = v;
            this.sz = sz;
        }

        public int GetMin()
        {
            return min;
        }

        private void SetMin(int n)
        {
            min = n;
        }

        private void SetPosMin(int n)
        {
            posMin = n;
        }

        public int GetPosMin()
        {
            return posMin;
        }

        public void FindMin()
        {
            SetMin(array[0]);
            for (int i = 0; i < sz; i++)
            {
                if (array[i] < GetMin())
                {
                    SetMin(array[i]);
                    SetPosMin(i);
                }
            }
            //SetPosMin(BuscarElemento(GetMin()));
        }

        private void Loop(ref int j, int[] a, int aux)
        {
            if (j >= 0 && array[j] < aux)
            {
                array[j + 1] = array[j];
                j -= 1;
                Loop(ref j, a, aux);
            }
        }

        public void SortDesc() // funcion para ordernar descendentemente por el método de inserción
        {
            for (int i = 1; i < sz; i++)
            {
                int aux = array[i];
                int j = i - 1;
                Loop(ref j, array, aux);
                array[j + 1] = aux;
            }
        }
        public int BuscarElemento(int x)
        {
            for (int i = 0; i < sz; i++)
            {
                if (array[i] == x)
                {
                    return i;
                }
            }
            return -1; // devolver posicion inexistente para indicar no presencia de valor

        }
        public void DeleteMin(ref int n)
        {
            for (int i = GetPosMin(); i < n; i++) // ciclo recorrido de valores
            {
                if (i < n - 1)
                {
                    array[i] = array[i + 1];
                }
            }
            n -= 1;
        }
    }
}
