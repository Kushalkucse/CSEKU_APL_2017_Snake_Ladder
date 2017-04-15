using UnityEngine;
using System.Collections;

public class Dice : MonoBehaviour {
	//int x=5;
	public GameObject[] die;
	Quaternion temp;
	Vector3 temp1;
	void Start ()
	{
		temp = transform.rotation;
		die = new GameObject[transform.childCount];
		for (int i = 0; i < transform.childCount; i++) 
		{
			die [i] = transform.GetChild (i).gameObject;
		}
	
	}

	public void Die()
	{


			
			temp1 = transform.position;
			temp.y += 65;
			temp.x += 45;
			temp.z += 65;
			temp1.x = 15.0f;
			temp1.y = 1.3f;
			temp1.y = 1.3f;
			transform.rotation = temp;
			transform.position = temp1;
	}
	public int Value()
	{
		if (die [1])
		{
			return 1;
		} 
		else if (die [2])
		{
			return 2;
		}
		else if (die [3])
		{
			return 3;
		}
		else if (die [4])
		{
			return 4;
		}
		else if (die [5])
		{
			return 5;
		}
		else 
		{
			return 6;
		}
	

	}
	

}
