using System.Collections.Generic;
using System.Windows.Forms;

namespace AppRevisionliteratura
{
    public partial class FrmLiteratura : Form
    {
        String[] Sustantivos;
        String[] Abverbios;
        String[] Verbos;
        String[] Adjetivos;


        public FrmLiteratura()
        {
            InitializeComponent();
            Abverbios = new string[] { "R�pidamente", "Sigilosamente", "Astutamente",
                "Dulcemente", "Cautamente", "Gentilmente", "Bruscamente", "H�bilmente",
                "Furiosamente", "Ingenuamente","Temprano", "Pronto", "Nunca", "Siempre",
                "Lentamente", "Velozmente", "Despacio", "Urgentemente", "Sorpresivamente",
                "Furtivamente","Lejos", "Profundamente", "Aqu�", "All�", "Cerca",
                "Adentro", "Afuera", "Mansamente", "Tiernamente", "Furtivamente" };

            Verbos = new string[] { "Ir", "Encontrar", "Hablar", "Comer", "Llegar", "Abrir",
              "Correr", "Salvar", "Asustar", "Ver", "Vestir", "Dormir", "Enga�ar",
              "Caminar", "Preguntar", "Recoger", "Llevar", "Llamar", "Poner", "Decir" };

            Sustantivos = new string[] { "Abuelita", "Caperucita", "Lobo", "Le�ador", "Bosque", "Caba�a",
             "Capa", "Canasta", "Camino", "Flores", "�rboles", "Ramas", "Ojos", "Orejas",
             "Dientes", "Colmillos", "Garras", "Ventana", "Cama", "Silla", "Bosque", "Sendero",
             "Picnic", "Pasto", "Patas", "Nariz", "Sol", "Nubes", "Hacha", "Chimenea" };

            Adjetivos = new string[] { "colorido", "caprichoso", "infantil", "juguet�n", "alegre", "soleado",
            "pac�fico", "pintoresco", "rural", "id�lico", "agradable", "encantador", "buc�lico", "relajante",
            "tranquilo", "nost�lgico", "rom�ntico", "pastoral", "divertida", "caricaturesca", "festivo", "vibrante",
            "animado", "sereno", "jubiloso", "acogedor", "exuberante", "armonioso", "resplandeciente", "sugestivo",
            "radiante", "pl�cido", "sosegado", "risue�o", "paradis�aco" };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text.ToLower();
            if (Abverbios.Contains(palabra))
            {
                MessageBox.Show("La palabra es un adverbio.");
            }
            else if (Verbos.Contains(palabra))
            {
                MessageBox.Show("La palabra es un verbo.");
            }
            else if (Sustantivos.Contains(palabra))
            {
                MessageBox.Show("La palabra es un sustantivo.");
            }
            else if (Adjetivos.Contains(palabra))
            {
                MessageBox.Show("La palabra es un adjetivo.");
            }
            else
            {
                MessageBox.Show("La palabra no es ni adverbio, ni verbo, ni sustantivo, ni adjetivo.");
            }
        }
    }
}