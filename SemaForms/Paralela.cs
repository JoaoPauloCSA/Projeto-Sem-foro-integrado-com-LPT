using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices; // tem que colocar


namespace SemaForms
    {
        class Paralela
        {
            // Escreve um byte no endereço
            [DllImport("Inpout32.dll", EntryPoint = "Out32")]
            public static extern void Escrever(int endereco, byte valor);
        }
    }


