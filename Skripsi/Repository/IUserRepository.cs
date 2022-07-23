using Skripsi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skripsi.Repository
{
    public interface IUserRepository
    {
        bool CheckPassword(string encrypt, string password);
        tn_u_login GetUsers(string uName);
        List<tn_u_login> GetUserLogin();
        bool SaveUserLogin(tn_u_login uLogin);
    }
}
