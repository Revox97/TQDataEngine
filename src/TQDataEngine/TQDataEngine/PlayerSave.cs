using System.ComponentModel.DataAnnotations;

namespace TQDataEngine
{
    /// <summary>
    /// Represents a player's saved game data.
    /// </summary>
    public class PlayerSave
    {
        /// <summary>
        /// Gets the id of the player.
        /// </summary>
        public string Id { get; } = string.Empty;

        /// <summary>
        /// Gets or sets the name of the player.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets the character class of the player.
        /// </summary>
        public string Class { get; } = string.Empty;

        /// <summary>
        /// Gets the level of the player.
        /// </summary>
        [Range(1, 80)]
        public int Level { get; } = 1;

        /// <summary>
        /// Gets wether the player is currently in the main quest.
        /// </summary>
        public bool IsInMainQuest { get; } = false;
    }
}
