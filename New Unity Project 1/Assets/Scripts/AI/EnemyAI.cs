using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	public Transform target;
	public float moveSpeed;
	public float rotSpeed;
	public float StopRange;

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
		float distance  = Vector3.Distance (target.transform.position, transform.position);
		
		Vector3 dir = (target.transform.position - transform.position).normalized;
		float direction = Vector3.Dot (dir, transform.forward);
		if (distance > StopRange)
		transform.Translate (Vector3.forward * moveSpeed *Time.deltaTime);
	}
}
