using Src.Shared.Domain;
using Src.Shared.Repository;
using Src.Shared.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src.Features.GetUserById
{
    public class GetUserByIdUseCase : IGetUserByIdUseCase
    {
        private readonly IUserRepository _repository;

        public GetUserByIdUseCase(
            IUserRepository repository
            )
        {
            _repository = repository;
        }

        public async Task<IList<User>> ExecuteAsync(int id)
        {
            var user = await _repository.GetUserByIdAsync(id);
            return user;
        }

    }
}
