using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadialTrigger : MonoBehaviour
{
    [Tooltip("Point A")]
    public Transform A;

    [Tooltip("Point B")]
    public Transform B;

    [Range(1, 10)]
    public float Radius;

    private void OnDrawGizmos()
    {
        if (A == null || B == null) return;
        
        var AB = Vector2.SqrMagnitude(A.position - B.position);

        if (AB > Mathf.Pow(Radius, 2))
        {
            Gizmos.color = Color.red;
        } 

        else
        {
            Gizmos.color = Color.green;
        }
     
        Gizmos.DrawSphere(A.position, Radius);
    }


}
