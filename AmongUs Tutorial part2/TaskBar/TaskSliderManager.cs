using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskSliderManager : MonoBehaviour
{
    private int currentTask;

    public TaskBar taskBar;

    void Start()
    {
        currentTask = 0;
    }

    public void TaskComplete(int complete)
    {
        currentTask += complete;
        taskBar.SetTask(currentTask);
    }
}
