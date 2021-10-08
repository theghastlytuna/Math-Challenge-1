using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transitionElement : MonoBehaviour
{
    public Transform transitionTarget;
    public float duration;

    private Vector3 elementPos;
    private float t = 0.0f;
    private bool lerpOut = false;
    private bool lerpIn = false;


    public void TransitionOut()
    {
        lerpOut = true;
    }

    public void TransitionIn()
    {
        EnableElement();
        lerpIn = true;
    }

    private void DisableElement()
    {
        this.gameObject.SetActive(false);
    }

    private void EnableElement()
    {
        this.gameObject.SetActive(true);
    }


    // Start is called before the first frame update
    void Start()
    {
        elementPos = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        if (lerpOut && t < 1)
        {
            t += Time.deltaTime / duration;
            GetComponent<Transform>().position = Vector3.Lerp(elementPos, transitionTarget.position, t);
            if (t >= duration)
            {
                t = 0;
                lerpOut = false;
                DisableElement();
            }
        }
        else if (lerpIn)
        {
            t += Time.deltaTime / duration;
            GetComponent<Transform>().position = Vector3.Lerp(transitionTarget.position, elementPos, t);
            if (t >= duration)
            {
                t = 0;
                lerpIn = false;
            }
        }
    }
}
