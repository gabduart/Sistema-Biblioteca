using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.BLL
{
    class Editores
    {
        private int editorid;
        private string nomeeditor;

        public int EditorId { get => editorid; set => editorid = value; }
        public string NomeEditor { get => nomeeditor; set => nomeeditor = value; }
    }
}
