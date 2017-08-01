using Microsoft.AspNet.Identity.EntityFramework;

namespace InteriorMobilya.Model.Entities.Identity
{
    public class Role:IdentityRole
    {
        public Role()
        {

        }

        public Role(string RoleName)
        {
            Name = RoleName;
        }
    }
}
