using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGame : MonoBehaviour {
    string playname;
    NPC user;

    private void Awake()
    {
        string json = PlayerPrefs.GetString("NPC");

        user = JsonConvert.DeserializeObject<NPC>(json);

        //playname = PlayerPrefs.GetString("NAME");


    }
    private void OnGUI()
    {

        GUI.Label(new Rect(10, 10, 100, 20), user.playname);


        if (GUI.Button(new Rect(10, 100, 100, 50), "Menu")){
            Application.LoadLevel(0);
        }
    }
}
