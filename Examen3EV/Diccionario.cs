using Examen3EV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen3EV
{
    // Clase que construye un diccionario de palabras a partir de dos frases
    // El dicionario estará ordenado alfabéticamente
    public class Diccionario
    {
        public List<String> palabras;
        public int conteoPalabras;

        public Diccionario()
        {
            palabras = new List<String>();
            conteoPalabras = 0;
        }

        // Método que analiza las frases
        // Primero comprueba que no son nulas o vacías
        // Después agrega las palabras al diccionario, omitiendo repeticiones
        // Códigos de error:
        // -1: la primera cadena no es válida
        // -2: la segunda cadena no es válida
        // 0: operación correcta
        //
        public string ERROR_CADENA_NO_VALIDA = "La cadena está vacía";
        /// <summary>
        /// Función que analiza dos frases introducidas por el usuarioque comprueba si son correctas y las devuelve ordenadas
        /// </summary>
        /// <param name="frase">Se corresponde con la  frase que le introducirá el usuario por formulario</param>
        /// <param name="fraseDos">Se corresponde con la segunda frase que le introducirá el usuario por formulario</param>
        /// <returns> Devolverá si es correcta o no</returns>
        /// <exception cref="Exception">Excepción que devuelve un error por cadena vacía o nula</exception>
        public int Analizar(String frase, String fraseDos)
        {
            String palabra;
            int posicionInexistente = -1;
            palabras.Clear();
            conteoPalabras = 0;
            // primer paso, analizar la primera cadena
 
            if (frase == null || frase.Length == 0) 
            {
                throw new Exception(ERROR_CADENA_NO_VALIDA);
            }


            int posicionInicial = 0;
            int posicionFinal = frase.IndexOf(' '); // encontramos el primer espacio

            while (posicionFinal != posicionInexistente) {
                palabra = frase.Substring(posicionInicial,posicionFinal-posicionInicial);
                if (palabra.Length>0 && !palabras.Contains(palabra)) {
                    palabras.Add(palabra);
                    conteoPalabras++;
                }
                posicionInicial = posicionFinal + 1;
                posicionFinal = frase.IndexOf(' ', posicionInicial);
            }
            // añadimos la última palabra
            palabra = frase.Substring(posicionInicial,frase.Length-posicionInicial);
            palabras.Add(palabra);
            conteoPalabras++;

            posicionInicial = 0;
            posicionFinal = fraseDos.IndexOf(' '); // encontramos el segundo espacio

            // segundo paso, analizar la segunda cadena
            ///<exception cref="Exception">La excepción se la lanzará si la frase dos es vacía o nula</exception>
            if (fraseDos == null || fraseDos.Length == 0)
            {
                throw new Exception(ERROR_CADENA_NO_VALIDA);
            }
            ///<summary>Mientras la posición final exista en la lista las irá colocando</summary>
            while (posicionFinal != posicionInexistente) {
                palabra = fraseDos.Substring(posicionInicial,posicionFinal-posicionInicial);
                if (palabra.Length > 0 && !palabras.Contains(palabra)) {
                    palabras.Add(palabra);
                    conteoPalabras++;
                }
                posicionInicial = posicionFinal + 1;
                posicionFinal = fraseDos.IndexOf(' ', posicionInicial);
            }
            // añadimos la última palabra
            palabra = fraseDos.Substring(posicionInicial, fraseDos.Length - posicionInicial);
            palabras.Add(palabra);
            conteoPalabras++;

            // tercer paso, Ordenar las palabras
            palabras.Sort();
            return 0;
        }
    }
}
