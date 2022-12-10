using Cinemachine;
using UnityEngine;

[RequireComponent(typeof(PolygonCollider2D))]
public class CameraConfiner  : MonoBehaviour
{
    void Start()
    {
        var confiner = FindObjectOfType<CinemachineConfiner>();
        var boundary = GetComponent(typeof(Collider2D)) as Collider2D;
            
        if (confiner != null && boundary != null)
            confiner.m_BoundingShape2D = boundary;
    }
}