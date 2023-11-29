namespace AppRevisionliteratura
{
    public partial class FrmLiteratura : Form
    {
        public FrmLiteratura()
        {
            String[] Sustantivos;
            String[] Abverbios;
            String[] Verbos;
            String[] Adjetivos;
            InitializeComponent();
            Abverbios = new string[] { "Rápidamente", "Sigilosamente", "Astutamente",
                "Dulcemente", "Cautamente", "Gentilmente", "Bruscamente", "Hábilmente",
                "Furiosamente", "Ingenuamente","Temprano", "Pronto", "Nunca", "Siempre",
                "Lentamente", "Velozmente", "Despacio", "Urgentemente", "Sorpresivamente",
                "Furtivamente","Lejos", "Profundamente", "Aquí", "Allí", "Cerca",
                "Adentro", "Afuera", "Mansamente", "Tiernamente", "Furtivamente" };

            Verbos = new string[] { "Ir", "Encontrar", "Hablar", "Comer", "Llegar", "Abrir",
              "Correr", "Salvar", "Asustar", "Ver", "Vestir", "Dormir", "Engañar",
              "Caminar", "Preguntar", "Recoger", "Llevar", "Llamar", "Poner", "Decir" };

            Sustantivos = new string[] { "Abuelita", "Caperucita", "Lobo", "Leñador", "Bosque", "Cabaña",
             "Capa", "Canasta", "Camino", "Flores", "Árboles", "Ramas", "Ojos", "Orejas",
             "Dientes", "Colmillos", "Garras", "Ventana", "Cama", "Silla", "Bosque", "Sendero",
             "Picnic", "Pasto", "Patas", "Nariz", "Sol", "Nubes", "Hacha", "Chimenea" };

            Adjetivos = new string[] { "colorido", "caprichoso", "infantil", "juguetón", "alegre", "soleado",
            "pacífico", "pintoresco", "rural", "idílico", "agradable", "encantador", "bucólico", "relajante",
            "tranquilo", "nostálgico", "romántico", "pastoral", "divertida", "caricaturesca", "festivo", "vibrante",
            "animado", "sereno", "jubiloso", "acogedor", "exuberante", "armonioso", "resplandeciente", "sugestivo",
            "radiante", "plácido", "sosegado", "risueño", "paradisíaco" };

        }
        private void separarTexto(String texto)
        {
            string [] palabras = texto.Split("\\s");

        }
    }
 

}