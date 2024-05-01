using PS_PreslavDrakov.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_PreslavDrakov.Services
{
    public interface ILoginRepository
    {
        Task<UserInfo> Login(string username, string password);
    }
}
