using Core.Security.Entities;
using Core.Security.JWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Auths.Dtos
{
    public class RegisteredDto
    {
        public RefreshToken RefreshToken { get; internal set; }
        public AccessToken AccessToken { get; internal set; }
    }
}
