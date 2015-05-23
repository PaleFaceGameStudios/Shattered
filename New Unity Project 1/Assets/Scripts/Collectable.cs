using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {
	//VitalBar.adjustScale(1f);
	public string identifier = "test";
	public string displayName = "testItem";

	void OnTriggerEnter(Collider other)
	{
		VitalBar healthBar = new VitalBar ();
		healthBar.AdjustScale (0.1f);
		if(other.gameObject.tag == "Player") 
		{
			Collect(other.gameObject);
		}
	}

	void Collect(GameObject player)
	{
		player.GetComponent<Inventory>().AddEquipment(identifier);
		Destroy(gameObject);
	}
}