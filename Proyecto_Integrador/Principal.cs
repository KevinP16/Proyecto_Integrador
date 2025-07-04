using Proyecto_Integrador.Data;
namespace Proyecto_Integrador
{
    public partial class Principal : Form
    {

        public Principal()
        {


            InitializeComponent();
            var datos = new datos(); // Crea una instancia de la clase datos
            datos.CargarCombo(cmbMedicamentos); // Llama al m�todo para probar la conexi�n a la base de datos


            cmbMedicamentos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMedicamentos.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbMedicamentos.Text = "Selecciona un medicamento"; // Establece el texto predeterminado del ComboBox
            cmbMedicamentos.Font = new Font("Verdana", 14);
            dtimeEntrada.Font = new Font("Verdana",12 );

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                tabControlMenu.Appearance = TabAppearance.FlatButtons;// Establece el estilo de las pesta�as la apariencia de las pesta�as es plana
                tabControlMenu.ItemSize = new Size(0, 2);// Establece el tama�o de las pesta�as muy peque�o para que no se vean
                tabControlMenu.SizeMode = TabSizeMode.Fixed;// Establece el modo de tama�o de las pesta�as conbinado los dos anteriores oculta las pesta�as
            }
            catch (Exception ex)
            {
                MessageBox.Show("Esto es un " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Establece la pesta�a de inicio como la pesta�a seleccionada al cargar el formulario
            tabControlMenu.SelectedTab = Mensajebienvenida; // Establece la pesta�a de inicio como la pesta�a seleccionada al cargar el formulario

        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {

            tabControlMenu.SelectedTab = Registar; // Cambia a la pesta�a de registro
            Form Verificar = new Verificacion(); // Crea una instancia del formulario de verificaci�n
            Verificar.Show();


        }

        private void btnActivos_Click(object sender, EventArgs e)
        {
            tabControlMenu.SelectedTab = Activos; // Cambia a la pesta�a de activos
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            tabControlMenu.SelectedTab = Historial; // Cambia a la pesta�a de historial
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbMedicamentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            //Datos personales
            string nombres = txtNombres.Text;
            string apellidoMaterno = txtApellidoMeterno.Text;
            string apellidoPaterno = txtApellidoPaterno.Text;
            string curp = txtCurp.Text;

            //Datos Medicos
            string causa = txtCausa.Text;
            int respuesta = rbtnSiExpediente.Checked ? 1 : 0;// verifica que si se seleciono Si
            int respuesta2  = rbtnSIEstudiosClinicos.Checked ? 1 : 0;// verifica que si se seleciono Si
            

            var datos = new datos(); // Crea una instancia de la clase datos
            Dictionary<string, object> datospersonales = new Dictionary<string, object>// Crea un diccionario para almacenar los datos personales
            {
                { "curp", curp },
                { "nombres", nombres },
                { "apellido_materno", apellidoMaterno },
                { "apellido_paterno", apellidoPaterno }
            };
            int idInsertado = datos.Insertar("datos_personales", datospersonales); // Inserta los datos del medicamento en la base de datos




        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

