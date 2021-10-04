using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public Vector3 p0;
    public Vector3 p1;

    // Start is called before the first frame update
    void Start()
    {
        LERPscript.Instance.LERP(p0, p1, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
