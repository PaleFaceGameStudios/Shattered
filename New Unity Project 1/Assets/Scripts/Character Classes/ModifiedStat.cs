using System.Collections.Generic;

public class ModifiedStat : BaseStat {

	List<ModifyingAttribute> _mods;  	// a list of Attributes that modify this stat
	int _modValue;						// the amount added to the baseValue of the modifiers

	public ModifiedStat(){
		_mods = new List<ModifyingAttribute> ();
		_modValue = 0;
	}

	public void AddModifier(ModifyingAttribute mod){
		_mods.Add (mod);
	}
	void CalculateModValue(){
		if (_mods.Count > 0)
			foreach (ModifyingAttribute att in _mods) {
//				_modValue += (int)(att.attribute.AdjustedBaseValue * att.ratio);
			}
	}

}


public struct ModifyingAttribute{
	public Attribute attribute;
	public float ratio;

}
