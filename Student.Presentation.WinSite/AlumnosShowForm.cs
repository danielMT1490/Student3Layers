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
            DataGrid.DataSource=IStudentBl.GetAll(TypeFormat.Json);
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Owner.Show();
            this.Close();
        }
    }
}
