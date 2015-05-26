using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Subtitles : MonoBehaviour {
	public string text;
	public Text Speech;
	public float DisplayTime;
	float timer = 0.0f;
	//public Text test;
	
	// Use this for initialization
	void StartTimer () 
	{
		timer += Time.deltaTime;
		if (timer >= DisplayTime)
			Speech.text = null;
	}
	void OnTriggerEnter( Collider Other){
		Speech.text = text;

		if (timer >= DisplayTime)
			Speech.text = text;
	}
	
	// Update is called once per frame
	void Update () 
	{
		StartTimer ();
	}
	void OnTriggerExit(Collider Other)
	{
		
		
		
	}
	
}
