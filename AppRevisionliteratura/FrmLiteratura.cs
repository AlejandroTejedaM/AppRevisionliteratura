using System.Collections.Generic;
using System.Windows.Forms;

namespace AppRevisionliteratura
{
    public partial class FrmLiteratura : Form
    {
        String[] Sustantivos;
        String[] Adverbios;
        String[] Verbos;
        String[] Adjetivos;
        String[] Pronombres;
        String[] Articulos;
        String[] Conjunciones;


        public FrmLiteratura()
        {
            InitializeComponent();
            Adverbios = new string[] { "r�pidamente", "sigilosamente", "astutamente",
            "dulcemente", "cautamente", "gentilmente", "bruscamente", "h�bilmente",
            "furiosamente", "ingenuamente","temprano", "pronto", "nunca", "siempre",
            "lentamente", "velozmente", "despacio", "urgentemente", "sorpresivamente",
            "furtivamente","lejos", "profundamente", "aqu�", "all�", "cerca",
            "adentro", "afuera", "mansamente", "tiernamente", "furtivamente" };

            Verbos = new string[] { "ir", "encontrar", "hablar", "comer", "llegar", "abrir",
             "correr", "salvar", "asustar", "ver", "vestir", "dormir", "enga�ar",
             "caminar", "preguntar", "recoger", "llevar", "llamar", "poner", "decir" };

            Sustantivos = new string[] { "abuelita", "caperucita", "lobo", "le�ador", "bosque", "caba�a",
            "capa", "canasta", "camino", "flores", "�rboles", "ramas", "ojos", "orejas",
            "dientes", "colmillos", "garras", "ventana", "cama", "silla", "bosque", "sendero",
            "picnic", "pasto", "patas", "nariz", "sol", "nubes", "hacha", "chimenea" };

            Adjetivos = new string[] { "colorido", "caprichoso", "infantil", "juguet�n", "alegre", "soleado",
            "pac�fico", "pintoresco", "rural", "id�lico", "agradable", "encantador", "buc�lico", "relajante",
            "tranquilo", "nost�lgico", "rom�ntico", "pastoral", "divertida", "caricaturesca", "festivo", "vibrante",
            "animado", "sereno", "jubiloso", "acogedor", "exuberante", "armonioso", "resplandeciente", "sugestivo",
            "radiante", "pl�cido", "sosegado", "risue�o", "paradis�aco" };

            Articulos = new string[] { "la", "el", "los", "las", "un", "una", "unos", "unas" };

            Pronombres = new string[] { "yo", "t�", "�l", "ella","ellos","ellas", "nosotros", "vosotros", "ellos", "ellas", "ustedes",
            "este", "ese", "aquel", "estos", "esos", "aquellos", "esta", "esa", "aquella", "estas", "esas", "aquellas", "esto", "eso", "aquello"};

            Conjunciones = new string[] {
                // Coordinantes
                "y", "e", "ni", "tanto como", "as� como",
                "pero", "mas", "sino", "aunque",
                "o", "u", "bien bien", "ya ya",
                "ora ora", "sea sea",

                // Subordinantes
                "que", "si", "como",
                "siempre que", "porque", "pues", "ya que",
                "que", "luego", "as� que", "de modo que",
                "aunque", "si bien", "aun cuando",
                "cuando", "mientras", "antes de que", "despu�s de que",
                "que", "como", "m�s que", "menos que",
                "para que", "a fin de que", "con el�fin�de�que"};
            richTextBox1.KeyDown += RichTextBox1_KeyDown;
        }

        private void RichTextBox1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Presionaste Enter.");
            }

        }

        private void llenarTextlistPalabras()
        {
            listBox1.DataSource = "";
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }
    }
}