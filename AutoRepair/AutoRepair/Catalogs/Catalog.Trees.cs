namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Mods that primarily relate to trees.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to the list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void TreeMods() {

            string catalog = "Trees";

            AddMod(new Review(1803209875u, "Trees' Respiration 1.0.1") {
                Affect = Factor.Environment
                       | Factor.Health
                       | Factor.Pollution
                       | Factor.Trees,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806963141u, Status.Compatible   }, // TM:PE v11.1.2 LABS
                    { 1637663252u, Status.Compatible   }, // TM:PE V11 STABLE
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/klyte45/TreesRespiration",
                Tags = new[] { "Trees", "Pollution", "Environment", "Noise", "Health" },
            });

            AddMod(new Review(1658679290u, "Forest Brush v1.3") {
                Affect = Factor.Environment
                       | Factor.PlaceAndMove
                       | Factor.Trees,
                Authors = "TPB, egi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1928787248u, Status.Recommended  }, // Weeds
                    { 1654658173u, Status.Incompatible }, // Random Tree Brush
                    { 1440928803u, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138u, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 963853793u , Status.Recommended  }, // Ultra low tri trees
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/TPBCS/ForestBrush",
                Tags = new[] { "Trees", "Brush", "Forest", "Landscape", "Random", "Paint", "Environment", "Detailing", },
            });

            AddMod(new Review(1654658173u, "Random Tree Brush") {
                Affect = Factor.Environment
                       | Factor.PlaceAndMove
                       | Factor.Trees,
                Authors = "toster.",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1928787248u, Status.Recommended  }, // Weeds
                    { 1658679290u, Status.Incompatible }, // Forest Brush v1.3
                    { 963853793u , Status.Recommended  }, // Ultra low tri trees
                },
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.Abandonware,
                SourceURL = "https://pastebin.com/8M0gFKZh",
                Tags = new[] { "Trees", "Brush", "Forest", "Landscape", "Random", "Paint", "Environment", "Detailing", },
            });

            AddMod(new Review(1637106958u, "Lock Forestry") {
                Affect = Factor.Environment
                       | Factor.HideRemove
                       | Factor.PlaceAndMove
                       | Factor.Production
                       | Factor.Textures
                       | Factor.Trees
                       | Factor.Zoning,
                Authors = "Quboid",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 593588108u, Status.Recommended }, // Prop & Tree Anarchy
                },
                Flags = ItemFlags.SourceUnavailable,
                Tags = new[] { "Trees", "Forest", "Landscape", "Farming", "Forestry", "Environment", "Detailing", "Industry", },
            });

            AddMod(new Review(1388613752u, "Tree Movement Control") {
                Affect = Factor.Environment
                       | Factor.Rendering
                       | Factor.Trees,
                Authors = "saki7, TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1440928803u, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138u, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1383456057u, Status.Incompatible }, // Shicho - Fundamental support mod for hardcore builders
                    { 842981708u , Status.Incompatible }, // Random Tree Rotation
                },
                Flags = ItemFlags.SourceUnavailable,
                Tags = new[] { "Trees", "Forest", "Landscape", "Wind", "Swaying", "Environment", "Detailing", },
            });

            // render catalog?
            AddMod(new Review(1349895184u, "Tree LOD Fix") {
                Affect = Factor.Environment
                       | Factor.Rendering
                       | Factor.Trees,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1680642819u, Status.Compatible }, // Ultimate Level of Detail (ULOD)
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Sunset Harbor: An error sometimes appears on startup, but it seems to work properly after that." },
                    { NOTE, "This mod improves quality of tree LODs with almost no impact on performance." },
                    { 1680642819u, "[Mod: ULOD] If Tree LOD Fix enabled, try setting tree LOD range lower for faster performance." }, 
                },
                ReleasedDuring = GameVersion.ChirpX,
                Tags = new[] { "Trees", "Forest", "Landscape", "LODs", "Graphics", "Environment", "Detailing", },
            });

            AddMod(new Review(910440715u, "Plant Scaling") {
                Affect = Factor.Trees,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "The mod takes effect whilst placing trees on the map:" },
                    { NOTE, "Press Ctrl + Up/Down to incease/decrease min scale." },
                    { NOTE, "Press Alt + Up/Down to incease/decrease max scale." },
                    { NOTE, "Press Ctrl + Alt + Up/Down to incease/decrease both min and max scale." },
                    { NOTE, "With shortcuts above, pressing Right arrow will increase/decrease faster." },
                    { NOTE, "Press Home to reset to default." },
                },
                Published = WorkshopDate("22 Apr, 2017"),
                Updated = WorkshopDate("13 Nov, 2018"),
            });

            AddMod(new Review(406723376u, "Tree Brush") {
                Affect = Factor.Environment
                       | Factor.PlaceAndMove
                       | Factor.Trees,
                Authors = "Destroyer",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1928787248u, Status.Recommended  }, // Weeds
                    { 963853793u , Status.Recommended  }, // Ultra low tri trees
                    { 502750307u , Status.Incompatible }, // Extra Landscaping Tools
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.InitialRelease,
                ReplaceWith = 502750307u, // Extra Landscaping Tools
            });
        }
    }
}