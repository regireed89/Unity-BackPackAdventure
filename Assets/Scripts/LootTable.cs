using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using ScriptableObjects;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "Loot Table", menuName = "Loot Table", order = 1)]
public class LootTable : ScriptableObject
{


    public List<ItemDrop> Drops;
    public float r;
    [System.Serializable]
    public class ItemDrop
    {
        public Item Item;

        [Range(0.0f, 1.0f)]
        public float ChanceToDrop;

    }



    public List<Item> GetDrops()
    {
        List<Item> items = new List<Item>();
        r = Random.Range(0.0f, 1.0f);
        foreach (ItemDrop drop in Drops)
        {
            if (drop.ChanceToDrop > r)
            {
                items.Add(drop.Item);
            }
        }
        return items;
    }
    [CustomEditor(typeof(LootTable))]
    public class InspectorLootTable:Editor
    {
        
        public override void OnInspectorGUI()
        {
            
            var mytarget = target as LootTable;
            if (GUILayout.Button("Roll"))
            {
                mytarget.GetDrops();
            }
            base.OnInspectorGUI();
        }
}
    


}
 