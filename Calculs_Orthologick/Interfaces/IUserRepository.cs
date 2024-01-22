using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculs_Orthologick.Interfaces
{
    public interface IUserRepository
    {
        int Login(string Username, string Password);
    }
}
