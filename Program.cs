using System;
using System.Linq;
using System.Collections.Generic;

namespace count_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            //string data = "gwvuv syrbk sjrwf yspsm akpki yhznw wkpbt kpboq rjlpe nejku sxteo ihufz lgsiu jlypa lgqin ubave hjxav mgoeu gddnp mdicm dynxu pkcyf plubt aotmi ymbtr yczgi eacns oklwp buvve naymc wrbgv yjdif fjcgp xcyxs pnlcx fgrjt jvuzh pcvqq zhgwq keuyd cwdam weptg uidvz pfoug uvmaq wuzho utbln arsoj nnwid bjfeu mnqmp mziej phacb nymoz uqbzr fdzjp gmshg ckvjs jyeik xfgyp";
            // string data = "abcabda";
            string data = "aabbccdeffff";         

            //Char count by char
            Dictionary<char, int> countByChar = new Dictionary<char, int>();

    	    //Iterar los caracteres uno por uno

            foreach (var caracter in data)
            {
                //Saltearse espacios vacíos
                if (caracter == ' ')
                {
                    continue;
                }
                //caracter es tipo char

                //1. Revisar si existe en el diccionario

                if (countByChar.ContainsKey(caracter)) {
                    //3. Consultar valor actual del diccionario

                    countByChar.TryGetValue(caracter, out int currentCount);

                    int nextCount = currentCount + 1;


                    //4. Registrar en diccionario

                    //4.1. Borrar registro actual
                    countByChar.Remove(caracter);

                    //4.2. Agregar valor
                    countByChar.Add(caracter, nextCount);
                } else {
                    //2. Agregar a diccionario con valor 1
                    countByChar.Add(caracter, 1);

                    //√ Terminamos esta iteración
                }
            }


            char highestRepeatedChar = ' ';
            int highestRepeatedCount = 0;

            char lessRepeatedChar = ' ';
            int lessRepeatedCount = countByChar.Count;

            foreach (var item in countByChar)
            {

                //item es de tipo KeyValuePair<char, int>

                //item.Key es la llave
                //item.Value es el valor

                if (item.Value < lessRepeatedCount) {
                    lessRepeatedChar = item.Key;
                    lessRepeatedCount = item.Value;
                }

                if (item.Value > highestRepeatedCount) {
                    highestRepeatedChar = item.Key;
                    highestRepeatedCount = item.Value;
                }
                

                System.Console.WriteLine($"{item.Key} -> {item.Value}");
            }

            System.Console.WriteLine($"Highest Count: {highestRepeatedChar} -> {highestRepeatedCount}");
            System.Console.WriteLine($"Lowest Count: {lessRepeatedChar} -> {lessRepeatedCount}");






        //     //For each char in data
        //     foreach (var c in data)
        //     {
        //         //TODO: Count chars!

        //         //Para obtener el conteo actual almacenado en el diccionario
        //         // if (countByChar.TryGetValue(c, out int currentCount)) {
        //             //currentCount tiene el valor actual
        //         // }

        //         //Para agregar algo que no existe al diccionario
        //         //countByChar.Add(caracter, cantidad);

        //         //Revisar si existe en el diccionario
        //         //countByChar.ContainsKey(caracter)

        //         //Para agregar si ya existía:
        //         //countByChar.Remove(caracter)
        //         //countByChar.Add(caracter, cantidad)

        //         //Solamente nos interesan aquellos caracteres que no sean espacio vacío
        //         // int count = 0;
        //         // if (c != ' ') {
        //         //     if (countByChar.ContainsKey(c)) {
        //         //         //Sumar +1 al conteo actual
        //         //         if (countByChar.TryGetValue(c, out int currentCount)) {
        //         //             //currentCount tiene el valor actual
        //         //             count = currentCount + 1;
        //         //         }
        //         //     } else {
        //         //         //Conteo es igual a 1
        //         //         count = 1;
        //         //     }
        //         // }

        //         //TODO: Actualizar el valor en el diccionario
        //         //Si ya existía un valor, remover y después agregar
        //         //Si no existía un valor, solamente agregar
        //     }

        //     //TODO: Imprimir diccionario
        }
    }
}
