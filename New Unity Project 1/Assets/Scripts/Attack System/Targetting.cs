using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Targetting : MonoBehaviour {
	public List<GameObject> targets;
	public GameObject selectedTarget;

	Transform myTransform;
	// Use this for initialization
	void Start () {
		targets = new List<GameObject>();
		AddAllEnemies ();
		selectedTarget = null;
		myTransform = transform;
	}
	
	public void AddAllEnemies(){
		GameObject[] go = GameObject.FindGameObjectsWithTag("Enemy");
		
		foreach(GameObject enemy in go ){
			AddTarget(enemy);
		}	
	}


	public void AddTarget (GameObject enemy){
		targets.Add (enemy);
	}

	void SortTagetsByDistance(){
		targets.Sort(delegate(GameObject t1, GameObject t2){
			return Vector3.Distance(t1.transform.position,myTransform.position).CompareTo(Vector3.Distance(t2.transform.position, myTransform.position));
			          });
		}


	void TargetEnemy(){
		if (selectedTarget == null) {
			SortTagetsByDistance ();
			selectedTarget = targets [0];
		} else {
			int index = targets.IndexOf(selectedTarget);
			if(index < targets.Count-1){
				index++;
			}
			else{
				index = 0;
			}
			DeselectTarget();
			selectedTarget = targets[index];
		}
		SelectTarget ();
	}
	void DeselectTarget (){
		selectedTarget.transform.GetComponent<Renderer>().material.color = Color.blue;
		selectedTarget = null;
	}
	void SelectTarget(){
		PlayerAttack pa = (PlayerAttack)GetComponent ("PlayerAttack");
		pa.target = selectedTarget;

		selectedTarget.transform.GetComponent<Renderer>().material.color = Color.red;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.F)) {
			TargetEnemy ();
		}
	}
}
