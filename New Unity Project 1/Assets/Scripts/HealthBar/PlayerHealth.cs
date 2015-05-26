using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
	public VitalBar healthBar;

	public float maxHealth = 100;
	public float curHealth= 100;
	

	public float healthBarLength;
	// Use this for initialization
	void Start () {
		healthBar = FindObjectOfType (typeof(VitalBar)) as VitalBar;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("cuHealth: " + curHealth);
		if (curHealth <= 0f)
			curHealth = 0f;
		if (curHealth >= maxHealth)
			curHealth = maxHealth;
		healthBar.AdjustScale (curHealth / 100);
	}

	public void AddjustCurrentHealth(float adj){
		curHealth += adj;
	}

	public void RemoveCurrentHealth(float adj){

		curHealth -= adj;
	}

	void OnGUI(){
		GUI.Box(new Rect(0,0,30,20), curHealth.ToString());
		//GUI.TextField
	}
}
