using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Rotater : MonoBehaviour {
	public Text timer;
	float timeLeft = 15f;
	bool neg = false;

	// Update is called once per frame
	void Update () {
		timer.text = timeLeft.ToString();
		timeLeft -= Time.deltaTime;

		if (timeLeft <= 15f) {
			neg = false;
		}
		if (timeLeft > 0f && timeLeft <=15f && neg == false) {
			transform.Translate (Vector3.down * Time.deltaTime, Space.World);
			transform.Rotate (new Vector3 (15, 15, 15) * Time.deltaTime);
		} else {
			if(neg == false){
				timeLeft = 30f;
			}
			neg = true;
			transform.Translate (Vector3.up * Time.deltaTime, Space.World);
			transform.Rotate (new Vector3 (15, 15, 15) * Time.deltaTime);
		}
	}


}

