using UnityEngine;
using System.Collections;
using UnityEditor;

namespace Game.ItemSystem{
public partial class ISQualityDatabaseEditor : EditorWindow  {
		ISQualityDatabase QualityDatabase;

		Texture2D selectedTexture;
		int selectedIndex = -1;

		Vector2 _scrossPos; // scroll position for the ListView

		const int SPRITE_BUTTON_SIZE = 46;
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
			QualityDatabase = ScriptableObject.CreateInstance<ISQualityDatabase> ();
			QualityDatabase = QualityDatabase.GetDatabase<ISQualityDatabase> (FOLDER_NAME, FILE_NAME);

		}

		void OnGUI(){
			if (QualityDatabase == null) {
				Debug.LogWarning ("qualityDatabase Not loaded");
				return;
			}
				ListView ();

				GUILayout.BeginHorizontal ("Box", GUILayout.ExpandWidth (true));
				BottomBar ();
				GUILayout.EndHorizontal ();
				//AddQualityToDatabase();
			
		}

		void BottomBar(){
			//count
			GUILayout.Label ("Qualities: " + QualityDatabase.Count ());

			//addButton
			if (GUILayout.Button ("Add")) {
				QualityDatabase.Add(new ISQuality());
			}
		}




}
}
