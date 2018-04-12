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
using System.Threading;
using System.Globalization;
using Student.Presentation.WinSite.Resources;
using System.Data.SqlClient;
using Student.Common.Logic.Resources;

namespace Student.Presentation.WinSite
{
    public partial class AlumnosForm : Form
    {

        private Alumno alumno;
        private IStudentBL AlumnoBL;
        public static readonly ILogger Log = new Logger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private string ConfigFormat { get; set; }

        public AlumnosForm()
        {
            
            Log.Debug(LogText.Inicio);
            InitializeComponent();
            InitializeConfig();
            alumno = new Alumno();
            AlumnoBL = new StudentBL();
            ChangeLanguage();
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
                Log.Debug($"{LogText.Object}{alumno.ToString()}");
            }
            catch (FormatException ex)
            {
                Log.Error(ex);
                MessageError(Languages.ErrorInfo);
                throw;
            }
           
        }

    
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.LoadAlumnoData();
                Log.Debug(LogText.Inicio);
                AlumnoBL.Add(alumno, (TypeFormat)Enum.Parse(typeof(TypeFormat),ConfigFormat));
            }
            catch (NullReferenceException ex)
            {
                MessageError(Languages.ErrorInfo);
                Log.Error(ex);
            }
            catch (ArgumentNullException ex)
            {
                MessageError(Languages.ErrorInfo);
                Log.Error(ex);
            }
            catch (FileNotFoundException ex)
            {
                MessageError(Languages.ErrorInfo);
                Log.Error(ex);
            }
            catch (FileLoadException ex)
            {
                MessageError(Languages.ErrorInfo);
                Log.Error(ex);

            }
            catch (FormatException ex)
            {
                MessageError(Languages.ErrorInfo);
                Log.Error(ex);
            }
            catch (SqlException ex)
            {
                Log.Error(ex);
                MessageError(Languages.ErrorInfo);
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

        private void ChangeLanguage()
        {
            toolStripMenuItem1.Text = Languages.toolStripMenuItem1;
            MenuRegistro.Text = Languages.MenuRegistro;
            lblId.Text = Languages.lblId;
            lblName.Text = Languages.lblName;
            lblApellido.Text = Languages.lblApellido;
            lblDateBron.Text = Languages.lblDateBron;
            MenuOptionCast.Text = Languages.MenuOptionCast;
            MenuOptionCat.Text = Languages.MenuOptionCat;
            MenuOptionIng.Text = Languages.MenuOptionIng;
            idiomaToolStripMenuItem.Text = Languages.idiomaToolStripMenuItem;
            formatoConfig.Text = Languages.formatoConfig;
            BtnAdd.Text = Languages.BtnAdd;
        }
        private void ChangeCulture(string utf_8)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(utf_8);
        }

        private void MenuOptionCast_Click(object sender, EventArgs e)
        {
            LanguageUtils.ChangeLanguageConfig(Utf_8.Castellano);
            ChangeCulture(Utf_8.Castellano);
            ChangeLanguage();
            MenuOptionCast.Checked=true;
            MenuOptionCat.Checked = false;
            MenuOptionIng.Checked = false;
        }
        private void MenuOptionCat_Click(object sender, EventArgs e)
        {
            LanguageUtils.ChangeLanguageConfig(Utf_8.Catala);
            ChangeCulture(Utf_8.Catala);
            ChangeLanguage();
            MenuOptionCast.Checked = false;
            MenuOptionCat.Checked = true;
            MenuOptionIng.Checked = false;
        }
        private void MenuOptionIng_Click(object sender, EventArgs e)
        {
            LanguageUtils.ChangeLanguageConfig(Utf_8.English);
            ChangeCulture(Utf_8.English);
            ChangeLanguage();
            MenuOptionCast.Checked = false;
            MenuOptionCat.Checked = false;
            MenuOptionIng.Checked = true;
        }

        private void InitializeConfig()
        {
            string LanguageConfig = LanguageUtils.GetLanguageConfig();
            ChangeCulture( LanguageConfig);
            MenuOptionCast.Checked = LanguageConfig.Equals(Utf_8.Castellano) ?  true :  false;
            MenuOptionCat.Checked = LanguageConfig.Equals(Utf_8.Catala) ? true : false;
            MenuOptionIng.Checked = LanguageConfig.Equals(Utf_8.English) ? true : false;

            ConfigFormat = FormatUtil.Format();
            if (ConfigFormat.Equals(FormatPWS.Sql)) { lblId.Visible = false; textId.Visible = false; }

            txtConfigOption.Checked =ConfigFormat.Equals(FormatPWS.Txt) ? true : false;
            jsonConfigOption.Checked = ConfigFormat.Equals(FormatPWS.Json) ? true : false;
            xmlConfigOption.Checked = ConfigFormat.Equals(FormatPWS.Xml) ? true : false;
            sqlConfigOption.Checked = ConfigFormat.Equals(FormatPWS.Sql) ? true : false;

        }

        private void txtConfigOption_Click(object sender, EventArgs e)
        {
            FormatUtil.ChangeFormat(FormatPWS.Txt);
            ConfigFormat = FormatUtil.Format();
            txtConfigOption.Checked = true;
            jsonConfigOption.Checked = false;
            xmlConfigOption.Checked =  false;
            sqlConfigOption.Checked = false;
            lblId.Visible = true; textId.Visible = true;
        }
        private void jsonConfigOption_Click(object sender, EventArgs e)
        {
            FormatUtil.ChangeFormat(FormatPWS.Json);
            ConfigFormat = FormatUtil.Format();
            txtConfigOption.Checked = false;
            jsonConfigOption.Checked = true;
            xmlConfigOption.Checked = false;
            sqlConfigOption.Checked = false;
            lblId.Visible = true; textId.Visible = true;
        }
        private void xmlConfigOption_Click(object sender, EventArgs e)
        {
            FormatUtil.ChangeFormat(FormatPWS.Xml);
            ConfigFormat = FormatUtil.Format();
            txtConfigOption.Checked = false;
            jsonConfigOption.Checked = false;
            xmlConfigOption.Checked = true;
            sqlConfigOption.Checked = false;
            lblId.Visible = true; textId.Visible = true;
        }
        private void sqlConfigOption_Click(object sender, EventArgs e)
        {
            FormatUtil.ChangeFormat(FormatPWS.Sql);
            ConfigFormat = FormatUtil.Format();
            txtConfigOption.Checked = false;
            jsonConfigOption.Checked = false;
            xmlConfigOption.Checked = false;
            sqlConfigOption.Checked = true;
            lblId.Visible = false; textId.Visible = false;
        }

       
    }
}
