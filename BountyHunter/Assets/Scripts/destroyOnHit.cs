using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnHit : MonoBehaviour
{
    void OnCollisionEnter(Collision Hitbox)
    {
        Destroy(this.gameObject);
    }
}
