using UnityEngine;
using System.Collections;
using UnityEditor;

namespace Game.ItemSystem{
public partial class ISQualityDatabaseEditor : EditorWindow  {
		ISQualityDatabase QualityDatabase;
		ISQuality selectedItem;
		Texture2D selectedTexture;
		int selectedIndex = -1;

		Vector2 _scrossPos; // scroll position for the ListView

		const int SPRITE_BUTTON_SIZE = 92;
		const string FILE_NAME = @"ShatteredQualityDatabase.asset";
		const string FOLDER_NAME = @"Database";
		const string DATABASE_PATH = @"Assets/"+FOLDER_NAME+"/" + FILE_NAME;

		[MenuItem("Shattered/Database/Quality Editor %#i")]
		public static void Init(){
			ISQualityDatabaseEditor window = EditorWindow.GetWindow<ISQualityDatabaseEditor> ();
			window.minSize = new Vector2 (400, 300);
			window.title = "Quality database";
			window.Show();
		}


		void OnEnable(){
			QualityDatabase = AssetDatabase.LoadAssetAtPath(DATABASE_PATH, typeof(ISQualityDatabase)) as ISQualityDatabase;

			if (QualityDatabase == null) {
				if(!AssetDatabase.IsValidFolder("Assets/"+FOLDER_NAME)){
					AssetDatabase.CreateFolder("Assets", FOLDER_NAME);

				}
				QualityDatabase = ScriptableObject.CreateInstance<ISQualityDatabase>();
				AssetDatabase.CreateAsset(QualityDatabase,DATABASE_PATH);
				AssetDatabase.SaveAssets();
				AssetDatabase.Refresh();
				
			}
			selectedItem = new ISQuality ();
		}

		void OnGUI(){
			ListView ();
			//AddQualityToDatabase();
		}

		void AddQualityToDatabase(){
			//Name
			selectedItem.Name = EditorGUILayout.TextField ("Name:", selectedItem.Name);
			//Sprite
			if (selectedItem.Icon)
				selectedTexture = selectedItem.Icon.texture;
			else
				selectedTexture = null;

			if (GUILayout.Button (selectedTexture, GUILayout.Width (SPRITE_BUTTON_SIZE), GUILayout.Height (SPRITE_BUTTON_SIZE))) {
				int controllerID = EditorGUIUtility.GetControlID(FocusType.Passive);
				EditorGUIUtility.ShowObjectPicker<Sprite>(null,true,null,controllerID);
			}

			string commandName = Event.current.commandName;
			if (commandName == "ObjectSelectorUpdated") {
				selectedItem.Icon = (Sprite)EditorGUIUtility.GetObjectPickerObject();
				Repaint();

			}

			if (GUILayout.Button ("Save")) {
				if(selectedItem == null || selectedItem.Name == "")
					return;

				QualityDatabase.Add(selectedItem);

				selectedItem = new ISQuality();
			}

		}
}
}
