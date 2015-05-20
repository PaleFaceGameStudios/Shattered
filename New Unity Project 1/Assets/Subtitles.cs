using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Subtitles : MonoBehaviour {
	public Text countText;
	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter( Collider Other){
		countText.text = "I wonder where these platforms will take me";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
