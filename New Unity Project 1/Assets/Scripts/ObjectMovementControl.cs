using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ObjectMovementControl : MonoBehaviour {
	public Vector3 RotateAxis;
	public Vector3 MoveAxis;
	public Vector3 CustomOrbitAxis;
	public bool Orbit;
	public bool move;
	public bool rotate;
	public bool Reverse;

	//public Text test;

	//timer
	public int choiceOfSeconds;
	public float timer = 0;

	//public vectors for orbit
	public float OrbitSpeed = 50f;
	public float Distance;

	//private vectors used for orbit
	Vector3 oldPos;
	Vector3	distance;

	//in state of reversing?
	bool revState = false;


	void Start(){
		//used for orbit

		//Get the position of gameobject before change
		oldPos = transform.position;
		//move object based on chosen distance, change made only on x axis
		distance = new Vector3 (transform.position.x + Distance, transform.position.y, transform.position.z);
		transform.position = distance;
	}



	void Rotate(Vector3 Axis)
	{
		transform.Rotate (Axis * Time.deltaTime);
	}

	void Move(Vector3 Axis)
	{
		transform.Translate(Axis * Time.deltaTime,  Space.World);
	}
	
	//aka orbit
	void InfinteMove(){
		//Orbits around its original position
		transform.RotateAround(oldPos, CustomOrbitAxis, OrbitSpeed * Time.deltaTime);
	}

	Vector3 reverse(Vector3 reversed){
		return reversed -= reversed * 2;
	}

		void Update () 
		{
		if (timer >= choiceOfSeconds) {
			revState ^= true;
			timer = 0f;
		}
		if (move && timer <= choiceOfSeconds && !revState) 
			{
			//Rotate if rotate is selected
			if(rotate)
				Rotate (RotateAxis);
			// if set to orbit, orbit object around selected xyz axis
			if(Orbit)
				InfinteMove ();

			//move normaly xyz axis(no orbit)
			else{
				Move(MoveAxis);
				timer += Time.deltaTime;
			}

			}
			else if (rotate && timer <= choiceOfSeconds && revState) 
			{
//				x_move = x_move * -1;
				timer += Time.deltaTime;
				Move (reverse(MoveAxis));
			if(rotate)
				Rotate (reverse(RotateAxis));
			}
			else
			{
			if(rotate)
				Rotate(RotateAxis);
			}
			//timer.text = timeLeft.ToString ();

		}

	}
		