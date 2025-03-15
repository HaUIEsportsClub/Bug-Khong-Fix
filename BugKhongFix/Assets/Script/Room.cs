using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Room : MonoBehaviour
{
    [Header("Button")]
    [SerializeField] private Button btnUp;
    [SerializeField] private Button btnDown;
    [SerializeField] private Button btnLeft;
    [SerializeField] private Button btnRight;

    [Space]
    [Header("Door")]
    [SerializeField] private GameObject DoorBase;
    [SerializeField] private Door door1;
    [SerializeField] private Door door2;
    [SerializeField] private Door door3;
    [SerializeField] private Door door4;

    [Header("Room")]
    [SerializeField] private int indexRoom;
    [SerializeField] private bool isRoomClick;
    private bool isClickBtnUp;
    private bool isClickBtnDown;
    private bool isClickBtnLeft;
    private bool isClickBtnRight;

    private void Awake()
    {
        this.door1 = DoorBase.transform.GetChild(0).GetComponent<Door>();
        this.door2 = DoorBase.transform.GetChild(1).GetComponent<Door>();
        this.door3 = DoorBase.transform.GetChild(2).GetComponent<Door>();
        this.door4 = DoorBase.transform.GetChild(3).GetComponent<Door>();
    }
    private void Update()
    {
        this.ClickDoor();
    }
    public void ClickDoor()
    {
        if (isRoomClick) return;

        btnUp.onClick.AddListener(delegate
        {
            if(isClickBtnUp)
            {
                btnUp.image.color = Color.white;
                this.isClickBtnUp = !this.isClickBtnUp;
            }
            else
            {
                btnUp.image.color = Color.yellow;
                this.isClickBtnUp = !this.isClickBtnUp;
            }

            GameController.instance.UpDoor(door1, this.indexRoom);
        });
        btnDown.onClick.AddListener(delegate
        {
            btnDown.image.color = Color.yellow;
            GameController.instance.UpDoor(door2, this.indexRoom);
        });
        btnLeft.onClick.AddListener(delegate
        {
            btnLeft.image.color = Color.yellow;
            GameController.instance.UpDoor(door3, this.indexRoom);
        });
        btnRight.onClick.AddListener(delegate
        {
            btnRight.image.color = Color.yellow;
            GameController.instance.UpDoor(door4, this.indexRoom);
        });

    }
}
