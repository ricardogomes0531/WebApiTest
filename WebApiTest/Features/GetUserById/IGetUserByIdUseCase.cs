using Src.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src.Features.GetUserById
{
    public interface IGetUserByIdUseCase
    {
        Task<IList<User>> ExecuteAsync(int id);
    }
}
