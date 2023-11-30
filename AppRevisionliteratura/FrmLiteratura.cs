using System.Collections;
using System.Collections.Generic;
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
        string[] oraciones;

        string[] listaSeparada;
        string cadena;
        public FrmLiteratura()
        {
            InitializeComponent();
            Articulos = new string[] { "la", "el", "los", "las", "un", "una", "unos", "unas" };

            Pronombres = new string[] { "yo", "tú", "él", "ella","ellos","ellas", "nosotros", "vosotros", "ellos", "ellas", "ustedes",
            "este", "ese", "aquel", "estos", "esos", "aquellos", "esta", "esa", "aquella", "estas", "esas", "aquellas", "esto", "eso", "aquello"};

            Conjunciones = new string[] { "y", "e", "ni", "tanto", "como", "ni", "igual", "que",
            "pero", "sin embargo", "no obstante", "sino", "o", "u",
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
            "adentro", "afuera", "mansamente", "tiernamente", "furtivamente","tranquilamente","tiene"};

            Verbos = new string[] { "ir", "encontrar", "hablar", "comer", "llegar", "abrir",
             "correr", "salvar", "asustar", "ver", "vestir", "dormir", "engañar",
             "caminar", "preguntar", "recoger", "llevar", "llamar", "poner", "decir" };

            richTextBox1.KeyDown += RichTextBox1_KeyDown;
        }

        private void RichTextBox1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Aquí puedes poner el código que quieres que se ejecute cuando se presiona Enter
                cadena = richTextBox1.Text;
                ComprobarTipoPalabraReservada();
                SepararOraciones();
                ConversionOracionesComponentesLexicos();
            }
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
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            cadena = richTextBox1.Text;
            ComprobarTipoPalabraReservada();
            SepararOraciones();
            ConversionOracionesComponentesLexicos();
        }

        private void ComprobarTipoPalabraReservada()
        {
            if (string.IsNullOrWhiteSpace(cadena))
            {
                MessageBox.Show("Porfavor introduzca un texto a comprobar");
                return;
            }
            listaSeparada = cadena.Split(' ', ';', '.');
            List<string> listaCadenasTipo = new List<string>();
            //token token token 
            //token token token token
            foreach (string palabra in listaSeparada)
            {
                if (EsArticulo(palabra) == true)
                {
                    string cadenaActual = "Palabra reservada: " + palabra + " (Artículo)";
                    listaCadenasTipo.Add(cadenaActual);

                }
                if (EsPronombre(palabra) == true)
                {
                    string cadenaActual = "Palabra reservada: " + palabra + " (Pronombre)";
                    listaCadenasTipo.Add(cadenaActual);
                }
                if (EsConjuncion(palabra) == true)
                {
                    string cadenaActual = "Palabra reservada: " + palabra + " (Conjunción)";
                    listaCadenasTipo.Add(cadenaActual);
                }
                if (EsSustantivo(palabra) == true)
                {
                    string cadenaActual = "Palabra reservada: " + palabra + " (Sustantivo)";
                    listaCadenasTipo.Add(cadenaActual);
                }
                if (EsAdjetivo(palabra) == true)
                {
                    string cadenaActual = "Palabra reservada: " + palabra + " (Adjetivo)";
                    listaCadenasTipo.Add(cadenaActual);
                }
                if (EsAdverbio(palabra) == true)
                {
                    string cadenaActual = "Palabra reservada: " + palabra + " (Adverbio)";
                    listaCadenasTipo.Add(cadenaActual);
                }
                if (EsVerbo(palabra) == true)
                {
                    string cadenaActual = "Palabra reservada: " + palabra + " (Verbo)";
                    listaCadenasTipo.Add(cadenaActual);
                }

            }
            listaElementos.DataSource = listaCadenasTipo;
        }

        private void SepararOraciones()
        {
            // Se divide el texto entrante en oraciones
            string[] oraciones = cadena.Split(';', '.');

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
                if (EsConjuncion(palabras[0]) == true)
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
                    //Se coloca en mayuscula la primera letra
                    string oracionMayus = char.ToUpper(oracionTrimmed[0]) + oracionTrimmed.Substring(1);

                    //Añade oracion a la lista
                    listaOracionesMayus.Add(oracionMayus);
                }
            }

            listaOraciones.DataSource = listaOracionesMayus;
        }

        private void ConversionOracionesComponentesLexicos()
        {
            //se recorren las oraciones
            listComponentesLexicos = new List<List<Token>>();
            foreach (string oraciones in listaOracionesMayus)
            {
                List<Token> componenteLexico = new List<Token>();
                foreach (string palabra in oraciones.Split(" "))
                {
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
                    Token token = new Token()
                    {
                        Type = tipo,
                        Value = palabra
                    };
                    componenteLexico.Add(token);
                }
                listComponentesLexicos.Add(componenteLexico);
            }

            List<string> cadenas = new List<string>();
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
                    cadenas.Add(cadena);
                }
            }
            listaComponentesLexicos.DataSource = cadenas;
        }


    }
}