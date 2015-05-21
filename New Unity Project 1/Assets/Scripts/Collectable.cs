using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {

	public string identifier = "";
	public string displayName = "";

	void OnTriggerEnter(Collider other)
	{
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