using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class newCharacterController : MonoBehaviour 
{
	public Transform grids;
	public Transform player;

	public List<Transform> gridList;
	int gridIndex;

	Transform startPos;
	Transform endPos;

	bool startPlay;
	bool doMove;
	void Start () 
	{
		gridList = new List<Transform> ();

		foreach (Transform item in grids) 
		{
			gridList.Add (item);
		}
		startPos = player;
		endPos = gridList [0];
	}
	

	void Update () 
	{
		if (startPlay)
		{
			//if (doMove) 
			//{
			player.position = Vector3.Lerp (startPos.position, endPos.position, Time.deltaTime);
			//
			//}

//			if (player.position == endPos.position)
//			{
//				doMove = true;
//			}

		}
	}

//	Transform GetCorrectGrid(string id)
//	{
//		var index = System.Int16.Parse (id);
//		return gridList [index];
//	}

	public void RollTheDice()
	{
		int r = Random.Range (1, 6);

		gridIndex += r;
		startPos = player;
		endPos = gridList [gridIndex];

		print (r + "   "+ gridList [gridIndex]);
		startPlay = true;
		doMove = true;
	}
}
