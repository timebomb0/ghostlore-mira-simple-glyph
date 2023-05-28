using UnityEngine;

namespace MiraSimpleGlyph
{
    /// <summary>
    /// Entry point for your mod. In this example we just display some text on the screen, but anything is possible.
    /// If you are new to modding for Unity games, there are many guides available online for other Unity games like Rimworld, Kerbal Space Program, and Cities Skylines.
    /// </summary>
    public class ModLoader : IModLoader
    {
        /// <summary>
        /// Called when mod is first loaded.
        /// </summary>
        public void OnCreated()
        {
        }

        /// <summary>
        /// Called when mod is unloaded.
        /// </summary>
        public void OnReleased()
        {
        }

        /// <summary>
        /// Called when game is loaded.
        /// </summary>
        /// <param name="mode">Either a new game, or a previously saved game.</param>
        public void OnGameLoaded(LoadMode mode)
        {
        }

        /// <summary>
        /// Called when game is unloaded.
        /// </summary>
        public void OnGameUnloaded()
        {
    }
}