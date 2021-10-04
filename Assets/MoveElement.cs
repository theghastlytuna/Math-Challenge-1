using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveElement : MonoBehaviour
{
    public Vector3 endPos = new Vector3(0.0f, 0.0f, 0.0f);
    public float duration;

    private Vector3 elementPos;
    private float t = 0;
    private bool animate = false;

    public void LERP()
    {
        animate = true;
        GetComponent<Transform>().position = Vector3.Lerp(elementPos, endPos, t);
    }

    // Start is called before the first frame update
    void Start()
    {
        Vector3 elementPos = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        if (animate)
        {
            t += duration / Time.deltaTime;
            if (t > duration)
            {
                t = 0;
                animate = false;
            }
        }
    }
}
