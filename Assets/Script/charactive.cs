using UnityEngine;
using System.Collections;

public class charactive : MonoBehaviour {

	Vector2 temp;
	void Start () {
	
	}
	

	void Update () {
	
	}
	public void OnTriggerStay2D(Collider2D other)
	{

		if(other.tag=="Player" )
		{
			temp=transform.position;
			temp.y  +=1;
		}




	}
}
