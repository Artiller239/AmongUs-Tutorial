using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskCanvas : MonoBehaviour
{
    public GameObject TaskCanvas1;
    public GameObject TaskCanvas2;

    public MouseLook mouseLook;
    public PlayerMovement playerMovement;
    public TaskManager taskManager;

    public void CloseTaskCanvas1()
    {
        TaskCanvas1.SetActive(false);
        mouseLook.enabled = true;
        playerMovement.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void CloseTaskCanvas2()
    {
        TaskCanvas2.SetActive(false);
        mouseLook.enabled = true;
        playerMovement.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Task1IsDone()
    {
        taskManager.Task1IsDone = true;
        taskManager.taskButton.interactable = false;
        Cursor.lockState = CursorLockMode.Locked;
        TaskCanvas1.SetActive(false);
        mouseLook.enabled = true;
        playerMovement.enabled = true;
    }

    public void Task2IsDone()
    {
        taskManager.Task2IsDone = true;
        taskManager.taskButton.interactable = false;
        Cursor.lockState = CursorLockMode.Locked;
        TaskCanvas2.SetActive(false);
        mouseLook.enabled = true;
        playerMovement.enabled = true;
    }
}
