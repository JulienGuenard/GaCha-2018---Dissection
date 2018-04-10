using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bone_Destroyed : MonoBehaviour {

	
	public GameObject[] Shatterable_Bones;
	public bool IsThisNotPhysical;


	void Start () {
		UpdateStatesBones();

	}
	




	void UpdateStatesBones(){
		int ChildCount = transform.childCount;
		if (IsThisNotPhysical == false){ gameObject.AddComponent<Rigidbody>();}
		Debug.Log(transform.childCount);
		GameObject[] Shatterable_Bones2 = new GameObject[ChildCount];

		for(int i = 0; i<ChildCount; i++) {
			Shatterable_Bones2[i]=transform.GetChild(i).gameObject;
			

			Shatterable_Bones2[i].gameObject.AddComponent<MeshCollider>().convex=true;
			MeshCollider Bones = Shatterable_Bones2[i].gameObject.AddComponent<MeshCollider>();
			Bones.convex=true;
			Bones.isTrigger=true;

			Shatterable_Bones2[i].gameObject.AddComponent<Collider_Bone_Trigger>().Order = i;
		}
		Shatterable_Bones=Shatterable_Bones2;
	}


	

	public void CheckFallingBones(int CurrentBoneToCheck){
		int	TotalBonesToCheck = Shatterable_Bones.Length;


		Collider_Bone_Trigger ThisBone_Component = Shatterable_Bones[CurrentBoneToCheck].GetComponent<Collider_Bone_Trigger>();
		ThisBone_Component.IsDestroyed = true;
		int NumberOfBonesChecked = 0;

		for (int i = CurrentBoneToCheck -1; i > 0; i--){
			NumberOfBonesChecked++;
			if (Shatterable_Bones[i].GetComponent<Collider_Bone_Trigger>().IsDestroyed == false){
			}
			
		}


		NumberOfBonesChecked=0;
		for (int i = CurrentBoneToCheck + 1; i < TotalBonesToCheck; i++){
			NumberOfBonesChecked++;
			if (Shatterable_Bones[i].GetComponent<Collider_Bone_Trigger>().IsDestroyed == false) {
			}
		}
		

		



	}





	
}
