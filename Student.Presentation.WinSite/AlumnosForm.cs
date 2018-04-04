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
            alumno.Id = Convert.ToInt32(textId.Text);
            alumno.Nombre = textNombre.Text;
            alumno.Apellidos = textApellido.Text;
            alumno.Dni = textDni.Text;
            alumno.DateBorn = Convert.ToDateTime(dateBorn.Value);
            Log.Debug($"Datos insertados {alumno.Id},{alumno.Nombre},{alumno.Apellidos},{alumno.Dni},{alumno.DateBorn}");
        }

        private void BtnTxt_Click(object sender, EventArgs e)
        {
            this.LoadAlumnoData();
            Log.Debug("Seleccionado registro en Txt");
            AlumnoBL.Add(alumno,TypeFormat.Txt);

        }

        private void BtnJson_Click(object sender, EventArgs e)
        {
            this.LoadAlumnoData();
            Log.Debug("Seleccionado registro en Txt");
            AlumnoBL.Add(alumno, TypeFormat.Json);
        }

        private void BtnXml_Click(object sender, EventArgs e)
        {
            this.LoadAlumnoData();
            Log.Debug("Seleccionado registro en Txt");
            AlumnoBL.Add(alumno, TypeFormat.Xml);
        }
    }
}
