using log4net;
using Student.Business.Logic;
using Student.Common.Logic.FileUtils;
using Student.Common.Logic.Log;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student.Presentation.WinSite.Resources;
using Student.Common.Logic.Resources;

namespace Student.Presentation.WinSite
{
    public partial class AlumnosShowForm : Form
    {
        private string ConfigFormat { get; set; }
        private IStudentBL IStudentBl = new StudentBL();
        public static readonly ILogger Log = new Logger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public AlumnosShowForm()
        {
            try
            {
                Log.Debug(LogText.Inicio);
                InitializeComponent();
                InitializeConfig();
                ChangeLanguage();
                DataGrid.DataSource = IStudentBl.GetAll((TypeFormat)Enum.Parse(typeof(TypeFormat), ConfigFormat));
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
            catch (UnauthorizedAccessException ex)
            {
                MessageError(Languages.ErrorInfo);
                Log.Error(ex);
            }

        }

        #region ReturnInit
        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Owner.Show();
            this.Close();
        }
        #endregion

        #region Select
        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                string format = FormatUtil.Format();
                if (CBoxSelect.SelectedIndex != -1)
                {
                    DataGrid.DataSource = IStudentBl.GetSelect((TypeFormat)Enum.Parse(typeof(TypeFormat), format), textValue.Text, (Campo)Enum.Parse(typeof(Campo), CBoxSelect.Text));
                }
                else
                {
                    MessageBox.Show("Elige un campo");

                    DataGrid.DataSource = IStudentBl.GetAll((TypeFormat)Enum.Parse(typeof(TypeFormat), format));
                }
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
        #endregion

        #region MessageError
        private void MessageError(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        } 
        #endregion

        #region Config
        private void ChangeLanguage()
        {
            menuToolStripMenuItem.Text = Languages.menuToolStripMenuItem;
            registroToolStripMenuItem.Text = Languages.registroToolStripMenuItem;
            lblValor.Text = Languages.lblValor;
            lblCampo.Text = Languages.lblCampo;
            BtnFiltrar.Text = Languages.BtnFiltrar;
            formatoConfigOption1.Text = Languages.formatoConfig;

        }

        private void InitializeConfig()
        {

            ConfigFormat = FormatUtil.Format();

            txtConfigOption1.Checked = ConfigFormat.Equals(FormatPWS.Txt) ? true : false;
            jsonConfigOption1.Checked = ConfigFormat.Equals(FormatPWS.Json) ? true : false;
            xmlConfigOption1.Checked = ConfigFormat.Equals(FormatPWS.Xml) ? true : false;
            sqlConfigOption1.Checked = ConfigFormat.Equals(FormatPWS.Sql) ? true : false;

        } 
        #endregion

        #region ChangeFormat
        private void txtConfigOption1_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Debug(LogText.Inicio);
                FormatUtil.ChangeFormat(FormatPWS.Txt);
                ConfigFormat = FormatUtil.Format();
                txtConfigOption1.Checked = true;
                jsonConfigOption1.Checked = false;
                xmlConfigOption1.Checked = false;
                sqlConfigOption1.Checked = false;
                DataGrid.DataSource = IStudentBl.GetAll((TypeFormat)Enum.Parse(typeof(TypeFormat), ConfigFormat));
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
            catch (UnauthorizedAccessException ex)
            {
                MessageError(Languages.ErrorInfo);
                Log.Error(ex);
            }
        }
        private void jsonConfigOption1_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Debug(LogText.Inicio);
                FormatUtil.ChangeFormat(FormatPWS.Json);
                ConfigFormat = FormatUtil.Format();
                txtConfigOption1.Checked = false;
                jsonConfigOption1.Checked = true;
                xmlConfigOption1.Checked = false;
                sqlConfigOption1.Checked = false;
                DataGrid.DataSource = IStudentBl.GetAll((TypeFormat)Enum.Parse(typeof(TypeFormat), ConfigFormat));
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
            catch (UnauthorizedAccessException ex)
            {
                MessageError(Languages.ErrorInfo);
                Log.Error(ex);
            }
        }
        private void xmlConfigOption1_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Debug(LogText.Inicio);
                FormatUtil.ChangeFormat(FormatPWS.Xml);
                ConfigFormat = FormatUtil.Format();
                txtConfigOption1.Checked = false;
                jsonConfigOption1.Checked = false;
                xmlConfigOption1.Checked = true;
                sqlConfigOption1.Checked = false;
                DataGrid.DataSource = IStudentBl.GetAll((TypeFormat)Enum.Parse(typeof(TypeFormat), ConfigFormat));
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
            catch (UnauthorizedAccessException ex)
            {
                MessageError(Languages.ErrorInfo);
                Log.Error(ex);
            }
        }
        private void sqlConfigOption1_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Debug(LogText.Inicio);
                FormatUtil.ChangeFormat(FormatPWS.Sql);
                ConfigFormat = FormatUtil.Format();
                txtConfigOption1.Checked = false;
                jsonConfigOption1.Checked = false;
                xmlConfigOption1.Checked = false;
                sqlConfigOption1.Checked = true;
                DataGrid.DataSource = IStudentBl.GetAll((TypeFormat)Enum.Parse(typeof(TypeFormat), ConfigFormat));
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
            catch (UnauthorizedAccessException ex)
            {
                MessageError(Languages.ErrorInfo);
                Log.Error(ex);
            }
        } 
        #endregion
    }
}
