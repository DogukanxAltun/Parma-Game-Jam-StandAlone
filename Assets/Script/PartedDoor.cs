using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartedDoor : MonoBehaviour
{
    public Animator anim;
    public static PartedDoor instance;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        anim = GetComponent<Animator>();
        anim.SetBool("isBuilding", true);
    }

    public void Rebuild()
    {
       anim.SetBool("isBuilding", false);

    }
}
