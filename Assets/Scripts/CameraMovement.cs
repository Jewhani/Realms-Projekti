using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed;
    
    void Start()
    {
        
    }

           //Tässä vaan meiän tyhjä peliobjekti liikkuu oikealle.
           //Täytyy mennä yhtä nopeasti kuin pelaaja muuten kusee homma :D
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
        
        
    }
}
