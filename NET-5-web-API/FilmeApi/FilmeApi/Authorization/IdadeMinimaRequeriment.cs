using Microsoft.AspNetCore.Authorization;

namespace FilmeApi.Authorization
{
    public class IdadeMinimaRequeriment : IAuthorizationRequirement
    {
        public int IdadeMinima { get; set; }

        public IdadeMinimaRequeriment(int idadeMinima)
        {
            IdadeMinima = idadeMinima;
        }
    }
}
