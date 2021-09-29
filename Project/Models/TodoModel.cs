using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    class TodoModel
    {
        private bool _isDone;
        private string text;

        public DateTime Date { get; set; } = DateTime.Now;
        public bool IsDone
        {
            get { return _isDone; }
            set { _isDone = value; }
        }
        public string  Text
        {
            get { return text; }
            set { text = value; }
        }


    }
}
