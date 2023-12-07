using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AppRevisionliteratura
{
    public partial class FrmLiteratura : Form
    {
        string[] Sustantivos;
        string[] Adverbios;
        string[] Verbos;
        string[] Adjetivos;
        string[] AdverbiosNegativos;
        string[] Pronombres;
        string[] Articulos;
        string[] Conjunciones;
        List<string> componentesOraciones = new List<string>();
        List<string> listaOracionesMayus;
        List<string> listaOracionesMayusDelimitadores;
        List<List<Token>> listComponentesLexicos;
        List<string> listaReglas;
        List<string> componentesLexicos = new List<string>();
        string[] oraciones;

        string[] listaSeparada;
        string cadena;
        Regex regexNombres;
        //Literales
        Regex regexliterales;
        //Operadores
        Regex regexOperadores;
        //Delimitadores
        Regex regexDelimitadores;

        Regex adverbiosNegativos;

        Regex regexOracionesInterrogativas;
        Regex regexOracionesExclamativas;



        public FrmLiteratura()
        {
            InitializeComponent();
            this.CenterToScreen();
            Articulos = new string[] { "la", "el", "los", "las", "un", "una", "unos", "unas" };

            Pronombres = new string[] { "yo", "tú", "él", "ella","ellos","ellas", "nosotros", "vosotros", "ellos", "ellas", "ustedes",
            "este", "ese", "aquel", "estos", "esos", "aquellos", "esta", "esa", "aquella", "estas", "esas", "aquellas", "esto", "eso", "aquello"};

            Conjunciones = new string[] { "y", "e", "ni", "tanto", "como", "ni", "igual", "que",
            "pero", "sin embargo", "no obstante", "sino", "o", "O", "u",
            "bien", "ya que", "por lo tanto", "entonces", "así que",
            "por eso", "porque", "pues", "aunque", "si bien",
            "mientras que", "antes", "después", "además", "incluso",
            "además de", "a pesar de", "con tal de que", "para que","en", "a","también"};

            Sustantivos = new string[] { "abuela", "lobo", "leñador", "vecinos","caperucita", "aldeanos", "árboles", "arbustos", "hojas", "rocas", "riachuelo",
          "capa", "canasta", "cuchillo", "mochila", "sombrero", "caja", "cabaña", "puente", "senda", "prado", "pueblo", "torre",
          "sonrisa", "mirada", "cejas", "rostro", "ojos", "manos", "pies", "piel", "cabeza", "brazos", "luna", "estrellas",
          "sombras", "silencio", "brisa", "flores", "joyas", "encaje", "diadema", "broche", "pastel", "miel", "pan", "mermelada",
          "sopa", "alegría", "temor", "asombro", "expectación", "gratitud", "abuelita", "niña", "casa", "pinos", "lago", "gorro",
          "moño", "cobija", "mallas", "babero", "mandil", "mantel", "arbustos", "tejado", "puerta", "cielo", "enigma", "candado",
          "clave", "eco", "suspense", "susurro", "huella", "túnel", "rescate", "deseo", "espina", "hechizo", "misterio",
          "tormenta", "hechicero", "destino", "suspiro", "secreto", "promesa", "despertar", "campana", "piedra", "leyenda",
          "revelación", "sendero", "adivinanza", "espejismo", "camuflaje", "resplandor", "poción", "portal", "refugio",
          "oráculo", "encrucijada", "máscara", "pasadizo", "ocaso", "bóveda", "visión", "calabaza", "ruina", "lamento",
          "trampa", "encanto", "antorcha", "princesa", "embrujo", "cosecha", "cántico", "criatura", "estirpe", "velo", "aroma",
          "canto", "travesía", "edén", "cometa", "señal", "alcoba", "maravilla", "espejo", "jardín", "quimera", "llave",
          "suspiro", "hojarasca", "guirnalda", "confusión", "juramento", "caricia", "ascuas", "tronco", "risueño", "ceniza",
          "pasión", "vértigo", "eco", "senda", "rayo", "brújula", "ruiseñor", "manantial", "caballero", "reliquia", "abrigo",
          "melodía", "piedra", "roble", "orquídea", "acróbata", "galaxia", "cenit", "bisonte", "aurora", "velada", "esfera",
          "acantilado", "crepúsculo", "canto", "orilla", "candil", "despertar", "luz", "quimera", "lamento", "torreón",
          "desvelo", "serenata", "arcadia", "murmullo", "risa", "ecuación", "serenidad", "bohemia", "soledad", "encuentro",
          "adagio", "poesía", "delirio", "susurro", "capricho", "conjuro", "invierno", "otoño", "travesía", "alquimia",
          "confidencia", "dulzura", "paisaje", "peregrino", "danza", "sueño", "baluarte", "abismo", "fragancia", "quijote",
          "ascua", "alféizar", "ímpetu", "antorcha", "pradera", "candado", "mirador", "trébol", "amaranto", "selva", "escenario",
          "primavera", "verano", "invierno", "otoño", "velo", "espejismo", "marfil", "selene", "simetría", "sinfonía", "serenata",
          "rumor", "silueta", "refugio", "canto", "paisaje", "delirio", "galaxia", "bisonte", "esmeralda", "sombra", "despedida",
          "retorno", "ceniza", "suspiro", "alba", "espejismo", "sinfonía", "camino", "eco", "libro", "página", "caligrafía",
          "conjuro", "desvanecimiento", "pétalo", "candor", "rumor", "lamento", "antorcha", "atmósfera", "rocío", "sendero",
          "embrujo", "galanteo", "silencio", "arpegio", "crepúsculo", "ventana", "sueño", "bosque", "desvelo", "encuentro",
          "hechicero", "romance", "corazón", "rocío", "maravilla", "encrucijada", "luz", "murmullo", "estrella", "bruma",
          "trébol", "susurro", "silueta", "calidez", "enigma", "pétalo", "paz", "caricia", "cometa", "emoción", "refugio",
          "pasión", "encanto", "paraje", "edén", "rincón", "hojarasca", "huella", "lamento", "deseo", "ascuas", "visión",
          "rincón", "canto", "velo", "arcadia", "fragancia", "conjuro", "hechizo", "sendero", "adivinanza", "misterio",
          "mirador", "travesía", "efímero", "revelación", "espejismo", "marfil", "silueta", "destello", "refugio", "esencia",
          "pasión", "calidez", "amuleto", "resplandor","encrucijada", "añoranza", "melodía", "caricia", "bosque", "rumor", "emoción", "conjuro", "hechizo", "travesía",
          "sinfonía", "canto", "anochecer", "rincón", "velada", "alba", "susurro", "encuentro", "espejismo", "travesía", "caricia",
          "pétalo", "candor", "resplandor", "destino", "paraje", "encrucijada", "sendero", "rocío", "encanto", "bóveda", "hechizo",
          "esencia", "sendero", "resplandor", "crepúsculo", "estrofa", "caricia", "encuentro", "edén", "rincón", "conjuro", "arcadia",
          "velo", "sueño", "emoción", "suspiro", "destino", "encanto", "rincón", "bóveda", "resplandor", "sueño", "hechizo", "sendero",
          "susurro", "canto", "alba", "espejismo", "caricia", "conjuro", "encrucijada", "velada", "fragancia", "destino", "rumor",
          "encanto", "resplandor", "arpegio", "espejismo", "destino", "caricia", "encuentro", "bóveda", "hechizo", "susurro", "velada",
          "paraje", "encanto", "fragancia", "calidez", "suspiro", "canto", "arcadia", "espejismo", "sendero", "resplandor", "rumor",
          "estrofa", "aroma", "hechizo", "destino", "sueño", "alba", "paraje", "bóveda", "resplandor", "rumor", "encanto", "canto",
          "espejismo", "destino", "velada", "susurro", "arcadia", "caricia", "encanto", "calidez", "resplandor", "susurro", "sueño",
          "alba", "bóveda", "fragancia", "destino", "canto", "rumor", "hechizo", "velada", "aroma", "resplandor", "susurro", "arcadia",
          "paraje", "caricia", "encanto", "rumor", "espejismo", "estrofa", "bóveda", "sueño", "velada", "susurro", "destino", "rumor","comida",
          "resplandor", "arpegio", "hambre","alimento","alimentos"};

            Adjetivos = new string[] { "colorido", "caprichoso", "infantil", "juguetón", "alegre", "soleado",
          "pacífico", "pintoresco", "rural", "idílico", "agradable", "encantador", "bucólico", "relajante",
          "tranquilo", "nostálgico", "romántico", "pastoral", "divertida", "caricaturesca", "festivo", "vibrante",
          "animado", "sereno", "jubiloso", "acogedor", "exuberante", "armonioso", "resplandeciente", "sugestivo",
          "radiante", "plácido", "sosegado", "risueño", "paradisíaco", "feroz", "valiente", "asustando", "asustadas",
          "mucho", "muchas", "poco", "poquito", "azul", "majestuoso", "apacible", "fascinante", "deslumbrante",
          "aventurero", "sereno", "mágico", "atractivo", "sugestivo", "hermoso", "impresionante", "divino",
          "espléndido", "encantador", "soñador", "maravilloso", "deslumbrante", "deslumbrador", "eufórico",
          "intrigante", "sofisticado", "cautivador", "glamoroso", "elegante", "espectacular", "dramático", "radiante",
          "moderno", "clásico", "vintage", "fresco", "vivo", "intrépido", "glorioso", "legendario", "sosegado",
          "silencioso", "efervescente", "sutil", "singular", "poderoso", "fascinante", "hipnótico", "esotérico",
          "deslumbrador", "místico", "fabuloso", "genuino", "imponente", "misterioso", "pintoresco", "sublime",
          "majestuoso", "soberbio", "precioso", "delicioso", "eufórico", "angelical", "centelleante", "iridiscente",
          "divertido", "vibrante", "deslumbrante", "espectacular", "emocionante", "impresionante", "deslumbrante",
          "etéreo", "cálido", "eterno", "extraordinario", "fantástico", "surrealista", "intrépido", "céfiro",
          "luminoso", "lúdico", "efervescente", "volátil", "sereno", "divino", "excelente", "exquisito", "exótico",
          "extático", "fastuoso", "fascinante", "fenomenal", "festivo", "flamante", "florido", "fuerte", "fulgurante",
          "fulguroso", "fúlgido", "genuino", "glamoroso", "glorioso", "grandioso", "grácil", "grato", "hilariante",
          "híper", "ideal", "ídolo", "ilustre", "inigualable", "inmaculado", "iridiscente", "joya", "jovial", "jubiloso",
          "juguetón", "lindo", "luminoso", "lúdico", "lustroso", "majestuoso", "maravilloso", "mágico", "meticuloso",
          "mítico", "moderno", "momento", "multicolor", "natural", "noble", "nostálgico", "notable", "novedoso", "nubil",
          "nuevo", "numinoso", "oasis", "ocasión", "óptimo", "opulento", "oscilante", "ostentoso", "paradisiaco",
          "paz", "pintoresco", "plácido", "precioso", "primaveral", "prístino", "radiante", "refinado", "relajante",
          "resplandeciente", "revigorizante", "rico", "sagrado", "seductor", "sereno", "sincero", "sin igual", "soberbio",
          "solemne", "sublime", "suntuoso", "superlativo", "supremo", "teatral", "tesoro", "tintineante", "tranquilo",
          "trascendental", "único", "venturoso", "vibrante", "vívido", "volátil", "voluptuoso", "zen", "hambriento", "muchas","muchos","mucha"};

            Adverbios = new string[] { "rápidamente", "sigilosamente", "astutamente",
            "dulcemente", "cautamente", "gentilmente", "bruscamente", "hábilmente",
            "furiosamente", "ingenuamente","temprano", "pronto", "nunca", "siempre",
            "lentamente", "velozmente", "despacio", "urgentemente", "sorpresivamente",
            "furtivamente","lejos", "profundamente", "aquí", "allí", "cerca",
            "adentro", "afuera", "mansamente", "tiernamente", "furtivamente","tranquilamente",
            "tiene","jamás","nada","no","tampoco","nunca", "jamás", "tampoco", "jamas", "ninguna vez",
            "ningún día", "ningún momento", "ningún lugar", "ningún modo", "ningún caso",
            "ningún modo", "nunca más", "nunca jamás", "ningún tanto", "en absoluto",
            "en ningún caso", "de ningún modo", "de ninguna manera", "en ninguna parte",
            "en ningún momento", "en ningún sentido", "en ninguna circunstancia",
            "en ninguna medida", "en ningún evento", "en ninguna situación"};

            AdverbiosNegativos = new string[] { "no", "nunca" };
            Verbos = new string[] { "ir", "encontrar", "hablar", "comer", "llegar", "abrir",
             "correr", "salvar", "asustar", "ver", "vestir", "dormir", "engañar",
             "caminar", "preguntar", "recoger", "llevar", "llamar", "poner", "decir", "come","camina","salva","encuentra,","llega",
             "abre","pregunta","asusta","va","ve","vemos","lleva", "llevas"};

            richTextBox1.KeyDown += RichTextBox1_KeyDown;


        }
        #region Comprobadores
        private bool EsArticulo(String cadena)
        {
            return Articulos.Contains(cadena.ToLower());
        }
        private bool EsPronombre(String cadena)
        {
            return Pronombres.Contains(cadena.ToLower());
        }
        private bool EsConjuncion(String cadena)
        {
            return Conjunciones.Contains(cadena.ToLower());
        }
        private bool EsSustantivo(String cadena)
        {
            return Sustantivos.Contains(cadena.ToLower());
        }
        private bool EsAdjetivo(String cadena)
        {
            return Adjetivos.Contains(cadena.ToLower());
        }
        private bool EsAdverbio(String cadena)
        {
            return Adverbios.Contains(cadena.ToLower());
        }
        private bool EsVerbo(String cadena)
        {
            return Verbos.Contains(cadena.ToLower());
        }

        private bool esNombrePropio(String cadena)
        {
            return regexNombres.IsMatch(cadena);
        }
        private bool esliteralNumeroEntero(String cadena)
        {
            return regexliterales.IsMatch(cadena);
        }
        private bool esOperador(String cadena)
        {
            return regexOperadores.IsMatch(cadena);
        }
        private bool esDelimitador(String cadena)
        {
            return regexDelimitadores.IsMatch(cadena);
        }
        #endregion
        private void RichTextBox1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    componentesLexicos.Clear();
                    AreaTextoComponentesLexicos.DataSource = null;
                    cadena = richTextBox1.Text;
                    if (string.IsNullOrWhiteSpace(cadena))
                    {
                        MessageBox.Show("Porfavor introduzca un texto a comprobar");
                        return;
                    }
                    ComprobarTipoPalabraReservada();
                    SepararOraciones();
                    ConversionOracionesComponentesLexicos();
                    AnalisisReglas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                componentesLexicos.Clear();
                AreaTextoComponentesLexicos.DataSource = null;
                cadena = richTextBox1.Text;
                if (string.IsNullOrWhiteSpace(cadena))
                {
                    MessageBox.Show("Porfavor introduzca un texto a comprobar");
                    return;
                }
                ComprobarTipoPalabraReservada();
                SepararOraciones();
                ConversionOracionesComponentesLexicos();
                AnalisisReglas();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AnalisisReglas()
        {
            List<string> resultados = new List<string>();

            foreach (var item in listaOracionesMayus)
            {
                string[] Aux = item.Split(" ");

                bool esOracionInterrogativa = false;
                bool esOracionSimple = false;
                bool esOracionExclamativa = false;

                foreach (var palabra in Aux)
                {
                    if (regexOracionesInterrogativas.IsMatch(palabra))
                    {
                        esOracionInterrogativa = true;
                    }
                    else if (Adverbios.Contains(palabra))
                    {
                        esOracionSimple = true;
                    }
                    else
                    {
                        if (regexOracionesExclamativas.IsMatch(palabra))
                        {
                            esOracionExclamativa = true;
                        }
                    }

                }


                if (esOracionInterrogativa)
                {
                    resultados.Add("Oración interrogativa");
                }
                else if (esOracionSimple)
                {
                    resultados.Add("Oración simple");
                }
                else if (esOracionExclamativa)
                {
                    resultados.Add("Oración exclamativa");
                }
                else
                {
                    resultados.Add("Oración enunciativa");
                }
            }


            AreaTextoReglas.DataSource = resultados;

        }







        private void ComprobarTipoPalabraReservada()
        {

            string cadenaTrimmed = cadena.Trim(); char[] delimitadores = { ' ', '.', ';', '(', ')', ',' };

            listaSeparada = Regex.Split(cadena, "([.,;()¿?¡!\\ ])");

            List<string> listaCadenasTipo = new List<string>();
            //token token token
            //token token token token
            foreach (string palabra in listaSeparada)
            {
                if (string.IsNullOrWhiteSpace(palabra))
                {

                }
                else if (EsArticulo(palabra) == true)
                {
                    string cadenaActual = "Palabra reservada: " + palabra + " (Artículo)";
                    listaCadenasTipo.Add(cadenaActual);
                }
                else if (EsPronombre(palabra) == true)
                {
                    string cadenaActual = "Palabra reservada: " + palabra + " (Pronombre)";
                    listaCadenasTipo.Add(cadenaActual);
                }
                else if (EsConjuncion(palabra) == true)
                {
                    string cadenaActual = "Palabra reservada: " + palabra + " (Conjunción)";
                    listaCadenasTipo.Add(cadenaActual);
                }
                else if (EsSustantivo(palabra) == true)
                {
                    string cadenaActual = "Palabra reservada: " + palabra + " (Sustantivo)";
                    listaCadenasTipo.Add(cadenaActual);
                }
                else if (EsAdjetivo(palabra) == true)
                {
                    string cadenaActual = "Palabra reservada: " + palabra + " (Adjetivo)";
                    listaCadenasTipo.Add(cadenaActual);
                }
                else if (EsAdverbio(palabra) == true)
                {
                    string cadenaActual = "Palabra reservada: " + palabra + " (Adverbio)";
                    listaCadenasTipo.Add(cadenaActual);
                }
                else if (EsVerbo(palabra) == true)
                {
                    string cadenaActual = "Palabra reservada: " + palabra + " (Verbo)";
                    listaCadenasTipo.Add(cadenaActual);
                }
                else if (esNombrePropio(palabra) == true)
                {
                    string cadenaActual = "Identificador: " + palabra + " (Nombre propio)";
                    listaCadenasTipo.Add(cadenaActual);
                }
                else if (esliteralNumeroEntero(palabra) == true)
                {
                    string cadenaActual = "Literal: " + palabra + " (Numero entero)";
                    listaCadenasTipo.Add(cadenaActual);
                }
                else if (esOperador(palabra) == true)
                {
                    string cadenaActual = "Operador: " + palabra;
                    listaCadenasTipo.Add(cadenaActual);
                }
                else if (esDelimitador(palabra) == true)
                {
                    string cadenaActual = "Delimitador: " + palabra;
                    listaCadenasTipo.Add(cadenaActual);
                }
                else
                {
                    string cadenaActual = "Desconocido: " + palabra;
                    listaCadenasTipo.Add(cadenaActual);
                }

            }
            AreaTextoElementos.DataSource = listaCadenasTipo;
        }

        private void SepararOraciones()
        {
            // Se divide el texto entrante en oraciones

            try
            {
                string[] oraciones = Regex.Split(cadena.Trim(), "([.,;])");

                //if (oraciones[oraciones.Length - 1] == "")
                //{
                //    string[] oracionesArray = new string[1];
                //    oracionesArray[0] = oraciones[0];
                //    oraciones = oracionesArray;
                //}
                // Crea una lista para las oraciones con la primera letra mayuscula
                listaOracionesMayus = new List<string>();
                listaOracionesMayusDelimitadores = new List<string>();
                // Se recorre cada oracion
                foreach (string oracion in oraciones)
                {
                    if (string.IsNullOrWhiteSpace(oracion) || esDelimitador(oracion))
                    {

                    }
                    else
                    {
                        // Se remueven espacios al inicio y final
                        string oracionTrimmed = oracion.Trim();

                        // Se divide la oracion en palabras
                        string[] palabras = oracionTrimmed.Split(' ', ',');

                        // Se verifica si la primera palabra es de conjunción
                        if (EsConjuncion(palabras[0]) == true)
                        {
                            if (oracionTrimmed.Contains(','))
                            {
                                //Se remueve la palabra de conjuncion y se elimina la coma.
                                string oracionSinConjuncion = oracionTrimmed.Substring(palabras[0].Length + 1).Trim();

                                //Se coloca en mayuscula la primera letra
                                string oracionMayus = char.ToUpper(oracionSinConjuncion[0]) + oracionSinConjuncion.Substring(1);

                                //Añade oracion a la lista
                                listaOracionesMayus.Add(oracionMayus);
                            }
                            else
                            {
                                //Se remueve la palabra de conjuncion y se elimina la coma.
                                string oracionSinConjuncion = oracionTrimmed.Substring(palabras[0].Length).Trim();

                                //Se coloca en mayuscula la primera letra
                                if (oracionSinConjuncion.Length > 1)
                                {
                                    string oracionMayus = char.ToUpper(oracionSinConjuncion[0]) + oracionSinConjuncion.Substring(1);
                                    listaOracionesMayus.Add(oracionMayus);
                                }

                                //Añade oracion a la lista
                            }

                        }
                        else if (EsConjuncion(palabras[0]) == true)
                        {
                            //Se remueve la palabra de conjuncion.
                            string oracionSinConjuncion = oracionTrimmed.Substring(palabras[0].Length).Trim();

                            //Se coloca en mayuscula la primera letra
                            string oracionMayus = char.ToUpper(oracionSinConjuncion[0]) + oracionSinConjuncion.Substring(1);

                            //Añade oracion a la lista
                            listaOracionesMayus.Add(oracionMayus);
                        }
                        else
                        {
                            //Se coloca en mayuscula la primera letra
                            string oracionMayus = char.ToUpper(oracionTrimmed[0]) + oracionTrimmed.Substring(1);

                            //Añade oracion a la lista
                            listaOracionesMayus.Add(oracionMayus);
                        }
                    }

                }

                AreaTextoOraciones.DataSource = listaOracionesMayus;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConversionOracionesComponentesLexicos()
        {
            //se recorren las oraciones
            listComponentesLexicos = new List<List<Token>>();

            foreach (string oraciones in listaOracionesMayus)
            {
                List<Token> componenteLexico = new List<Token>();
                ;
                foreach (string palabraOracion in Regex.Split(oraciones, "([.,;()¿?¡!\\ ])"))
                {
                    if (String.IsNullOrWhiteSpace(palabraOracion) || String.IsNullOrEmpty(palabraOracion))
                    {

                    }
                    else
                    {
                        string palabra = palabraOracion.ToLower();
                        //if (palabra.Contains('?') || palabra.Contains('!') || palabra.Contains('¿') || palabra.Contains('¡'))
                        //{
                        //    palabra = palabra.Replace("¿", "");
                        //    palabra = palabra.Replace("?", "");
                        //    palabra = palabra.Replace("¡", "");
                        //    palabra = palabra.Replace("!", "");
                        //}
                        string tipo = "desconocido";
                        if (EsArticulo(palabra) == true)
                        {
                            tipo = "Artículo";
                        }
                        if (EsPronombre(palabra) == true)
                        {
                            tipo = "Pronombre";
                        }
                        if (EsConjuncion(palabra) == true)
                        {
                            tipo = "Conjunción";
                        }
                        if (EsSustantivo(palabra) == true)
                        {
                            tipo = "Sustantivo";
                        }
                        if (EsAdjetivo(palabra) == true)
                        {
                            tipo = "Adjetivo";
                        }
                        if (EsAdverbio(palabra) == true)
                        {
                            tipo = "Adverbio";
                        }
                        if (EsVerbo(palabra) == true)
                        {
                            tipo = "Verbo";
                        }
                        if (esNombrePropio(palabra) == true)
                        {
                            tipo = "Nombre propio";
                        }
                        if (esOperador(palabra) == true)
                        {
                            tipo = "Delimitador";
                        }
                        Token token = new Token()
                        {
                            Type = tipo,
                            Value = palabra
                        };
                        //La caperucita camina mucho en el bosque. El lobo feroz tiene hambre; pero, la caperucita lleva mucha comida. ¿El lobo come mucho?
                        componenteLexico.Add(token);
                    }
                }
                listComponentesLexicos.Add(componenteLexico);
            }

            //Oraciones
            foreach (List<Token> item in listComponentesLexicos)
            {
                //tokens
                string cadena = "";
                int indice = 0;
                foreach (Token token in item)
                {
                    indice++;
                    if (indice == item.Count)
                    {
                        cadena += token.Type;
                    }
                    else
                    {
                        cadena += token.Type + "+";
                    }
                }
                componentesLexicos.Add(cadena);
            }
            AreaTextoComponentesLexicos.DataSource = componentesLexicos;
        }

        private void FrmLiteratura_Load(object sender, EventArgs e)
        {
            //Nombre propio
            regexNombres = new Regex("[A-Z][a-z]+");
            //Literales
            regexliterales = new Regex("[1-9]+");
            //Operadores
            regexOperadores = new Regex("\\?|\\¿|\\!|\\¡");
            //Delimitadores
            regexDelimitadores = new Regex("\\.|;|\\)|\\(|,|:");
            regexOracionesInterrogativas = new Regex("[¿][a-zA-Z]*");
            regexOracionesExclamativas = new Regex("[¡][a-zA-Z]*");
        }
    }


}