using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src.Shared.Repository.Query
{
    public static class UserQuery
    {
        public static string GetUserByIdQuery=>
                    @"select * from usuario where id=@Id;";
        
    }
}
