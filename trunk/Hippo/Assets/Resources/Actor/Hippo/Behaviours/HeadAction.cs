using UnityEngine;
using System.Collections;

public class HeadAction : MonoBehaviour {

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");

     

        foreach (ContactPoint contact in collision.contacts)
        {
            GameObjectDestroy.Destroy(contact.otherCollider);
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }

    }
}
