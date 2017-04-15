using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Ladder
{
    public int fromIndex;
    public int toIndex;
}
public class LodoLogic : MonoBehaviour
{
	public Text Diceoutput;
    public Transform parentNode;
    public  float speed;
    public GameObject player;
    public Button rollAdice;
    public List<Ladder> laddr;
    public int maxGrid;
	Animator anim;
	bool ChangePos=true;

    List<Transform> nodes;

    int input;
    int targetValue;

   

    Vector3 currentBlockPos;
    Vector3 targetBlockPos;

    int currentBlockIndex;

    bool isLader;
    float timer;
	// Use this for initialization
	void Start () 
    {
		anim = GetComponent<Animator> ();
        nodes = new List<Transform>();
        input = 0;
        targetValue = 0;
        foreach (Transform item in parentNode)
        {
            nodes.Add(item);
        }
        currentBlockPos = nodes[currentBlockIndex].position;
        player.transform.position = currentBlockPos;
        targetBlockPos = player.transform.position;
	}
	

	// Update is called once per frame
	void Update () 
    {
        if(player.transform.position != targetBlockPos)
        {
           // print(currentBlockIndex);
			//player animation true;
            timer = Time.deltaTime * speed;
			//rotatedforward ();

            if(player.transform.position != currentBlockPos)
            {
				
                player.transform.position = Vector3.Lerp(player.transform.position,currentBlockPos,timer);
            }
            else
            {
                                 
                currentBlockIndex++;
				Debug.Log (currentBlockIndex);

                UpdateCurrentPos();
            }
			if (nodes [currentBlockIndex].position == nodes [10].position&&ChangePos==true) {
				rotatedback ();
				ChangePos=false;
			}
			if (nodes [currentBlockIndex].position == nodes [20].position&&ChangePos==false) {
				rotatedback ();
				ChangePos=true;
			}
            rollAdice.interactable = false;

			for (int i = 0; i < laddr.Count; i++)
			{
				if(laddr[i].fromIndex == currentBlockIndex && targetValue == laddr[i].fromIndex)
				{
					currentBlockIndex = laddr[i].toIndex-1 ;
					targetValue = laddr[i].toIndex;
					targetBlockPos = nodes[targetValue].position;
				}
			}
        }
        else
        {
            rollAdice.interactable = true;
			//anim.SetBool ("Walk", false);
        }
	}

    void UpdateCurrentPos()
    {
        currentBlockPos = nodes[currentBlockIndex].position;

        

    }
    public void GetInput()
    {
        input = Random.Range(1,6);
		Diceoutput.text = input.ToString();
        targetValue = targetValue + input;

		if (targetValue == maxGrid - 1)
		{
			 
			SceneManager.LoadScene ("level2");
		} 
		else 
		{

		}
//		else if (targetValue == maxGrid - 1) 
//		{
//			SceneManager.LoadScene ("level2");
//		}
        targetBlockPos = nodes[targetValue].position;

        currentBlockIndex++;
        currentBlockPos = nodes[currentBlockIndex].position;

		print (input + "  "+ targetValue);


    }
	public void rotatedback()                                                                //rotated the character 180 degree;
	{
		player.transform.Rotate (Vector3.up * 180);
	} 
	public void rotatedforward()                                                               //intial rotated state of the char;
	{
		player.transform.Rotate (Vector3.down * 180);
	}

}
