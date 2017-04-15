using UnityEngine;
using System.Collections;

public class anim : MonoBehaviour {

	Animator anims;
	void Start () {
		anims = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	public void Update () 
	{
		anims.SetBool ("Walk", false);
	}


}
