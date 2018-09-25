using CoreApi.Entity;
using AutoFixture;

namespace CoreApi.InversionOfControl
{
    public static class DatabaseTestData
    {
        public static void Create(DatabaseContext databaseContext)
        {
            var fixture = new Fixture();
            fixture.Customize<Entity.Model.CustomerAddress>(x => x.Without(c => c.Customer));
            fixture.Customize<Entity.Model.Order>(x => x.Without(c => c.Customer));

            var list = fixture.CreateMany<Entity.Model.Customer>(100);
            databaseContext.Customer.AddRange(list);
            databaseContext.SaveChanges();
        }
    }
}