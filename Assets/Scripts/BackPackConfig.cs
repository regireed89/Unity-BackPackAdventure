﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "BackPackConfig", menuName = "Item/Equipment/BackPackConfig", order = 1)]
    public class BackPackConfig : Equipment
    {
        public List<Item> INIT_Inventory = new List<Item>();
        public int Capacity = 25;
        public List<Item> Items { get { return INIT_Inventory; } }
    }
}
