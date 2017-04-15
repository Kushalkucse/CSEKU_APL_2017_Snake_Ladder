using UnityEngine;
using System.Collections;

public class snakeControll : MonoBehaviour {

	Animator anim;
	void Start () 
	{
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
//		if (Input.GetKeyDown (KeyCode.Space)) 
//		{
//			anim.SetBool ("move",true);
//		}
	}
	public void OnTriggerStay2D(Collider2D other)
	{

		if(other.tag=="Player")
		{
			anim.SetBool("move", true);

			Invoke ("snakemove", 2);
		}




	}
	public void snakemove()
	{
		anim.SetBool ("move", false);
	}



}
