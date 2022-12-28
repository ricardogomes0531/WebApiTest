using Src.Shared.Domain;
using Src.Shared.Repository;
using Src.Shared.Repository.Interface;
using Src.Shared.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src.Features.GetUserById
{
    public class GetUserByIdUseCase : IGetUserByIdUseCase
    {
        private readonly IUserRepository _repository;
        private readonly DataResult _output;

        public GetUserByIdUseCase(
            IUserRepository repository
            )
        {
            _repository = repository;
            _output = new DataResult();
        }

        public async Task<DataResult> ExecuteAsync(int id)
        {
            var user = await _repository.GetUserByIdAsync(id);
            if (user.Count > 0)
            {
                _output.AddResult(user);
            }
            else
            {
                _output.AddMessageError("A consulta não retornou resultado.");
            }
            return _output;
        }

    }
}
