using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleElement : MonoBehaviour
{
    public Vector3 scaleTarget;
    public float duration;

    private float t = 0.0f;
    private bool scalingUP = false;
    private bool scalingDOWN = false;
    private Vector3 scaleInit;


    public void ScaleUP()
    {
        scalingUP = true;
    }

    public void ScaleDOWN()
    {
        scalingDOWN = true;
    }


    // Start is called before the first frame update
    void Start()
    {
        scaleInit = GetComponent<Transform>().localScale;
    }

    // Update is called once per frame
    void Update()
    {

        if (scalingUP && t < 1)
        {
            t += Time.deltaTime / duration;
            GetComponent<Transform>().localScale = Vector3.Lerp(scaleInit, scaleTarget, t);

            if (t >= 1)
            {
                t = 0;
                scalingUP = false;
            }

        }

        else if (scalingDOWN)
        {
            t += Time.deltaTime / duration;
            GetComponent<Transform>().localScale = Vector3.Lerp(scaleTarget, scaleInit, t);

            if (t >= 1)
            {
                t = 0;
                scalingDOWN = false;
            }
        }

    }
}
