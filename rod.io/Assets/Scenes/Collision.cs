using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collision : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)

    {
        Debug.Log("Collided with " + collider.gameObject.name);
        if (collider.gameObject.tag == "Capsule(1)")
        {
            Destroy(collider.gameObject);

        }

    }
}
