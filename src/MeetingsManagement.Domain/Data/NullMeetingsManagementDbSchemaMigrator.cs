using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MeetingsManagement.Data;

/* This is used if database provider does't define
 * IMeetingsManagementDbSchemaMigrator implementation.
 */
public class NullMeetingsManagementDbSchemaMigrator : IMeetingsManagementDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
