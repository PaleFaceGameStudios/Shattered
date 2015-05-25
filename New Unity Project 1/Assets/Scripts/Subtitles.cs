using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Subtitles : MonoBehaviour {
	public string text;
	public Text Speech;
	public int DisplayTime;
	double Timer = 0.0f;
	public Text test;
	
	// Use this for initialization
	void Start () 
	{
		
		
	}
	void OnTriggerEnter( Collider Other)
	{
		if (Timer <= DisplayTime) {
			Speech.text = null;
		}
		else {
			Speech.text = text;
			
			Timer += Time.deltaTime;
			
		}
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	void OnTriggerExit(Collider Other)
	{
		
		
		
	}
	
}
