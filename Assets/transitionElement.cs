using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transitionElement : MonoBehaviour
{
    public Transform transitionTarget;
    public float duration;

    private Vector3 elementPos;
    private float t = 0.0f;
    private bool lerpEnabled = false;


    public void transition()
    {
        lerpEnabled = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        elementPos = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        if (lerpEnabled)
        {
            t += Time.deltaTime / duration;
            GetComponent<Transform>().position = Vector3.Lerp(elementPos, transitionTarget.position, t);
            if (t >= duration)
            {
                t = 0;
                lerpEnabled = false;
                this.gameObject.SetActive(false);
            }
        }
    }
}
