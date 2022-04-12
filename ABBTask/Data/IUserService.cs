using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ABBTask.Shared;
using static ABBTask.Model.Common;

namespace ABBTask.Data
{
    public interface IUserService
    {          
        Task<List<Users>> GetUsers();
        
    }
}

