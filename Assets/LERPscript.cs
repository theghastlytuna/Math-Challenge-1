using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LERPscript : MonoBehaviour
{

    private static LERPscript _Instance;

    public static LERPscript Instance
    {
        get
        {
            if (_Instance == null)
            {
                _Instance = new GameObject("LerpScript").AddComponent<LERPscript>();
            }

            return _Instance;
        }
    }

    public static Vector3 LERP (Vector3 p0, Vector3 p1, float t)
    {
        return (1.0f - t) * p0 + t * p1;
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
