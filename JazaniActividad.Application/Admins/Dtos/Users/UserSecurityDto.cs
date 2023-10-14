

using JazaniActividad.Core.Securities.Etities;

namespace JazaniActividad.Application.Admins.Dtos.Users
{
    public class UserSecurityDto : UserDto
    {
        public SecurityEntity Security { get; set; }
    }
}
