using UnityEngine;
using System.Collections;
namespace Game.ItemSystem{


	public interface IISEquipable{
		//equipSlot
		ISEquipmentSlot EquipmentSlot{ get;}
		bool Equip();
}


}