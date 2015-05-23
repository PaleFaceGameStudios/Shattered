using UnityEngine;
using System.Collections;
namespace Game.ItemSystem{

	[System.Serializable]
public class ISQuality : IISQuality {
	#region IISQuality implementation
	[SerializeField]string _name;
	[SerializeField]Sprite _icon;



	public ISQuality(){
		_icon = new Sprite ();
		_name = "";
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
}