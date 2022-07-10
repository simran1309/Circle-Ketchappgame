using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    public Animator anim;
    public GameManager manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        anim = GetComponent<Animator>();
        
    }
   public void Entry ()
    {
        anim.SetTrigger("entry");
    }
   public void Exit()
    {
        anim.SetTrigger("exit");
    }
}
