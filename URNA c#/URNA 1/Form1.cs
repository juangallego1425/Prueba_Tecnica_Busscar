namespace URNA_1
{
    public partial class Form1 : Form


    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            botonCarroceria1.Click += VotarCarroceria1;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            botonCarroceria2.Click += VotarCarroceria2;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            botonCarroceria3.Click += VotarCarroceria3;

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void etiquetaVotosCarroceria1 (object sender, EventArgs e)
        {
         
        }
        private void etiquetaVotosCarroceria2(object sender, EventArgs e)
        {

        }
        private void etiquetaVotosCarroceria3(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void VotarCarroceria1(object sender, EventArgs e)
        {
            votosCarroceria1++;
            totalVotos++;
            ActualizarResultados();
        }

        private void VotarCarroceria2(object sender, EventArgs e)
        {
            votosCarroceria2++;
            totalVotos++;
            ActualizarResultados();
        }

        private void VotarCarroceria3(object sender, EventArgs e)
        {
            votosCarroceria3++;
            totalVotos++;
            ActualizarResultados();
        }

        private void ActualizarResultados()
        {
            etiquetaVotosCarroceria1.Text = $"Votos: {votosCarroceria1}";
            etiquetaVotosCarroceria2.Text = $"Votos: {votosCarroceria2}";
            etiquetaVotosCarroceria3.Text = $"Votos: {votosCarroceria3}";

            double porcentajeCarroceria1 = (double)votosCarroceria1 / totalVotos * 100;
            double porcentajeCarroceria2 = (double)votosCarroceria2 / totalVotos * 100;
            double porcentajeCarroceria3 = (double)votosCarroceria3 / totalVotos * 100;

            etiquetaPorcentajeCarroceria1.Text = $"Porcentaje: {porcentajeCarroceria1:F2}%";
            etiquetaPorcentajeCarroceria2.Text = $"Porcentaje: {porcentajeCarroceria2:F2}%";
            etiquetaPorcentajeCarroceria3.Text = $"Porcentaje: {porcentajeCarroceria3:F2}%";
        }
    }
}