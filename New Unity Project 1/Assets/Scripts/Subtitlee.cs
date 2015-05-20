using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Subtitlee : MonoBehaviour {
	public string text;
	public Text Speech;
	// Use this for initialization


void OnTriggerEnter( Collider Other){
	Speech.text = text;
}

	void OnTriggerExit(Collider Other){
		Speech.text = null;
	}
	

}
