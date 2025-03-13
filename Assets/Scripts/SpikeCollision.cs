using UnityEngine;

public class SpikeCollision : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Koodi missä piikit huomaa jos "Player" tagi oleva objecti osuu niihin nii "Player" tuhoutuu.
        //Player prefabissa unityssa täytyy olla Tagi "Player"
        if (collision.gameObject.CompareTag("Player"))
        {

            Destroy(collision.gameObject);

            
        }
    }
}
