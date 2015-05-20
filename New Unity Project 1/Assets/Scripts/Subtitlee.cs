using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Subtitlee : MonoBehaviour {
	public Text Speech;
	// Use this for initialization


void OnTriggerEnter( Collider Other){
	Speech.text = "This place.. Where Am I?";
}
	// Update is called once per frame

}
