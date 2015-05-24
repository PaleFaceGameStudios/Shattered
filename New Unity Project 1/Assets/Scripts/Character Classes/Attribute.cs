using UnityEngine;
using System.Collections;

public class Attribute : BaseStat {

	public Attribute(){
		ExpToLevel = 50;
		LevelModifier = 1.05f;
	}
}

public enum AttributeName{
	Strength,
	Stamina,
	Defence,
	Agility,
	Intellect,
	Luck
}