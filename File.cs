using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210042130_lab05
{
    internal class File
    {
        List<Editable> editableArray = new List<Editable>();
        List<Read_only> read_onlyArray = new List<Read_only>();

        public string file_name;
        public string file_type;
        public string file_content;

        public File(string _file_name, string _file_type, string _file_content)
        {
            file_name = _file_name;
            file_type = _file_type;
            file_content = _file_content;
        }

        public File()
        { }

           


    }
}
