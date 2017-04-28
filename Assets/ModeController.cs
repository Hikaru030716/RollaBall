using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeController : MonoBehaviour {


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
}
