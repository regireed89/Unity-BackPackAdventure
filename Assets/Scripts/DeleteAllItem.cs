using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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
		BackPack b = GameObject.FindGameObjectWithTag ("Player").GetComponent<BackPack> ();
		foreach (ScriptableObjects.Item i in b.Inventory) {
			b.RemoveAllFromStash ();
			GameObject.DestroyImmediate (i);
		}
	}


}