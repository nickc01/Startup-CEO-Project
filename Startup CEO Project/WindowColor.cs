using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using MetroFramework.Components;
using Newtonsoft.Json;
using MetroFramework.Interfaces;

namespace Startup_CEO_Project
{
	[JsonObject(MemberSerialization.OptIn)]
	//Used to update the theme and color of windows and window elements
	public class WindowColor
	{
		//Holds a list of style managers that can be themed
		List<MetroStyleManager> StyleManagers = new List<MetroStyleManager>();
		//Holds a list of forms that can be themed
		List<IMetroForm> FormThemeables = new List<IMetroForm>();
		//Holds a list of controls/elements that can be themed
		List<IMetroControl> ControlThemeables = new List<IMetroControl>();

		[JsonProperty]
		MetroThemeStyle theme; //The theme of the windows
		[JsonProperty]
		MetroColorStyle color; //The color of the windows

		//The default constructor that sets default values
		public WindowColor()
		{
			//Set the color to black
			SetColor(MetroColorStyle.Black);
			//Set the theme to light
			SetTheme(MetroThemeStyle.Light);
		}

		//A constructor that sets the theme and color to the specified parameters
		public WindowColor(MetroColorStyle Color, MetroThemeStyle Theme)
		{
			//Set the color
			SetColor(Color);
			//Set the theme
			SetTheme(Theme);
		}

		//A constructor that sets the theme and color to a specified theme and color name
		public WindowColor(string colorName,string themeName)
		{
			//Set the color
			SetColor(colorName);
			//Set the theme
			SetTheme(themeName);
		}

		//Saves the theme and color to a file
		public void Save()
		{
			//Create a text file and open a writer to it
			using (StreamWriter stream = File.CreateText("styles.txt"))
			{
				//Converts itself into a json string and writes it to the file
				stream.Write(JsonConvert.SerializeObject(this));
				//Close the stream
				stream.Close();
			}
		}

		//Loads the theme and color from a file
		public void Load()
		{
			//If the file exists
			if (File.Exists("styles.txt"))
			{
				try
				{
					//Stores the loaded settings
					WindowColor newSettings = null;

					//Opens a stream reader to the file
					using (StreamReader stream = File.OpenText("styles.txt"))
					{
						//Read the contents of the file, convert the json back into it's object form, and store the object
						newSettings = JsonConvert.DeserializeObject<WindowColor>(stream.ReadToEnd());

						//Close the stream
						stream.Close();
					}

					//Set the color
					SetColor(newSettings.color);
					//Set the theme
					SetTheme(newSettings.theme);
				}
				catch (Exception)
				{

				}
			}
		}

		//Adds a style manager to the list of things that can be colorized
		public void AddThemable(MetroStyleManager styler)
		{
			//Add the style manager
			StyleManagers.Add(styler);

			//Set the style manager's color and theme
			styler.Style = color;
			styler.Theme = theme;
		}

		//Resets the theme and color back to it's original state
		public void Reset()
		{
			SetColor(MetroColorStyle.Black);
			SetTheme(MetroThemeStyle.Light);
		}

		//Remove a style manager from the list of things to be colorized
		public void RemoveThemable(MetroStyleManager styler)
		{
			//Remove the style manager
			StyleManagers.Remove(styler);
		}

		//Adds a form to the list of things to be colorized
		public void AddThemable(IMetroForm themable)
		{
			//Add the form
			FormThemeables.Add(themable);

			//Set the form's color and theme
			themable.Style = color;
			themable.Theme = theme;
		}

		//Removes the form from the list of things to be colorized
		public void RemoveThemable(IMetroForm themable)
		{
			FormThemeables.Remove(themable);
		}

		//Adds an element to the list of things to be colorized
		public void AddThemable(IMetroControl themable)
		{
			//Add the element
			ControlThemeables.Add(themable);

			//Set the element's color and theme
			themable.Style = color;
			themable.Theme = theme;
		}

		//Removes an element from the list of things to be colorized
		public void RemoveThemable(IMetroControl themable)
		{
			//Remove the element
			ControlThemeables.Remove(themable);
		}

		//Sets the color of all the things that can be colorized
		public void SetColor(MetroColorStyle Color)
		{
			//Update the current color
			color = Color;
			//Set the color of the style managers
			foreach (var styler in StyleManagers)
			{
				styler.Style = color;
			}

			//Set the color of the forms
			foreach (var themable in FormThemeables)
			{
				themable.Style = Color;
			}

			//Set the color of the elements
			foreach (var element in ControlThemeables)
			{
				element.Style = Color;
			}
		}

		//Sets the theme of all the things that can be colorized
		public void SetTheme(MetroThemeStyle Theme)
		{
			//Update the theme
			theme = Theme;
			//Set the theme of the style managers
			foreach (var styler in StyleManagers)
			{
				styler.Theme = theme;
			}

			//Set the theme of the forms
			foreach (var themable in FormThemeables)
			{
				themable.Theme = theme;
			}

			//Set the theme of the elements
			foreach (var element in ControlThemeables)
			{
				element.Theme = theme;
			}
		}

		//Sets the color of all the themable elements
		public void SetColor(string colorName)
		{
			if (colorName == "")
			{
				colorName = "Black";
			}
			//Set the color based on the specified index
			//SetColor((MetroColorStyle)(colorName + 1));
			SetColor((MetroColorStyle)Enum.Parse(typeof(MetroColorStyle),colorName));
		}

		//Sets the theme of all the themable elements
		public void SetTheme(string themeName)
		{
			if (themeName == "")
			{
				themeName = "Light";
			}
			//Set the theme based on the specified index
			//SetTheme((MetroThemeStyle)(themeName + 1));
			SetTheme((MetroThemeStyle)Enum.Parse(typeof(MetroThemeStyle),themeName));
		}

		//Gets the current color of all the elements
		public MetroColorStyle GetColor()
		{
			return color;
		}

		//Gets the current theme of all the elements
		public MetroThemeStyle GetTheme()
		{
			return theme;
		}

		//Gets the current color name of all the elements
		public string GetColorName()
		{
			return Enum.GetName(typeof(MetroColorStyle),color);
		}

		//Gets the current theme name of all the elements
		public string GetThemeName()
		{
			//return (int)theme - 1;
			return Enum.GetName(typeof(MetroThemeStyle),theme);
		}

	}
}
