using Src.Shared.Domain;
using Src.Shared.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src.Features.GetUserById
{
    public interface IGetUserByIdUseCase
    {
        Task<DataResult> ExecuteAsync(int id);
    }
}
