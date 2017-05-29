using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(RemoveAllItem))]
public class RemoveAllitemEditor : Editor {

	public override void OnInspectorGUI()
	{
		RemoveAllItem remove = (RemoveAllItem)target;
		if(GUILayout.Button("Remove From Scene"))
			remove.RemoveAllFromScreen();
	}


}
