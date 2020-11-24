using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxTask(int task)
    {
        slider.maxValue = task;
        slider.value = task;
    }

    public void SetTask(int task)
    {
        slider.value = task;
    }
}
