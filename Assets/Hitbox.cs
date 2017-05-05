using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour {

    public static int count;

    GameObject parent;

    public void OnTriggerEnter(Collider other)
    {
        PlayerController player = other.gameObject.GetComponent<PlayerController>();
        parent = GameObject.Find("GamePlay");
        if(player != null)
        {
            gameObject.SetActive(false);
            parent.GetComponent<ModeController>().spawnItem = gameObject;
            count++;
            parent.SendMessage("SetCountText");
            parent.SendMessage("Spawn");
        }
    }

}
