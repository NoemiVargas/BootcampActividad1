using JazaniActividad.Application.Admins.Dtos.Users;
using JazaniActividad.Application.Cores.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazaniActividad.Application.Admins.Services
{
    public interface IUserService : ISaveService<UserDto, UserSaveDto, int>
    {
        Task<UserSecurityDto> LoginAsync(UserAuthDto userAuth);
    }
}
