using Microsoft.AspNetCore.Authorization;

using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FilmeApi.Authorization
{
    public class IdadeMinimaHandler : AuthorizationHandler<IdadeMinimaRequeriment>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IdadeMinimaRequeriment requirement)
        {
            if(!context.User.HasClaim(c => c.Type == ClaimTypes.DateOfBirth))
                return Task.CompletedTask;

            var dataNascimento = Convert.ToDateTime(context.User.FindFirst(c => c.Type == ClaimTypes.DateOfBirth).Value);
            var idadeObtida = DateTime.Today.Year - dataNascimento.Year;

            if (dataNascimento > DateTime.Today.AddYears(-idadeObtida))
                idadeObtida--;

            if(idadeObtida >= requirement.IdadeMinima)
                context.Succeed(requirement);

            return Task.CompletedTask;
        }
    }
}
