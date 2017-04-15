using UnityEngine;
using System.Collections;

public class ladder : MonoBehaviour {

	public float speed = 100f;
	Vector2 temp;
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void OnTriggerStay2D(Collider2D other)

	{


		if (other.tag == "Player" ) 
		{
			

			other.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, speed);
			//temp=transform.position;
			//temp.y += speed;
			//transform.position = temp;
		}


	}
}
