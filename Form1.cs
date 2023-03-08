using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _210042130_lab05
{
    public partial class Form1 : Form
    {
        List<Editable> editableArray = new List<Editable>();
        List<Read_only> read_onlyArray = new List<Read_only>();

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FN1_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddFile_button_Click(object sender, EventArgs e)
        {
            string file_name = FN1_textBox.Text;
            string file_type = FT_comboBox.Text;
            string file_content = FC_textBox.Text;

            File f = new File(file_name, file_type, file_content);
            if(file_type == "Editable" )
            {
                editableArray.Add((Editable)f);
            }
            else
            {
                read_onlyArray.Add((Read_only)f);
            }

            MessageBox.Show("The file is added.");
            FN1_textBox.Clear();
            FC_textBox.Clear();

        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
            string search = FN2_textBox.Text;
            foreach(Editable d in editableArray) 
            {
              if(d.File_name == search)
                {
                    d.remove(search);
                }
            }

        }
    }
}
