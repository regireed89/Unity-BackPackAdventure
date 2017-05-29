using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "Remove Item", menuName = "Remove Item")]
public class RemoveAllItem : ScriptableObject
{
	public void RemoveAllFromScreen()
	{
		
		foreach(GameObject g in GameObject.FindGameObjectsWithTag("Item"))
		{
			GameObject.DestroyImmediate (g);
		}

	}

	public void RemoveAllFromBackpack()
	{
		
	}


}