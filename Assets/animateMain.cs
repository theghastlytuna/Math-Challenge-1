using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateMain : MonoBehaviour
{
    public GameObject panel;

    public void animate()
    {
        if (panel != null)
        {
            Animator animator = panel.GetComponent<Animator>();
            if (animator != null)
            {
                bool mainOut = animator.GetBool("mainOut");

                animator.SetBool("mainOut", !mainOut);
            }
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
