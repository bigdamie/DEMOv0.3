using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Collision"))
        {
            this.gameObject.transform.position = this.gameObject.transform.position;

            Debug.Log(collision.collider.name);
        }
    }
}
