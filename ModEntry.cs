using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace StardewValleyMod
{

	/// The mod's entry point (duh) ;
	public class ModEntry : Mod
	{
		/// The mod entry point, called after the mod is first loaded ;
		/// <param name="helper">Provides simplified APIs for writing mods ;
		public override void Entry(IModHelper helper)
		{
			helper.Events.Input.ButtonPressed += OnButtonPressed;
		}

		/// Raised after the player presses a button on the keyboard, controller, or mouse ;
		/// <param name="sender">The event sender.</param>
		/// <param name="e">The event data.</param>
		private void OnButtonPressed(object sender, ButtonPressedEventArgs e)
		{
			// ignore if player hasn't loaded a save yet
			if (!Context.IsWorldReady)
				return;

			// print button presses to the console window
			Monitor.Log($"{Game1.player.Name} pressed {e.Button}.", LogLevel.Debug);
		}
	}

}