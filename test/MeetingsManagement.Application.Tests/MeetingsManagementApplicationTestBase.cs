using Volo.Abp.Modularity;

namespace MeetingsManagement;

public abstract class MeetingsManagementApplicationTestBase<TStartupModule> : MeetingsManagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
