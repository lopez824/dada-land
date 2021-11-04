using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruct : MonoBehaviour {

	public GameObject destroy;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Weapon" || other.tag == "Art")
        {
            Destroy(gameObject);
            Instantiate(destroy, transform.position, transform.rotation);
        }
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
        Instantiate(destroy, transform.position, transform.rotation);
    }
}
