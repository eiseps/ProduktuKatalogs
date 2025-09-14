namespace ProduktuKatalogs
{
    public partial class Form1 : Form
    {
        private List<Produkts> produktuKatalogs = new List<Produkts>();
        public Form1()
        {
            InitializeComponent();
        }

        private void pievienotGramatu_Click(object sender, EventArgs e)
        {
            try
            {
                string nosaukums = gramatasNosaukums.Text;
                string autors = gramatasAutors.Text;
                decimal cena = decimal.Parse(gramatasCena.Text);

                var gramata = new Gramata(nosaukums, autors, cena);
                produktuKatalogs.Add(gramata);
                AtjaunotSarakstu();
                NotiritLaukus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kļūda, pievienojot grāmatu: {ex.Message}", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pievienotElektroniku_Click(object sender, EventArgs e)
        {
            try
            {
                string nosaukums = elektronikasNosaukums.Text;
                int garantija = int.Parse(elektronikasGarantija.Text);
                decimal cena = decimal.Parse(elektronikasCena.Text);

                var elektronika = new Elektronika(nosaukums, garantija, cena);
                produktuKatalogs.Add(elektronika);
                AtjaunotSarakstu();
                NotiritLaukus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kļūda, pievienojot elektroniku: {ex.Message}", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AtjaunotSarakstu()
        {
            katalogs.Items.Clear();
            decimal kopejaVertiba = 0;
            foreach (var produkts in produktuKatalogs)
            {
                katalogs.Items.Add(produkts.Informacija());
                kopejaVertiba += produkts.Cena;
            }
            katalogaVertiba.Text = $"Kopējā kataloga vērtība: {kopejaVertiba} €";
        }
        private void NotiritLaukus()
        {
            gramatasAutors.Clear();
            gramatasCena.Clear();
            gramatasNosaukums.Clear();
            elektronikasCena.Clear();
            elektronikasGarantija.Clear();
            elektronikasNosaukums.Clear();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public abstract class Produkts
    {
        public string Nosaukums { get; set; }
        public decimal Cena { get; set; }

        public Produkts(string nosaukums, decimal cena)
        {
            Nosaukums = nosaukums;
            Cena = cena;
        }
        public abstract string Informacija();
    }
    public class Gramata : Produkts
    {
        public string Autors { get; set; }
        public Gramata(string nosaukums, string autors,decimal cena) : base(nosaukums, cena)
        {
            Autors = autors;
        }
        public override string Informacija()
        {
            return $"{Nosaukums} (Grāmata) - Autors: {Autors}, Cena - {Cena} €";
        }
    }
    public class Elektronika : Produkts
    {
         public int Garantija { get; set; }
         public Elektronika(string nosaukums, int garantija, decimal cena) : base(nosaukums, cena)
         {
             Garantija = garantija;
         }
         public override string Informacija()
         {
             return $"{Nosaukums} (Elektronika) - Garantija: {Garantija} mēneši, Cena - {Cena} €";
         }
    }
}
