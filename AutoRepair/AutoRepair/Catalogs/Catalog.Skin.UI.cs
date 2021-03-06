namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Stuff that alters user interface.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void SkinUIMods() {

            string catalog = "Skin.UI";

            AddMod(new Review(2040218778uL, "ScaleUI") {
                Affect = Factor.UI,
                Authors = "*",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // likely incompatible with TMPE
                    { 2040218778uL, Status.Incompatible }, // ScaleUI
                    { 2009172305uL, Status.Incompatible }, // EPTUI TLM Integration (Beta)
                    { 1763358249uL, Status.Incompatible }, // 411164732 (EPTUI)
                    { 802489150uL , Status.Incompatible }, // Extended Public Transport UI (+DLCs!)
                    { 419090722uL , Status.Incompatible }, // Mod Corral
                    { 411164732uL , Status.Incompatible }, // Extended Public Transport UI (Obsolete)
                    { 409338401uL , Status.Incompatible }, // ScaleUI (beta)
                    { 407225523uL , Status.Incompatible }, // TextScaleMod
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 409338401uL, // ScaleUI (beta)
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Can break UI of other mods during scaling (close buttons move, panels go off-screen, etc.)" },
                    { NOTE, "Breaks UI of all versions of Extended Public Transport UI mods." },
                },
                Published = WorkshopDate("29 Mar, 2020"),
                SourceURL = "https://github.com/joeyjojojunior/skylines-scaleui",
                Updated = WorkshopDate("4 Apr, 2020"),
            });

            // sounds like bit of a nightmare
            // todo: move to dependencies cat?
            AddMod(new Review(1769420886uL, "Panel Hook (beta) for modders") {
                Affect = Factor.BuildingInfo
                       | Factor.VehicleInfo,
                Authors = "vpoteryaev",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // tmpe?
                    // snooper?
                    // klyte mods?
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Author states they no longer play C:SL; this mod will not be updated." },
                },
                Published = WorkshopDate("14 Jun, 2019"),
                SourceURL = "https://github.com/vpoteryaev-cs-mods/PanelHook",
                Updated = WorkshopDate("11 Jul, 2019"),
            });

            AddMod(new Review(1768810491uL, "Measure It!") {
                Affect = Factor.Other,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("13 Jun, 2019"),
                SourceURL = "https://github.com/keallu/CSL-MeasureIt",
                Updated = WorkshopDate("3 Jul, 2019"),
            });

            AddMod(new Review(1526302248uL, "Spinny RGB Circle") {
                Affect = Factor.UI,
                Authors = "Fox, Serial Bread",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1502721219uL, Status.Incompatible }, // [Deprecated] Spinny Red Circle
                },
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Adjustable thiccness, now with 16.7 million colors." },
                },
                Published = WorkshopDate("29 Sep, 2018"),
                Updated = WorkshopDate("29 Sep, 2018"),
            });

            AddMod(new Review(877748783uL, "Topographic Lines Toggle") {
                Affect = Factor.UI,
                Authors = "Komb",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1764637396uL, Status.MinorIssues  }, // Toggle It
                    { 507225392uL , Status.MinorIssues  }, // Topographic Info View
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Press Alt + T to toggle the lines. Shortcut can be changed in mod options." },
                    { NOTE, "Doesn't work very well when info views are active (white map mode); you will have to re-toggle when exiting info views." },
                    { NOTE, "Toggle button has issues in map editor, but seems functional." },
                    { 1764637396uL, "[Mod: Toggle It!] Both mods can toggle topographic lines; use one and unsubscribe the other." },
                    { 507225392u , "[Mod: Topographic Info View] Both mods provide similar functionality; choose one and remove the other." },
                },
                Published = WorkshopDate("5 Mar, 2017"),
                Updated = WorkshopDate("16 Mar, 2017"),
            });

            AddMod(new Review(412149127uL, "Font Selector") {
                Affect = Factor.UI,
                Authors = "hippo",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods) {
                    { 408286108uL , Status.Incompatible }, // SkylinesFont
                    { 407225523uL , Status.Incompatible }, // TextScaleMod
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                Published = WorkshopDate("9 Apr, 2015"),
                Updated = WorkshopDate("14 Feb, 2018"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Review(1799667916uL, "UX Mod - OSD & Keybinds") {
                Affect = Factor.Other,
                Authors = "kvakvs",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                Flags = ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This was going to be a UI helper mod for TM:PE v11, but we decided to just build it in to TM:PE instead. Unsubscribe." },
                },
                Published = WorkshopDate("11 Jul, 2019"),
                SourceURL = "https://github.com/kvakvs/Skylines-UX",
                Updated = WorkshopDate("11 Jul, 2019"),
            });

            AddMod(new Review(1756787990uL, "More Advanced InfoViews") {
                Affect = Factor.UI,
                Authors = "Dendraspis",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1764637396uL, Status.Incompatible }, // Toggle It!
                    { 1756787990uL, Status.Incompatible }, // More Advanced InfoViews
                    { 1595663918uL, Status.Incompatible }, // InfoPanelOnLoad
                },
                Flags = ItemFlags.SourceObfuscated // big warning sign
                      | ItemFlags.SourceUnavailable,
                Published = WorkshopDate("31 May, 2019"),
                Updated = WorkshopDate("9 Jun, 2019"),
            });

            AddMod(new Review(1595663918uL, "InfoPanelOnLoad") {
                Affect = Factor.UI,
                Authors = "Dendraspis",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1756787990uL, Status.Incompatible }, // More Advanced InfoViews
                    { 1595663918uL, Status.Incompatible }, // InfoPanelOnLoad
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceObfuscated // checked 12/Mar/2020
                      | ItemFlags.SourceUnavailable,
                Published = WorkshopDate("20 Dec, 2018"),
                ReplaceWith = 1756787990uL, // More Advanced InfoViews
                Updated = WorkshopDate("20 Dec, 2018"),
            });

            AddMod(new Review(1502721219uL, "[Deprecated] Spinny Red Circle") {
                Affect = Factor.UI,
                Authors = "Fox, Serial Bread",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1526302248uL, Status.Incompatible }, // Spinny RGB Circle
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Obsolete,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Discontinued due to insufficient thiccness and lack of colours." },
                },
                Published = WorkshopDate("3 Sep, 2018"),
                ReplaceWith = 1526302248uL, // Spinny RGB Circle
                Updated = WorkshopDate("3 Sep, 2018"),
            });

            AddMod(new Review(781767563uL, "Extended InfoPanel") {
                Affect = Factor.UI,
                Authors = "iinsnian",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1764208250uL, Status.MinorIssues  }, // More Vehicles
                    { 1420955187uL, Status.MinorIssues  }, // Real Time
                    { 1224627683uL, Status.Incompatible }, // Fudged Population Enhanced
                    { 888017364uL , Status.MinorIssues  }, // Quartz (Sapphire) - Fixed 1.11
                    { 576970398uL , Status.MinorIssues  }, // Quartz (former Sapphire) - UI skin framework
                    { 421770876uL , Status.MinorIssues  }, // Sapphire - UI skin framework
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Laggy
                      | ItemFlags.Localised
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                LastSeen = WorkshopDate("10 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This mod only supports 16:9 and 16:10 screen aspect ratios." },
                },
                Published = WorkshopDate("16 Oct, 2016"),
                SourceURL = "https://github.com/Nextopening/IINS.ExtendedInfo",
                Updated = WorkshopDate("31 Dec, 2016"),
            });

            AddMod(new Review(419090722uL, "Mod Corral") {
                Affect = Factor.UI,
                ArchiveURL = "https://web.archive.org/web/20150415205521/http://steamcommunity.com/sharedfiles/filedetails/?id=419090722",
                Authors = "brittany",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2040218778uL, Status.Incompatible }, // ScaleUI
                    { 409338401uL , Status.Compatible   }, // ScaleUI (beta)
                    { 407225523uL , Status.Incompatible }, // TextScaleMod
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("3 Apr, 2015"), // guessing based on github initial commit
                SourceURL = "https://github.com/brittanygh/CS-ModCorral",
                Updated = WorkshopDate("12 Apr, 2015"),
            });

            // treating as obsolete as it's not been updated since forever and there's loads of UI changes in game since then
            AddMod(new Review(888017364uL, "Quartz (Sapphire) - Fixed 1.11") {
                Affect = Factor.UI,
                Authors = "AlexM",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // frameworks:
                    { 888017364uL , Status.Incompatible }, // Quartz (Sapphire) - Fixed 1.11
                    { 576970398uL , Status.Incompatible }, // Quartz (former Sapphire) - UI skin framework
                    { 421770876uL , Status.Incompatible }, // Sapphire - UI skin framework
                    // skins:
                    { 593987954uL , Status.Compatible   }, // Triple-Screen UI Skin
                    { 578482272uL , Status.Compatible   }, // [FIXED][LEGACY] Emerald UI (16:9)
                    { 577230299uL , Status.Compatible   }, // [LEGACY][FIXED][UI] Silicon Skin V1.0
                    { 511029270uL , Status.Compatible   }, // Sapphire - Triple Screen Centered
                    { 450453336uL , Status.Compatible   }, // Hello UI [Fixed 1.7]
                    { 428457597uL , Status.Compatible   }, // ClearUI - Quartz Skin 16:9 / 16:10
                    { 428298776uL , Status.Incompatible }, // [UI] Silicon Skin (21:9) V1.0
                    { 424995783uL , Status.Incompatible }, // [UI] Silicon Skin V1.0
                    { 423910890uL , Status.Compatible   }, // Blue UI - Quartz Skin
                    { 422251153uL , Status.Incompatible }, // Emerald UI (16:9)
                    // toolbar altering mods:
                    { 2016920607uL, Status.Incompatible }, // RICO revisited
                    { 1597852915uL, Status.Incompatible }, // More Advanced Toolbar
                    { 1577882296uL, Status.Incompatible }, // Resize It!
                    { 1204126182uL, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 837734529uL , Status.Compatible   }, // Find It (boogieman sam)
                    { 781767563uL , Status.MinorIssues  }, // Extended InfoPanel
                    { 586012417uL , Status.Incompatible }, // Ploppable RICO
                    { 563229150uL , Status.Incompatible }, // Advanced Toolbar
                    { 540758804uL , Status.Incompatible }, // Search Box Mod
                    { 451906822uL , Status.Incompatible }, // Enhanced Build Panel (WIP)
                    { 451700838uL , Status.Incompatible }, // Extended Toolbar
                    // other:
                    { 1420955187uL, Status.MinorIssues  }, // Real Time
                    { 1224627683uL, Status.Incompatible }, // Fudged Population Enhanced
                },
                CompatibleWith = GameVersion.Patch_1_11_1_f4,
                ContinuationOf = 576970398uL, // Quartz (former Sapphire) - UI skin framework
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Laggy
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "User guide: https://github.com/AlexanderDzhoganov/Skylines-Sapphire/wiki/" },
                    { 1420955187uL, "[Mod: Real Time] Quartz prevents display of events on the time bar." },
                },
                Published = WorkshopDate("20 Mar, 2017"),
                Updated = WorkshopDate("6 Nov, 2018"),
            });

            AddMod(new Review(576970398uL, "Quartz (former Sapphire) - UI skin framework") {
                Affect = Factor.UI,
                Authors = "TheOne",
                BrokenBy = GameVersion.Industries,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // frameworks:
                    { 888017364uL , Status.Incompatible }, // Quartz (Sapphire) - Fixed 1.11
                    { 576970398uL , Status.Incompatible }, // Quartz (former Sapphire) - UI skin framework
                    { 421770876uL , Status.Incompatible }, // Sapphire - UI skin framework
                    // skins:
                    { 593987954uL , Status.Compatible   }, // Triple-Screen UI Skin
                    { 578482272uL , Status.Compatible   }, // [FIXED][LEGACY] Emerald UI (16:9)
                    { 577230299uL , Status.Compatible   }, // [LEGACY][FIXED][UI] Silicon Skin V1.0
                    { 511029270uL , Status.Compatible   }, // Sapphire - Triple Screen Centered
                    { 450453336uL , Status.Compatible   }, // Hello UI [Fixed 1.7]
                    { 428457597uL , Status.Compatible   }, // ClearUI - Quartz Skin 16:9 / 16:10
                    { 428298776uL , Status.Incompatible }, // [UI] Silicon Skin (21:9) V1.0
                    { 424995783uL , Status.Incompatible }, // [UI] Silicon Skin V1.0
                    { 423910890uL , Status.Compatible   }, // Blue UI - Quartz Skin
                    { 422251153uL , Status.Incompatible }, // Emerald UI (16:9)
                    // toolbar altering mods:
                    { 2016920607uL, Status.Incompatible }, // RICO revisited
                    { 1597852915uL, Status.Incompatible }, // More Advanced Toolbar
                    { 1577882296uL, Status.Incompatible }, // Resize It!
                    { 1204126182uL, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 837734529uL , Status.Compatible   }, // Find It (boogieman sam)
                    { 781767563uL , Status.MinorIssues  }, // Extended InfoPanel
                    { 586012417uL , Status.Incompatible }, // Ploppable RICO
                    { 563229150uL , Status.Incompatible }, // Advanced Toolbar
                    { 540758804uL , Status.Incompatible }, // Search Box Mod
                    { 451906822uL , Status.Incompatible }, // Enhanced Build Panel (WIP)
                    { 451700838uL , Status.Incompatible }, // Extended Toolbar
                    // other:
                    { 1420955187uL, Status.MinorIssues  }, // Real Time
                    { 1224627683uL, Status.Incompatible }, // Fudged Population Enhanced
                },
                CompatibleWith = GameVersion.Patch_1_10_1_f3,
                ContinuationOf = 421770876uL, // Sapphire - UI skin framework
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.Laggy
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "User guide: https://github.com/AlexanderDzhoganov/Skylines-Sapphire/wiki/" },
                    { 1420955187uL, "[Mod: Real Time] Quartz prevents display of events on the time bar." },
                },
                Published = WorkshopDate("16 Dec, 2015"),
                ReplaceWith = 888017364uL, // Quartz (Sapphire) - Fixed 1.11
                SourceURL = "https://github.com/bnm12/Skylines-Sapphire",
                Updated = WorkshopDate("28 Dec, 2015"),
            });

            AddMod(new Review(421770876uL, "Sapphire - UI skin framework") {
                Affect = Factor.UI,
                Authors = "nlight",
                BrokenBy = GameVersion.AfterDark,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // frameworks:
                    { 888017364uL , Status.Incompatible }, // Quartz (Sapphire) - Fixed 1.11
                    { 576970398uL , Status.Incompatible }, // Quartz (former Sapphire) - UI skin framework
                    { 421770876uL , Status.Incompatible }, // Sapphire - UI skin framework
                    // skins:
                    { 593987954uL , Status.Incompatible }, // Triple-Screen UI Skin
                    { 578482272uL , Status.Incompatible }, // [FIXED][LEGACY] Emerald UI (16:9)
                    { 577230299uL , Status.Incompatible }, // [LEGACY][FIXED][UI] Silicon Skin V1.0
                    { 511029270uL , Status.Incompatible }, // Sapphire - Triple Screen Centered
                    { 450453336uL , Status.Incompatible }, // Hello UI [Fixed 1.7]
                    { 428457597uL , Status.Incompatible }, // ClearUI - Quartz Skin 16:9 / 16:10
                    { 428298776uL , Status.Compatible   }, // [UI] Silicon Skin (21:9) V1.0
                    { 424995783uL , Status.Compatible   }, // [UI] Silicon Skin V1.0
                    { 423910890uL , Status.Incompatible }, // Blue UI - Quartz Skin
                    { 422251153uL , Status.Compatible   }, // Emerald UI (16:9)
                    // toolbar altering mods:
                    { 2016920607uL, Status.Incompatible }, // RICO revisited
                    { 1597852915uL, Status.Incompatible }, // More Advanced Toolbar
                    { 1577882296uL, Status.Incompatible }, // Resize It!
                    { 1204126182uL, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 837734529uL , Status.Compatible   }, // Find It (boogieman sam)
                    { 781767563uL , Status.MinorIssues  }, // Extended InfoPanel
                    { 586012417uL , Status.Incompatible }, // Ploppable RICO
                    { 563229150uL , Status.Incompatible }, // Advanced Toolbar
                    { 540758804uL , Status.Incompatible }, // Search Box Mod
                    { 451906822uL , Status.Incompatible }, // Enhanced Build Panel (WIP)
                    { 451700838uL , Status.Incompatible }, // Extended Toolbar
                    // other:
                    { 1420955187uL, Status.MinorIssues  }, // Real Time
                    { 1224627683uL, Status.Incompatible }, // Fudged Population Enhanced
                },
                CompatibleWith = GameVersion.Patch_1_1_1,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "User guide: https://github.com/AlexanderDzhoganov/Skylines-Sapphire/wiki/" },
                    { 1420955187uL, "[Mod: Real Time] Sapphire prevents display of events on the time bar." },
                },
                Published = WorkshopDate("8 Apr, 2015"),
                ReplaceWith = 888017364uL, // Quartz (Sapphire) - Fixed 1.11
                SourceURL = "https://github.com/AlexanderDzhoganov/Skylines-Sapphire/",
                Updated = WorkshopDate("16 Apr, 2015"),
            });

            AddMod(new Review(413584409uL, "BetterLoadPanel") {
                Affect = Factor.UI,
                ArchiveURL = "https://web.archive.org/web/20150415230208/http://steamcommunity.com/sharedfiles/filedetails/?id=413584409",
                Authors = "brittany",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop // avail Nov 2015, gone by Jun 2016
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This mod is obsolete as the base game now has these features. Unsubscribe." },
                },
                Published = WorkshopDate("4 Apr, 2015"), // guessing based on github initial commit
                SourceURL = "https://github.com/brittanygh/CS-BetterLoadPanel",
                Updated = WorkshopDate("8 Apr, 2015"),
            });

            AddMod(new Review(409338401uL, "ScaleUI (beta)") {
                Affect = Factor.UI,
                Authors = "permutation",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2040218778uL, Status.Incompatible }, // ScaleUI
                    { 2009172305uL, Status.Incompatible }, // EPTUI TLM Integration (Beta)
                    { 1763358249uL, Status.Incompatible }, // 411164732 (EPTUI)
                    { 802489150uL , Status.Incompatible }, // Extended Public Transport UI (+DLCs!)
                    { 419090722uL , Status.Compatible   }, // Mod Corral
                    { 411164732uL , Status.Incompatible }, // Extended Public Transport UI (Obsolete)
                    { 409338401uL , Status.Incompatible }, // ScaleUI (beta)
                    { 407225523uL , Status.Incompatible }, // TextScaleMod
                },
                ContinuationOf = 407225523uL, // TextScaleMod
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete // new ver avail
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "To reset scale to default, hit Ctrl+0 (zero)." },
                },
                Published = WorkshopDate("17 Mar, 2015"),
                ReplaceWith = 2040218778uL, // ScaleUI
                SourceURL = "https://github.com/githubpermutation/skylines-scaleui",
                Updated = WorkshopDate("14 Apr, 2015"),
            });

            // Runs code in it's .Name property
            // That code includes UIView.GetAView() without checking to see if it's null
            // Will throw exception to any mod querying its name during splash screens
            AddMod(new Review(408286108uL, "SkylinesFont") {
                Affect = Factor.UI,
                Authors = "WiseClock",
                BrokenBy = GameVersion.Patch_1_1_1,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 412149127uL , Status.Incompatible }, // Font Selector
                    { 408286108uL , Status.Incompatible }, // SkylinesFont
                    { 407225523uL , Status.Incompatible }, // TextScaleMod
                },
                CompatibleWith = GameVersion.Patch_1_1_0b,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BadStartup
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This mod causes an error on app startup and can cause other mods to break; unsubscribe it!" },
                },
                Published = WorkshopDate("15 Mar, 2015"),
                ReplaceWith = 412149127uL, // Font Selector
                Updated = WorkshopDate("16 Mar, 2015"),
                UserModInspected = true,
            });

            AddMod(new Review(407225523uL, "TextScaleMod") {
                Affect = Factor.UI,
                ArchiveURL = "https://web.archive.org/web/20150703140007/http://steamcommunity.com/sharedfiles/filedetails/?id=407225523",
                Authors = "alex3305",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2040218778uL, Status.Incompatible }, // ScaleUI
                    { 2009172305uL, Status.Incompatible }, // EPTUI TLM Integration (Beta)
                    { 419090722uL , Status.Incompatible }, // Mod Corral
                    { 412149127uL , Status.Incompatible }, // Font Selector
                    { 409338401uL , Status.Incompatible }, // ScaleUI (beta)
                    { 408286108uL , Status.Incompatible }, // SkylinesFont
                    { 407225523uL , Status.Incompatible }, // TextScaleMod
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop // gone by Jan 2019
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("13 Mar, 2015"), // guessing based on github initial commit
                SourceURL = "https://github.com/alex3305/CitiesSkylinesTextScaleMod",
                Updated = WorkshopDate("14 Mar, 2015"),
            });

            /*
            # ███████ ██   ██ ██ ███    ██ ███████
            # ██      ██  ██  ██ ████   ██ ██
            # ███████ █████   ██ ██ ██  ██ ███████
            #      ██ ██  ██  ██ ██  ██ ██      ██
            # ███████ ██   ██ ██ ██   ████ ███████
            */

            // continuation of:
            // 511029270uL, "Sapphire - Triple Screen Centered"
            AddMod(new Review(593987954uL, "Triple-Screen UI Skin") {
                Affect = Factor.UI,
                Authors = "Snacko",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // frameworks:
                    { 888017364uL , Status.Required     }, // Quartz (Sapphire) - Fixed 1.11
                    { 576970398uL , Status.Compatible   }, // Quartz (former Sapphire) - UI skin framework
                    { 421770876uL , Status.Incompatible }, // Sapphire - UI skin framework
                    // skins:
                    { 593987954uL , Status.Incompatible }, // Triple-Screen UI Skin
                    { 511029270uL , Status.Incompatible }, // Sapphire - Triple Screen Centered
                    // other:
                    { 1224627683uL, Status.Incompatible }, // Fudged Population Enhanced
                },
                CompatibleWith = GameVersion.Patch_1_11_1_f4,
                ContinuationOf = 511029270uL, // Sapphire - Triple Screen Centered
                Flags = ItemFlags.Laggy
                      | ItemFlags.SourceBundled,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "IUserMod: No 'OnEnabled()' or 'OnDisabled()' methods; might throw errors on app launch/exit." },
                    { NOTE, "Only tested on triple 1920 x 1080 monitors (total resolution of 5760 x 1080). Other setups unlikely to work without modification."},
                },
                Published = WorkshopDate("6 Jan, 2016"),
                Updated = WorkshopDate("12 Mar, 2016"),
                UserModInspected = true,
            });

            // update
            AddMod(new Review(578482272uL, "[FIXED][LEGACY] Emerald UI (16:9)") {
                Affect = Factor.UI,
                Authors = "TheOne",
                //BrokenBy = GameVersion.GreenCities,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // frameworks:
                    { 888017364uL , Status.Required     }, // Quartz (Sapphire) - Fixed 1.11
                    { 576970398uL , Status.Compatible   }, // Quartz (former Sapphire) - UI skin framework
                    { 421770876uL , Status.Incompatible }, // Sapphire - UI skin framework
                    // skins:
                    { 578482272uL , Status.Incompatible }, // [FIXED][LEGACY] Emerald UI (16:9)
                    { 422251153uL , Status.Incompatible }, // Emerald UI (16:9)
                    // other:
                    { 1224627683uL, Status.Incompatible }, // Fudged Population Enhanced
                },
                ContinuationOf = 422251153uL, // Emerald UI (16:9)
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceBundled,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "IUserMod: No 'OnEnabled()' or 'OnDisabled()' methods; might throw errors on app launch/exit." },
                },
                Published = WorkshopDate("18 Dec, 2015"),
                Updated = WorkshopDate("19 Dec, 2015"),
                UserModInspected = true,
            });

            // update
            AddMod(new Review(577230299uL, "[LEGACY][FIXED][UI] Silicon Skin V1.0") {
                Affect = Factor.UI,
                Authors = "TheOne",
                BrokenBy = GameVersion.GreenCities,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // frameworks:
                    { 888017364uL , Status.Required     }, // Quartz (Sapphire) - Fixed 1.11
                    { 576970398uL , Status.Compatible   }, // Quartz (former Sapphire) - UI skin framework
                    { 421770876uL , Status.Incompatible }, // Sapphire - UI skin framework
                    // skins:
                    { 577230299uL , Status.Incompatible }, // [LEGACY][FIXED][UI] Silicon Skin V1.0
                    { 428298776uL , Status.Incompatible }, // [UI] Silicon Skin (21:9) V1.0
                    { 424995783uL , Status.Incompatible }, // [UI] Silicon Skin V1.0
                    // other:
                    { 1224627683uL, Status.Incompatible }, // Fudged Population Enhanced
                },
                ContinuationOf = 424995783uL, // [UI] Silicon Skin V1.0
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceBundled,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "IUserMod: No 'OnEnabled()' or 'OnDisabled()' methods; might throw errors on app launch/exit." },
                    { NOTE, "Very susceptible to changes in vanilla game UI, likely to be broken by each game update." },
                    { NOTE, "Green Cities: Road buttons are broken." },
                },
                Published = WorkshopDate("17 Dec, 2015"),
                Updated = WorkshopDate("28 Dec, 2015"),
                UserModInspected = true,
            });

            // original - updated for quartz
            AddMod(new Review(511029270uL, "Sapphire - Triple Screen Centered") {
                Affect = Factor.UI,
                Authors = "Snacko",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // frameworks:
                    { 888017364uL , Status.Required     }, // Quartz (Sapphire) - Fixed 1.11
                    { 576970398uL , Status.Compatible   }, // Quartz (former Sapphire) - UI skin framework
                    { 421770876uL , Status.Incompatible }, // Sapphire - UI skin framework
                    // skins:
                    { 593987954uL , Status.Incompatible }, // Triple-Screen UI Skin
                    { 511029270uL , Status.Incompatible }, // Sapphire - Triple Screen Centered
                    // other:
                    { 1224627683uL, Status.Incompatible }, // Fudged Population Enhanced
                },
                CompatibleWith = GameVersion.Patch_1_2_2_f2,
                Flags = ItemFlags.Abandonware // author states this version will no longer be updated
                      | ItemFlags.ForceMigration
                      | ItemFlags.Laggy
                      | ItemFlags.Obsolete // use newer version
                      | ItemFlags.SourceBundled,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "IUserMod: No 'OnEnabled()' or 'OnDisabled()' methods; might throw errors on app launch/exit." },
                    { NOTE, "Only tested on triple 1920 x 1080 monitors (total resolution of 5760 x 1080). Other setups unlikely to work without modification."},
                },
                Published = WorkshopDate("2 Sep, 2015"), // sapphire version
                ReplaceWith = 593987954uL, // Triple-Screen UI Skin
                Updated = WorkshopDate("6 Jan, 2016"), // update to quartz
                UserModInspected = true,
            });

            // original - updated to quartz
            AddMod(new Review(450453336uL, "Hello UI [Fixed 1.7]") {
                Affect = Factor.UI,
                Authors = "hellodave",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // frameworks:
                    { 888017364uL , Status.Required     }, // Quartz (Sapphire) - Fixed 1.11
                    { 576970398uL , Status.Compatible   }, // Quartz (former Sapphire) - UI skin framework
                    { 421770876uL , Status.Incompatible }, // Sapphire - UI skin framework
                    // skins:
                    // other:
                    { 1224627683uL, Status.Incompatible }, // Fudged Population Enhanced
                },
                CompatibleWith = GameVersion.MassTransit,
                Flags = ItemFlags.Abandonware
                      //| ItemFlags.BrokenByUpdate
                      | ItemFlags.GameBreaking
                      | ItemFlags.Laggy
                      | ItemFlags.SourceBundled,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "IUserMod: No 'OnEnabled()' or 'OnDisabled()' methods; might throw errors on app launch/exit." },
                },
                Published = WorkshopDate("27 May, 2015"),
                Updated = WorkshopDate("23 Jun, 2017"),
                UserModInspected = true,
            });

            // original - updated to quartz
            AddMod(new Review(428457597uL, "ClearUI - Quartz Skin 16:9 / 16:10") {
                Affect = Factor.UI,
                Authors = "s i c",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // frameworks:
                    { 888017364uL , Status.Required     }, // Quartz (Sapphire) - Fixed 1.11
                    { 576970398uL , Status.Compatible   }, // Quartz (former Sapphire) - UI skin framework
                    { 421770876uL , Status.Incompatible }, // Sapphire - UI skin framework
                    // skins:
                    // other:
                    { 1224627683uL, Status.Incompatible }, // Fudged Population Enhanced
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceBundled, // Source folder
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "IUserMod: No 'OnEnabled()' or 'OnDisabled()' methods; might throw errors on app launch/exit." },
                },
                Published = WorkshopDate("19 Apr, 2015"),
                Updated = WorkshopDate("4 Feb, 2016"),
                UserModInspected = true,
            });

            // continuation
            AddMod(new Review(428298776uL, "[UI] Silicon Skin (21:9) V1.0") {
                Affect = Factor.UI,
                Authors = "kokonut",
                BrokenBy = GameVersion.AfterDark,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // frameworks:
                    { 888017364uL , Status.Incompatible }, // Quartz (Sapphire) - Fixed 1.11
                    { 576970398uL , Status.Incompatible }, // Quartz (former Sapphire) - UI skin framework
                    { 421770876uL , Status.Required     }, // Sapphire - UI skin framework
                    // skins:
                    { 577230299uL , Status.Incompatible }, // [LEGACY][FIXED][UI] Silicon Skin V1.0
                    { 428298776uL , Status.Incompatible }, // [UI] Silicon Skin (21:9) V1.0
                    { 424995783uL , Status.Incompatible }, // [UI] Silicon Skin V1.0
                    // other:
                    { 1224627683uL, Status.Incompatible }, // Fudged Population Enhanced
                },
                CompatibleWith = GameVersion.Patch_1_1_1,
                ContinuationOf = 424995783uL, // [UI] Silicon Skin V1.0
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "IUserMod: No 'OnEnabled()' or 'OnDisabled()' methods; might throw errors on app launch/exit." },
                    { NOTE, "Very susceptible to changes in vanilla game UI, likely to be broken by each game update." },
                },
                Published = WorkshopDate("19 Apr, 2015"),
                ReplaceWith = 577230299uL, // [LEGACY][FIXED][UI] Silicon Skin V1.0
                SourceURL = "https://github.com/kokonut0802/Silicon-Skin-21-9",
                Updated = WorkshopDate("23 Apr, 2015"),
                UserModInspected = true,
            });

            // original
            AddMod(new Review(424995783uL, "[UI] Silicon Skin V1.0") {
                Affect = Factor.UI,
                Authors = "kokonut",
                BrokenBy = GameVersion.AfterDark,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // frameworks:
                    { 888017364uL , Status.Incompatible }, // Quartz (Sapphire) - Fixed 1.11
                    { 576970398uL , Status.Incompatible }, // Quartz (former Sapphire) - UI skin framework
                    { 421770876uL , Status.Required     }, // Sapphire - UI skin framework
                    // skins:
                    { 577230299uL , Status.Incompatible }, // [LEGACY][FIXED][UI] Silicon Skin V1.0
                    { 428298776uL , Status.Incompatible }, // [UI] Silicon Skin (21:9) V1.0
                    { 424995783uL , Status.Incompatible }, // [UI] Silicon Skin V1.0
                    // other:
                    { 1224627683uL, Status.Incompatible }, // Fudged Population Enhanced
                },
                CompatibleWith = GameVersion.Patch_1_1_1,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "IUserMod: No 'OnEnabled()' or 'OnDisabled()' methods; might throw errors on app launch/exit." },
                    { NOTE, "Very susceptible to changes in vanilla game UI, likely to be broken by each game update." },
                },
                Published = WorkshopDate("14 Apr, 2015"),
                ReplaceWith = 577230299uL, // [LEGACY][FIXED][UI] Silicon Skin V1.0
                SourceURL = "https://github.com/kokonut0802/Silicon-Skin",
                Updated = WorkshopDate("23 Apr, 2015"),
                UserModInspected = true,
            });

            // original - updated to quartz
            AddMod(new Review(423910890uL, "Blue UI - Quartz Skin") {
                Affect = Factor.UI,
                Authors = "Unknown Soldier",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // frameworks:
                    { 888017364uL , Status.Required     }, // Quartz (Sapphire) - Fixed 1.11
                    { 576970398uL , Status.Compatible   }, // Quartz (former Sapphire) - UI skin framework
                    { 421770876uL , Status.Incompatible }, // Sapphire - UI skin framework
                    // skins:
                    // other:
                    { 1224627683uL, Status.Incompatible }, // Fudged Population Enhanced
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "IUserMod: No 'OnEnabled()' or 'OnDisabled()' methods; might throw errors on app launch/exit." },
                },
                Published = WorkshopDate("12 Apr, 2015"),
                Updated = WorkshopDate("18 Dec, 2015"),
                UserModInspected = true,
            });

            // update
            AddMod(new Review(422251153uL, "Emerald UI (16:9)") {
                Affect = Factor.UI,
                Authors = "nlight",
                BrokenBy = GameVersion.AfterDark,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // frameworks:
                    { 888017364uL , Status.Incompatible }, // Quartz (Sapphire) - Fixed 1.11
                    { 576970398uL , Status.Incompatible }, // Quartz (former Sapphire) - UI skin framework
                    { 421770876uL , Status.Required     }, // Sapphire - UI skin framework
                    // skins:
                    { 578482272uL , Status.Incompatible }, // [FIXED][LEGACY] Emerald UI (16:9)
                    { 422251153uL , Status.Incompatible }, // Emerald UI (16:9)
                    // other:
                    { 1224627683uL, Status.Incompatible }, // Fudged Population Enhanced
                },
                CompatibleWith = GameVersion.Patch_1_1_1,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable
                      | ItemFlags.SourceBundled, // Source folder
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "IUserMod: No 'OnEnabled()' or 'OnDisabled()' methods; might throw errors on app launch/exit." },
                },
                Published = WorkshopDate("9 Apr, 2015"),
                ReplaceWith = 578482272uL, // [FIXED][LEGACY] Emerald UI (16:9)
                SourceURL = "https://github.com/AlexanderDzhoganov/Skylines-Sapphire/tree/master/Skins/Emerald",
                Updated = WorkshopDate("12 Apr, 2015"),
                UserModInspected = true,
            });
        }
    }
}