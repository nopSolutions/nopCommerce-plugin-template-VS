using FluentMigrator;
using Nop.Data.Migrations;

namespace $safeprojectname$.Migrations
{
    [SkipMigrationOnUpdate]
    [NopMigration("", "$safeprojectname$ schema")]
    public class SchemaMigration : AutoReversingMigration
    {
        private readonly IMigrationManager _migrationManager;

        public SchemaMigration(IMigrationManager migrationManager)
        {
            _migrationManager = migrationManager;
        }

        /// <summary>
        /// Collect the UP migration expressions
        /// </summary>
        public override void Up()
        {
        }
    }
}
