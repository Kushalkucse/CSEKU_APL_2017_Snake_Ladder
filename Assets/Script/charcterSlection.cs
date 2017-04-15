using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class charcterSlection : MonoBehaviour {

	public GameObject[] characterlist;
	private int index=0;
	public void Start () 
	{
		index = PlayerPrefs.GetInt ("CharacterSelected");

		characterlist = new GameObject[transform.childCount];
		for (int i = 0; i < transform.childCount; i++) 
		{
			characterlist [i] = transform.GetChild (i).gameObject;
		}
		foreach (GameObject go in characterlist) 
		{
			go.SetActive (false);
		}
		//print (transform.childCount + " "+ characterlist.Length + " " + characterlist[0].name );
		//if (characterlist [0])
			//characterlist [0].SetActive (true);
		if (characterlist [index])
			characterlist [index].SetActive (true);

	}
	public void left()
	{
		characterlist [index].SetActive (false);
		index--;
		if (index < 0)
			index = characterlist.Length - 1;

		characterlist [index].SetActive (true);

	}
	public void right()
	{
		characterlist [index].SetActive (false);
		index++;
		if (index ==characterlist.Length)
			index = 0;

		characterlist [index].SetActive (true);

	}
	public void changescene()
	{
		PlayerPrefs.SetInt ("CharacterSelected", index);
		SceneManager.LoadScene ("Board");

	}


}
