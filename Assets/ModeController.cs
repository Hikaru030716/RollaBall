using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeController : MonoBehaviour {

    private int score;
	public Text countText;
    public Text winText;

    


    void Start()
    {
        winText.text = "";
        SetCountText();
    }

    void Update()
    {
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

    //void OnTriggerEnter(Collider other)
    //{
    //    if(hitCheck.gameObject.CompareTag("Pick Up"))
    //    {
    //        SetCountText();
    //    }
    //}

    void SetCountText()
    {
        Hitbox hitCheck = GetComponent<Hitbox>();
        score = Hitbox.count;
        Debug.Log("" + score);
        countText.text = "Count: " + score.ToString();
        if (score >= 10)
        {
            winText.text = "You Win!";
        }
    }


}
