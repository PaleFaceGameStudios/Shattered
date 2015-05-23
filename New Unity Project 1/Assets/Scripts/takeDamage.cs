using UnityEngine;
using System.Collections;

public class takeDamage : MonoBehaviour {
	public VitalBar healthBar;
	public float Damage = 0f;
	public float DamageRate = 0f;
	public bool Knockback;
	float lastDamage = 0f;
	float mass = 3.0F; // defines the character mass
	Vector3 impact = Vector3.zero;
	void FixedUpdate()
	{
		if (lastDamage >= DamageRate)
		{
			lastDamage = 0f;
		}
		lastDamage += Time.fixedDeltaTime;
	}

	void Start(){
		healthBar = FindObjectOfType (typeof(VitalBar)) as VitalBar;

		//player = GameObject.FindWithTag ("Player");
	}

	void OnTriggerStay(Collider Other)
	{
		CharacterController controller = Other.GetComponent<CharacterController> ();

		Vector3 direction = Camera.main.transform.forward;
		direction = Camera.main.transform.forward - Camera.main.transform.forward * 2;
		//Debug.Log("Showing takeDamage, this script is working!");
		if (lastDamage >= DamageRate) {
			healthBar.AdjustScale (Damage / 100);
			if(Knockback)
			AddImpact (direction, 10f);
			if (impact.magnitude > 0.2F)
				controller.Move (impact * Time.deltaTime);
			// consumes the impact energy each cycle:
			impact = Vector3.Lerp (impact, Vector3.zero, 5 * Time.deltaTime);


			//controller.Move (direction);
			Debug.Log (direction);
		}

	}
	public void AddImpact(Vector3 dir, float force){
		dir.Normalize();
		if (dir.y < 0) dir.y = -dir.y; // reflect down force on the ground
		impact += dir.normalized * force / mass;
	}
}
