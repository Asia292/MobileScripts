using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public static InventoryController Instance { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        if (Instance != null && Instance != this)
            Destroy(gameObject);
        else
            Instance = this;
    }

    ////////https://www.youtube.com/watch?v=S5fRFS9lNpc&list=PLivfKP2ufIK6ToVMtpc_KTHlJRZjuE1z0&index=10 ////////////

}
