using Volo.Abp.Modularity;

namespace MeetingsManagement;

/* Inherit from this class for your domain layer tests. */
public abstract class MeetingsManagementDomainTestBase<TStartupModule> : MeetingsManagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
