using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyScript : Photon.MonoBehaviour {

	public int index = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



		if (photonView.isMine) {
		
			switch (index) {
			case 1:
				transform.position = ViveManager.Instance.head.transform.position;
				transform.rotation = ViveManager.Instance.head.transform.rotation;
				break;
			case 2:
				transform.position = ViveManager.Instance.leftHand.transform.position;
				transform.rotation = ViveManager.Instance.leftHand.transform.rotation;
				break;
			case 3:
				transform.position = ViveManager.Instance.rightHand.transform.position;
				transform.rotation = ViveManager.Instance.rightHand.transform.rotation;
				break;
			}

		}
	}
}
