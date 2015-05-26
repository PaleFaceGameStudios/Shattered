using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {
	public GameObject target;
	public float attackRange;
	float attackTimer;
	public float cooldown;
	
	
	// Use this for initialization
	void Start () {
		attackTimer = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (attackTimer > 0)
			attackTimer -= Time.deltaTime;
		
		if (attackTimer < 0)
			attackTimer = 0;
		
		

			if(attackTimer== 0){
				Attack();
				attackTimer=cooldown;

		}
	}
	void Attack(){
		float distance  = Vector3.Distance (target.transform.position, transform.position);
		
		Vector3 dir = (target.transform.position - transform.position).normalized;
		float direction = Vector3.Dot (dir, transform.forward);
		
		//Debug.Log (direction);
		
		if (distance < attackRange && direction > 0f) {
			
			PlayerHealth ph = (PlayerHealth) target.GetComponent ("PlayerHealth");
			ph.RemoveCurrentHealth (10);
			
		}
	}
}
