namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using UnityEngine;

    /// <summary>
    /// Cubemaps, weather, disasters, graphics rendering, etc.
    ///
    /// See also: <c>Catalog.VehicleEffects.cs</c>.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to the list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void VisualEffectMods() {

            string catalog = "VisualEffects";

            /*
            # ███    ███  ██████  ██████  ███████
            # ████  ████ ██    ██ ██   ██ ██
            # ██ ████ ██ ██    ██ ██   ██ ███████
            # ██  ██  ██ ██    ██ ██   ██      ██
            # ██      ██  ██████  ██████  ███████
            */

            AddMod(new Review(2077102792uL, "AD Cloud Enabler") {
                Affect = Factor.Environment
                       | Factor.Rendering,
                Authors = "네인 | neinnew",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1183931915uL, Status.Compatible   }, // Cubemap Replacer
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Published = WorkshopDate("28 Apr, 2020"),
                Updated = WorkshopDate("28 Apr, 2020"),
                UserModInspected = true,
            });

            AddMod(new Review(1886877404uL, "Custom Effect Loader") {
                Affect = Factor.Rendering
                       | Factor.Textures,
                Authors = "boformer",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1889349343uL, Status.Recommended  },
                    { 1886961495uL, Status.Recommended  },
                    { 959894658uL , Status.Compatible   }, // Custom Light Effects
                    // If active, some vehicles will get hard-dependency for Custom Effect Loader:
                    { 800820816uL , Status.MinorIssues  }, // Extended Asset Editor
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.EditorMod // assets created with it require it
                      | ItemFlags.MinorIssues // can become hard dependency for vehicle assets if Extended Asset Editor active
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Asset creators: See https://gist.github.com/boformer/a9c5935a9752dcaa68d67e3a611ada26" },
                    { 800820816uL, "[Mod: Extended Asset Editor] Vehicles edited/published while CEL + EAE are active might have hard-dependency on CEL." },
                },
                Published = WorkshopDate("12 Oct, 2019"),
                SourceURL = "https://github.com/boformer/CustomEffectLoader",
                Updated = WorkshopDate("12 Oct, 2019"),
            });

            AddMod(new Review(1883101331uL, "Persistent Fog Adjuster") {
                Affect = Factor.Environment,
                Authors = "Cgameworld",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 672248733uL , Status.MinorIssues  }, // Ultimate Eyecandy v1.5.2 (UE setting overriden by PFA setting)
                    { 415732693uL , Status.Incompatible }, // Disable Clouds
                },
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { 672248733uL , "[Mod: Ultimate Eye Candy] Both mods change fog effect; Ultimate Eyecandy effect will be overriden by Ultimate Fog Adjuster." },
                },
                Published = WorkshopDate("7 Oct, 2019"),
                SourceURL = "https://github.com/Cgameworld/PersistentFogAdjuster",
                Tags = new[] { "Fog", "Mist", "Cloud", "Weather", "Eyecandy" },
                Updated = WorkshopDate("7 Oct, 2019"),
            });

            AddMod(new Review(1794015399uL, "Render It!") {
                Affect = Factor.Environment
                       | Factor.Rendering,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1794015399uL, Status.Incompatible }, // Render It!
                    { 1138510774uL, Status.Incompatible }, // PostProcessFX - Multi-platform
                    { 934825735uL , Status.Incompatible }, // Ambient Occlusion
                    { 412146081uL , Status.Incompatible }, // PostProcessFX v1.9.0
                    { 410805639uL , Status.Incompatible }, // Sun Shafts (old)
                    { 410329674uL , Status.Incompatible }, // Ambient Occlusion
                    { 409359952uL , Status.Incompatible }, // Isometric Camera
                    { 408648436uL , Status.Incompatible }, // More Options
                    { 406629464uL , Status.Incompatible }, // Dynamic Resolution (old)
                },
                Flags = ItemFlags.MinorIssues // harmony patch management could be better, TAA is shit
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                SourceURL = "https://github.com/keallu/CSL-RenderIt",
                Tags = new[] { "Effects", "Visual", "Graphics", "Eyecandy" },
            });

            // todo: check if source still obfu
            AddMod(new Review(1760945529uL, "Terrain Level Of Detail (TLOD)") {
                Affect = Factor.Environment
                       | Factor.Rendering
                       | Factor.Textures,
                Authors = "Dendraspis",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1680642819uL, Status.Required }, // Ultimate Level Of Detail (ULOD)
                },
                Flags = ItemFlags.SourceObfuscated // big warning sign
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Tags = new[] { "LODs", "Detail", "Graphics", "Eyecandy", "Terrain", "Map" },
            });

            // LOD toggler has conflicting shortcut, and is also obsoleted by ULOD
            AddMod(new Review(1680642819uL, "Ultimate Level Of Detail (ULOD)") {
                Affect = Factor.Rendering
                       | Factor.Textures
                       | Factor.Trees,
                Authors = "boformer",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1349895184uL, Status.Compatible   }, // Tree LOD Fix
                    { 898480258uL , Status.Recommended  }, // Camera Positions Utility
                    { 812713438uL , Status.Recommended  }, // Dynamic Resolution (Fixed for 1.9!)
                    { 625608461uL , Status.Recommended  }, // Adaptive Prop Visibility Distance
                    { 561888259uL , Status.Incompatible }, // LOD Toggler (deprecated)
                    { 556784825uL , Status.Recommended  }, // Random Tree Rotation
                    { 427258853uL , Status.Unknown      }, // Crossings
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 561888259uL, // LOD Toggler (deprecated)
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                SourceURL = "https://github.com/boformer/UltimateLevelOfDetail",
                Tags = new[] { "LODs", "Detail", "Graphics", "Eyecandy", "Trees", "Props", "Buildings", "Networks", "Decals" },
            });

            AddMod(new Review(1664509314uL, "Custom Animation Loader (CAL)") {
                Affect = Factor.Rendering,
                Authors = "boformer",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 2010704792uL, Status.Recommended  }, // Animated Excavator CAT 365C L
                    { 1706978404uL, Status.Recommended  }, // Animated Excavator アニメーションユンボ
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.EditorMod
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Find animated assets here: https://steamcommunity.com/workshop/browse/?appid=255710&section=readytouseitems&requiredtags%5B%5D=custom%20animation" },
                    { NOTE, "Some animations won't work if the building has no power or is disabled." },
                    { NOTE, "Asset creators, see: http://cslmodding.info/mod/custom-animation-loader/" },
                    { NOTE, "A (slightly outdated) video shows how to create assets: https://www.youtube.com/watch?v=Y7SABko_ZXQ" },
                },
                Published = WorkshopDate("23 Feb, 2019"),
                SourceURL = "https://github.com/boformer/CustomAnimationLoader",
                Updated = WorkshopDate("27 Mar, 2019"),
            });

            AddMod(new Review(1410003347uL, "Additive Shader") {
                Affect = Factor.Rendering,
                Authors = "Ronyx69, Simon Ryr",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Asset creators, see: https://cslmodding.info/mod/additive-shader/" },
                },
                ReleasedDuring = GameVersion.ParkLife,
                SourceURL = "https://gist.github.com/ronyx69/41d2368485b4eea89958c368fab878b8",
            });

            AddMod(new Review(1304997689uL, "Light Trail") {
                Affect = Factor.Camera
                       | Factor.Rendering,
                Authors = "sqrl",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Published = WorkshopDate("18 Feb, 2018"),
                Updated = WorkshopDate("3 Dec, 2018"),
            });

            AddMod(new Review(1300411488uL, "Dynamic Fireworks") {
                Affect = Factor.Rendering,
                Authors = "sqrl",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Published = WorkshopDate("13 Feb, 2018"),
                Updated = WorkshopDate("16 Feb, 2018"),
            });

            AddMod(new Review(1274199764uL, "Network Tiling") {
                Affect = Factor.Rendering,
                Authors = "Ronyx69",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                Flags = ItemFlags.Recommended
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Asset creators, see: https://gist.github.com/ronyx69/db4e7c41fe80020e31d9bd2e1e1196f8" },
                },
                SourceURL = "https://gist.github.com/ronyx69/4f06181c8082188418cd0c224f630a09",
            });

            // Game engine issues: Shadow acne vs. Shadow detachment
            AddMod(new Review(1209581656uL, "Relight") {
                Affect = Factor.Environment
                       | Factor.Rendering,
                Authors = "Ronyx69, TPB, Simon Ryr",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1889738001uL, Status.Recommended  }, // Real Neutral LUT - for Relight, Daylight Classic and Vanilla
                    { 1539183804uL, Status.Recommended  }, // Testing LUTs (for asset creators)
                    { 1539181199uL, Status.Recommended  }, // More Relight LUTs
                    { 1414802020uL, Status.Recommended  }, // Color & Material Test Charts
                    { 1122189715uL, Status.Recommended  }, // Realtime (for asset creators)
                    { 762520291uL , Status.Recommended  }, // Shadow Strength Adjuster
                    { 672248733uL , Status.Recommended  }, // Ultimate Eye Candy
                    { 643364914uL , Status.Incompatible }, // Softer Shadows
                    { 530871278uL , Status.MinorIssues  }, // Daylight Classic
                    { 408648436uL , Status.Incompatible }, // More Options
                },
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Read the workshop page for important details on how to properly set-up your system for Relight." },
                    { 530871278uL, "[Mod: Daylight Classic] Disable 'Classic sunlight color/intensity' and 'classic fog color' to make compatible with Relight." },
                    { 762520291uL, "[Mod: Shadow Strength Adjuster] Set it's 'Shadow Strength' to maximum for best results with Relight." },
                },
                SourceURL = "https://gist.github.com/ronyx69/a75400389e7561164bacabadf0095a2b",
                Tags = new[] { "Render", "Lighting", "Eyecandy", "Brightness", "Gamma", "Contrast", "Temperature", "Tint", "Sun", "Sky", "Moon", "Tonemapping" },
            });

            AddMod(new Review(1183931915uL, "Cubemap Replacer") {
                Affect = Factor.Environment
                       | Factor.Rendering,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2077102792uL, Status.Compatible   }, // AD Cloud Enabler
                    { 1209581656uL, Status.Recommended  }, // Relight
                    { 1183931915uL, Status.Compatible   }, // Cubemap Replacer
                    { 1138510774uL, Status.Recommended  }, // PostProcessFX - Multi-platform
                    { 751706914uL , Status.Incompatible }, // Moon Phases
                    { 530871278uL , Status.Required     }, // Daylight classic
                    { 412146081uL , Status.Compatible   }, // PostProcessFX v1.9.0
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "[Mod: Daylight Classic] 'Classic fog effect' option must be enabled for the cubemap to work!" },
                },
                ReleasedDuring = GameVersion.GreenCities,
                SourceURL = "https://github.com/bloodypenguin/Skylines-CubemapReplacer",
                Tags = new[] { "Cubemap", "Sky", "Environment", "Stars", "Clouds" },
            });

            AddMod(new Review(1138510774uL, "PostProcessFX - Multi-platform") {
                Affect = Factor.Rendering,
                Authors = "cor3ntin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1794015399uL, Status.Incompatible }, // Render It!
                    { 1183931915uL, Status.Compatible   }, // Cubemap Replacer
                    { 1138510774uL, Status.Incompatible }, // PostProcessFX - Multi-platform
                    { 934825735uL , Status.Incompatible }, // Ambient Occlusion
                    { 933513277uL , Status.Recommended  }, // Sun Shafts
                    { 812713438uL , Status.MinorIssues  }, // Dynamic Resolution (Fixed for 1.9)
                    { 412146081uL , Status.Incompatible }, // PostProcessFX v1.9.0
                    { 410805639uL , Status.Incompatible }, // Sun Shafts (old)
                    { 410329674uL , Status.Incompatible }, // Ambient Occlusion
                    { 409359952uL , Status.Incompatible }, // Isometric Camera
                    { 408648436uL , Status.Incompatible }, // More Options
                },
                ContinuationOf = 412146081uL, // PostProcessFX v1.9.0
                Flags = ItemFlags.Abandonware
                      | ItemFlags.EditorBreaking
                      | ItemFlags.MinorIssues // some users have problems opening GUI
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable, // some users say it stopped working
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Keycodes for shortcut key config: https://pastebin.com/qe5BwdA2" },
                    { 812713438uL, "[Dynamic Resolution] PostProcessFX breaks SSAO. Additionally might cause blue or pink screen on load." },
                },
                Tags = new[] { "Render", "Lighting", "Eyecandy", "Bloom", "Lensflare", "FXAA", "TAA", "Ambient Occlusion", "Grain", "Sun shafts" },
            });

            AddMod(new Review(940299505uL, "AnimUV Params") {
                Affect = Factor.Props
                       | Factor.Rendering,
                Authors = "Ronyx69",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Asset creators: See https://cslmodding.info/shader/animuv/" },
                },
            });

            AddMod(new Review(933513277uL, "Sun Shafts") {
                Affect = Factor.Rendering,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 934825735uL , Status.Compatible   }, // Ambinet Occlusion? (no longer in workshop)
                    { 933513277uL , Status.Incompatible }, // Sun Shafts (BP ver)
                    { 530871278uL , Status.Recommended  }, // Daylight classic
                    { 410805639uL , Status.Incompatible }, // Sun Shafts (orig)
                    { 410329674uL , Status.Incompatible }, // Ambient Occlusion
                    { 409359952uL , Status.Incompatible }, // Isometric Camera
                    { 408648436uL , Status.Incompatible }, // More Options
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 410805639uL, // Sun Shafts
                Flags = ItemFlags.Laggy
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "May cause fps drop in-game, especially if you have weak graphics card." },
                },
                Published = WorkshopDate("26 May, 2017"),
                SourceURL = "https://github.com/bloodypenguin/Skylines-SunShafts",
                Updated = WorkshopDate("30 Oct, 2017"),
            });

            AddMod(new Review(929295695uL, "Panorama") {
                Affect = Factor.Camera,
                Authors = "sqrl",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Press Ctrl + Alt + P to open the settings panel. Shortcut can be customised in 'Cities_Skylines/ScreenShotP/hotkey.txt'." },
                },
                Published = WorkshopDate("20 May, 2017"),
                SourceURL = "https://github.com/xdedss/Panorama",
                Updated = WorkshopDate("20 May, 2017"),
            });

            AddMod(new Review(922939393uL, "Transparency LODs Fix") {
                Affect = Factor.Rendering,
                Authors = "TPB, Ronyx69",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Laggy
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "May cause lag on older computers or graphics cards due to increased rendering workload." },
                },
                Published = WorkshopDate("10 May, 2017"),
                Updated = WorkshopDate("1 Apr, 2018"),
            });

            AddMod(new Review(812713438uL, "Dynamic Resolution (Fixed for 1.9!)") {
                Affect = Factor.Rendering,
                Authors = "Gradius Twin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1870740367uL, Status.Incompatible }, // Dynamic Resolution 动态分辨率 Sakuya16个人汉化版
                    { 1138510774uL, Status.MinorIssues  }, // PostProcessFX - Multi-platform
                    { 926945709uL , Status.Incompatible }, // Adjustable FOV
                    { 812713438uL , Status.Incompatible }, // Dynamic Resolution (Fixed for 1.9!)
                    { 602077938uL , Status.Incompatible }, // TotalyFree Camera
                    { 409359952uL , Status.Incompatible }, // Isometric Camera
                    { 408648436uL , Status.Incompatible }, // More Options
                    { 406629464uL , Status.Incompatible }, // Dynamic Resolution (old)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 406629464uL, // Dynamic Resolution
                Flags = ItemFlags.Laggy
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Press F10, or Left Ctrl + R, to open the slider panel." },
                    { NOTE, "Can cause extreme lag on older graphics cards. Make sure your GPU has good cooling." },
                    { 1138510774uL, "[PostProcessFX] PostProcessFX breaks SSAO, and might also cause blue or pink screen on load." },
                },
                Published = WorkshopDate("5 Dec, 2016"),
                SourceURL = "https://github.com/dremelofdeath/Skylines-DynamicResolution",
                Updated = WorkshopDate("28 Oct, 2017"),
            });
            // app notes for Dynamic Resolution
            switch (Application.platform) {
                case RuntimePlatform.WindowsPlayer:
                    Reviews[812713438u].Notes.Add(NOTE, "Windows Users: This mod requires a big page file on high resolutions: https://steamcommunity.com/sharedfiles/filedetails/?id=465790009");
                    break;
                case RuntimePlatform.OSXPlayer:
                    Reviews[812713438u].Notes.Add(NOTE, "Mac Users: This mod causes blank sky on OS/X; unsubscribing the mod will fix it. https://steamcommunity.com/workshop/filedetails/discussion/812713438/1649919326328550651/");
                    break;
            }

            AddMod(new Review(793176674uL, "Sharp Textures") {
                Affect = Factor.Rendering
                       | Factor.UI,
                Authors = "Ronyx69, boformer, TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 812713438uL , Status.Recommended   }, // Dynamic Resolutuion
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Published = WorkshopDate("4 Nov, 2016"),
                Updated = WorkshopDate("4 Nov, 2016"),
            });

            AddMod(new Review(762520291uL, "Shadow Strength Adjuster") {
                Affect = Factor.Rendering,
                Authors = "Ronyx69",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("14 May, 2020"),
                Published = WorkshopDate("12 Sep, 2016"),
                Updated = WorkshopDate("12 Sep, 2016"),
            });

            AddMod(new Review(751706914uL, "Moon Phases") {
                Affect = Factor.Textures
                       | Factor.Rendering,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // likely incompat with anything that changes cubemap, moon texture (eg. theme mixer), etc
                    { 1899640536uL, Status.Incompatible }, // Theme Mixer 2
                    { 1183931915uL, Status.Incompatible }, // Cubemap Replacer
                    { 751706914uL , Status.Incompatible }, // Moon Phases
                    { 582725661uL , Status.Incompatible }, // Skyscape 1
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.MinorIssues
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("14 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { ISSUE, "Sometimes has small flickering black square in middle of the Moon." },
                },
                Published = WorkshopDate("25 Aug, 2016"),
                Updated = WorkshopDate("26 Aug, 2016"),
            });

            AddMod(new Review(582725661uL, "Skyscape 1") {
                Affect = Factor.Textures
                       | Factor.Rendering,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // likely incompat with anything that changes cubemap, moon texture (eg. theme mixer), etc
                    { 1899640536uL, Status.Incompatible }, // Theme Mixer 2
                    //{ 1183931915uL, Status.Incompatible }, // Cubemap Replacer // compatible?! wat!
                    { 751706914uL , Status.Incompatible }, // Moon Phases
                    { 582725661uL , Status.Incompatible }, // Skyscape 1
                },
                CompatibleWith = GameVersion.Campus,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("14 May, 2020"),
                Published = WorkshopDate("24 Dec, 2015"),
                Updated = WorkshopDate("24 Dec, 2015"),
            });

            AddMod(new Review(412146081uL, "PostProcessFX v1.9.0") {
                Affect = Factor.Rendering,
                Authors = "MazK",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1794015399uL, Status.Incompatible }, // Render It!
                    { 1183931915uL, Status.Compatible   }, // Cubemap Replacer
                    { 1138510774uL, Status.Incompatible }, // PostProcessFX - Multi-platform
                    { 934825735uL , Status.Incompatible }, // Ambient Occlusion
                    { 933513277uL , Status.Recommended  }, // Sun Shafts (BP ver)
                    { 412146081uL , Status.Incompatible }, // PostProcessFX v1.9.0
                    { 410329674uL , Status.Incompatible }, // Ambient Occlusion
                    // recommend: dynamic resolution
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.EditorBreaking
                      | ItemFlags.Obsolete // newer version available: 1138510774u
                      | ItemFlags.MinorIssues // some users have problems displaying the GUI
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Keycodes for shortcut key config: https://pastebin.com/qe5BwdA2" },
                    { 812713438uL, "[Dynamic Resolution] PostProcessFX breaks SSAO. Additionally might cause blue or pink screen on load." },
                },
                //ReplaceWith = 1138510774uL, // PostProcessFX - Multi-platform
                Tags = new[] { "Render", "Lighting", "Eyecandy", "Bloom", "Lensflare", "FXAA", "SMAA", "Ambient Occlusion" },
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            // translation
            AddMod(new Review(1870740367uL, "Dynamic Resolution 动态分辨率 Sakuya16个人汉化版") {
                Affect = Factor.Rendering,
                Authors = "Izayoi _Sakuya16",
                Catalog = catalog,
                CloneOf = 812713438uL, // Dynamic Resolution (Fixed for 1.9!)
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1870740367uL, Status.Incompatible }, // Dynamic Resolution 动态分辨率 Sakuya16个人汉化版
                    { 812713438uL , Status.Incompatible }, // Dynamic Resolution (Fixed for 1.9!)
                    { 409359952uL , Status.Incompatible }, // Isometric Camera
                    { 408648436uL , Status.Incompatible }, // More Options
                    { 406629464uL , Status.Incompatible }, // Dynamic Resolution (old)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Laggy
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "F10 or Left Ctrl + R to open the slider panel." },
                    { NOTE, "Can cause extreme lag on older graphics cards. Make sure your GPU has good cooling." },
                },
                Published = WorkshopDate("23 Sep, 2019"),
                ReplaceWith = 812713438uL, // Dynamic Resolution (Fixed for 1.9!)
                Suppress = Warning.OlderReplacement,
                Updated = WorkshopDate("23 Sep, 2019"),
            });

            // broken
            AddMod(new Review(959894658uL, "Custom Light Effects") {
                Affect = Factor.Rendering
                       | Factor.Textures,
                Authors = "Ronyx69, vasimr22",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1886877404uL, Status.Compatible }, // Custom Effects Loader
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // memory leaks = crashes
                      | ItemFlags.Laggy
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This mod causes memory leaks which eventually result in lag then crash to desktop." },
                    { NOTE, "Asset creators: Use Custom Effect Loader mod instead (see replacement link)." },
                },
                Published = WorkshopDate("30 Jun, 2017"),
                ReplaceWith = 1886877404uL, // Custom Effects Loader
                Updated = WorkshopDate("21 Aug, 2017"),
            });

            // No workshop page, but Sun Shafts (BP ver) says it's something about AO
            // Old Sun Shafts page confirms it was called Ambinet Occlusion
            // User on old AO page also linked to it, so it's a continuation of old AO.
            AddMod(new Review(934825735uL, "Ambient Occlusion") {
                Affect = Factor.Rendering,
                ArchiveURL = "https://web.archive.org/web/20170715133852/http://steamcommunity.com/sharedfiles/filedetails/?id=934825735",
                Authors = "TPB, BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1794015399uL, Status.Incompatible }, // Render It!
                    { 1138510774uL, Status.Incompatible }, // PostProcessFX - Multi-platform
                    { 933513277uL , Status.Compatible   }, // Sun Shafts (current)
                    { 934825735uL , Status.Incompatible }, // Ambient Occlusion (TBP)
                    { 412146081uL , Status.Incompatible }, // PostProcessFX v1.9.0
                    { 410805639uL , Status.Incompatible }, // Sun Shafts (old)
                    { 410329674uL , Status.Incompatible }, // Ambient Occlusion (orig)
                    { 410196151uL , Status.Compatible   }, // Bordered Skylines (Fixed for Mass Transit!)
                    { 409359952uL , Status.Incompatible }, // Isometric Camera
                    { 408648436uL , Status.Incompatible }, // More Options
                    { 406629464uL , Status.Compatible   }, // Dynamic Resolution
                },
                ContinuationOf = 410329674uL, // Ambient Occlusion
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop // removed between 21-27 Oct 2017?
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("15 Jul, 2017"), // web archive
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Press F8 to show the sliders." },
                },
                Published = WorkshopDate("28 May, 2017"), // web archive
                Removed = WorkshopDate("23 Jul, 2018"), // web archive
                ReplaceWith = 412146081uL, // PostProcessFX v1.9.0
                SourceURL = "https://github.com/bloodypenguin/Skylines-AmbientOcclusion",
                Suppress = Warning.OlderReplacement,
                Updated = WorkshopDate("30 May, 2017"), // web archive
            });

            AddMod(new Review(926945709uL, "Adjustable FOV") {
                Affect = Factor.Camera,
                Authors = "sqrl",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 812713438uL , Status.Incompatible }, // Dynamic Resolution (Fixed for 1.9!)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Move mouse while pressing Ctrl + O to change FOV. Reset by pressing Ctrl + Shift + O" },
                },
                Published = WorkshopDate("16 May, 2017"),
                Updated = WorkshopDate("16 May, 2017"),
            });

            // old
            AddMod(new Review(415732693uL, "Disable Clouds") {
                Affect = Factor.Environment
                       | Factor.Rendering,
                ArchiveURL = "https://web.archive.org/web/20150415011651/http://steamcommunity.com/sharedfiles/filedetails/?id=415732693",
                Authors = "Obelisk",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1883101331uL, Status.Incompatible }, // Persistent Fog Adjuster
                    { 523824395uL , Status.Incompatible }, // Clouds & Fog Toggler
                    { 408648436uL , Status.Incompatible }, // More Options (Quget)
                },
                ContinuationOf = 408648436uL, // More Options (Quget)
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("23 Jul, 2015"),
                Published = WorkshopDate("28 Mar, 2015"),
                Removed = WorkshopDate("17 Mar, 2016"),
                ReplaceWith = 523824395uL, // Clouds & Fog Toggler
                Updated = WorkshopDate("28 Mar, 2015"), // no evidence of any updates
            });

            // old
            AddMod(new Review(410805639uL, "Sun Shafts") {
                Affect = Factor.Rendering,
                Authors = "Ulysius",
                BrokenBy = GameVersion.AfterDark,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1794015399uL, Status.Incompatible }, // Render It!
                    { 1138510774uL, Status.Incompatible }, // PostProcessFX - Multi-platform
                    { 933513277uL , Status.Incompatible }, // Sun Shafts (current)
                    { 934825735uL , Status.Incompatible }, // Ambient Occlusion (TBP)
                    { 410329674uL , Status.Compatible   }, // Ambient Occlusion (orig)
                    { 410196151uL , Status.Compatible   }, // Bordered Skylines (Fixed for Mass Transit!)
                    { 409359952uL , Status.Compatible   }, // Isometric Camera
                    { 408648436uL , Status.Compatible   }, // More Options
                    { 406629464uL , Status.Compatible   }, // Dynamic Resolution
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Published = WorkshopDate("25 Mar, 2015"),
                ReplaceWith = 933513277uL, // Sun Shafts
                Updated = WorkshopDate("25 Mar, 2015"),
            });

            // old
            AddMod(new Review(410329674uL, "Ambient Occlusion") {
                Affect = Factor.Rendering,
                Authors = "Ulysius",
                BrokenBy = GameVersion.AfterDark,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1794015399uL, Status.Incompatible }, // Render It!
                    { 1138510774uL, Status.Incompatible }, // PostProcessFX - Multi-platform
                    { 933513277uL , Status.Incompatible }, // Sun Shafts (current)
                    { 934825735uL , Status.Incompatible }, // Ambient Occlusion (TBP)
                    { 412146081uL , Status.Incompatible }, // PostProcessFX v1.9.0
                    { 410805639uL , Status.Compatible   }, // Sun Shafts (old)
                    { 410329674uL , Status.Incompatible }, // Ambient Occlusion (orig)
                    { 410196151uL , Status.Compatible   }, // Bordered Skylines (Fixed for Mass Transit!)
                    { 409359952uL , Status.Incompatible }, // Isometric Camera
                    { 408648436uL , Status.Incompatible }, // More Options
                    { 406629464uL , Status.Compatible   }, // Dynamic Resolution
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Press F8 to show the sliders." },
                },
                Published = WorkshopDate("25 Mar, 2015"),
                ReplaceWith = 412146081uL, // PostProcessFX v1.9.0
                Updated = WorkshopDate("25 Mar, 2015"),
            });

            // discovered via: https://steamcommunity.com/workshop/filedetails/discussion/410329674/611701360830851903/
            // looks very much like an early version of Ultimate Eye Candy or Relight.. fog, bloom, tone mapping...
            AddMod(new Review(408648436uL, "More Options") {
                Affect = Factor.Rendering,
                ArchiveURL = "https://web.archive.org/web/20150415010910/http://steamcommunity.com/sharedfiles/filedetails/?id=408648436",
                Authors = "Quget",
                BrokenBy = GameVersion.Snowfall,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1870740367uL, Status.Incompatible }, // Dynamic Resolution 动态分辨率 Sakuya16个人汉化版
                    { 1794015399uL, Status.Incompatible }, // Render It!
                    { 1209581656uL, Status.Incompatible }, // Relight
                    { 1138510774uL, Status.Incompatible }, // PostProcessFX - Multi-platform
                    { 934825735uL , Status.Incompatible }, // Ambient Occlusion (TBP)
                    { 933513277uL , Status.Incompatible }, // Sun Shafts (current)
                    { 812713438uL , Status.Incompatible }, // Dynamic Resolution (Fixed for 1.9!)
                    { 415732693uL , Status.Incompatible }, // Disable Clouds
                    { 410805639uL , Status.Compatible   }, // Sun Shafts (old)
                    { 410329674uL , Status.Incompatible }, // Ambient Occlusion (orig)
                    { 410196151uL , Status.Compatible   }, // Bordered Skylines (Fixed for Mass Transit!)
                    { 409359952uL , Status.Compatible   }, // Isometric Camera
                    { 408648436uL , Status.Incompatible }, // More Options
                    { 407555557uL , Status.Incompatible }, // Camera Effect Remover prototype
                    { 406629464uL , Status.Compatible   }, // Dynamic Resolution (old)
                },
                CompatibleWith = GameVersion.Patch_1_2_2_f2,
                ContinuationOf = 407555557uL, // Camera Effect Remover prototype
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("22 Dec, 2015"), // based on last git commit // mentioned by 415732693uL Disable Clouds mod 23 Jul, 2015
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Press Left Alt + O (letter 'o') to open settings panel." },
                    { NOTE, "This mod apears to be the forerunner to Ultimate Eyecandy and Relight mods." },
                },
                Published = WorkshopDate("15 Mar, 2015"), // adjacent workshop item
                Removed = WorkshopDate("2 Nov, 2017"), // https://steamcommunity.com/app/255710/discussions/0/1479857071254473642/
                ReplaceWith = 1209581656uL, // Relight
                SourceURL = "https://github.com/Quget/More-Options",
                Updated = WorkshopDate("22 Dec, 2015"), // github
            });

            // only toggled fog/clouds, hence landing in this catalog
            AddMod(new Review(407555557uL, "Camera Effect Remover prototype") {
                Affect = Factor.Rendering,
                ArchiveURL = "https://steamcommunity.com/app/255710/discussions/0/610575007210963814/#c610575007210987600",
                Authors = "Quget",
                BrokenBy = GameVersion.Snowfall, // guess
                Catalog = catalog,
                CatalogLinks = new[] { "Camera" },
                Compatibility = new Dictionary<ulong, Status>() {
                    { 523824395uL , Status.Incompatible }, // Clouds & Fog Toggler
                    { 408648436uL , Status.Incompatible }, // More Options
                },
                CompatibleWith = GameVersion.Patch_1_2_2_f2,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("14 Mar, 2015"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Press O to use toggles. Gets rid of the fog/clouds." },
                },
                Published = WorkshopDate("14 Mar, 2015"), // adjacent workshop item
                Removed = WorkshopDate("21 Apr, 2015"), // likely replaced by More Options
                ReplaceWith = 523824395uL, // Clouds & Fog Toggler
                Updated = WorkshopDate("14 Mar, 2015"),
            });

            AddMod(new Review(407358867uL, "Quget's Day & Night Prototype") {
                Affect = Factor.Rendering,
                ArchiveURL = "https://web.archive.org/web/20150326014836/http://steamcommunity.com/id/Quget/myworkshopfiles/?appid=255710",
                Authors = "Quget",
                BrokenBy = GameVersion.AfterDark,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.InitialRelease, // actually 1.1.1 patch
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete // now in vanilla game
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("26 Mar, 2015"), // web archive
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Vanilla game now has day/night cycle. Unsubscribe this mod." },
                },
                Published = WorkshopDate("14 Mar, 2015"), // based on adjacent item
                Removed = GameVersion.PatchDate("2015-09-24"), // complete guess
                Updated = WorkshopDate("14 Mar, 2015"), // insufficient info
            });

            // old
            AddMod(new Review(406629464uL, "Dynamic Resolution") {
                Affect = Factor.Rendering,
                Authors = "nlight",
                BrokenBy = GameVersion.GreenCities,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1870740367uL, Status.Incompatible }, // Dynamic Resolution 动态分辨率 Sakuya16个人汉化版
                    { 1794015399uL, Status.Incompatible }, // Render It!
                    { 934825735uL , Status.Compatible   }, // Ambient Occlusion
                    { 812713438uL , Status.Incompatible }, // Dynamic Resolution (Fixed for 1.9!)
                    { 602077938uL , Status.Incompatible }, // TotalyFree Camera
                    { 410805639uL , Status.Compatible   }, // Sun Shafts
                    { 410329674uL , Status.Compatible   }, // Ambient Occlusion
                    { 409359952uL , Status.Compatible   }, // Isometric Camera
                    { 408648436uL , Status.Compatible   }, // More Options
                    { 406629464uL , Status.Incompatible }, // Dynamic Resolution (old)
                },
                CompatibleWith = GameVersion.MassTransit,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Laggy
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("7 Apr, 2015"),
                ReplaceWith = 812713438uL, // Dynamic Resolution (Fixed for 1.9!)
                SourceURL = "https://github.com/AlexanderDzhoganov/Skylines-DynamicResolution",
                Updated = WorkshopDate("7 Apr, 2015"),
            });

            /*
            # ██████   █████   ██████ ██   ██ ███████
            # ██   ██ ██   ██ ██      ██  ██  ██
            # ██████  ███████ ██      █████   ███████
            # ██      ██   ██ ██      ██  ██       ██
            # ██      ██   ██  ██████ ██   ██ ███████
            */

            AddMod(new Review(1980656676uL, "MARS Sky - Cubemap Replacer Pack") {
                Affect = Factor.Environment,
                Authors = "citywokcitywall",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1183931915uL, Status.Required    }, // Cubemap Replacer
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.LargeFileWarning
                      | ItemFlags.SourceUnavailable,
                Tags = new[] { "Cubemap", "4K", "Sky", "Mars", "Environment" },
            });

            AddMod(new Review(1771841274uL, "HDRI Haven Cubemap Pack 2") {
                Affect = Factor.Environment,
                Authors = "Ronyx69",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1183931915uL, Status.Required }, // Cubemap replacer
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.LargeFileWarning
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://hdrihaven.com/",
                Tags = new[] { "Cubemap", "2K", "Sky", "Earth", "Day", "Sunny", "Dusk", "Night", "Sunset", "Weather", "Environment" },
            });

            AddMod(new Review(1591584836uL, "HDRI 2K Cubemap Pack") {
                Affect = Factor.Environment,
                Authors = "Sparks",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1183931915uL, Status.Required }, // Cubemap replacer
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.LargeFileWarning
                      | ItemFlags.SourceAvailable,
                SourceURL = "http://noemotionhdrs.net/hdrday.html",
                Tags = new[] { "Cubemap", "2K", "Sky", "Earth", "Day", "Sunny", "Sunset", "Weather", "Environment" },
            });

            AddMod(new Review(1585691173uL, "HDRI Haven Cubemap Pack") {
                Affect = Factor.Environment,
                Authors = "Ronyx69",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1183931915uL, Status.Required }, // Cubemap replacer
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://hdrihaven.com/",
                Tags = new[] { "Cubemap", "1K", "Sky", "Earth", "Sunset", "Weather", "Environment" },
            });

            AddMod(new Review(1186800787uL, "Pastel Cubemap Pack") {
                Affect = Factor.Environment,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1183931915uL, Status.Required }, // Cubemap replacer
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://imgur.com/a/WSGJ5",
                Tags = new[] { "Cubemap", "1K", "Sky", "Earth", "Sunset", "Weather", "Environment" },
            });
        }
    }
}