using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
        string[] Pronombres;
        string[] Articulos;
        string[] Conjunciones;
        List<string> componentesOraciones = new List<string>();
        List<string> listaOracionesMayus;
        List<List<Token>> listComponentesLexicos;
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

        
        public FrmLiteratura()
        {
            InitializeComponent();

            Articulos = new string[] { "la", "el", "los", "las", "un", "una", "unos", "unas" };

            Pronombres = new string[] { "yo", "tú", "él", "ella","ellos","ellas", "nosotros", "vosotros", "ellos", "ellas", "ustedes",
            "este", "ese", "aquel", "estos", "esos", "aquellos", "esta", "esa", "aquella", "estas", "esas", "aquellas", "esto", "eso", "aquello"};

            Conjunciones = new string[] { "y", "e", "ni", "tanto", "como", "ni", "igual", "que",
            "pero", "sin embargo", "no obstante", "sino", "o", "O", "u",
            "bien", "ya que", "por lo tanto", "entonces", "así que",
            "por eso", "porque", "pues", "aunque", "si bien",
            "mientras que", "antes", "después", "además", "incluso",
            "además de", "a pesar de", "con tal de que", "para que","en"};

            Sustantivos = new string[] { "abuelita", "caperucita", "lobo", "leñador", "bosque", "cabaña",
            "capa", "canasta", "camino", "flores", "árboles", "ramas", "ojos", "orejas",
            "dientes", "colmillos", "garras", "ventana", "cama", "silla", "sendero",
            "picnic", "pasto", "patas", "nariz", "sol", "nubes", "hacha", "chimenea", "niña", "casa", "pinos",              "lago","gorro","moño", "cobija", "mallas", "babero", "mandil", "mantel", "arbustos", "tejado", "puerta",            "cielo"};

            Adjetivos = new string[] { "colorido", "caprichoso", "infantil", "juguetón", "alegre", "soleado",
            "pacífico", "pintoresco", "rural", "idílico", "agradable", "encantador", "bucólico", "relajante",
            "tranquilo", "nostálgico", "romántico", "pastoral", "divertida", "caricaturesca", "festivo", "vibrante",
            "animado", "sereno", "jubiloso", "acogedor", "exuberante", "armonioso", "resplandeciente", "sugestivo",
            "radiante", "plácido", "sosegado", "risueño", "paradisíaco","feroz","valiente","asustando","asustadas",             "mucho", "muchas","poco","poquito", "azul"};

            Adverbios = new string[] { "rápidamente", "sigilosamente", "astutamente",
            "dulcemente", "cautamente", "gentilmente", "bruscamente", "hábilmente",
            "furiosamente", "ingenuamente","temprano", "pronto", "nunca", "siempre",
            "lentamente", "velozmente", "despacio", "urgentemente", "sorpresivamente",
            "furtivamente","lejos", "profundamente", "aquí", "allí", "cerca",
            "adentro", "afuera", "mansamente", "tiernamente", "furtivamente","tranquilamente","tiene","jamás","nada","no","tampoco"};

            Verbos = new string[] { "ir", "encontrar", "hablar", "comer", "llegar", "abrir",
             "correr", "salvar", "asustar", "ver", "vestir", "dormir", "engañar",
             "caminar", "preguntar", "recoger", "llevar", "llamar", "poner", "decir", "come","camina","salva","encuentra,","llega",
             "abre","pregunta","asusta","va"};

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
            //Oracion simple
            AreaTextoReglas.Items.Clear();
            foreach (List<Token> listaTokenOracion in listComponentesLexicos)
            {
                //token token token
                //token token
                int contadorToken = 0;
                foreach (var token in listaTokenOracion)
                {
                    contadorToken++;
                    string cadenaMostrar = "Regla desconocida/Erronea";
                    Token tokenActual = token as Token;
                    if (listaTokenOracion.Count == 1)
                    {
                        return;
                    }
                    Token tokenSiguiente = listaTokenOracion.ElementAt(1);
                    if ((tokenActual.Type == "Sustantivo" || tokenActual.Type == "Nombre propio") && tokenSiguiente.Type == "Adverbio")
                    {
                        bool isSustantivo = EsSustantivo(token.Value);
                        bool isNombrePropio = esNombrePropio(token.Value);
                        bool isAdverbio = EsAdverbio(tokenSiguiente.Value);
                        //Token
                        if ((isSustantivo || isNombrePropio) && isAdverbio)
                        {
                            cadenaMostrar = "Oracion simple - Enunciativa";
                        }
                        else
                        {
                            if ((isSustantivo || isNombrePropio) && )
                            {
                                cadenaMostrar = "Oracion simple - Enunciativa";
                            }

                        }
                    }
                    if(contadorToken == listaTokenOracion.Count)
                    {
                        AreaTextoReglas.Items.Add(cadenaMostrar);
                    }
                }
            }
            //Oracion compuesta
        }
        
        private string separar(string componente)
        {
            //if(!string.IsNullOrEmpty(componente))
            //{
            //    Adjetivos+Sustantivo+Adverbio
            //}
            //else
            //{
            //    return "";
            //}
            return "";
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
                }else if (esNombrePropio(palabra) == true )
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

                string[] oraciones = cadena.Trim().Split(';', '.');
                if (oraciones[oraciones.Length - 1] == "")
                {
                    string[] oracionesArray = new string[1];
                    oracionesArray[0] = oraciones[0];
                    oraciones = oracionesArray;
                }
                // Crea una lista para las oraciones con la primera letra mayuscula
                listaOracionesMayus = new List<string>();

                // Se recorre cada oracion
                foreach (string oracion in oraciones)
                {
                    // Se remueven espacios al inicio y final
                    string oracionTrimmed = oracion.Trim();

                    // Se divide la oracion en palabras
                    string[] palabras = oracionTrimmed.Split(' ', ',');

                    // Se verifica si la primera palabra es de conjunción
                    if (EsConjuncion(palabras[0]) == true && oracionTrimmed.Contains(','))
                    {
                        //Se remueve la palabra de conjuncion y se elimina la coma.
                        string oracionSinConjuncion = oracionTrimmed.Substring(palabras[0].Length + 1).Trim();

                        //Se coloca en mayuscula la primera letra
                        string oracionMayus = char.ToUpper(oracionSinConjuncion[0]) + oracionSinConjuncion.Substring(1);

                        //Añade oracion a la lista
                        listaOracionesMayus.Add(oracionMayus);
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
                foreach (string palabraOracion in oraciones.Split(' '))
                {
                    string palabra = palabraOracion;
                    if (palabra.Contains('?') || palabra.Contains('!') || palabra.Contains('¿') || palabra.Contains('¡'))
                    {
                        palabra = palabra.Replace("¿", "");
                        palabra = palabra.Replace("?", "");
                        palabra = palabra.Replace("¡", "");
                        palabra = palabra.Replace("!", "");
                    }
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
                    Token token = new Token()
                    {
                        Type = tipo,
                        Value = palabra
                    };
                    componenteLexico.Add(token);
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
           
        }
    }


}