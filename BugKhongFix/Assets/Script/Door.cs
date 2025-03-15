using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Door doorConnect;
    [SerializeField] private GameObject connectMenu;
    public Door DoorConnect
    {
        set => this.doorConnect = value;
    }
    [SerializeField] private bool isConnect;
    public bool IsConnect
    {
        set => this.isConnect = value;
    }
    // tu tao
    [SerializeField] private int direction;
    //1 - up 
    //2 - down
    //3 - left
    //4 - right

    public Vector3 PositionDoorConnect(GameObject game)
    {
        if (!this.isConnect)
        {
            this.connectMenu.SetActive(true);
            return game.transform.position + CheckDirection();
        }

        return this.doorConnect.transform.position + CheckDirection(this.doorConnect.direction);
    }

    public Vector3 CheckDirection()
    {
        switch(direction)
        {
            case 1:
                return Vector3.down * 1.2f;
            case 2:
                return Vector3.up * 1.2f;
            case 3:
                return Vector3.right * 1.2f;
            case 4:
                return Vector3.left * 1.2f;
        }
        return Vector3.zero;
    }

    public Vector3 CheckDirection(int dir)
    {
        switch (dir)
        {
            case 1:
                return Vector3.down * 1.2f;
            case 2:
                return Vector3.up * 1.2f;
            case 3:
                return Vector3.right * 1.2f;
            case 4:
                return Vector3.left * 1.2f;
        }
        return Vector3.zero;
    }
}
