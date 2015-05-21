using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

	public string equipment = "";
	public List<string> items = new List<string>();
	
	public void AddEquipment(string name)
	{
		equipment = name;

		foreach(Equipment equip in gameObject.GetComponentsInChildren<Equipment>())
		{
			if(equip.identifier == name)
			{
				foreach(Transform t in equip.transform)
				{
					t.gameObject.SetActive(true);
				}
			}
		}
	}
}
