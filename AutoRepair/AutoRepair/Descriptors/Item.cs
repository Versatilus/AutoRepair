namespace AutoRepair.Descriptors {
    using AutoRepair.Enums;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Descriptor for a workshop item.
    /// </summary>
    public class Item {

        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        ///
        /// If <see cref="ItemType"/> member is not set, the item is ignored.
        /// </summary>
        /// 
        /// <param name="workshopId">The Steam Workshop ID for this item.</param>
        /// <param name="workshopName">The name of this item as it appears in Steam Workshop.</param>
        public Item(ulong workshopId, string workshopName) {
            if (workshopId == 0 || string.IsNullOrEmpty(workshopName)) {
                throw new ArgumentNullException("All items must specify both workshop ID and name.");
            }
            WorkshopId = workshopId;
            WorkshopName = workshopName;
        }

        /// <summary>
        /// Gets or sets the authors who developed the item. Comma-separated list.
        /// </summary>
        public string Authors { get; set; }

        /// <summary>
        /// Gets or sets the name of the catalog that defined this item.
        /// </summary>
        public string Catalog { get; set; }

        /// <summary>
        /// Gets or sets explicitly compatible items.
        ///
        /// Use this to denote compatible or complimentary items within meta conflict groups.
        /// </summary>
        public List<ulong> CompatibleWith { get; set; }

        /// <summary>
        /// Gets or sets flags denoting meta conflict groups.
        /// </summary>
        public ConflictGroups ConflictsWith { get; set; } = ConflictGroups.None;

        /// <summary>
        /// Gets or sets the <see cref="ItemFlags"/> for this item.
        /// </summary>
        public ItemFlags Flags { get; set; } = ItemFlags.None;

        /// <summary>
        /// Gets or sets assets that this item is incompatible with.
        /// </summary>
        public List<ulong> IncompatibleAssets { get; set; }

        /// <summary>
        /// Gets or sets mods that this item is incompatible with.
        /// </summary>
        public List<ulong> IncompatibleMods { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="ItemTypes"/> for this item.
        /// </summary>
        public ItemTypes ItemType { get; set; } = ItemTypes.None;

        /// <summary>
        /// Gets or sets the item's primary language id. Defaults to <c>"en"</c>.
        /// </summary>
        public string Locale { get; set; } = "en";

        /// <summary>
        /// Gets or sets recommended replacement Steam Workshop ID.
        ///
        /// Use this to help users upgrade to most recent/reliable version of something.
        /// </summary>
        public ulong ReplaceWith { get; set; }

        /// <summary>
        /// Gets or sets assets that this item requires.
        /// </summary>
        public List<ulong> RequiredAssets { get; set; }

        /// <summary>
        /// Gets or sets the number of <see cref="RequiredAssetsSelection"/> required.
        /// </summary>
        public Selection RequiredAssetsSelection { get; set; } = Selection.All;

        /// <summary>
        /// Gets or sets mods that this item requires in order to function properly.
        /// </summary>
        public List<ulong> RequiredMods { get; set; }

        /// <summary>
        /// Gets or sets the number of <see cref="RequiredModsSelection"/> required.
        /// </summary>
        public Selection RequiredModsSelection { get; set; } = Selection.All;

        /// <summary>
        /// Gets or sets URL to source code.
        /// </summary>
        public string SourceCodeURL { get; set; }

        /// <summary>
        /// Gets or sets list of useful complimentary assets for this item.
        /// </summary>
        public List<ulong> SuggestedAssets { get; set; }

        /// <summary>
        /// Gets or sets list of useful complimentary mods for this item.
        /// </summary>
        public List<ulong> SuggestedMods { get; set; }

        /// <summary>
        /// Gets or sets the Steam Workshop ID for this item.
        /// </summary>
        public ulong WorkshopId { get; set; }

        /// <summary>
        /// Gets or sets the name of this item as it appears in Steam Workshop.
        /// (UGCDetails.title).
        /// </summary>
        public string WorkshopName { get; set; }
    }
}
