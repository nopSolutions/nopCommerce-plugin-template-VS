using FluentMigrator;
using Nop.Data.Extensions;
using Nop.Data.Migrations;
using $safeprojectname$.Domains;

namespace $safeprojectname$.Migrations;

[NopMigration("$time$", "$safeprojectname$ schema", MigrationProcessType.Installation)]
public class SchemaMigration : AutoReversingMigration
{
    /// <summary>
    /// Collect the UP migration expressions
    /// </summary>
    public override void Up()
    {
        Create.TableFor<CustomTable>();
    }
}