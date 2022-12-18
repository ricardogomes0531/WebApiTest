using Src.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src.Shared.Repository.Interface
{
    public interface IUserRepository
    {
        Task<IList<User>> GetUserByIdAsync(int id);
    }
}
