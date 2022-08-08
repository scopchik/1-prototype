using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAttractor : MonoBehaviour
{
    void Update(){
        transform.LookAt(Attractor.POS);
    }
}
