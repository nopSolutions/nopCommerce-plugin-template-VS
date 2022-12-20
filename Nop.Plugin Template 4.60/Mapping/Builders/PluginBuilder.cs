using FluentMigrator.Builders.Create.Table;
using Nop.Data.Mapping.Builders;
using $safeprojectname$.Domains;

namespace $safeprojectname$.Mapping.Builders
{
    public class PluginBuilder : NopEntityBuilder<CustomTable>
    {
        #region Methods
    
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
        }

        #endregion
    }
}