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

	void OnmouseClick()
	{
		Instantiate(destroy, transform.position, transform.rotation);
		Destroy(gameObject);
	}
}
