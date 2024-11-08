using System.Threading.Tasks;

namespace MeetingsManagement.Data;

public interface IMeetingsManagementDbSchemaMigrator
{
    Task MigrateAsync();
}
