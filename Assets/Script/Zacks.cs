using UnityEngine;
using System.Collections;

public class Zacks : MonoBehaviour {

	//public Text diceOutput;

	Vector3 startPos;
	Vector3 movedPos;

	int diceInput;
	bool doMove;
	bool Rotation=true;
	bool ChangeY=true;
	bool PosForward=true;
	Animator anim;

	void Start ()
	{
		anim = GetComponent<Animator> ();
		startPos = transform.position;
		//movedPos = transform.position - startPos;
	}
	void FixedUpdate()
	{
		if (Input.GetKeyDown (KeyCode.Space))                                                                   //input starts here ;
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
		if ((transform.position.y<=0.0f && transform.position.x >= 9.5f) && ChangeY ==true )                 //y axis increment condition, with rotation character;
		{
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
		if ((transform.position.y <=3.4f && transform.position.x <= 0.5f) && ChangeY ==false )                //y axis increment condition, without rotation character;
		{
			if (Rotation == false)
			{
				rotatedforward();
			}
			startPos = transform.position;
			startPos.y =6.3f;
			transform.position = startPos;
			ChangeY = true;
			PosForward = true;


		}

		if (((transform.position - startPos).x > diceInput) && PosForward==true)         //forward control break;
		{
			startPos = transform.position;
			doMove = false;
			anim.SetBool ("walk", false);
		}
		if ((( startPos -transform.position ).x >  diceInput) && PosForward==false)         //backward control break;
		{
			startPos = transform.position;
			doMove = false;
			anim.SetBool ("walk", false);
		}


	} 
	void pone()                                                                              //walking forward;
	{
		anim.SetBool ("walk", true);
		transform.position += new Vector3(1,0,0) * Time.deltaTime;
	}
	void ptwo()                                                                              //walking backward;
	{
		anim.SetBool ("walk", true);
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



