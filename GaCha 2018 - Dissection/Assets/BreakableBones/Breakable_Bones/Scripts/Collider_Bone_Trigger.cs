using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_Bone_Trigger : MonoBehaviour {

	public int Order;
	public bool IsDestroyed = false;

	void OnTriggerEnter(Collider collision) {
		if (collision.tag == "Outil"){
			if (collision.GetComponent<Rigidbody>().velocity.magnitude > 2){
				Debug.Log("Break!");

				if (GetComponentInParent<Bone_Destroyed>()){
					this.GetComponentInParent<Bone_Destroyed>().CheckFallingBones(Order);
				}
			}
		}
	}


	private void Update() {
		if (IsDestroyed == true){
			MeshCollider[] MeshCOL_Array = GetComponents<MeshCollider>();

			if(MeshCOL_Array[0].isTrigger == true){
				MeshCOL_Array[0].enabled = false;
			}
			else {MeshCOL_Array[1].enabled = false;}

			this.gameObject.transform.parent= GameObject.Find("DestroyedObjectConteneur").transform;
			this.gameObject.AddComponent<Rigidbody>();
			this.gameObject.GetComponent<Collider_Bone_Trigger>().enabled = false;
		}
	}

}
