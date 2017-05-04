using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour {

    public static int count;

    ModeController controller;

    private void OnTriggerEnter(Collider other)
    {
        PlayerController player = other.gameObject.GetComponent<PlayerController>();
        //ModeController controller = gameObject.GetComponent<ModeController>();
        if (gameObject.CompareTag("Pick Up"))
        {
            gameObject.SetActive(false);
            count++;
            controller.gameObject.SendMessage("SetCountText", count);
            //Debug.Log("Count" + count);
        }
    }

    public IEnumerator PickUpSpawn()
    {
        if (gameObject.activeInHierarchy == false)
        {
            yield return new WaitForSeconds(2.0f);
            Debug.Log("spawn");
            gameObject.SetActive(true);
        }
    }
}