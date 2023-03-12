using Src.Shared.Utils;
using System.Threading.Tasks;

namespace Src.Features.PostUser
{
    public interface IPostUserUseCase
    {
        Task<DataResult> ExecuteAsync(PostUserInput input);
    }
    public record PostUserInput(string Nome);

}