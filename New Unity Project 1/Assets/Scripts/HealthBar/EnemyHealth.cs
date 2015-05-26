using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	
	public float maxHealth = 100;
	public float curHealth= 100;

	public float healthBarLength;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("cuHealth: " + curHealth);
		if (curHealth <= 0f)
			Destroy (gameObject);
		if (curHealth >= maxHealth)
			curHealth = maxHealth;
	}
	
	public void AddjustCurrentHealth(float adj){
		curHealth += adj;
	}
	
	public void RemoveCurrentHealth(float adj){
		
		curHealth -= adj;
	}
	
	void OnGUI(){
		GUI.Box(new Rect(0,30,30,20), curHealth.ToString());
		//GUI.TextField
	}
}
