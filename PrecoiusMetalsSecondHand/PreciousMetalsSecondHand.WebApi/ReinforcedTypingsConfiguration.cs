using PreciousMetalsSecondHand.Data.Entities;
using PreciousMetalsSecondHand.WebApiModels.Models;
using Reinforced.Typings.Attributes;
using Reinforced.Typings.Fluent;

[assembly: TsGlobal(CamelCaseForProperties = true, CamelCaseForMethods = true, UseModules = true,
    DiscardNamespacesWhenUsingModules = true, ExportPureTypings = false, TabSymbol = "    ")]

namespace PreciousMetalsSecondHand.WebApi
{
    public class ReinforcedTypingsConfiguration
    {
        public static void Configure(ConfigurationBuilder builder)
        {
            const string productNamespace = "product";
            builder.ExportAsEnums(new[]
            {
                typeof(Ore),
                typeof(Category)
            }, conf =>
            {
                conf.OverrideNamespace(productNamespace);
            });

            builder.ExportAsClasses(new[]
            {
                typeof(ProductType)
            }, conf =>
            {
                conf.OverrideNamespace(productNamespace);
                conf.WithPublicProperties();
            });

            const string orderNamespace = "order";
            builder.ExportAsEnums(new[]
            {
                typeof(OrderType)
            }, conf =>
            {
                conf.OverrideNamespace(orderNamespace);
            });

            builder.ExportAsClasses(new[]
            {
                typeof(CreateOrderModel)
            }, conf =>
            {
                conf.OverrideNamespace(orderNamespace);
                conf.WithPublicProperties();
            });
        }
    }
}
