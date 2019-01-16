using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inmenu : MonoBehaviour {

    NPC user;

    bool toggleTxt;

    private void Awake()
    {
        string json = PlayerPrefs.GetString("NPC");

        if (string.IsNullOrEmpty(json))
        {
            user = new NPC();
            user.HP = 200;
            user.MP = 10;

            user.items = new List<Item>();
            user.items.Add(new Item(3, 5));
            user.items.Add(new Item(4, 2));
            // user.playname = "AAA";
            user.playname = PlayerPrefs.GetString("NAME");
        }
        else
        {
            user = JsonConvert.DeserializeObject<NPC>(json);
        }

        toggleTxt = false;
    }
    private void OnGUI()
    {
        user.playname = GUI.TextField(new Rect(10, 10, 200, 20), user.playname, 25);
        toggleTxt = GUI.Toggle(new Rect(10, 40, 100, 30), toggleTxt, "A Toggle text");

        if(GUI.Button(new Rect(10, 100, 100, 50), "Game"))
        {
           
            string json = JsonConvert.SerializeObject(user);
            PlayerPrefs.SetString("NPC", json);

            Application.LoadLevel(1);
        }

    }
}
