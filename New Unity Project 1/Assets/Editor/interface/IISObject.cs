using UnityEngine;
using System.Collections;
namespace Game.ItemSystem{
public interface IISObject {
	string ISName { get; set; }
	int ISValue { get; set; }
	Sprite ISIcon { get; set; }
	int ISBurden { get; set; }
	ISQuality ISQuality { get; set;}

	//equip
	//questItem flag
	//durability
	//takedamage
	//prefabs
}
}