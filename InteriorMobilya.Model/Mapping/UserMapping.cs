using InteriorMobilya.Model.Entities.Identity;
using System.Data.Entity.ModelConfiguration;

namespace InteriorMobilya.Model.Mapping
{
    public class UserMapping : EntityTypeConfiguration<ApplicationUser>
    {
        public UserMapping()
        {
            Ignore(x => x.PhoneNumberConfirmed);
            Ignore(x => x.PhoneNumber);
            Ignore(x => x.TwoFactorEnabled);
            Ignore(x => x.AccessFailedCount);
            Ignore(x => x.LockoutEnabled);
        }
    }
}
