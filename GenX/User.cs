using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenX
{
    class User
    {
        public string Gamertag { get; set; }
        public int Points { get; set; }

        //  The amount of times the user is allowed to play games (any of the modes)
        public int GameAttemptsLeft = 3; 
    }
}
