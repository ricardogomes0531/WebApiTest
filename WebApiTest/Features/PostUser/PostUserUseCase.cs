using Src.Shared.Domain;
using Src.Shared.Repository.Interface;
using Src.Shared.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src.Features.PostUser
{
    public class PostUserUseCase : IPostUserUseCase
    {
        private readonly IUserRepository _repository;
        private readonly DataResult _output;

        public PostUserUseCase(
            IUserRepository repository
            )
        {
            _repository = repository;
            _output = new DataResult();
        }

        public async Task<DataResult> ExecuteAsync(PostUserInput input)
        {
            
            var user = await _repository.InsertUser(new User { Nome = input.Nome });
            if (user)
            {
                _output.AddResult(true);
            }
            else
            {
                _output.AddMessageError("A consulta não retornou resultado.");
            }
            
            return _output;
        }

    }
}
