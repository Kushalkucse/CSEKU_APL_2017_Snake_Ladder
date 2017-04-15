using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour 
{

	public void newGameBtn(string newScene)
	{
		SceneManager.LoadScene (newScene);
	}
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
