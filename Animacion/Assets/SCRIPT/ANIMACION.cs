using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANIMACION : MonoBehaviour {
    
    Animator anim;
	
	void Awake () {
        anim = GetComponent<Animator>();
	}
	
	
	void Update () {
        //caminar
        if (Input.GetKeyDown(KeyCode.Alpha1))
            anim.SetBool("isWalking", true);
        if (Input.GetKeyUp(KeyCode.Alpha1))
            anim.SetBool("isWalking", false);
        //correr
        if (Input.GetKeyDown(KeyCode.Alpha2))
            anim.SetBool("IsRunning", true);
        if (Input.GetKeyUp(KeyCode.Alpha2))
            anim.SetBool("IsRunning", false);
        //saltar
        if (Input.GetKeyDown(KeyCode.Alpha3))
            anim.SetBool("isJumping", true);
        if (Input.GetKeyUp(KeyCode.Alpha3))
            anim.SetBool("isJumping", false);
        //bola
        if (Input.GetKeyDown(KeyCode.Alpha4))
            anim.SetBool("isBolita", true);
        if (Input.GetKeyUp(KeyCode.Alpha4))
            anim.SetBool("isBolita", false);
    }
}
