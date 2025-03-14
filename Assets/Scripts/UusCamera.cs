using UnityEngine;

public class UusCamera : MonoBehaviour
{
    public Transform player;  
    public float smoothSpeed = 0.125f;  
    public Vector3 offset;  


    void LateUpdate()
    {

        if (player != null)
        {
                          //Uus kamera koodi mis se seuraa pelaajaa, offsetill‰ saa siirrettyy kameraa.
            Vector3 desiredPosition = new Vector3(player.position.x + offset.x, transform.position.y, transform.position.z);


            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);


            transform.position = smoothedPosition;
        }
        else
        {
   // kun pelaaja kuolee, voi kameran joko pys‰ytt‰‰ tai laittaa johki muualle esim. joku fixed position kuoleman j‰lkeen

            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
    }
}
