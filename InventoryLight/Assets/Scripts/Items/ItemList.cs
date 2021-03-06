﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Assets.Scripts.Items
{
    public class ItemList : MonoBehaviour
    {
        public List<Item> Items;
        public ItemDatabase database;

        void Start()
        {
            Items = new List<Item>();
            
            Items.Add(new Item("Iron Sword","Two-handed iron sword"));
            Items.Add(new Item("Frostmourne", "Weapon made by The Lich King"));
            Items.Add(new Item("New Item3", "It's only an Item"));

            for (int i = 0; i < Items.Count; i++)
            {
               Items[i].ID = i;      
            }

            database.ItemList[0].OnUse += () =>
            {
                print("You have used the " + database.ItemList[0].Name);
            };
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                 print(database.BluePrints[0].x1y2);          
            }
        }
    }
}
