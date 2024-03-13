using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butter : MonoBehaviour
{
    private int tilingTime = 0;
    private MeshRender ButterMat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (tilingTime < 5)
            {
                Debug.Log("TapingButterTimes" + tilingTime);
                tilingTime++;// tilingTime + 1
            }
    }
}
