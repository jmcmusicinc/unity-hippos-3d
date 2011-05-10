using UnityEngine;
using System.Collections;

public class HeadAction : MonoBehaviour {

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");

        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }

    }
}
