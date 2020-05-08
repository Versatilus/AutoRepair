namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Currently active CSM mods.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        private void MultiplayerMods() {

            string catalog = "Multiplayer";

            Dictionary<ulong, Status> multiplayerIncompatible = new Dictionary<ulong, Status>() {
                { 2080356971uL, Status.Incompatible }, // CSM
                { 2040225526uL, Status.Incompatible }, // Multiplayer
                { 2030131871uL, Status.Incompatible }, // CSM
                { 2027716634uL, Status.Incompatible }, // CitiesSkylinesMultiplayer_2002.2.0
                { 2021598295uL, Status.Incompatible }, // 1558438291 [Beta] CSM - Cities_ Skylines Multiplayer
                { 2000408250uL, Status.Incompatible }, // CSM
                { 1985701540uL, Status.Incompatible }, // CSM
                { 1841616225uL, Status.Incompatible }, // CSM
                { 1731754018uL, Status.Incompatible }, // CSM
                { 1598623776uL, Status.Incompatible }, // CSM - CitySkyline Multiplayer
                { 1598622569uL, Status.Incompatible }, // CSM - CitySkyline Multiplayer
                { 1598621063uL, Status.Incompatible }, // CSM - CitySkyline Multiplayer
                { 1558438291uL, Status.Incompatible }, // Cities: Skylines Multiplayer (CSM) [Beta] "official release"
                { 1556669944uL, Status.Incompatible }, // CSM
            };

            // This seems to be the current "official" version
            // although there are several versions released after it.
            // Strangely, none of the uploaders are very talkative
            AddMod(new Review(1558438291uL, "Cities: Skylines Multiplayer (CSM) [Beta]") {
                Affect = Factor.Multiplayer,
                Authors = "xylisn",
                Catalog = catalog,
                Compatibility = multiplayerIncompatible,
                ContinuationOf = 1556669944uL, // CSM
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.MinorIssues, // doesn't sync full game features
                SourceURL = "https://github.com/DominicMaas/Tango",
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            // ...
            AddMod(new Review(2080356971uL, "Multiplayer") {
                Affect = Factor.Multiplayer,
                Authors = "Toads",
                Catalog = catalog,
                CloneOf = 1558438291uL, // Cities: Skylines Multiplayer (CSM) [Beta]
                Compatibility = multiplayerIncompatible,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Published = WorkshopDate("1 May, 2020"),
                ReplaceWith = 1558438291uL, // Cities: Skylines Multiplayer (CSM) [Beta]
                Suppress = Warning.OlderReplacement,
                Updated = WorkshopDate("1 May, 2020"),
            });

            // and another clone!
            AddMod(new Review(2040225526uL, "Multiplayer") {
                Affect = Factor.Multiplayer,
                Authors = "State Farm",
                Catalog = catalog,
                CloneOf = 1558438291uL, // Cities: Skylines Multiplayer (CSM) [Beta]
                Compatibility = multiplayerIncompatible,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1558438291uL, // Cities: Skylines Multiplayer (CSM) [Beta]
                Suppress = Warning.OlderReplacement,
            });

            // looks like yet another clone, waiting for feedback from author
            AddMod(new Review(2030131871uL, "CSM") {
                Affect = Factor.Multiplayer,
                Authors = "wihtewolf1712",
                Catalog = catalog,
                CloneOf = 1558438291uL, // Cities: Skylines Multiplayer (CSM) [Beta]
                Compatibility = multiplayerIncompatible,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1558438291uL, // Cities: Skylines Multiplayer (CSM) [Beta]
                Suppress = Warning.OlderReplacement,
            });

            // waiting for response from author, currently assuming _yet another clone_
            AddMod(new Review(2027716634uL, "CitiesSkylinesMultiplayer_2002.2.0") {
                Affect = Factor.Multiplayer,
                Authors = "Ceddicedced",
                Catalog = catalog,
                CloneOf = 1558438291uL, // Cities: Skylines Multiplayer (CSM) [Beta]
                Compatibility = multiplayerIncompatible,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1558438291uL, // Cities: Skylines Multiplayer (CSM) [Beta]
                Suppress = Warning.OlderReplacement,
            });

            // Struggled to get any meaningful info from author, assuming clone
            AddMod(new Review(2021598295uL, "1558438291 [Beta] CSM - Cities_ Skylines Multiplayer") {
                Affect = Factor.Multiplayer,
                Authors = "Leñador de Abedules",
                Catalog = catalog,
                CloneOf = 1558438291uL, // Cities: Skylines Multiplayer (CSM) [Beta]
                Compatibility = multiplayerIncompatible,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1558438291uL, // Cities: Skylines Multiplayer (CSM) [Beta]
                Suppress = Warning.OlderReplacement,
            });

            AddMod(new Review(2000408250uL, "CSM") {
                Affect = Factor.Multiplayer,
                Authors = "(unknown)", // can't remember who created it
                Catalog = catalog,
                CloneOf = 1558438291uL, // Cities: Skylines Multiplayer (CSM) [Beta]
                Compatibility = multiplayerIncompatible,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorIssues
                      | ItemFlags.NoWorkshop // removed on or around 12/Mar/2020
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("10 Mar, 2020"),
                Published = WorkshopDate("17 Feb, 2020"), // based on adjacent items
                Removed = WorkshopDate("12 Mar, 2020"),
                ReplaceWith = 1558438291uL, // Cities: Skylines Multiplayer (CSM) [Beta]
                Suppress = Warning.MissingArchiveURL | Warning.OlderReplacement,
                Updated = WorkshopDate("17 Feb, 2020"), // remember it only having 1 release
            });

            AddMod(new Review(1985701540uL, "CSM") {
                Affect = Factor.Multiplayer,
                Authors = "himete",
                Catalog = catalog,
                CloneOf = 1558438291uL, // Cities: Skylines Multiplayer (CSM) [Beta]
                Compatibility = multiplayerIncompatible,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1558438291uL, // Cities: Skylines Multiplayer (CSM) [Beta]
                Suppress = Warning.OlderReplacement,
            });

            AddMod(new Review(1841616225uL, "CSM") {
                Affect = Factor.Multiplayer,
                Authors = "Stutenandy",
                Catalog = catalog,
                CloneOf = 1558438291uL, // Cities: Skylines Multiplayer (CSM) [Beta]
                Compatibility = multiplayerIncompatible,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorIssues
                      | ItemFlags.Obsolete // 1558438291u has since been updated
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1558438291uL, // Cities: Skylines Multiplayer (CSM) [Beta]
                Suppress = Warning.OlderReplacement,
            });

            AddMod(new Review(1731754018uL, "CSM") {
                Affect = Factor.Multiplayer,
                Authors = "motacy",
                Catalog = catalog,
                CloneOf = 1558438291uL, // Cities: Skylines Multiplayer (CSM) [Beta]
                Compatibility = multiplayerIncompatible,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorIssues
                      | ItemFlags.Obsolete // 1558438291u has since been updated
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1558438291uL, // Cities: Skylines Multiplayer (CSM) [Beta]
                Suppress = Warning.OlderReplacement,
            });

            AddMod(new Review(1598623776uL, "CSM - CitySkyline Multiplayer") {
                Affect = Factor.Multiplayer,
                Authors = "WartraxX",
                Catalog = catalog,
                CloneOf = 1558438291uL, // Cities: Skylines Multiplayer (CSM) [Beta]
                Compatibility = multiplayerIncompatible,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorIssues
                      | ItemFlags.Obsolete // 1558438291u has since been updated
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1558438291uL, // Cities: Skylines Multiplayer (CSM) [Beta]
                Suppress = Warning.OlderReplacement,
            });

            AddMod(new Review(1598622569uL, "CSM - CitySkyline Multiplayer") {
                Affect = Factor.Multiplayer,
                Authors = "WartraxX",
                Catalog = catalog,
                CloneOf = 1558438291uL, // Cities: Skylines Multiplayer (CSM) [Beta]
                Compatibility = multiplayerIncompatible,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorIssues
                      | ItemFlags.Obsolete // 1558438291u has since been updated
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1558438291uL, // Cities: Skylines Multiplayer (CSM) [Beta]
                Suppress = Warning.OlderReplacement,
            });

            AddMod(new Review(1598621063uL, "CSM - CitySkyline Multiplayer") {
                Affect = Factor.Multiplayer,
                Authors = "WartraxX",
                Catalog = catalog,
                CloneOf = 1558438291uL, // Cities: Skylines Multiplayer (CSM) [Beta]
                Compatibility = multiplayerIncompatible,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorIssues
                      | ItemFlags.Obsolete // 1558438291u has since been updated
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1558438291uL, // Cities: Skylines Multiplayer (CSM) [Beta]
                Suppress = Warning.OlderReplacement,
            });

            AddMod(new Review(1556669944uL, "CSM") {
                Affect = Factor.Multiplayer,
                Authors = "Daniel",
                Catalog = catalog,
                Compatibility = multiplayerIncompatible,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorIssues
                      | ItemFlags.Obsolete // replaced by 1558438291u "official" release
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1558438291uL, // Cities: Skylines Multiplayer (CSM) [Beta]
            });
        }
    }
}
