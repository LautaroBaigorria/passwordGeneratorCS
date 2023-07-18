using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PasswordGenerator
    {
    static void Main(string[] args)
    {
        if (args.Length == 0)
	    {   
		Prompt();
		}
        else if (args.Length == 2 && args[0] == "-c")
        {
            int intcantCaracteres = Convert.ToInt32(args[1]);
            GeneratePassword(intcantCaracteres,true,true,true);
        }
        else
        {
            Console.WriteLine("Argumentos invalidos");
        } 
        
    }
    
    static void GeneratePassword(int intcantCaracteres, bool bCaps, bool bCharEsp, bool bNums)
    {
        // Console.WriteLine("metodo GeneratePassword");
        // Console.WriteLine("{0} - {1} - {2} - {3}", intcantCaracteres,bCaps.ToString(),bCharEsp.ToString(),bNums.ToString() );
        List<string> listachar = new List<string>();

        string[] listacharDn = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        for (int i = 0; i < listacharDn.Length; i++)
        {
            listachar.Add(listacharDn[i]);
        };

        string[] listacharUp = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        string[] listespchar = {"~", "`", "!", "@", "#", "$", "%", "^", "&", "*","(", ")", "-", "_", "+", "=", "{", "}", "[", "]", "|", "/", ":", ";", ",", "<", ">", ".", "?"};
        string[] numeros = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0"};
        if (bCaps == true)
        {
            for (int i = 0; i < listacharUp.Length; i++)
            {
            listachar.Add(listacharUp[i]);
            };
        }
        if (bCharEsp == true)
        {
            for (int i = 0; i < listespchar.Length; i++)
            {
            listachar.Add(listespchar[i]);
            };
        }
        if (bNums == true)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
            listachar.Add(numeros[i]);
            };
        }
        List<string> contrasena = new List<string>();

        for (int i = 0; i < intcantCaracteres; i++)
        {
            var random = new Random();
            int index = random.Next(listachar.Count);
            contrasena.Add(listachar[index]);
        };

        for (int i = 0; i < contrasena.Count; i++)
        {
            Console.Write(contrasena[i]);
            if (i < contrasena.Count -1){Console.Write(""); }
        } 
        Console.WriteLine("");
    }
    
    static void Prompt() 
    {
        Console.WriteLine("Ingrese cantidad de caracteres");
        string cantCaracteres = Console.ReadLine();
        int intcantCaracteres = Convert.ToInt32(cantCaracteres);
        Console.WriteLine("incluir mayusculas? (s/n)");
        string incluyeMayus = Console.ReadLine();
        Console.WriteLine("Incluir caracteres especiales? (s/n) ");
        string incluyeCharEsp = Console.ReadLine();
        Console.WriteLine("Incluir numeros? (s/n) ");
        string incluyeNum = Console.ReadLine();
        bool bCaps = false, bCharEsp = false, bNums = false;

        if (incluyeMayus == "s")
        {
            bCaps = true;
        }
        else if (incluyeMayus == "n")
        {
            bCaps = false;
        }

        if (incluyeCharEsp == "s")
        {
            bCharEsp = true;
        }
        else if (incluyeCharEsp == "n")
        {
            bCharEsp = false;
        }

        if (incluyeNum == "s")
        {
            bNums = true;
        }
        else if (incluyeNum == "n")
        {
            bNums = false;
        }
        GeneratePassword(intcantCaracteres,bCaps,bCharEsp,bNums);

    }

    }
    
}