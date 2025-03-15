using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : Singleton<GameController>
{

    [SerializeField] private GameObject connectMenu;

    [SerializeField] private Door door1;
    [SerializeField] private Door door2;
    private int indexRoom = 0;
    public void UpDoor(Door door, int indexDoor)
    {

        if (indexRoom == 0) this.indexRoom = indexDoor;

        if(this.indexRoom != indexDoor)
        {
            this.door2 = door;
        }
        else
        {
            this.door1 = door;
        }

        this.ConnectDoor();
    }

    public void ConnectDoor()
    {
        if(this.door1 == null || this.door2 == null) return;

        door1.DoorConnect = door2;
        door2.DoorConnect = door1;

        door1.IsConnect = true;
        door2.IsConnect = true;

        door1 = null;
        door2 = null;

        this.indexRoom = 0;

        this.connectMenu.SetActive(false);

    }
}
