using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskManager : MonoBehaviour
{
    public Button taskButton;

    public GameObject TaskCanvas1;
    public GameObject TaskCanvas2;

    public bool Task1IsDone;
    private bool CanDoTask1;

    public bool Task2IsDone;
    private bool CanDoTask2;

    public MouseLook mouseLook;
    public PlayerMovement playerMovement;

    void Start()
    {
        taskButton.interactable = false;
    }

    void Update()
    {
        if (CanDoTask1 == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                mouseLook.enabled = false;
                playerMovement.enabled = false;
                TaskCanvas1.SetActive(true);
                UnlockMouse();
            }
        }

        if (CanDoTask2 == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                mouseLook.enabled = false;
                playerMovement.enabled = false;
                TaskCanvas2.SetActive(true);
                UnlockMouse();
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if((col.tag == "Task1"))
        {
            if (Task1IsDone == false)
            {
                taskButton.interactable = true;
                CanDoTask1 = true;
            }
        }

        if ((col.tag == "Task2"))
        {
            if (Task2IsDone == false)
            {
                taskButton.interactable = true;
                CanDoTask2 = true;
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        if ((col.tag == "Task1"))
        {
            taskButton.interactable = false;
            CanDoTask1 = false;
        }

        if ((col.tag == "Task2"))
        {
            taskButton.interactable = false;
            CanDoTask2 = false;
        }
    }

    public void UnlockMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
