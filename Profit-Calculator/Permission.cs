using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Profit_Calculator
{
    public class Permission
    {
        public Permission() { }
        public Permission(int id, string desc)
        {
            Id = id;
            Description = desc;
        }
        public int Id { get; set;}
        public string Description { get; set;}
        public override string ToString()
        {
            return Id + " - " + Description;
        }
    }
}
