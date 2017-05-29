using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DeleteAllItem))]
public class DeleteAllitemEditor : Editor {

	public override void OnInspectorGUI()
	{
		DeleteAllItem remove = (DeleteAllItem)target;
		if(GUILayout.Button("Delete From Scene"))
			remove.DeleteAllFromScreen();

		if (Application.isPlaying == true) {
			if (GUILayout.Button ("Delete From Backpack")) {
				remove.DeleteAllFromBackpack ();
			}
		}
	}


}
