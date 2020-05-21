using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnHit : MonoBehaviour
{
    void OnCollisionEnter(Collision Layer2)
    {
        Destroy(this.gameObject);
    }
}
