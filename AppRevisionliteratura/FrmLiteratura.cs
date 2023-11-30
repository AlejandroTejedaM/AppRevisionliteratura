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
        string[] oraciones;

        string[] listaSeparada;
        string cadena;
        public FrmLiteratura()
        {
            InitializeComponent();
            Articulos = new string[] { "la", "el", "los", "las", "un", "una", "unos", "unas" };

            Pronombres = new string[] { "yo", "t�", "�l", "ella","ellos","ellas", "nosotros", "vosotros", "ellos", "ellas", "ustedes",
            "este", "ese", "aquel", "estos", "esos", "aquellos", "esta", "esa", "aquella", "estas", "esas", "aquellas", "esto", "eso", "aquello"};

            Conjunciones = new string[] { "y", "e", "ni", "tanto", "como", "ni", "igual", "que",
            "pero", "sin embargo", "no obstante", "sino", "o", "u",
            "bien", "ya que", "por lo tanto", "entonces", "as� que",
            "por eso", "porque", "pues", "aunque", "si bien",
            "mientras que", "antes", "despu�s", "adem�s", "incluso",
            "adem�s de", "a pesar de", "con tal de que", "para que","en"};

            Sustantivos = new string[] { "abuelita", "caperucita", "lobo", "le�ador", "bosque", "caba�a",
            "capa", "canasta", "camino", "flores", "�rboles", "ramas", "ojos", "orejas",
            "dientes", "colmillos", "garras", "ventana", "cama", "silla", "sendero",
            "picnic", "pasto", "patas", "nariz", "sol", "nubes", "hacha", "chimenea", "ni�a"};

            Adjetivos = new string[] { "colorido", "caprichoso", "infantil", "juguet�n", "alegre", "soleado",
            "pac�fico", "pintoresco", "rural", "id�lico", "agradable", "encantador", "buc�lico", "relajante",
            "tranquilo", "nost�lgico", "rom�ntico", "pastoral", "divertida", "caricaturesca", "festivo", "vibrante",
            "animado", "sereno", "jubiloso", "acogedor", "exuberante", "armonioso", "resplandeciente", "sugestivo",
            "radiante", "pl�cido", "sosegado", "risue�o", "paradis�aco","feroz","valiente","asustando","asustadas", "mucho", "muchas","poco","poquito"};

            Adverbios = new string[] { "r�pidamente", "sigilosamente", "astutamente",
            "dulcemente", "cautamente", "gentilmente", "bruscamente", "h�bilmente",
            "furiosamente", "ingenuamente","temprano", "pronto", "nunca", "siempre",
            "lentamente", "velozmente", "despacio", "urgentemente", "sorpresivamente",
            "furtivamente","lejos", "profundamente", "aqu�", "all�", "cerca",
            "adentro", "afuera", "mansamente", "tiernamente", "furtivamente","tranquilamente","tiene"};

            Verbos = new string[] { "ir", "encontrar", "hablar", "comer", "llegar", "abrir",
             "correr", "salvar", "asustar", "ver", "vestir", "dormir", "enga�ar",
             "caminar", "preguntar", "recoger", "llevar", "llamar", "poner", "decir" };

            richTextBox1.KeyDown += RichTextBox1_KeyDown;
        }

        private void RichTextBox1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Aqu� puedes poner el c�digo que quieres que se ejecute cuando se presiona Enter
                cadena = richTextBox1.Text;
                ComprobarTipoPalabraReservada();
                SepararOraciones();
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
            foreach (string palabra in listaSeparada)
            {
                if (EsArticulo(palabra) == true)
                {
                    string cadenaActual = "Palabra reservada: " + palabra + " (Art�culo)";
                    listaCadenasTipo.Add(cadenaActual);
                }
                if (EsPronombre(palabra) == true)
                {
                    string cadenaActual = "Palabra reservada: " + palabra + " (Pronombre)";
                    listaCadenasTipo.Add(cadenaActual);
                }
                if (EsConjuncion(palabra) == true)
                {
                    string cadenaActual = "Palabra reservada: " + palabra + " (Conjunci�n)";
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
            // Split the string into sentences
            string[] oraciones = cadena.Split(';', '.');

            // Create a new list to store the sentences
            List<string> listaOracionesMayus = new List<string>();

            // Loop through each sentence
            foreach (string oracion in oraciones)
            {
                // Remove leading and trailing spaces
                string oracionTrimmed = oracion.Trim();

                // Split the sentence into words
                string[] words = oracionTrimmed.Split(' ',',');

                // Check if the first word is a conjunction
                if (EsConjuncion(words[0]) == true)
                {
                    // If the first word is a conjunction, remove it and the following comma
                    string oracionWithoutConjunction = oracionTrimmed.Substring(words[0].Length + 1).Trim();

                    // Capitalize the first letter of the sentence
                    string oracionCapitalized = char.ToUpper(oracionWithoutConjunction[0]) + oracionWithoutConjunction.Substring(1);

                    // Add the sentence to the list
                    listaOracionesMayus.Add(oracionCapitalized);
                }
                else
                {
                    // If the first word is not a conjunction, capitalize the first letter of the sentence
                    string oracionCapitalized = char.ToUpper(oracionTrimmed[0]) + oracionTrimmed.Substring(1);

                    // Add the sentence to the list
                    listaOracionesMayus.Add(oracionCapitalized);
                }
            }

            // Set the DataSource of the list to the list of sentences
            listaOraciones.DataSource = listaOracionesMayus;
        }


    }
}