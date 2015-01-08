using UnityEngine;
using System.Collections;

public class warpController : MonoBehaviour {

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.CompareTag ("warp")) {
			transform.position = new Vector3(0, 1, 0);
		}
	}
}
