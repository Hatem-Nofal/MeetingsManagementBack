using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MeetingsManagement.Data;
using Volo.Abp.DependencyInjection;

namespace MeetingsManagement.EntityFrameworkCore;

public class EntityFrameworkCoreMeetingsManagementDbSchemaMigrator
    : IMeetingsManagementDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreMeetingsManagementDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the MeetingsManagementDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<MeetingsManagementDbContext>()
            .Database
            .MigrateAsync();
    }
}
