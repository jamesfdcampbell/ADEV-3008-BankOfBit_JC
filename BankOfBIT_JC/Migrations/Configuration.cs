namespace BankOfBIT_JC.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<BankOfBIT_JC.Data.BankOfBIT_JCContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BankOfBIT_JC.Data.BankOfBIT_JCContext";
        }

        protected override void Seed(BankOfBIT_JC.Data.BankOfBIT_JCContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
