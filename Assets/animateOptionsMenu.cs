using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateOptionsMenu : MonoBehaviour
{
    public GameObject panel;

    public void animate()
    {
        if (panel != null)
        {
            Animator animator = panel.GetComponent<Animator>();
            if (animator != null)
            {
                bool optionsIn = animator.GetBool("optionsIn");

                animator.SetBool("optionsIn", !optionsIn);
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
