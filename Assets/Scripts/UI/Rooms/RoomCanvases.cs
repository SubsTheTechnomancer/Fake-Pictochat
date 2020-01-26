﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCanvases : MonoBehaviour
{
    
    [SerializeField]
    private CreateOrJoinRoom _createOrJoinRoom;
    public CreateOrJoinRoom CreateOrJoinRoom{get{return _createOrJoinRoom;}}

    [SerializeField]
    private CurrentRoom _currentRoom;
    public CurrentRoom CurrentRoom{get{return _currentRoom;}}

    private void Awake()
    {
        FirstInitialize();
    }

    private void FirstInitialize()
    {
        CreateOrJoinRoom.Initialize(this);
        CurrentRoom.Initialize(this);
    }

}
