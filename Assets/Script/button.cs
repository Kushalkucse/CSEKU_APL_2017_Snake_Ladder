using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class button : MonoBehaviour 
{
	public Sprite oneEye;
	public button btn;
	public Image image;
	void Start () 
	{
		btn = GetComponent<button>();
	}

	public void ChangePic()
	{
		btn.image.overrideSprite = oneEye;
	}

}
