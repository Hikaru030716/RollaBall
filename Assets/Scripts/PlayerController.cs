using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public static int antiAliasing;

	private Rigidbody rb;

	public GameObject Pickup;
    public ModeController GamePlay;
    Collider other;

	void Start ()
	{
		QualitySettings.antiAliasing = 2;
		rb = GetComponent<Rigidbody>();      
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		if (!Application.isEditor) {
			moveHorizontal = Input.acceleration.x;
			moveVertical = Input.acceleration.z;
		}

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}




/*	IEnumerator PickUpSpawn(){
		yield return new WaitForSeconds (2.0f);
		Debug.Log ("spawn");
		Pickup.SetActive (true);
	}
*/
}