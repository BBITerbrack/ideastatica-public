﻿using IdeaStatiCa.Api.Connection.Model;
using IdeaStatiCa.Api.Connection.Model.Connection;
using IdeaStatiCa.ConnectionApi;

namespace CodeSamples
{
	public partial class ClientExamples
	{
		/// <summary>
		/// This example adds a new load effect to an opened project.
		/// </summary>
		/// <param name="conClient">The connected API Client</param>
		public static async Task AddLoadEffect(ConnectionApiClient conClient)
		{
			string filePath = "inputs/simple cleat connection.ideaCon";
			await conClient.Project.OpenProjectAsync(filePath);

			var connections = await conClient.Connection.GetConnectionsAsync(conClient.ProjectId);
			int connectionId = connections[0].Id;

			ConLoadSettings loadSettings = await conClient.LoadEffect.GetLoadSettingsAsync(conClient.ProjectId, connectionId);

			Console.WriteLine(loadSettings.ToString());

			// Get Load Effects
			List<ConLoadEffect> loadEffects = await conClient.LoadEffect.GetLoadEffectsAsync(conClient.ProjectId, connectionId);

			Console.WriteLine("Add new Load effect.");
			Console.WriteLine("Specify Name or Hit Enter for Quick Add");
			string input = Console.ReadLine()?? "";

			if (string.IsNullOrEmpty(input))
			{
				//Generic quick add of a load effect
				//BUG: DOES NOT WORK.
				//BUG: DEFAULT SHOULD BE ACTIVE.
				var newLoadEffect = await conClient.LoadEffect.AddLoadEffectAsync(conClient.ProjectId, connectionId);
				
				if(newLoadEffect != null) 
					Console.WriteLine($"Load Effect Added: Name= {newLoadEffect.Name}, Id= {newLoadEffect.Id}"); 
			}
			{
				ConLoadEffect loadEffect = new ConLoadEffect() { Name = input };

				var newLoadEffect = await conClient.LoadEffect.AddLoadEffectAsync(conClient.ProjectId, connectionId, loadEffect);
				if (newLoadEffect != null)
					Console.WriteLine($"Load Effect Added: Name= {newLoadEffect.Name}, Id= {newLoadEffect.Id}");
			}

			string exampleFolder = GetExampleFolderPathOnDesktop("AddLoadEffect");
			
			// Save updated file.
			string fileName = "add-load-effects.ideaCon";
			string saveFilePath = Path.Combine(exampleFolder, fileName);
			await conClient.Project.SaveProjectAsync(conClient.ProjectId, saveFilePath);

			Console.WriteLine("File saved to: " + saveFilePath);

			//Close the opened project.
			await conClient.Project.CloseProjectAsync(conClient.ProjectId);
		}
	}
}
