namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Balance affecting mods.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void BalanceMods() {

            string catalog = "Balance";

            AddMod(new Review(2039606384u, "Easy Mode: Money Mod") {
                Affect = Factor.Revenue,
                Authors = "Anvilarse",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.UnlimitedMoney, Status.MinorIssues  },
                    { Vanilla.HardMode      , Status.Incompatible },

                    { 2039606384u, Status.Incompatible }, // Easy Mode: Money Mod
                    { 2039205403u, Status.Incompatible }, // Free Maintenance by Anvilarse
                    { 1830455071u, Status.Incompatible }, // EasyMode
                    { 1744522363u, Status.Incompatible }, // Money Back (Refund)
                    { 1598546349u, Status.Incompatible }, // Mary's Mod
                    { 1227735337u, Status.Incompatible }, // Full Refund Cost[Industries Compatible]
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Sets all construction, maintennace and relocation costs to zero." },
                    { Vanilla.UnlimitedMoney, "[Vanilla Mod: Unlimited Money] If you have unlimited money, Easy Mode mod is not much use." },
                    { 2039606384u, "[Mod: Free Maintenance] Easy Mode includes free maintenance, so you can remove one of these mods." },
                },
                ReleasedDuring = GameVersion.SunsetHarbor,
            });

            // confirmed by anvil that it sets maintenance to zero for everything (including transport)
            AddMod(new Review(2039205403u, "Free Maintenance by Anvilarse") {
                Affect = Factor.Revenue,
                Authors = "Anvilarse",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.UnlimitedMoney, Status.MinorIssues  },
                    { Vanilla.HardMode      , Status.Incompatible },

                    { 2039606384u, Status.Incompatible }, // Easy Mode: Money Mod
                    { 2039205403u, Status.Incompatible }, // Free Maintenance by Anvilarse
                    { 1830455071u, Status.Incompatible }, // EasyMode
                    { 1744522363u, Status.Incompatible }, // Money Back (Refund)
                    { 1598546349u, Status.Incompatible }, // Mary's Mod
                    { 1227735337u, Status.Incompatible }, // Full Refund Cost[Industries Compatible]
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Sets all maintenance fees to zero." },
                    { 2039606384u, "[Mod: Easy Mode: Money] Easy Money also sets maintenance fees to zero. Use one of the mods, not both." },
                },
                ReleasedDuring = GameVersion.SunsetHarbor,
            });

            AddMod(new Review(2027161563u, "Lifecycle Rebalance Revisited") {
                Affect = Factor.Aging
                       | Factor.Education
                       | Factor.Health
                       | Factor.Immigrants
                       | Factor.TransportPreference,
                Authors = "algernon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2027161563u, Status.Incompatible }, // Lifecycle Rebalance Revisited
                    { 2025147082u, Status.Recommended  }, // Realistic Population revisited
                    { 1749971558u, Status.MinorIssues  }, // Real Time Offline
                    { 1420955187u, Status.Compatible   }, // Real Time
                    { 1383456057u, Status.Incompatible }, // Shicho
                    //Randomize Age Cim Move In (incompat)
                    //Lifespan Changer (incompat)
                    //Slow Citizen Aging (incompat)
                    //Very Slow Citizen Aging (incompat)
                    //[ARIS] Early Death (incompat)
                    { 654707599u, Status.Incompatible }, // Citizen Lifecycle Rebalance v2.6
                    { 643642403u, Status.Incompatible }, // Lifespan multiplier v1.1
                    { 541673195u, Status.Incompatible }, // Resident Travel Rebalance v1.1
                    { 409071509u, Status.Incompatible }, // Slow Citizen Aging Configurable
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 654707599u, // Citizen Lifecycle Rebalance v2.6
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/algernon-A/Lifecycle-Rebalance-Revisited",
            });

            AddMod(new Review(2025147082u, "Realistic Population revisited") {
                Affect = Factor.BuildingCapacity
                       | Factor.Consumption
                       | Factor.Employment
                       | Factor.Immigrants
                       | Factor.LandValue
                       | Factor.Pollution
                       | Factor.Production
                       | Factor.Revenue
                       | Factor.TransportPreference,
                Authors = "algernon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2027161563u, Status.Recommended  }, // Lifecycle Rebalance Revisited
                    { 2016920607u, Status.Compatible   }, // Ploppable RICO revisited
                    { 1587482024u, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1204126182u, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 931330091u , Status.Incompatible }, // 410344523 PopBalanceMod
                    { 586012417u , Status.Incompatible }, // Ploppable RICO (original)
                    { 426163185u , Status.Incompatible }, // Realistic Population and Consumption (WG)
                    { 410344523u , Status.Incompatible }, // PopBalanceMod
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 426163185u, // Realistic Population and Consumption (WG)
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/algernon-A/Realistic-Population-Revisited",
            });

            AddMod(new Review(1830455071u, "EasyMode") {
                Affect = Factor.Bulldoze
                       | Factor.Construction
                       | Factor.MaintenanceCost
                       | Factor.PlaceAndMove
                       | Factor.Money
                       | Factor.Revenue,
                Authors = "GoNutsDonuts",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.UnlimitedMoney, Status.MinorIssues  },
                    { Vanilla.HardMode      , Status.Incompatible },

                    { 2039606384u, Status.Incompatible }, // Easy Mode: Money Mod
                    { 2039205403u, Status.Incompatible }, // Free Maintenance by Anvilarse
                    { 1744522363u, Status.Incompatible }, // Money Back (Refund)
                    { 1598546349u, Status.Incompatible }, // Mary's Mod
                    { 1227735337u, Status.Incompatible }, // Full Refund Cost[Industries Compatible]
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Reduces cost of construction, maintenance, relocation, increases refund." },
                    { Vanilla.UnlimitedMoney, "[Vanilla Mod: Unlimited Money] If you have unlimited money, EasyMode mod is not much use." },
                },
                Published = WorkshopDate("10 Aug, 2019"),
                Updated = WorkshopDate("10 Aug, 2019"),
            });

            AddMod(new Review(1806759255u, "Customize It Extended") {
                Affect = Factor.BuildingInfo
                       | Factor.BuildingCapacity
                       | Factor.Employment
                       | Factor.Emptying
                       | Factor.Entertainment
                       | Factor.Health
                       | Factor.Pollution
                       | Factor.Service
                       | Factor.StorageCapacity
                       | Factor.VehicleCapacity,
                Authors = "C#",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1865667356u, Status.Unknown      }, // Twitch Citizens
                    { 1562650024u, Status.Compatible   }, // Rebalanced Industries
                    { 1440928803u, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138u, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1369729955u, Status.Incompatible }, // Customize It (original mod)
                    { 946550801u , Status.Incompatible }, // Park Rebalance
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 1369729955u, // Customize It (original mod)
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/Celisuis/CustomizeItExtended",
            });

            AddMod(new Review(1765325082u, "Customizable Education") {
                Affect = Factor.Education
                       | Factor.Immigrants,
                Authors = "monkey_sheng",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 654707599u , Status.Incompatible }, // Citizen Lifecycle Rebalance
                    { 1915645482u, Status.Incompatible }, // Citizen Lifecycle Rebalance v2
                },
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.MinorIssues // somtimes loses settings
                      | ItemFlags.Abandonware,
            });

            // todo: prolly incompatible with similar mods
            AddMod(new Review(1744522363u, "Money Back (Refund)") {
                Affect = Factor.Money
                       | Factor.PlaceAndMove
                       | Factor.Revenue,
                Authors = "vpoteryaev",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.UnlimitedMoney, Status.MinorIssues  }, // Unlimited Money (bundled with Cities: Skylines)
                    { Vanilla.HardMode      , Status.Incompatible }, // Hard Mode (bundled with Cities: Skylines)

                    { 2039606384u, Status.Incompatible }, // Easy Mode: Money Mod
                    { 2039205403u, Status.Incompatible }, // Free Maintenance by Anvilarse
                    { 1830455071u, Status.Incompatible }, // EasyMode
                    { 1598546349u, Status.Incompatible }, // Mary's Mod
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Abandonware,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Allows altering the relocation costs and bulldozer refund amounts while game is paused." },
                },
                Published = WorkshopDate("18 May, 2019"),
                Updated = WorkshopDate("18 May, 2019"),
            });

            AddMod(new Review(1674732053u, "Employ Overeducated Workers V2 (1.11+)") {
                Affect = Factor.Employment,
                Authors = "pcfantasy",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1706703944u, Status.Compatible   }, // More Outside Interaction
                    { 1680840913u, Status.Compatible   }, // More Effective Transfer Manager
                    { 1674732053u, Status.Incompatible }, // Employ Overeducated Workers V2 (1.11+)
                    { 1623509958u, Status.Compatible   }, // Real Gas Station
                    { 1614061108u, Status.Compatible   }, // Real Construction
                    { 1192503086u, Status.Compatible   }, // Real City V9.0.03.10
                    { 1114249433u, Status.Incompatible }, // Employ Overeducated Workers (1.10+)
                    { 569008960u , Status.Incompatible }, // Employ Overeducated Workers
                },
                ContinuationOf = 1114249433u, // Employ Overeducated Workers (1.10+)
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.Obsolete, // use Industry 4.0 city/district policy
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "If you have Industries DLC, the 'Industry 4.0' city/district policy might be better alternative." },
                },
                SourceURL = "https://github.com/pcfantasy/EmployOvereducatedWorkers-v2",
            });

            AddMod(new Review(1598546349u, "Mary's Mod") {
                Affect = Factor.Money,
                Authors = "tim",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.UnlimitedMoney, Status.MinorIssues  },
                    { Vanilla.HardMode      , Status.Incompatible },

                    { 2039606384u, Status.Incompatible }, // Easy Mode: Money Mod
                    { 2039205403u, Status.Incompatible }, // Free Maintenance by Anvilarse
                    { 1830455071u, Status.Incompatible }, // EasyMode
                    { 1744522363u, Status.Incompatible }, // Money Back (Refund)
                    { 1598546349u, Status.Incompatible }, // Mary's Mod
                    { 1227735337u, Status.Incompatible }, // Full Refund Cost[Industries Compatible]
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { Vanilla.UnlimitedMoney, "[Vanilla Mod: Unlimited Money] If you have unlimited money, Mary's Mod mod is not much use." },
                },
                Published = WorkshopDate("22 Dec, 2018"),
                Updated = WorkshopDate("22 Dec, 2018"),
            });

            AddMod(new Review(1562650024u, "Rebalanced Industries") {
                Affect = Factor.BuildingCapacity
                       | Factor.BuildingLevel
                       | Factor.Consumption
                       | Factor.Employment
                       | Factor.Unlockers
                       | Factor.Production
                       | Factor.StorageCapacity
                       | Factor.VehicleCapacity,
                Authors = "Quboid",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806759255u, Status.Compatible   }, // Customize It Extended
                    { 1553517176u, Status.Incompatible }, // Specialized Industry Fix Redux
                    { 1440928803u, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138u, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1369729955u, Status.Incompatible }, // Customize It!
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/Quboid/CSL_RebalancedIndustries",
            });

            // todo: prolly incompat with WG mods
            AddMod(new Review(1551563197u, "EnhancedBuildingCapacity - Fixed") {
                Affect = Factor.BuildingCapacity
                       | Factor.Consumption
                       | Factor.Production
                       | Factor.StorageCapacity,
                Authors = " Flexible Games",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 931330091u , Status.Incompatible }, // 410344523 PopBalanceMod
                    { 411190402u , Status.Incompatible }, // Building Simulation Overhaul (no longer in workshop)
                    { 410344523u , Status.Incompatible }, // PopBalanceMod
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Review(1522785644u, "Infinite Demand Mod") {
                Affect = Factor.DemandRCI
                       | Factor.Immigrants,
                Authors = "μohnytoxic™",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.HardMode, Status.Incompatible }, // Hard Mode (bundled with Cities: Skylines)
                },
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Review(1412844620u, "Realistic Walking Speed") {
                Affect = Factor.Velocity,
                Authors = "egi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1749971558u, Status.Compatible   }, // Real Time Offline
                    { 1420955187u, Status.Compatible   }, // Real Time
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.ParkLife,
                SourceURL = "https://github.com/DaEgi01/CitiesSkylines-RealisticWalkingSpeed",
            });

            AddMod(new Review(1403960464u, "Maintenance Fees (Parklife Ready)") {
                Affect = Factor.Budget // side effect
                       | Factor.MaintenanceCost
                       | Factor.Revenue, // side effect
                Authors = "Xial",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.UnlimitedMoney, Status.MinorIssues  },
                    { Vanilla.HardMode      , Status.Incompatible },

                    { 602336261u, Status.Incompatible }, // Maintenance Fees
                },
                ContinuationOf = 602336261u, // Maintenance Fees
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/Xial/Maintenancefee",
            });

            // refund full construction cost when bulldozing
            AddMod(new Review(1227735337u, "Full Refund Cost[Industries Compatible]") {
                Affect = Factor.Money,
                Authors = "C#",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.UnlimitedMoney, Status.MinorIssues  }, // Unlimited Money (bundled with Cities: Skylines)
                    { Vanilla.HardMode      , Status.Incompatible }, // Hard Mode (bundled with Cities: Skylines)

                    { 2039606384u, Status.Incompatible }, // Easy Mode: Money Mod
                    { 2039205403u, Status.Incompatible }, // Free Maintenance by Anvilarse
                    { 1830455071u, Status.Incompatible }, // EasyMode
                    { 1598546349u, Status.Incompatible }, // Mary's Mod
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { Vanilla.UnlimitedMoney, "[Vanilla Mod: Unlimited Money] If you have unlimited money, Full Refund Cost mod is not much use." },
                },
                Published = WorkshopDate("10 Dec, 2017"),
                Updated = WorkshopDate("5 Mar, 2019"),
            });

            // An update to 406841580u - SimCity Fudged Population, but with better UI.
            // Dev still responsive as of Feb 2020, confirms mod still works.
            AddMod(new Review(1224627683u, "Fudged Population Enhanced") {
                Affect = Factor.Toolbar,
                Authors = "khollenbeck",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 888017364u, Status.Incompatible }, // Quartz (Sapphire) - Fixed 1.11
                    { 781767563u, Status.Incompatible }, // Extended InfoPanel
                    { 576970398u, Status.Incompatible }, // Quartz (former Sapphire) - UI skin framework
                    { 406841580u, Status.Incompatible }, // SimCity Fudged Population
                    { 421770876u, Status.Incompatible }, // Sapphire - UI skin framework
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/krishollenbeck/cities_skylines_enhanced_fudged_population_mod",
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            // Real population, only one household at low density, high density population becomes larger
            AddMod(new Review(1587482024u, "真实人口，低密度只有一户人，高密度人口容量变大") {
                Affect = Factor.BuildingCapacity,
                Authors = "changxiuyingjian",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2025147082u, Status.Incompatible }, // Realistic Population revisited
                    { 2016920607u, Status.Incompatible }, // Ploppable RICO revisited
                    { 1587482024u, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大
                    { 1204126182u, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 931330091u , Status.Incompatible }, // 410344523 PopBalanceMod
                    { 586012417u , Status.Incompatible }, // Ploppable RICO (original)
                    { 426163185u , Status.Incompatible }, // Realistic Population and Consumption Mod v8.4.0
                    { 410344523u , Status.Incompatible }, // PopBalanceMod
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 2025147082u, // Realistic Population revisited
            });

            AddMod(new Review(1553517176u, "Specialized Industry Fix Redux") {
                Affect = Factor.Consumption
                       | Factor.Production,
                Authors = "Vectorial1024",
                BrokenBy = GameVersion.Industries, // lol
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1562650024u, Status.Incompatible }, // Rebalanced Industries
                    { 662386761u , Status.Incompatible }, // Specialised Industry Fix [BUGFIX for Vanilla]
                },
                CompatibleWith = GameVersion.Industries,
                ContinuationOf = 662386761u, // Specialised Industry Fix [BUGFIX for Vanilla]
                Flags = ItemFlags.Obsolete
                      | ItemFlags.BrokenByUpdate // broken since Industries DLC (lol)
                      | ItemFlags.GameBreaking
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.Industries,
                ReplaceWith = 1562650024u, // Rebalanced Industries
                SuppressVersionWarnings = true,
                SourceURL = "https://github.com/Vectorial1024/SpecializedIndustryFixRedux",
            });;

            AddMod(new Review(1487849798u, "Higher Income Mod 1.2a") {
                Affect = Factor.Revenue,
                Authors = "I'm Not MentaL",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1498036881u, Status.Incompatible }, // UltimateMod 2.4 ( Higher Income and More Options )
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable, // some users report issues with xml file
                ReplaceWith = 1498036881u, // UltimateMod 2.4 ( Higher Income and More Options )
            });

            AddMod(new Review(1398502258u, "Dam Upkeep Scaling") {
                Affect = Factor.MaintenanceCost,
                Authors = "Derangedteddy",
                BrokenBy = GameVersion.Industries,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.HardMode, Status.Incompatible }, // Hard Mode (bundled with Cities: Skylines)
                },
                CompatibleWith = GameVersion.ParkLife,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // Industries DLC
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.ParkLife,
            });

            // icky - not sure if this belongs in balance catagory, but lots of mods here conflict with it
            // (it's kind of manual balance adjustment for buildings and vehicles, although AVO could be considered same? meh)
            AddMod(new Review(1369729955u, "Customize It!") {
                Affect = Factor.BuildingInfo
                       | Factor.BuildingCapacity
                       | Factor.Employment
                       | Factor.Emptying
                       | Factor.Entertainment
                       | Factor.Health
                       | Factor.Pollution
                       | Factor.Service
                       | Factor.StorageCapacity,
                Authors = "TPB",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1865667356u, Status.Unknown      }, // Twitch Citizens
                    { 1806759255u, Status.Incompatible }, // Customize It Extended
                    { 1562650024u, Status.Incompatible }, // Rebalanced Industries
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 946550801u , Status.Incompatible }, // Park Rebalance
                },
                Flags = ItemFlags.Obsolete // new version avail
                      | ItemFlags.SourceAvailable,
                ReplaceWith = 1806759255u, // Customize It Extended
                SourceURL = "https://github.com/TPBCS/CustomizeIt",
            });

            // Residents become senile
            // Actually translated clone of 409070739u - Very Slow Citizen Aging (by Nohealforu)
            AddMod(new Review(1196714522u, "居民衰老变十六分之一") {
                Affect = Factor.Aging,
                Authors = "回忆时光℡",
                Catalog = catalog,
                CloneOf = 409070739u, // Very Slow Citizen Aging
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                    { 1420955187u, Status.Incompatible }, // Real Time
                    { 654707599u , Status.Incompatible }, // Citizen Lifecycle Rebalance
                    { 643642403u , Status.Incompatible }, // Lifespan multiplier v1.1
                    { 573925048u , Status.Incompatible }, // Lifespan Changer
                    { 571655171u , Status.Incompatible }, // Randomize Age Cims Move in
                    { 541673195u , Status.Incompatible }, // Resident Travel Rebalance v1.1:
                    { 421188880u , Status.Incompatible }, // [ARIS] Early Death
                    { 409071509u , Status.Incompatible }, // Slow Citizen Aging Configurable
                    { 409070739u , Status.Incompatible }, // Very Slow Citizen Aging
                    { 409070218u , Status.Incompatible }, // Slow Citizen Aging
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // Game update during 2018 broke it
                      | ItemFlags.Obsolete // Replaced by WG's Citizen Lifecycle Rebalance
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                ReplaceWith = 654707599u, // Citizen Lifecycle Rebalance
            });

            AddMod(new Review(1114249433u, "Employ Overeducated Workers (1.10+)") {
                Affect = Factor.Employment,
                Authors = "Ellie",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1706703944u, Status.Incompatible }, // More Outside Interaction
                    { 1680840913u, Status.Incompatible }, // More Effective Transfer Manager
                    { 1674732053u, Status.Incompatible }, // Employ Overeducated Workers V2 (1.11+)
                    { 1623509958u, Status.Incompatible }, // Real Gas Station
                    { 1614061108u, Status.Incompatible }, // Real Construction
                    { 1192503086u, Status.Incompatible }, // Real City V9.0.03.10
                    { 1114249433u, Status.Incompatible }, // Employ Overeducated Workers (1.10+)
                    { 569008960u , Status.Incompatible }, // Employ Overeducated Workers
                },
                ContinuationOf = 569008960u, // Employ Overeducated Workers
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.Obsolete, // use Industry 4.0 city/district policy
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "If you have Industries DLC, the 'Industry 4.0' city/district policy might be better alternative." },
                },
                ReplaceWith = 1674732053u, // Employ Overeducated Workers V2 (1.11+)
                SourceURL = "https://github.com/AmaroqOkami/Skylines-EmployOvereducatedWorkers",
            });

            // Broken since May 2019
            AddMod(new Review(1108715012u, "Adjustable Business Consumption") {
                Affect = Factor.Consumption
                       | Factor.DemandRCI
                       | Factor.Production
                       | Factor.StorageCapacity,
                Authors = "Ellie",
                BrokenBy = GameVersion.Campus,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // incompat: Infinite Goods by Googen
                    { 1614061108u, Status.Incompatible }, // Real Construction
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 426163185u , Status.Incompatible }, // Realistic Population and Consumption Mod v8.4.0
                    { 408706691u , Status.Incompatible }, // Proper Hardness

                    { Vanilla.HardMode, Status.Incompatible }, // Hard Mode (bundled with Cities: Skylines)
                },
                CompatibleWith = GameVersion.Industries,
                Flags = ItemFlags.BrokenByUpdate // some time around May 2019
                      | ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.Concerts,
                SourceURL = "https://github.com/AmaroqOkami/CS-AdjustableBusinessConsumption",
            });

            AddMod(new Review(946550801u, "Park Rebalance") {
                Affect = Factor.Entertainment,
                Authors = "Azzurite, egi",
                BrokenBy = GameVersion.Campus,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806759255u, Status.Incompatible }, // Customize It Extended
                    { 1369729955u, Status.Incompatible }, // Customize It
                },
                CompatibleWith = GameVersion.Industries,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // whatever came after the Industries update
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.MinorIssues // mod doesn't disable properly
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                ReleasedDuring = GameVersion.ParkLife,
                ReplaceWith = 1806759255u, // Customize It Extended
                SourceURL = "https://gitlab.com/azzurite/parkrebalance",
            });

            AddMod(new Review(938049744u, "Proper Hardness Fixed") {
                Affect = Factor.Boredom
                       | Factor.BuildingInfo
                       | Factor.BuildingLevel
                       | Factor.Construction
                       | Factor.DemandRCI
                       | Factor.Despawn
                       | Factor.Employment
                       | Factor.Disasters
                       | Factor.Happiness
                       | Factor.Immigrants
                       | Factor.MaintenanceCost
                       | Factor.Unlockers // reduced cash reward
                       | Factor.Money
                       | Factor.Pollution
                       | Factor.Production
                       | Factor.Revenue
                       | Factor.TransportPreference
                       | Factor.VehicleCapacity
                       | Factor.Wealth
                       | Factor.Zoning,
                Authors = "MarkedOne",
                BrokenBy = GameVersion.ParkLife,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.UnlimitedMoney, Status.MinorIssues  },
                    { Vanilla.HardMode      , Status.Incompatible },
                    { 2039606384u, Status.Incompatible }, // Easy Mode: Money Mod
                    { 2039486691u, Status.Incompatible }, // 1133108993 Extended Building Information (1
                    { 2039205403u, Status.Incompatible }, // Free Maintenance by Anvilarse
                    { 2025147082u, Status.Incompatible }, // Realistic Population revisited
                    { 2016920607u, Status.Incompatible }, // RICO revisited
                    { 1875298330u, Status.Incompatible }, // Extended Building Info (live627)
                    { 1830455071u, Status.Incompatible }, // EasyMode
                    { 1776052533u, Status.Incompatible }, // Stops & Stations
                    { 1766839841u, Status.Incompatible }, // Anxiety Reducer
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                    { 1744522363u, Status.Incompatible }, // Money Back (Refund)
                    { 1614061108u, Status.Incompatible }, // Real Construction
                    { 1598546349u, Status.Incompatible }, // Mary's Mod
                    { 1587482024u, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大
                    { 1556715327u, Status.Incompatible }, // Show It!
                    { 1551563197u, Status.Incompatible }, // EnhancedBuildingCapacity - Fixed
                    { 1420955187u, Status.Incompatible }, // Real Time
                    { 1393820309u, Status.Incompatible }, // Ticket Price Customizer
                    { 1227735337u, Status.Incompatible }, // Full Refund Cost[Industries Compatible]
                    { 1204126182u, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 1133108993u, Status.Incompatible }, // Extended Building Information (1.10+)
                    { 1108715012u, Status.Incompatible }, // Adjustable Business Consumption
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 931330091u , Status.Incompatible }, // 410344523 PopBalanceMod
                    { 928988785u , Status.Incompatible }, // Extended Building Information (billw)
                    { 670422128u , Status.Incompatible }, // Extended Building Information (Hedgehog)
                    { 586012417u , Status.Incompatible }, // Ploppable RICO
                    { 426163185u , Status.Incompatible }, // Realistic Population and Consumption Mod v8.4.0
                    { 414469593u , Status.Incompatible }, // Extended Building Information (emf)
                    { 410344523u , Status.Incompatible }, // PopBalanceMod
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.GreenCities,
                // note: if there is a knighthawkGP version, then it's continuation of that instead
                ContinuationOf = 408706691u, // Proper Hardness
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.GameBreaking // Breaks police service (milestone 5 or above), spams log with errors, etc.
                      | ItemFlags.SaveAltering
                      | ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.MassTransit,
                SourceURL = "https://github.com/m4rked0ne/Cities-Skyline-Proper-Hardness-master",
            });

            AddMod(new Review(931330091u, "410344523 PopBalanceMod") {
                Affect = Factor.BuildingCapacity
                       | Factor.Consumption,
                Authors = "onekil7804",
                BrokenBy = GameVersion.AfterDark,
                Catalog = catalog,
                CloneOf = 410344523u, // PopBalanceMod
                Compatibility = new Dictionary<ulong, Status>() {
                    // INCOMPATIBLE:
                    { 411190402u , Status.Incompatible }, // Building Simulation Overhaul (no longer in workshop)
                    { 2025147082u, Status.Incompatible }, // Realistic Population revisited
                    { 2016920607u, Status.Incompatible }, // RICO revisited
                    { 1587482024u, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大 (similar to pop bal mod)
                    { 1551563197u, Status.Incompatible }, // EnhancedBuildingCapacity - Fixed
                    { 1204126182u, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 931330091u , Status.Incompatible }, // 410344523 PopBalanceMod
                    { 637901778u , Status.Incompatible }, // Fire Spread [ Fixed for C:S 1.3.2+ ]
                    { 586012417u , Status.Incompatible }, // Ploppable RICO (original)
                    { 426163185u , Status.Incompatible }, // Realistic Population and Consumption Mod v8.4.0
                    { 410344523u , Status.Incompatible }, // PopBalanceMod
                    { 410234967u , Status.Incompatible }, // Fire Spread
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                    // COMPATIBLE:
                    // Control Building Level up v0.4
                    // Terraform Tool 0.5
                    // Public Transport Capacity (Real)
                    // Traffic++ (Zonable Pedestrian Paths)
                    // Trafic Report Tool
                    // Extended Public Transport UI
                    // Tree Brush
                    // City Statistics Easy Access
                    // City Vitals Watch
                },
                CompatibleWith = GameVersion.EuropeBiome,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // AD
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete // replaced by WG's pop & consumption mod, which itself has now been replaced
                      | ItemFlags.SourceUnavailable,
                Published = WorkshopDate("23 May, 2017"),
                ReplaceWith = 2025147082u, // Realistic Population revisited
                Updated = WorkshopDate("23 May, 2017"),
            });

            AddMod(new Review(654707599u, "Citizen Lifecycle Rebalance v2.6") {
                Affect = Factor.Aging
                       | Factor.Education
                       | Factor.Health
                       | Factor.Immigrants
                       | Factor.TransportPreference,
                ArchiveURL = "https://web.archive.org/web/20190806010838/https://steamcommunity.com/sharedfiles/filedetails/?id=654707599",
                Authors = "Whitefang Greytail",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2027161563u, Status.Incompatible }, // Lifecycle Rebalance Revisited
                    { 1765325082u, Status.Incompatible }, // Customizable Education
                    { 1749971558u, Status.MinorIssues  }, // Real Time Offline
                    { 1420955187u, Status.Compatible   }, // Real Time
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1196714522u, Status.Incompatible }, // 居民衰老变十六分之一
                    //Randomize Age Cim Move In (incompat)
                    //Lifespan Changer (incompat)
                    //Slow Citizen Aging (incompat)
                    //Very Slow Citizen Aging (incompat)
                    //[ARIS] Early Death (incompat)
                    { 654707599u , Status.Incompatible }, // Citizen Lifecycle Rebalance v2.6
                    { 643642403u , Status.Incompatible }, // Lifespan multiplier v1.1
                    { 541673195u , Status.Incompatible }, // Resident Travel Rebalance v1.1
                    { 409071509u , Status.Incompatible }, // Slow Citizen Aging Configurable
                },
                ContinuationOf = 643642403u, // Lifespan multiplier v1.1
                Flags = ItemFlags.Abandonware
                      | ItemFlags.NoWorkshop // Made "friends only" around March 2020
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("28 Mar, 2016"),
                SourceURL = "https://github.com/WhitefangGreytail/WG_CitizenEdit",
                Updated = WorkshopDate("31 Oct, 2018"),
            });

            AddMod(new Review(643642403u, "Lifespan multiplier v1.1") {
                Affect = Factor.Aging
                       | Factor.TransportPreference,
                Authors = "Whitefang Greytail",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // early death mods (incompat)
                    { 2027161563u, Status.Incompatible }, // Lifecycle Rebalance Revisited
                    { 1749971558u, Status.MinorIssues  }, // Real Time Offline
                    { 1420955187u, Status.MinorIssues  }, // Real Time (by dymanoid)
                    { 1196714522u, Status.Incompatible }, // 居民衰老变十六分之一
                    { 654707599u , Status.Incompatible }, // Citizen Lifecycle Rebalance v2.6
                    { 643642403u , Status.Incompatible }, // Lifespan multiplier v1.1
                    { 573925048u , Status.Incompatible }, // Lifespan Changer
                    { 571655171u , Status.Incompatible }, // Randomize Age Cims Move in
                    { 541673195u , Status.Incompatible }, // Resident Travel Rebalance v1.1
                    { 426163185u , Status.Incompatible }, // Realistic Population and Consumption Mod v8.4.0
                    { 421188880u , Status.Incompatible }, // [ARIS] Early Death
                    { 409071509u , Status.Incompatible }, // Slow Citizen Aging Configurable
                    { 409070739u , Status.Incompatible }, // Very Slow Citizen Aging
                    { 409070218u , Status.Incompatible }, // Slow Citizen Aging
                },
                ContinuationOf = 409071509u, // Slow Citizen Aging Configurable
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.NoWorkshop // Made "friends only" around March 2020
                      | ItemFlags.SourceAvailable,
                ReplaceWith = 654707599u, // Citizen Lifecycle Rebalance v2.6
                SourceURL = "https://github.com/WhitefangGreytail/WG_Lifespan",
            });

            AddMod(new Review(569008960u, "Employ Overeducated Workers") {
                Affect = Factor.Employment,
                Authors = "Akira Ishizaki",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1706703944u, Status.Incompatible }, // More Outside Interaction
                    { 1680840913u, Status.Incompatible }, // More Effective Transfer Manager
                    { 1674732053u, Status.Incompatible }, // Employ Overeducated Workers V2 (1.11+)
                    { 1623509958u, Status.Incompatible }, // Real Gas Station
                    { 1614061108u, Status.Incompatible }, // Real Construction
                    { 1192503086u, Status.Incompatible }, // Real City V9.0.03.10
                    { 1114249433u, Status.Incompatible }, // Employ Overeducated Workers (1.10+)
                    { 569008960u , Status.Incompatible }, // Employ Overeducated Workers
                },
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.Obsolete, // use Industry 4.0 city/district policy
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "If you have Industries DLC, the 'Industry 4.0' city/district policy might be better alternative." },
                },
                ReplaceWith = 1674732053u, // Employ Overeducated Workers V2 (1.11+)
                SourceURL = "https://github.com/AmaroqOkami/Skylines-EmployOvereducatedWorkers",
            });

            AddMod(new Review(541673195u, "Resident Travel Rebalance v1.1") {
                Affect = Factor.TransportPreference,
                Authors = "Whitefang Greytail",
                ArchiveURL = "https://web.archive.org/web/20160222120305/http://steamcommunity.com/sharedfiles/filedetails/?id=541673195",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2027161563u, Status.Incompatible }, // Lifecycle Rebalance Revisited
                    { 1749971558u, Status.MinorIssues  }, // Real Time Offline
                    { 1420955187u, Status.MinorIssues  }, // Real Time
                    { 1196714522u, Status.Incompatible }, // 居民衰老变十六分之一
                    { 654707599u , Status.Incompatible }, // Citizen Lifecycle Rebalance v2.6
                    { 643642403u , Status.Incompatible }, // Lifespan multiplier v1.1
                    { 426163185u , Status.Recommended  }, // Realistic Population and Consumption Mod v8.4.0
                    { 409071509u , Status.Incompatible }, // Slow Citizen Aging Configurable
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.NoWorkshop // Made "friends only" around March 2020
                      | ItemFlags.SourceUnavailable,
                Published = WorkshopDate("25 Oct, 2015"),
                Updated = WorkshopDate("30 Oct, 2015"),
            });

            // Incompatible with any mod which changes:
            // * residential household capacity,
            // * worker count,
            // * power, water, sewage, garbage,
            // * income, pollution or production.
            AddMod(new Review(426163185u, "Realistic Population and Consumption Mod v8.4.0") {
                Affect = Factor.BuildingCapacity
                       | Factor.Consumption
                       | Factor.Employment
                       | Factor.Immigrants
                       | Factor.LandValue
                       | Factor.Pollution
                       | Factor.Production
                       | Factor.Revenue
                       | Factor.TransportPreference,
                ArchiveURL = "https://web.archive.org/web/20190806010923/https://steamcommunity.com/sharedfiles/filedetails/?id=426163185",
                Authors = "Whitefang Greytail",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2025147082u, Status.Incompatible }, // Realistic Population revisited
                    { 2016920607u, Status.Compatible   }, // RICO revisited
                    { 1587482024u, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1204126182u, Status.Compatible   }, // Ploppable Rico High Density Fix
                    { 1108715012u, Status.Incompatible }, // Adjustable Business Consumption
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 931330091u , Status.Incompatible }, // 410344523 PopBalanceMod
                    { 643642403u , Status.Incompatible }, // Lifespan multiplier v1.1
                    { 586012417u , Status.Compatible   }, // Ploppable RICO
                    { 541673195u , Status.Compatible   }, // Resident Travel Rebalance v1.1
                    { 410344523u , Status.Incompatible }, // PopBalanceMod
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                    // INCOMPATIBLE:
                    // Building Simulation Overhaul
                    // Enhanced Building Capacity
                },
                ContinuationOf = 410344523u, // PopBalanceMod
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.NoWorkshop // Made hidden around March 2020
                      | ItemFlags.Obsolete // new version available
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("16 Apr, 2015"),
                ReplaceWith = 2025147082u, // Realistic Population revisited
                SourceURL = "https://github.com/WhitefangGreytail/WG_RealisticCitySkylines",
                Updated = WorkshopDate("25 Oct, 2018"),
            });

            AddMod(new Review(410344523u, "PopBalanceMod") {
                Affect = Factor.BuildingCapacity
                       | Factor.Consumption,
                Authors = "Kundun",
                BrokenBy = GameVersion.AfterDark,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // INCOMPATIBLE:
                    { 411190402u , Status.Incompatible }, // Building Simulation Overhaul (no longer in workshop)
                    { 2025147082u, Status.Incompatible }, // Realistic Population revisited
                    { 2016920607u, Status.Incompatible }, // RICO revisited
                    { 1587482024u, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大 (similar to pop bal mod)
                    { 1551563197u, Status.Incompatible }, // EnhancedBuildingCapacity - Fixed
                    { 1204126182u, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 931330091u , Status.Incompatible }, // 410344523 PopBalanceMod
                    { 637901778u , Status.Incompatible }, // Fire Spread [ Fixed for C:S 1.3.2+ ]
                    { 586012417u , Status.Incompatible }, // Ploppable RICO (original)
                    { 426163185u , Status.Incompatible }, // Realistic Population and Consumption Mod v8.4.0
                    { 410344523u , Status.Incompatible }, // PopBalanceMod
                    { 410234967u , Status.Incompatible }, // Fire Spread
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                    // COMPATIBLE:
                    // Control Building Level up v0.4
                    // Terraform Tool 0.5
                    // Public Transport Capacity (Real)
                    // Traffic++ (Zonable Pedestrian Paths)
                    // Trafic Report Tool
                    // Extended Public Transport UI
                    // Tree Brush
                    // City Statistics Easy Access
                    // City Vitals Watch
                },
                CompatibleWith = GameVersion.EuropeBiome,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // difficult to say when, but definitely broken
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete // replaced by WG's pop & consumption mod, which itself has now been replaced
                      | ItemFlags.SourceBundled,
                Published = WorkshopDate("19 Mar, 2015"),
                ReplaceWith = 2025147082u, // Realistic Population revisited
                Updated = WorkshopDate("26 Mar, 2015"),
            });

            AddMod(new Review(409071509u, "Slow Citizen Aging Configurable") {
                Affect = Factor.Aging,
                Authors = "Nohealforu",
                BrokenBy = GameVersion.Snowfall,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2027161563u, Status.Incompatible }, // Lifecycle Rebalance Revisited
                    { 1749971558u, Status.MinorIssues  }, // Real Time Offline
                    { 1420955187u, Status.MinorIssues  }, // Real Time (by dymanoid)
                    { 1196714522u, Status.Incompatible }, // 居民衰老变十六分之一
                    { 654707599u , Status.Incompatible }, // Citizen Lifecycle Rebalance v2.6
                    { 643642403u , Status.Incompatible }, // Lifespan multiplier v1.1
                    { 573925048u , Status.Incompatible }, // Lifespan Changer
                    { 571655171u , Status.Incompatible }, // Randomize Age Cims Move in
                    { 541673195u , Status.Incompatible }, // Resident Travel Rebalance v1.1:
                    { 421188880u , Status.Incompatible }, // [ARIS] Early Death
                    { 409071509u , Status.Incompatible }, // Slow Citizen Aging Configurable
                    { 409070739u , Status.Incompatible }, // Very Slow Citizen Aging
                    { 409070218u , Status.Incompatible }, // Slow Citizen Aging
                },
                CompatibleWith = GameVersion.AfterDark,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // 1.3.2 Snowfall update
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.InitialRelease,
                ReplaceWith = 643642403u, // Lifespan multiplier v1.1
            });

            // note possibly a KnighthawkGP continuation (AD & snowfall compat) of this prior to later Proper Hardness Fixed version
            // see https://github.com/Knighth/Cities-Skyline-Proper-Hardness
            AddMod(new Review(408706691u, "Proper Hardness") {
                Affect = Factor.Boredom
                       | Factor.BuildingInfo
                       | Factor.BuildingLevel
                       | Factor.Construction
                       | Factor.DemandRCI
                       | Factor.Despawn
                       | Factor.Employment
                       | Factor.Disasters
                       | Factor.Happiness
                       | Factor.Immigrants
                       | Factor.MaintenanceCost
                       | Factor.Unlockers // reduced cash reward
                       | Factor.Money
                       | Factor.Pollution
                       | Factor.Production
                       | Factor.Revenue
                       | Factor.TransportPreference
                       | Factor.VehicleCapacity
                       | Factor.Wealth
                       | Factor.Zoning,
                Authors = "emf",
                BrokenBy = GameVersion.AfterDark,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.UnlimitedMoney, Status.MinorIssues  },
                    { Vanilla.HardMode      , Status.Incompatible },
                    // incompat with t++ & likely other traffic mods
                    { 2039606384u, Status.Incompatible }, // Easy Mode: Money Mod
                    { 2039486691u, Status.Incompatible }, // 1133108993 Extended Building Information (1
                    { 2039205403u, Status.Incompatible }, // Free Maintenance by Anvilarse
                    { 2025147082u, Status.Incompatible }, // Realistic Population revisited
                    { 2016920607u, Status.Incompatible }, // RICO revisited
                    { 1875298330u, Status.Incompatible }, // Extended Building Info (live627)
                    { 1830455071u, Status.Incompatible }, // EasyMode
                    { 1776052533u, Status.Incompatible }, // Stops & Stations
                    { 1766839841u, Status.Incompatible }, // Anxiety Reducer
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                    { 1744522363u, Status.Incompatible }, // Money Back (Refund)
                    { 1614061108u, Status.Incompatible }, // Real Construction
                    { 1598546349u, Status.Incompatible }, // Mary's Mod
                    { 1587482024u, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大
                    { 1556715327u, Status.Incompatible }, // Show It!
                    { 1551563197u, Status.Incompatible }, // EnhancedBuildingCapacity - Fixed
                    { 1420955187u, Status.Incompatible }, // Real Time
                    { 1393820309u, Status.Incompatible }, // Ticket Price Customizer
                    { 1227735337u, Status.Incompatible }, // Full Refund Cost[Industries Compatible]
                    { 1204126182u, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 1133108993u, Status.Incompatible }, // Extended Building Information (1.10+)
                    { 1108715012u, Status.Incompatible }, // Adjustable Business Consumption
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 931330091u , Status.Incompatible }, // 410344523 PopBalanceMod
                    { 928988785u , Status.Incompatible }, // Extended Building Information (billw)
                    { 670422128u , Status.Incompatible }, // Extended Building Information (Hedgehog)
                    { 586012417u , Status.Incompatible }, // Ploppable RICO
                    { 426163185u , Status.Incompatible }, // Realistic Population and Consumption Mod v8.4.0
                    { 414469593u , Status.Incompatible }, // Extended Building Information (emf)
                    { 410344523u , Status.Incompatible }, // PopBalanceMod
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.EuropeBiome,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete // new mod avail
                      | ItemFlags.SaveAltering
                      | ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.InitialRelease,
                ReplaceWith = 938049744u, // Proper Hardness Fixed
                SourceURL = "https://github.com/lxteo/Cities-Skyline-Proper-Hardness",
            });
        }
    }
}
