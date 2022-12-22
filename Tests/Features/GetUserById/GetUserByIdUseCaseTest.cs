using Moq;
using Src.Features.GetUserById;
using Src.Shared.Domain;
using Src.Shared.Repository.Interface;
using System;
using System.Collections.Generic;
using Xunit;

namespace Tests.Features.GetUserById
{
    public class GetUserByIdUseCaseTest
    {
        private readonly Mock<IUserRepository> _mock;

        public GetUserByIdUseCaseTest()
        {
            _mock = new Mock<IUserRepository>();
        }

        [Fact]
        public void GetUserReturnResult()
        {
            var userResult = new List<User>();
            userResult.Add(
                new User
                {
                    Id = 1,
                    Nome = "ricardo"
                }
                ); ;
            _mock.Setup(x => x.GetUserByIdAsync(19)).ReturnsAsync(userResult);

            var useCase = new GetUserByIdUseCase(_mock.Object);
            var call = useCase.ExecuteAsync(19);
            Assert.Equal(call.Result[0].Nome, "ricardo");
        }
    }
}
