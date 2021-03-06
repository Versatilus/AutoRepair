namespace AutoRepair {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    public class Mods {

        private Dictionary<ulong, Review> list;

        /// <summary>
        /// Initializes a new instance of the <see cref="Mods"/> class.
        /// </summary>
        public Mods() {
            list = new Dictionary<ulong, Review>();
            Populate();
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="Mods"/> class.
        /// </summary>
        ~Mods() {
            list.Clear();
        }

        /// <summary>
        /// Adds an item to the list.
        /// </summary>
        /// 
        /// <param name="item">The item to add.</param>
        public void Add(Review item) {
            item.ItemType = ItemTypes.Mod;
            list.Add(item.WorkshopId, item);
        }

        /// <summary>
        /// Adds an item to the list.
        /// </summary>
        /// 
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Workshop.</param>
        public void Add(ulong workshopId, string workshopName) {
            list.Add(workshopId, new Review(workshopId, workshopName) {
                ItemType = ItemTypes.Mod,
            });
        }

        // todo: flag the item as dodgey
        public void AddDodgey(ulong workshopId, string workshopName) {
            list.Add(workshopId, new Review(workshopId, workshopName) {
                ItemType = ItemTypes.Mod,
            });
        }

        public void Populate() {
            AddDodgey(1891302387u, "自动推土机");

            AddDodgey(1891302187u, "自动推土机");

            // todo: this might be localisation of older mod, not sure
            AddDodgey(1864205702u, "地图图片叠加 Image Overlay");

            // todo: prolly breaks TM:PE
            // todo: requires Industries DLC
            Add(1816571194u, "No Industries Import");

            AddDodgey(1787941751u, "交通"); // "traffic" ?!


            Add(new Review(1759269367u, "CrazyTouristFix") {
                Flags = ItemFlags.SourceAvailable,
            });


            Add(new Review(1741725093u, "Note It!") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorIssues, // harmony patch management could be better
            });

            AddDodgey(1740517576u, "ССМП"); // ??

            // todo: likely incompat with similar mods
            Add(1739888663u, "Budget Balancer");

            // todo: auto subscribe if user has the broken version?
            Add(new Review(1737575423u, "[ Backward Compatibility ]  New Roads For Network Extension 2") {
                Compatibility = new Dictionary<ulong, Status>() {
                    { 812125426u, Status.Required },
                    { 1243740191u, Status.Required },
                    { 929114228u, Status.Incompatible },
                },
            });

            Add(new Review(1729576238u, "Date Changer") {
                Flags = ItemFlags.SourceAvailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1420955187u, Status.Incompatible }, // Real Time (original)
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                },
            });

            Add(new Review(1723583521u, "Total Autobudget (Buffer Increase fix) deprecated") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.ForceMigration,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1541897355u, Status.Incompatible }, // Total Autobudget
                },
                ReplaceWith = 1541897355u, // Total Autobudget
            });


            // todo: requires dlcs
            Add(1718245521u, "No Park Building Fires");


            Add(new Review(1689984220u, "Electric Roads Mod 1.2.3") {
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Review(1651036644u, "Advanced Traffic Congestion Report") {
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/pcfantasy/TrafficCongestionReport",
            });

            Add(new Review(1648585256u, "NoBailOutWarning") {
                Flags = ItemFlags.SourceUnavailable,
            });



            Add(new Review(1603319148u, "576997275 Remove Need For Pipes") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 576997275u, Status.Incompatible }, // Remove Need For Pipes
                },
                ReplaceWith = 576997275u, // Remove Need For Pipes
            });

            // removes building needs at night
            Add(new Review(1591311030u, "Don't Bulldoze At Night") {
                Flags = ItemFlags.SourceUnavailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1420955187u, Status.Required }, // Real Time
                },
            });

            AddDodgey(1570376078u, "自动推土机");

            AddDodgey(1559479494u, "MyTheme");
            AddDodgey(1558675585u, "MyTheme");

            AddDodgey(1555378173u, "410344523"); // translated pop balance mod?

            Add(new Review(1548749050u, "Mark-a-Route Reuploaded") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 649674529u, Status.Incompatible }, // Mark-a-route (no longer in workshop)
                },
            });

            AddDodgey(1547491802, "Chengguanju");

            // shows vehicles in tunnels, likely to be removed from workshop
            Add(new Review(1544546832u, "TRMod") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceUnavailable,
                // todo; prolly incompat with NExt2
            });

            AddDodgey(1544326926u, "重复建设地标建筑");

            Add(new Review(1541897355u, "Total Autobudget") {
                Flags = ItemFlags.MinorIssues // can sometimes break services
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/ZenyaIse/Cities-Skylines-Total-Autobudget",
                // todo: incompat with other budget mods
            });




            Add(new Review(1523608557u, "American Sign Replacer") {
                Flags = ItemFlags.SourceUnavailable,
            });



            Add(new Review(1485051886u, "Cimtographer - rebuild for 1.10.1-f3") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorIssues
                      | ItemFlags.Unreliable,
                SourceURL = "https://github.com/rdiekema/Cities-Skylines-Mapper/commit/4bb1557b97226cd84728593799be2710bb129c19",
                Compatibility = new Dictionary<ulong, Status>() {
                    { 416064574u, Status.Incompatible }, // Cimtographer
                },
            });

            // Click the "M" mark in the upper left corner to display each type of functional building in different colors
            Add(new Review(1455265809u, "ServiceMap") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                // todo: might conflict with TMPE
            });

            Add(new Review(1452259306u, "Aedificium RELOADED [BETA] - OBSOLETE") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 793489846u, Status.Incompatible }, // Aedificium - Hotloading workshop items while you play
                },
            });

            // todo: need speed catalog as there are more of these things
            Add(new Review(1425061566u, "V10Speed") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/V10lator/V10Speed",
                Compatibility = new Dictionary<ulong, Status>() {
                    { 412292157u, Status.Incompatible }, // More Simulation Speed Options
                    // real time, and other speed sliders
                },
            });

            Add(new Review(1415090282u, "AutoLineColor Redux") {
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/taradinoc/CitiesSkylinesAutoColorMod",
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1415090282u, Status.Incompatible }, // AutoLineColor Redux
                    { 408760323u , Status.Incompatible }, // Auto Line Color
                },
            });



            AddDodgey(1391679732u, "CS-RP");

            Add(new Review(1385468094u, "PollutionRemoverMod") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                // todo: incompat with other pol removers
            });

            AddDodgey(1379361024u, "bd96432_mod_2"); // likely a translation mod





            Add(new Review(1324539315u, "Land Ships") {
                Authors = "BloodyPenguin",
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/bloodypenguin/Skylines-LandShips",
                Compatibility = new Dictionary<ulong, Status>() {
                    { 707759735u, Status.Recommended }, // Ship Path Anarchy
                },
            });

            // todo: move to translations;
            Add(new Review(1322787091u, "Addresses & Names Mod 2.0.1") {
                Authors = "Klyte45",
                Flags = ItemFlags.SourceAvailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1231957400u, Status.Incompatible }, // Custom Namelists
                },
                SourceURL = "https://github.com/klyte45/AddressesMod",
            });






            Add(new Review(1269478692u, "Trains stop on both sides of the station") {
                Authors = "Jaddy",
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable, // some users report crashes or that it doesn't work
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1394468624u, Status.Incompatible }, // Advanced Stop Selection
                    // MTSE etc.
                },
                ReplaceWith = 1394468624u, // Advanced Stop Selection
            });



            Add(new Review(1217239330u, "Profitable Offices") {
                Authors = "Mrnr1",
                Flags = ItemFlags.SourceAvailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    // possible conflict with 550479679u (eg. duplicate assembly name)
                },
                SourceURL = "https://github.com/mrnr1/CS-Profitable-Offices/",
            });


            Add(new Review(1182174575u, "Export Vehicles Positions") {
                Authors = "Simon Ryr",
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://gist.github.com/simon56modder/78b3ecab27b7829017f327baf0f9652c",
            });

            Add(new Review(1174585364u, "Rescue Fullwidth Digits") {
                Authors = "Gansaku",
                Flags = ItemFlags.SourceUnavailable,
            });

            // Similar thing to Klyte's addresses mod
            // renames based on street/district name
            Add(new Review(1179846541u, "Rename buildings") {
                Authors = "Romanoza",
                Affect = Factor.Naming,
                Flags = ItemFlags.SourceUnavailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    // todo: incompat - klyte addresses, possibly also customize it extended, and custom name lists
                },
            });


        }
    }
}