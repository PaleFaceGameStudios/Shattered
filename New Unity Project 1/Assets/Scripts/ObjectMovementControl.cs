using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ObjectMovementControl : MonoBehaviour {
	public Vector3 RotateAxis;
	public Vector3 MoveAxis;
	public Vector3 CustomOrbitAxis;
	public bool Orbit;
	public bool move;
	public bool Reverse;

	//public Text test;

	//timer
	public int choiceOfSeconds;
	public int timer = 0;

	//public vectors for orbit
	public float OrbitSpeed = 50f;
	public float Distance;

	//private vectors used for orbit
	Vector3 oldPos;
	Vector3	distance;


	void Start(){
		//used for orbit

		//Get the position of gameobject before change
		oldPos = transform.position;
		//move object based on chosen distance, change made only on x axis
		distance = new Vector3 (transform.position.x + Distance, transform.position.y, transform.position.z);
		transform.position = distance;
	}


	void Rotate()
	{
		transform.Rotate (RotateAxis * Time.deltaTime);
	}
	void Move()
	{
		transform.Translate(MoveAxis * Time.deltaTime,  Space.World);
	}


	//aka orbit
	void InfinteMove(){
		//Orbits around its original position
		transform.RotateAround(oldPos, CustomOrbitAxis, OrbitSpeed * Time.deltaTime);
	}
		void Update () 
		{

		if (move && timer <= choiceOfSeconds) 
			{

			// if set to orbit, orbit object around selected xyz axis
			if(Orbit)
				InfinteMove ();

			//move normaly xyz axis(no orbit)
			else{
				Move();
				timer += 1;
			}

			Rotate ();
			}
			else if (move && timer >= choiceOfSeconds) 
			{
//				x_move = x_move * -1;
				timer += 1;
				Move ();
				Rotate ();
			}
			else
			{
				Rotate();
			}
			//timer.text = timeLeft.ToString ();
<<<<<<< HEAD

		 

=======
>>>>>>> origin/master
		}

	}
		