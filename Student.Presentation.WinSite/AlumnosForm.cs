using Student.Business.Logic;
using Student.Common.Logic.FileUtils;
using Student.Common.Logic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using System.IO;

namespace Student.Presentation.WinSite
{
    public partial class AlumnosForm : Form
    {

        private Alumno alumno;
        private IStudentBL AlumnoBL;
        public static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        public AlumnosForm()
        {
            Log.Debug("Arranca la aplicación");
            InitializeComponent();
            alumno = new Alumno();
            AlumnoBL = new StudentBL();
        }
        private void LoadAlumnoData()
        {
            try
            {
                alumno.Id = Convert.ToInt32(textId.Text);
                alumno.Nombre = textNombre.Text;
                alumno.Apellidos = textApellido.Text;
                alumno.Dni = textDni.Text;
                alumno.DateBorn = Convert.ToDateTime(dateBorn.Value);
                Log.Debug($"Datos insertados {alumno.Id},{alumno.Nombre},{alumno.Apellidos},{alumno.Dni},{alumno.DateBorn}");
            }
            catch (FormatException e)
            {
                Log.Error("El formato no es el adecuado "+e);
                MailSend.Send("El formato insertado no es el correcto");
                throw;
            }
           
        }

        private void BtnTxt_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadAlumnoData();
                Log.Debug("Seleccionado registro en Txt");
                AlumnoBL.Add(alumno, TypeFormat.Txt);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Problema interno");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Problema interno");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Fallo en el registro , archivo no encontrado");
            }
            catch (FileLoadException)
            {
                MessageBox.Show("Fallo en el registro , no se pudo cargar el archivo");
            }
            catch (FormatException)
            {
                MessageBox.Show("Los datos introducidos no tienen el formato correcto");
            }


        }

        private void BtnJson_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadAlumnoData();
                Log.Debug("Seleccionado registro en Txt");
                AlumnoBL.Add(alumno, TypeFormat.Json);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Problema interno");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Problema interno");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Fallo en el registro , archivo no encontrado");
            }
            catch (FileLoadException)
            {
                MessageBox.Show("Fallo en el registro , no se pudo cargar el archivo");
            }
            catch (FormatException)
            {
                MessageBox.Show("Los datos introducidos no tienen el formato correcto");
            }


        }

        private void BtnXml_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadAlumnoData();
                Log.Debug("Seleccionado registro en Txt");
                AlumnoBL.Add(alumno, TypeFormat.Xml);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Problema interno");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Problema interno");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Fallo en el registro , archivo no encontrado");
            }
            catch (FileLoadException)
            {
                MessageBox.Show("Fallo en el registro , no se pudo cargar el archivo");
            }
            catch (FormatException)
            {
                MessageBox.Show("Los datos introducidos no tienen el formato correcto");
            }

        }

        private void MenuRegistro_Click(object sender, EventArgs e)
        {
            AlumnosShowForm alumnosShowForm = new AlumnosShowForm();
            alumnosShowForm.Owner=this;
            alumnosShowForm.Show();
            this.Hide();
        }
    }
}
