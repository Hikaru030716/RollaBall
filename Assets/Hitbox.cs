using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        PlayerController player = other.gameObject.GetComponent<PlayerController>();
        if (player != null)
        {
            gameObject.SetActive(false);
        }
    }
}