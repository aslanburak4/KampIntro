using GameProjectDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo
{
    class Gamer: IGamerService
    {
        public long IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthYear { get; set; }
        int IGamerService.IdentityNumber { get; set; }
    }
}
