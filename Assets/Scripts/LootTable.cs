using System.Collections; 
using System.Collections.Generic;
using System.Security.Policy;
using ScriptableObjects;
using UnityEngine; 

[CreateAssetMenu(fileName = "Loot Table", menuName = "Loot Table", order = 1)]
public class LootTable : ScriptableObject
{

    public List<ItemDrop> Drops;

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
        float r = Random.Range(0.0f, 1.0f);
        foreach (ItemDrop drop in Drops)
        {
            if (drop.ChanceToDrop > r)
            {
                
                items.Add(drop.Item);
            }
        }
        return items;
    }

}
 