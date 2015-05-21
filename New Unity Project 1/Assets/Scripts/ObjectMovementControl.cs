using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ObjectMovementControl : MonoBehaviour {
	public Text timer;
	public bool Reverse = false;
	public float timeLeft = 15f;
	public int x_rotate;
	public int y_rotate;
	public int z_rotate;
	float _timeLeft;
	bool neg = false;
	
	
	
	void Start (){
		_timeLeft = timeLeft;
	}
	// Update is called once per frame
	void Update () {
		timer.text = timeLeft.ToString ();
		timeLeft -= Time.deltaTime;
		
		if (Reverse) {
			if (timeLeft <= _timeLeft) {
				neg = false;
			}
			if (timeLeft > 0f && timeLeft <= _timeLeft && neg == false) {
				transform.Translate (Vector3.down * Time.deltaTime, Space.World);
				transform.Rotate (new Vector3 (x_rotate, y_rotate, z_rotate) * Time.deltaTime);
			} else {
				if (neg == false) {
					timeLeft = _timeLeft*2;
				}
				neg = true;
				transform.Translate (Vector3.up * Time.deltaTime, Space.World);
				transform.Rotate (new Vector3 (x_rotate, y_rotate, z_rotate) * Time.deltaTime);
			}
		} else {
			if (timeLeft <= _timeLeft) {
				neg = false;
			}
			if (timeLeft > 0f && timeLeft <= _timeLeft && neg == false) {
				transform.Translate (Vector3.up * Time.deltaTime, Space.World);
				transform.Rotate (new Vector3 (x_rotate, y_rotate, z_rotate) * Time.deltaTime);
			} else {
				if (neg == false) {
					timeLeft = _timeLeft*2;
				}
				neg = true;
				transform.Translate (Vector3.down * Time.deltaTime, Space.World);
				transform.Rotate (new Vector3 (x_rotate, y_rotate, z_rotate) * Time.deltaTime);
			}
		}
	}
	
}