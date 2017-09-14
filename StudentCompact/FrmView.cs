using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentCompact
{
    public partial class FrmView : MetroFramework.Forms.MetroForm
    {

        private const string dbFileName = @"C:\Users\JOB\Desktop\Projects\school finance\Database prototypes\StudentCompact\Student.sdf";

        private static string dbConnectionString =
           string.Format("Data Source=|DataDirectory|{0};Max Database Size=4091", dbFileName);
        public FrmView()
        {
            InitializeComponent();

            using (var connection = new SqlCeConnection(dbConnectionString))
            {
                using (var context = new StudentContext(connection))
                {
                    //test works
                    // var studentList= context.Students.ToList();
                   
                }
            }
        }
    }
}
