namespace Ejercicio55.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void InicializarControles()
        {
            textNroIngresado.Clear();
            textLimiteInferior.Clear();
            textLimiteSuperior.Clear();
            textNroIngresado.Focus();

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var nroIngresado = int.Parse(textNroIngresado.Text);
                var limiteInferior = int.Parse(textLimiteInferior.Text);
                var limiteSuperior = int.Parse(textLimiteSuperior.Text);
                MostarMultiplos(nroIngresado, limiteInferior, limiteSuperior);

            }
        }

        private void MostarMultiplos(int nroIngresado, int limiteInferior, int limiteSuperior)
        {
            lstMultiplos.Items.Clear();//limpia el listBox para que no crezca infinitamente
            for (int contador = limiteInferior; contador < limiteSuperior; contador++)
            {
                if (EsMultiplo(contador, nroIngresado))
                {
                    lstMultiplos.Items.Add(contador);
                }

            }
        }

        private bool EsMultiplo(int contador, int nroIngresado)
        {
            return contador % nroIngresado == 0;
        }

        private bool ValidarDatos()
        {
            bool esValido = true;
            errorProvider1.Clear();
            if (!int.TryParse(textNroIngresado.Text, out int numero))
            {
                esValido = false;
                errorProvider1.SetError(textNroIngresado, "NUMERO MAL INGRESADO");
            }
            if (!int.TryParse(textLimiteInferior.Text, out int menor))
            {
                esValido = false;
                errorProvider1.SetError(textLimiteInferior, "NUMERO MAL INGRESADO");
            }
            if (!int.TryParse(textLimiteSuperior.Text, out int mayor))
            {
                esValido = false;
                errorProvider1.SetError(textLimiteSuperior, "NUMERO MAL INGRESADO");
            }
            else if (menor > mayor)
            {
                esValido = false;
                errorProvider1.SetError(textNroIngresado, "El limite INFERIOR es mas grande que el limite SUPERIOR");
            }
            return esValido;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InicializarControles();
            LimpiarListBox();
        }

        private void LimpiarListBox()
        {
            lstMultiplos.Items.Clear();
        }
    }
}