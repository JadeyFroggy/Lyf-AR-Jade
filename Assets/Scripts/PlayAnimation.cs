using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayAnimation : MonoBehaviour
{
    Animator anim;

    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            anim.SetBool("rocket", true);
            StartCoroutine(CatFly());
        }

    }

    /*
    public void PlayAnimationOnTarget()
    {
        Debug.Log("found target");
    }
    */

    IEnumerator CatFly()
    {
        yield return new WaitForSeconds(4f);
        anim.SetBool("catFly", true);
    }
}
