using UnityEngine;
using System.Collections;
namespace Game.ItemSystem{
	

public interface ISStacable{

		int MaxStack{get;}
		int Stack(int amount); //default value of 0
		
}


}