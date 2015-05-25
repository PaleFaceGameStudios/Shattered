using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ObjectMovementControl : MonoBehaviour {
	public int x_rotate;
	public int y_rotate;
	public int z_rotate;

	public bool move;
	public bool Reverse = false;
	public int x_move;
	public int y_move;
	public int z_move;

	public Text test;

	public int choiceOfSeconds;
	public int timer = 0;

	void Rotate()
	{
		transform.Rotate (new Vector3 (x_rotate, y_rotate, z_rotate) * Time.deltaTime);
	}
	void Move()
	{
		transform.Translate(new Vector3(x_move,y_move,z_move) * Time.deltaTime,  Space.World);
	}
		void Update () 
		{
			
			if (move && timer <= choiceOfSeconds) 
			{
				timer += 1;
				Move ();
				Rotate ();
			}
			else if (move && timer >= choiceOfSeconds) 
			{
				x_move = x_move * -1;
				timer += 1;
				Move ();
				Rotate ();
			}
			else
			{
				Rotate();
			}
			//timer.text = timeLeft.ToString ();
		}

	}
		