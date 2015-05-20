using UnityEngine;
using System.Collections;

public class LevelReload : MonoBehaviour {

	void OnTriggerEnter( Collider Player){

		Application.LoadLevel(Application.loadedLevelName);
	}
}
