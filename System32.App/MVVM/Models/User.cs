using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System32.App.MVVM.Models
{
    public class User
    {
        // User punya nama, punya id, punya data status yang bisa dikembangkan seperti kesehatan, mental/charisma, dan juga kecerdasan

        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Intelligence { get; set; }
        public int Charisma { get; set; }
    }
}
