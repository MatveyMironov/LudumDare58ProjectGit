using UnityEngine;

public class TeleportMB : MonoBehaviour
{
    [SerializeField] private Transform exitPoint;
    
    public void TeleportObject(GameObject teleportedObject)
    {
        teleportedObject.transform.position = exitPoint.position;
    }
}
