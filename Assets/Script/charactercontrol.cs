using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class charactercontrol : MonoBehaviour
{
	public GameObject[,] grid;
	public Text diceOutput;
	public Transform Parent;
	Vector3 startPos;
	Vector3 movedPos;
	//public Rigidbody2D rbody;
	int diceInput;
	bool doMove;
	bool Rotation=true;
	bool ChangeY=true;
	bool PosForward=true;
	private bool OnLadder = false;
	Animator anim;

	void Start ()
	{
		
		anim = GetComponent<Animator> ();
		//rbody = GetComponent<Rigidbody2D> ();
		startPos = transform.position;
		//movedPos = transform.position - startPos;
	}
	public void FixedUpdate()
	{
		                                                                   //input starts here ;
		//if (Input.GetButton ("hello")) 
		{
			diceInput = GetRandomDice ();
			//diceOutput.text = diceInput.ToString(); 

			doMove = true;
		}
		if (doMove==true && PosForward==true)                                                                     //forward move method;
		{
			pone ();

		}
		if (doMove==true && PosForward==false)                                                                     //backward move method;
		{
			ptwo ();

		}
		if ((transform.position.y<=0.0f && transform.position.x >= 10.0f) && ChangeY ==true && OnLadder==false )                 //y axis increment condition, with rotation character;
		{
			//rbody.velocity = new Vector2 (0, 4f);
			if (Rotation== true)
			{
				rotatedback ();
			}
			PosForward = false;
			startPos = transform.position;
			startPos.y = 3.4f;
			transform.position = startPos;
			ChangeY = false;
			Rotation = false;


		}
		if ((transform.position.y <=3.4f && transform.position.x <= 0.5f) && ChangeY ==false && OnLadder==false )                //y axis increment condition, without rotation character;
		{
			//rbody.velocity = new Vector2 (0, 5f);
			if (Rotation == false)
			{
				rotatedforward();
			}
			startPos = transform.position;
			startPos.y = 6.3f;
			transform.position = startPos;
			ChangeY = true;
			PosForward = true;


		}

		if (((transform.position - startPos).x > diceInput) && PosForward==true)         //forward control break;
		{
			startPos = transform.position;
			doMove = false;
			anim.SetBool ("Walk", false);
		}
		if ((( startPos -transform.position ).x >  diceInput) && PosForward==false)         //backward control break;
		{
			startPos = transform.position;
			doMove = false;
			anim.SetBool ("Walk", false);
		}



	}
	public void OnTriggerStay2D(Collider2D other)
	{

		if(other.tag=="snake" )
		{
			Destroy (gameObject);
		}




	}
	void pone()                                                                              //walking forward;
	{
		anim.SetBool ("Walk", true);
		transform.position += new Vector3(1,0,0) * Time.deltaTime;
	}
	void ptwo()                                                                              //walking backward;
	{
		anim.SetBool ("Walk", true);
		transform.position -= new Vector3(1,0,0) * Time.deltaTime;
	}
	int GetRandomDice()                                                                       //random number generator;
	{
		return Random.Range (1, 6);
	}
	public void rotatedback()                                                                //rotated the character 180 degree;
	{
		transform.Rotate (Vector3.up * 180);
	} 
	public void rotatedforward()                                                               //intial rotated state of the char;
	{
		transform.Rotate (Vector3.down * 180);
	}

		

	}



