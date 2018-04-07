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
using Student.Common.Logic.Log;

namespace Student.Presentation.WinSite
{
    public partial class AlumnosForm : Form
    {

        private Alumno alumno;
        private IStudentBL AlumnoBL;
        public static readonly ILogger Log = new Logger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


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
            catch (FormatException ex)
            {
                Log.Error(ex);
                MessageError("Formato incorrecto");
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
            catch (NullReferenceException ex)
            {
                MessageError("Problema interno");
                Log.Error(ex);
            }
            catch (ArgumentNullException ex)
            {
                MessageError("Problema interno");
                Log.Error(ex);
            }
            catch (FileNotFoundException ex)
            {
                MessageError("Fallo en el registro , archivo no encontrado");
                Log.Error(ex);
            }
            catch (FileLoadException ex)
            {
                MessageError("Fallo en el registro , no se pudo cargar el archivo");
                Log.Error(ex);
            }
            catch (FormatException ex)
            {
                MessageError("Los datos introducidos no tienen el formato correcto");
                Log.Error(ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageError("No se tiene autarizacion para escribir en el archivo");
                Log.Error(ex);
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
            catch (NullReferenceException ex)
            {
                MessageError("Problema interno");
                Log.Error(ex);
            }
            catch (ArgumentNullException ex)
            {
                MessageError("Problema interno");
                Log.Error(ex);
            }
            catch (FileNotFoundException ex)
            {
                MessageError("Fallo en el registro , archivo no encontrado");
                Log.Error(ex);
            }
            catch (FileLoadException ex)
            {
                MessageError("Fallo en el registro , no se pudo cargar el archivo");
                Log.Error(ex);
            }
            catch (FormatException ex)
            {
                MessageError("Los datos introducidos no tienen el formato correcto");
                Log.Error(ex);
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
            catch (NullReferenceException ex )
            {
                MessageError("Problema interno");
                Log.Error(ex);
            }
            catch (ArgumentNullException ex )
            {
                MessageError("Problema interno");
                Log.Error(ex);
            }
            catch (FileNotFoundException ex)
            {
                MessageError("Fallo en el registro , archivo no encontrado");
                Log.Error(ex);
            }
            catch (FileLoadException ex)
            {
                MessageError("Fallo en el registro , no se pudo cargar el archivo");
                Log.Error(ex);

            }
            catch (FormatException ex)
            {
                MessageError("Los datos introducidos no tienen el formato correcto");
                Log.Error(ex);
            }

        }

        private void MenuRegistro_Click(object sender, EventArgs e)
        {
            AlumnosShowForm alumnosShowForm = new AlumnosShowForm();
            alumnosShowForm.Owner=this;
            alumnosShowForm.Show();
            this.Hide();
        }
        private void MessageError(string error)
        {
            MessageBox.Show(error,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
