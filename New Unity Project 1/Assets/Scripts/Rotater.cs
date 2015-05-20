using UnityEngine;
using System.Collections;

public class Rotater : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.up * Time.deltaTime, Space.World);
		transform.Rotate ( new Vector3 (15,15,15) * Time.deltaTime);
	}
}

