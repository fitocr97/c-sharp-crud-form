using Crud.Data;

namespace Crud
{
    public partial class Form1 : Form
    {
        private readonly MyDbContext _context;
        public Form1(MyDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DiseñoInicial();
           // ObtenerPersonas();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DiseñoInicial()
        {
            btnCrear.Cursor = Cursors.Hand;
            btnCrear.BackColor = Color.Blue;
            btnCrear.ForeColor = Color.White;
            btnCrear.FlatStyle = FlatStyle.Flat;


            dataGridViewPersona.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //seleccionar columna
            dataGridViewPersona.MultiSelect = false; //no multiselect
            dataGridViewPersona.ReadOnly = true;
            dataGridViewPersona.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize; //tamaños columnas valor
            dataGridViewPersona.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //tamaño columnas al valor
        }


        private void ObtenerPersonas()
        {
            //LIMPIAMOS EL DATAGRIDVIEW
            dataGridViewPersona.DataSource = null;
            dataGridViewPersona.Rows.Clear();
            dataGridViewPersona.Columns.Clear();

            //RELLENAMOS EL DATAGRIDVIEW
            var data = _context.Personas.ToList();

            dataGridViewPersona.DataSource = data;
            /*
            //AGREGAR BOTON EDITAR
            DataGridViewButtonColumn BotonEditar = new DataGridViewButtonColumn();

            BotonEditar.HeaderText = "Editar";
            BotonEditar.Text = "Editar";
            BotonEditar.Name = "btnEditar";
            BotonEditar.FlatStyle = FlatStyle.Flat;
            BotonEditar.UseColumnTextForButtonValue = true;
            BotonEditar.CellTemplate.Style.BackColor = Color.Green;
            BotonEditar.CellTemplate.Style.ForeColor = Color.White;

            //AGREGAR BOTON ELIMINAR
            DataGridViewButtonColumn BotonElimar = new DataGridViewButtonColumn();

            BotonElimar.HeaderText = "Eliminar";
            BotonElimar.Text = "Eliminar";
            BotonElimar.Name = "btnEliminar";
            BotonElimar.FlatStyle = FlatStyle.Flat;
            BotonElimar.UseColumnTextForButtonValue = true;
            BotonElimar.CellTemplate.Style.BackColor = Color.Red;
            BotonElimar.CellTemplate.Style.ForeColor = Color.White;


            //AGREGAMOS LOS BOTONES
            DataGridViewPersona.Columns.Add(BotonEditar);
            DataGridViewPersona.Columns.Add(BotonElimar);


        }

        /*

        private void BotonCrear_Click(object sender, EventArgs e)
        {
            frmPersona oFrmPersona = new frmPersona();
            oFrmPersona.ShowDialog();
            ObtenerPersonas();
        }

        private void DataGridViewPersona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewPersona.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                PERSONA personaSeleccionada = (PERSONA)DataGridViewPersona.SelectedRows[0].DataBoundItem;
                frmPersona oFrmPersona = new frmPersona(personaSeleccionada);
                oFrmPersona.ShowDialog();
                ObtenerPersonas();
            }



            if (DataGridViewPersona.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                PERSONA personaSeleccionada = (PERSONA)DataGridViewPersona.SelectedRows[0].DataBoundItem;

                using (CN_DBPRUEBAS db = new CN_DBPRUEBAS())
                {
                    PERSONA personaEliminar = (from persona in db.PERSONA
                                               where persona.IdPersona == personaSeleccionada.IdPersona
                                               select persona).FirstOrDefault();

                    db.PERSONA.Remove(personaEliminar);
                    db.SaveChanges();
                }

                ObtenerPersonas();
            }

        }*/
        }
    }

}
