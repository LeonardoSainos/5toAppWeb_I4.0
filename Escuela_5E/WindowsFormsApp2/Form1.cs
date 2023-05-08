using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
       ADO objeto = new ADO ();
        public Form1()
        {
            InitializeComponent();
            COMBOBOXbloqueado.Enabled = false;
          
            
            Label labelejem = new Label();
            labelejem = new Label();
            labelejem.Width = 100;
            labelejem.Height = 170;
            labelejem.Top = 693;
            labelejem.Left = 354;
         //   labelejem.Enabled = true;
            labelejem.AutoSize = true;
            this.Controls.Add(labelejem);


            CheckBox botonradio = new CheckBox();

            botonradio = new CheckBox();
            botonradio.Width =40;
            botonradio.Height = 60;
            botonradio.Top = 60;
            botonradio.Left = 60;
            this.Controls.Add(botonradio);

            // Create and initialize a Button.



            Button button1 = new Button();

            // Set the button to return a value of OK when clicked.
            button1.DialogResult = DialogResult.OK;

            // Add the button to the form.
            Controls.Add(button1);

           
            


            ComboBox button11 = new ComboBox();
            // Set the button to return a value of OK when clicked.
            button11.Text = Text;
            // Add the button to the form.
            Controls.Add(button11);

            /*   Button[,] boton = new Button[10, 10];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                boton[i, j] = new Button();
                boton[i, j].Width = 40;
                boton[i, j].Height = 20;
                boton[i, j].Text = String.Format("{0},{1}", i, j);
                boton[i, j].Top = i * 20;
                boton[i, j].Left = j * 40;
                this.Controls.Add(boton[i, j]);
            }
        }*/
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            //  string mensaje = "";
            //  objeto.Insertar(txtnombre.Text, Convert.ToInt32(txtEdad.Text), txtsexo.Text, cmbRedSocial.Text, cmbGrupo.Text,pictureBox1, ref  mensaje);
            //lblmensaje.Text = mensaje;

            //AQUI ES EL INSERTAR QUE NO HACIA NADA Y EL COMENTARIO DE ABAJO ERA SU FORMA ANTIGUA DE INSERTAR
            // String mensaje = "";
            //// String sentencia = "insert into Alumno (nombre,edad,sexo,redsocial,id_grupo, foto )Values('" + txtnombre.Text + "',' " + Convert.ToInt32(txtEdad.Text) + "','" + txtsexo.Text + "','" + cmbRedSocial.Text + "','" + txtId.Text + "','" + "@foto)";
            //  objeto.Insertar(sentencia, pictureBox1, ref mensaje);
            //objeto.Insertar(txtnombre.Text, Convert.ToInt32(txtEdad.Text), txtsexo.Text, cmbRedSocial.Text, cmbGrupo.Text, pictureBox1, ref mensaje);
            //  lblmensaje.Text = mensaje;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string w = "";
            objeto.BD = "UTP";
            objeto.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            objeto.Conectar(ref w);
            lblmensaje.Text = w;
            CrearBoton();
        }

        public void CrearBoton()
        {
            Button btn_uno = new Button();
            btn_uno.Location = new Point(197, 12);
            btn_uno.Text = "Mostrar";
            btn_uno.Anchor = AnchorStyles.Right;
            btn_uno.Anchor = AnchorStyles.Top;
            this.Controls.Add(btn_uno);
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string mensaje = "";
           
            objeto.Mostrar(listBox1,ref mensaje,cmbTablas.Text);
            lblmensaje.Text = mensaje;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string labell = "";
            string SENTENCIASQL = "update Alumno set nombre = ' " + txtnombre.Text + "', edad = '" + txtEdad.Text + "', sexo = '" + txtsexo.Text + "', redsocial = '" + cmbRedSocial.Text + "', id_grupo = '" + cmbGrupo.Text + "'where no_control = " +  Convert.ToInt32(txtId.Text);
            objeto.Actualizar_registro(SENTENCIASQL,ref labell);
            lblmensaje.Text = labell;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String mensaje = "";
            objeto.Eliminar(Convert.ToInt32(txtId.Text), ref mensaje);
            lblmensaje.Text = mensaje;
        }

        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            String mensaje = "";
            String sentencia = "insert into Alumno (nombre,edad,sexo,redsocial,id_grupo, foto )Values('" + txtnombre.Text + "',' " + Convert.ToInt32(txtEdad.Text) + "','" + txtsexo.Text + "','" + cmbRedSocial.Text + "','" + cmbGrupo.Text + "'," + "@foto)";
            //objeto.Insertar(txtnombre.Text, Convert.ToInt32(txtEdad.Text), txtsexo.Text, cmbRedSocial.Text, cmbGrupo.Text, pictureBox1, ref mensaje);
            // objeto.Insertar(sentencia, pictureBox1, ref mensaje);
            objeto.Insertar_y_Actualizar_Registro(ref mensaje, sentencia, pictureBox1);
            lblmensaje.Text = mensaje;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objeto.CargarImagen(pictureBox1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /* string mensaje = "";

             objeto.ConsultaDataSet(ref mensaje, dataGridView1);*/
    
            string mensaje = "";
            string sentenciaSQL = " Select * from " + cmbTablas.Text;
             objeto.ConsultaDataSet(ref mensaje, dataGridView1, sentenciaSQL);
         
 
            // objeto.ConsultaDataset2(sentenciaSQL, ref mensaje);
            lblmensaje.Text = mensaje;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
           
                if (e.Context == DataGridViewDataErrorContexts.CurrentCellChange)
                {
                    lblmensaje.Text = "Cambio de Celdas";
                }
            
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mensaje = "";

          //  string sentenciaSQL = "update persona set nombre='" + txtnombre.Text + "',Foto=@foto where id=" + txtid_person.Text;

            String Consulta = "update alumno set Foto= @foto where no_control=" + " ' " + Convert.ToInt32(txtId.Text) + " ' "; 

            objeto.Insertar_y_Actualizar_Registro(ref mensaje, Consulta, pictureBox1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMateria_Click(object sender, EventArgs e)
        {
            String cadena = "";
            string ConsultaSQL = "insert into Materia values(' " + Convert.ToInt32(txtIdmateria.Text) + " ', '" +txtNombreMateria.Text + "', '" + Convert.ToInt32(cmbHorasMateria.Text) +  " ')";
            objeto.Insertar(ConsultaSQL, ref cadena);
            lblmensaje.Text = cadena;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cadena = "";
            string consulta = "insert into toma values (' " + Convert.ToInt32(txtMatricula.Text) + " ', '" + Convert.ToInt32(txtMatriculaMateria.Text) + "' , '" + Convert.ToInt32(txtPromediar.Text) + " ')";

            objeto.Insertar(consulta, ref cadena);
            lblmensaje.Text = cadena;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVerProm_Click(object sender, EventArgs e)
        {
            if (radioMat.Checked)
            {
                txtIdMateriaTabla.Enabled = true;
                string cad = "";
                 objeto.Paso_parametros(COMBOBOXbloqueado, Convert.ToInt32(txtIdAlumno.Text), Convert.ToInt32(txtIdMateriaTabla.Text), ref cad);
                objeto.MostrarAVG(listBox1, ref cad, Convert.ToInt32(txtIdAlumno.Text), Convert.ToInt32(txtIdMateriaTabla.Text));
                lblmensaje.Text = cad;
            }
            else if (radioGeneral.Checked)
            {
                txtIdMateriaTabla.Clear();
                txtIdMateriaTabla.Enabled = false;

                string cad = "";
                objeto.MostrarAVG2(listBox1, ref cad, Convert.ToInt32(txtIdAlumno.Text));

                objeto.PromedioGeneral(COMBOBOXbloqueado, Convert.ToInt32(txtIdAlumno.Text), ref cad);
                lblmensaje.Text = cad;
            }
        }

        private void idMateria_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string mensaje = "";
            string sentenciaSQL = "update toma set Clave_alumnoT = ' " + Convert.ToInt32(txtMatricula.Text) + "', clave_materiaT = '" + Convert.ToInt32(txtMatriculaMateria.Text) + "', promedio = '" + Convert.ToInt32(txtPromediar.Text) + " ' where clave_materiaT = " + " ' " + Convert.ToInt32(txtActIdActuMateri.Text)+ " ' " + "and clave_alumnoT = " + " ' " + Convert.ToInt32(txtActuaMatriMat.Text) + "' "; 
            objeto.Actualizar_registro(sentenciaSQL, ref mensaje);
        }
    }
}


        
            

