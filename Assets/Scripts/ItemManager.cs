using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;

public class ItemManager : Singleton<ItemManager>
{
    [Description("物品列表")]
    public List<Item> items = new List<Item>();

    public void Load()
    {
        string path = Path.Combine(Application.streamingAssetsPath, "items.json");
        string json = File.ReadAllText(path);
        items = JsonConvert.DeserializeObject<List<Item>>(json);
    }
}