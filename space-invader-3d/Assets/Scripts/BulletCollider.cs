using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollider : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Enemy")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }else if (other.gameObject.name != "Player")
        {
            Destroy(gameObject);
        }
    }

}
