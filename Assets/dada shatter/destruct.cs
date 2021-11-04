using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus;

public class destruct : MonoBehaviour {

	public GameObject destroy;
    void OnTriggerEnter(Collider other)
    {
        if (gameObject.GetComponent<OVRGrabbable>().isGrabbed == false)
        {
            if (other.tag == "Weapon" || other.tag == "Art")
            {
                gameObject.SetActive(false);
                Instantiate(destroy, transform.position, transform.rotation);
            }
        }
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
        Instantiate(destroy, transform.position, transform.rotation);
    }
}
