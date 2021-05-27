using Autofac;
using inQuba.Drinks.Factories;

namespace inQuba.Drinks.Ioc
{
    public class DrinksModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DrinkFactory>()
                .As<IDrinkFactory>()
                .InstancePerDependency();
        }
    }
}
