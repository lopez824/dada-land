using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruct : MonoBehaviour {

	public GameObject destroy;
	
	//void OnTriggerEnter()
	//{
	//	Instantiate(destroy, transform.position, transform.rotation);
	//	Destroy(gameObject);
	//}

	void OnMouseDown()
	{
		Instantiate(destroy, transform.position, transform.rotation);
		Destroy(gameObject);
	}
}
