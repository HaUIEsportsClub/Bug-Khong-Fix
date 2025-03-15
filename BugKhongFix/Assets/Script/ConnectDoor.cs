using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConnectDoor : MonoBehaviour
{


    public void Connecter(Door d1, Door d2)
    {
        d1.DoorConnect = d2;
        d2.DoorConnect = d1;
    }

}
