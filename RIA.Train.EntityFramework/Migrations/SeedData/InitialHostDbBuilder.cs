using RIA.Train.EntityFramework;
using EntityFramework.DynamicFilters;

namespace RIA.Train.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly TrainDbContext _context;

        public InitialHostDbBuilder(TrainDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
