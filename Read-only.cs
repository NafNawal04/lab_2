using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210042130_lab05
{
    class Read_only : File
    {

        public string File_name;
        public double file_size;
        public string File_content;


        public Read_only(string _file_content)
        {
            File_content = _file_content;
        }


        public Read_only()
        { }

        public void remove(string File_name)
        {

        }
    }
}
