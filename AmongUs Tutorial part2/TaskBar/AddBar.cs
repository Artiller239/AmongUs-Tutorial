using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBar : MonoBehaviour
{
    public TaskSliderManager TSM;

    public void Task1IsComplete()
    {
        TSM.TaskComplete(25);
    }

    public void Task2IsComplete()
    {
        TSM.TaskComplete(25);
    }
}
