using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public Transform Target;

    
    void Update()
    {
        var playerPosition = Target.position;
        transform.position = new Vector3(playerPosition.x, playerPosition.y, transform.position.z);
    }


}
