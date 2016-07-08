namespace MoneyManager.Db.DataAccess
{
    internal class MMDbInitializer : System.Data.Entity.CreateDatabaseIfNotExists<MMDbContext>
    {
        protected override void Seed(MMDbContext context)
        {
            base.Seed(context);
        }
    }
}
