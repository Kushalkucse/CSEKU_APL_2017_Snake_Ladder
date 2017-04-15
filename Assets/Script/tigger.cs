using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class tigger : MonoBehaviour {


	void Start ()
	{
	
	}
	public void Update()
	{
		if(Input.GetKeyDown(KeyCode.A))
			Destroy (gameObject);


	}
	public void OnTriggerStay2D(Collider2D other)
	{

		if(other.tag=="Player" )
		{
			SceneManager.LoadScene ("Board");
		}
}

}