using UnityEngine;
using System.Collections;
 
[AddComponentMenu("Utilities/Flickering Light")]
public class FlickeringLight2 : MonoBehaviour 
{
	public float cycleDuration = 2f; // How long before looping back to the beginning of the curve
	public int keysCount = 10; // The number of keys
	public float startVal = 1f; // The value around which the intensity will be randomized
	public float randMin = -1f, randMax = 1f; // The min and max of the curve
	public float flickrIntensity = 1f; // The curve will be multiplied by that value and added to startVal	
	// You could use only the curve, but to change the light's behaviour you would need to
	// Resample the keys. It involves Random calls, and can be expensive.
	// By using intensity and startVal, you can modulate it at any time for no cost.
 
 
	private AnimationCurve curve;
 
	private IEnumerator Start () 
	{
		ResampleKeys();
		while( Application.isPlaying )
		{
			float t = 0f;
			float cycleInv = 1f / cycleDuration;
			while( t < 1f )
			{
				GetComponent<Light>().intensity = startVal + curve.Evaluate( t ) * flickrIntensity;
 
				yield return null;
 
				t += Time.deltaTime * cycleInv;
			}
		}
	}
 
	// Can be called from outside if you want a different seed and new settings
	public void ResampleKeys( float _startVal, float _randMin, float _randMax, float _intensity )
	{
		startVal = _startVal;
		flickrIntensity = _intensity;
		randMin = _randMin;
		randMax = _randMax;
 
		ResampleKeys();
	}
	// Can be called from outside if you want a different seed
	public void ResampleKeys()
	{		
		// Make sure there is at least 2 keys
		keysCount = Mathf.Max( keysCount, 2 );
 
		// Generate the keys randomly
		Keyframe[] keys = new Keyframe[keysCount];
		float inv = 1f / (keysCount-1);
		for( int i = 0; i < keysCount; i++ )
			keys[i] = new Keyframe( i * inv, Random.Range(randMin, randMax) );
 
		// Make sure the first and last value matches to have a proper loop
		float firstVal = keys[0].value;
		float lastVal = keys[ keys.Length-1 ].value;
		float middle = (firstVal + lastVal) * .5f;
		keys[0].value = middle;
		keys[ keys.Length-1 ].value = middle;
 
		// Commit
		curve = new AnimationCurve( keys );
	}
}