using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class VitalBar : MonoBehaviour {
	public float scale = 0f;
	float trueScale;
	public RectTransform rectTransform;
	// Update is called once per frame
	void Update () {

		rectTransform.localScale = new Vector3 (scale*2, rectTransform.localScale.y, rectTransform.localScale.z);
	}

	public void AdjustScale(float adj){
		//Debug.Log("Showing AdjustScale, adj: " + adj);
		scale = adj;
		//Debug.Log("Scale: " + scale);
	}
}
