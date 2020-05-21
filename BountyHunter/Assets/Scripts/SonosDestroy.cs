using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonosDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        delete();
    }
    private IEnumerator delete()
    {
        yield return new WaitForSeconds(.5f);
        Destroy(this.gameObject);
    }
}
