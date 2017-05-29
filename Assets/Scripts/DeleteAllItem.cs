using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "Delete Item", menuName = "Delete Item")]
public class DeleteAllItem : ScriptableObject
{
	public void DeleteAllFromScreen()
	{
		
		foreach(GameObject g in GameObject.FindGameObjectsWithTag("Item"))
		{
			GameObject.DestroyImmediate (g);
		}

	}

	public void DeleteAllFromBackpack()
	{
		
	}


}