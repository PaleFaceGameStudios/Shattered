using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	public Transform target;
	public float moveSpeed;
	public float rotSpeed;

	Transform myTransform;

	void Awake(){
		myTransform = transform;
	}

	// Use this for initialization
	void Start () {
		GameObject go = GameObject.FindGameObjectWithTag ("Player");
		target = go.transform;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawLine (target.transform.position, myTransform.position, Color.black);


		//look at target
		Vector3 relPos = target.position - myTransform.position;
		Quaternion rotation = Quaternion.LookRotation (relPos);
		transform.rotation = rotation;


		//move
		transform.Translate (Vector3.forward * moveSpeed *Time.deltaTime);
	}
}
