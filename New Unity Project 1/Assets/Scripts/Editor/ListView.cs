using UnityEngine;
using UnityEditor;
using System.Collections;

namespace Game.ItemSystem{
	public partial class ISQualityDatabaseEditor {


		//list all qualities
		void ListView(){
			_scrossPos = EditorGUILayout.BeginScrollView (_scrossPos, GUILayout.ExpandHeight (true));

			DisplayQualities ();
			EditorGUILayout.EndScrollView ();
	}

		void DisplayQualities(){
			for (int cnt = 0; cnt < QualityDatabase.Count(); cnt++) {

				//sprite
				if(QualityDatabase.Get(cnt).Icon)
				selectedTexture = QualityDatabase.Get(cnt).Icon.texture;
				else 
					selectedTexture = null;
				if(GUILayout.Button (selectedTexture, GUILayout.Width (SPRITE_BUTTON_SIZE), GUILayout.Height (SPRITE_BUTTON_SIZE))){
					int controllerID = EditorGUIUtility.GetControlID(FocusType.Passive);
					EditorGUIUtility.ShowObjectPicker<Sprite>(null,true,null,controllerID);
					selectedIndex = cnt;
				}
				string commandName = Event.current.commandName;
				if (commandName == "ObjectSelectorUpdated") {
					if(selectedIndex != -1)
					{
					QualityDatabase.Get(selectedIndex).Icon = (Sprite)EditorGUIUtility.GetObjectPickerObject();
					//selectedIndex = -1;
					}
						Repaint();
					
				}



				//name
				QualityDatabase.Get(cnt).Name = GUILayout.TextField( QualityDatabase.Get(cnt).Name);
				//delete
				if(GUILayout.Button("x")){
					if(EditorUtility.DisplayDialog("Delete",
					                               "Are you sure that you want to delete " +QualityDatabase.Get(cnt).Name + " from the database?",
					                               "Much yes", 
					                               "Many no")){
						QualityDatabase.Remove(cnt);
					}
				}
			}
		}
	}
}