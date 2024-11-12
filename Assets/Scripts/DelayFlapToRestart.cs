using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayFlapToRestart : MonoBehaviour
{
    public GameObject flapToRestart;
    public int delay = 1;

    // Start is called before the first frame update
    void OnEnable()
    {
        Invoke("EnableFlapToRestart", delay);
    }

    void EnableFlapToRestart()
    {
        flapToRestart.SetActive(true);
    }
}
