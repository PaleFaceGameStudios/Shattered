using UnityEngine;
using System.Collections;

public interface IISObject {

	//name
	//value - gold value
	//icon
	//burden
	//qualityLevel
	string ISName { get; set; }
	int ISValue { get; set; }
	Sprite ISIcon { get; set; }
	int ISBurden { get; set; }


	//equip
	//questItem flag
	//durability
	//takedamage
}
