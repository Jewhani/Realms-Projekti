using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed;
    
    void Start()
    {
        
    }

           //T�ss� vaan mei�n tyhj� peliobjekti liikkuu oikealle.
           //T�ytyy menn� yht� nopeasti kuin pelaaja muuten kusee homma :D
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
        
        
    }
}
