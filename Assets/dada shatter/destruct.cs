using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruct : MonoBehaviour {

	public GameObject destroy;
    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Weapon")
    //    {
    //        Instantiate(destroy, transform.position, transform.rotation);
    //        Destroy(gameObject);
    //    }
    //}

    void OnMouseDown()
    {
        Instantiate(destroy, transform.position, transform.rotation);
        Destroy(gameObject);
        //Debug.Log("destroy");

        //StartCoroutine(respawn());
    }

    //public IEnumerator respawn()
    //   {
    //	Debug.Log("respawn");
    //	yield return new WaitForSeconds(2f);
    //	Instantiate(destroy, transform.position, transform.rotation);

    //}


}
