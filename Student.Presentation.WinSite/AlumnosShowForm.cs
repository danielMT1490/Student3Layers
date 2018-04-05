using log4net;
using Student.Business.Logic;
using Student.Common.Logic.FileUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Student.Presentation.WinSite
{
    public partial class AlumnosShowForm : Form
    {
        private IStudentBL IStudentBl = new StudentBL();
        public static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public AlumnosShowForm()
        {
            InitializeComponent();
            DataGrid.DataSource=IStudentBl.GetAll(TypeFormat.Txt);
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Owner.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGrid.DataSource = IStudentBl.GetAll(TypeFormat.Txt);
            FormatUtil.ChangeFormat("Txt");
            MessageBox.Show(FormatUtil.Format());
        }

        private void BtnJso_Click(object sender, EventArgs e)
        {
            DataGrid.DataSource = IStudentBl.GetAll(TypeFormat.Json);
            FormatUtil.ChangeFormat("Json");
            MessageBox.Show(FormatUtil.Format());

        }

        private void BtnXml_Click(object sender, EventArgs e)
        {
            DataGrid.DataSource = IStudentBl.GetAll(TypeFormat.Xml);
            FormatUtil.ChangeFormat("Xml");
            MessageBox.Show(FormatUtil.Format());
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            string format = FormatUtil.Format();
            if (CBoxSelect.SelectedIndex != -1)
            {
               DataGrid.DataSource = IStudentBl.GetSelect((TypeFormat)Enum.Parse(typeof(TypeFormat), format), textValue.Text,(Campo)Enum.Parse(typeof(Campo),CBoxSelect.Text));
            }
            else
            {
                MessageBox.Show("Elige un campo");
               
                DataGrid.DataSource = IStudentBl.GetAll((TypeFormat)Enum.Parse(typeof(TypeFormat),format));
            }
            
        }
    }
}
