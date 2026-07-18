using System.Threading;
using UnityEngine;

public class Test : MonoBehaviour
{
    private int n = 0;

    private float timer = 0f;
     void Awake()
    {
        Debug.Log("Awake");
    }
    void Start()
    {
        Debug.Log("Start");
    }

    void Update()
    {
        timer += Time.deltaTime;
        n++;
        Debug.Log(Time.deltaTime);

        if (timer >= 1f)
        {
            Debug.Log(n);
            timer = 0f;
            n = 0;

        }
    }
}
