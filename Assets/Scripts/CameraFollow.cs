using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  
    public Vector3 offset;   

           //T‰ss‰ pit‰‰ vaa asettaa unityss‰ target eli ket‰ seurataan. Ja t‰s tapaukses se on toi camerafollow
    void Update()
    {
        if (target != null)
        {
          
            transform.position = Vector3.Lerp(transform.position, new Vector3(target.position.x + offset.x, target.position.y + offset.y, transform.position.z), Time.deltaTime * 5f);

        }
    }
}

