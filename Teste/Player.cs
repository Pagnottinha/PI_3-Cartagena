using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class Player
    {
        public int id {  get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string color { get; set; }

        public Player(int id, string name, string color)
        {
            this.id = id;
            this.name = name;
            this.color = color;
        }

        public Player(int id, string name, string password, string color)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.color = color;
        }
    }
}
