using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210042130_lab05
{
    class Editable : File
    {
        public string File_name;
        public double file_size;
        public string File_content;


        public Editable(string _file_name, string _file_content)
        {
            File_name = _file_name;
            File_content = _file_content;
        }


        public Editable()
        { }

        public void edit(string File_content)
        { 
            
        }

        public void remove(string File_name) 
        { 
          
        }
    }
}
