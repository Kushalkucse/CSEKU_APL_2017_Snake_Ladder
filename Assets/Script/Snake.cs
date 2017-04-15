using UnityEngine;
using System.Collections;

public class Snake : MonoBehaviour {

	Animator anim;
	public bool snake=true;
	void Start () 
	{
		anim = GetComponent<Animator> ();
	}
	

	void Update () 
	{
		//if (Input.GetKeyDown (KeyCode.A))
		//{
			//anim.SetBool ("move", true);
		//} 
		//else
			//anim.SetBool ("move", false);

	
	}
	public void OnTriggerStay2D(Collider2D other)
	{

		if(other.tag=="Player" && transform.position.y <=4.9f && transform.position.x <= 5.0f)
		{
			anim.SetBool("move", true);
		}
		anim.SetBool ("move", true);



	}

}
