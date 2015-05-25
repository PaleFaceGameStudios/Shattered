using UnityEngine;
using System.Collections;

public class BaseStat {
	int _baseValue;			//the base value of this stat
	int _buffValue;			//the amount of the buff to this stat
	int _expToLevel;		//the total amount of exp needed to rait this skill
	float _levelModifier; 	//the modifier applied to the exp needed to raise the skill

	public BaseStat(){
		_baseValue = 0;
		_buffValue = 0;
		_levelModifier = 1.1f;
		_expToLevel = 100;
	}

	int CalculateExpToLevel(){
		return (int)(_expToLevel * _levelModifier);
	}

	public void LevelUp(){
		_expToLevel = CalculateExpToLevel ();
		_baseValue++;
	}

	public int AdjustedBaseValue(){
		return _baseValue + _buffValue;
	}









	#region Basic Setter and Getters
	public int BaseValue {
		get {
			return _baseValue;
		}
		set {
			_baseValue = value;
		}
	}

	public int BuffValue {
		get {
			return _baseValue;
		}
		set {
			_baseValue = value;
		}
	}

	public int ExpToLevel {
		get {
			return _expToLevel;
		}
		set {
			_expToLevel = value;
		}
	}

	public float LevelModifier {
		get {
			return _levelModifier;
		}
		set {
			_levelModifier = value;
		}
	}
	#endregion

}
