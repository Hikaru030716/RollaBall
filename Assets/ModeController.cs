using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeController : MonoBehaviour {

	private int count;
	public Text countText;
    public Text winText;

    void Start()
    {
        count = 0;
        winText.text = "";
    }

    public void ChangeVRmode(){
		Application.LoadLevel ("RollaBall");
	}

	public void ChangeNormalMode(){
		StartCoroutine ("Change");
	}

	IEnumerator Change(){
		yield return new WaitForSeconds (3.0f);
		Application.LoadLevel ("RollaBall_normal");
	}

	public void StopChange(){
		StopCoroutine ("Change");
	}


    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 10)
        {
            winText.text = "You Win!";
        }
    }

}
