﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Fake Pictochat/GameSettings")]
public class GameSettings : ScriptableObject
{
    
    [SerializeField]
    private string _gameVersion = "0.0.1";
    public string GameVersion{get{return _gameVersion;}}

    [SerializeField]
    private string _nickName = "Default";
    public string NickName
    {
        get
        {
            int value = Random.Range(0,9999);
            string v = value.ToString();
            return _nickName + v;
        }
    } 

}