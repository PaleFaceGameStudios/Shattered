using UnityEngine;
using System.Collections;

public class ISQuality : IISQuality {
	#region IISQuality implementation
	[SerializeField]string _name;
	[SerializeField]Sprite _icon;



	ISQuality(){
		_icon = new Sprite ();
		_name = "common";
	}



	public string Name {

		get {return _name;}
		set {_name = value;}
	}

	public Sprite Icon {
		get {
			return _icon;
		}
		set {_icon = value;}
	}

	#endregion




}
