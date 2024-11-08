using MeetingsManagement.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MeetingsManagement.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MeetingsManagementEntityFrameworkCoreModule),
    typeof(MeetingsManagementApplicationContractsModule)
    )]
public class MeetingsManagementDbMigratorModule : AbpModule
{
}
