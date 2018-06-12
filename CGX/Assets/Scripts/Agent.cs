﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Prime31;

public class Agent : MonoBehaviour {

	 [SerializeField]
    protected float health;

    [SerializeField]
    protected float moveSpeed;


	protected CharacterController2D _controller;
    protected Animator _animator;


	#region Event Listeners

    void onControllerCollider(RaycastHit2D hit)
    {
        // bail out on plain old ground hits cause they arent very interesting
        if (hit.normal.y == 1f)
            return;

        // logs any collider hits if uncommented. it gets noisy so it is commented out for the demo
        //Debug.Log( "flags: " + _controller.collisionState + ", hit.normal: " + hit.normal );
    }


    void onTriggerEnterEvent(Collider2D col)
    {
        Debug.Log("onTriggerEnterEvent: " + col.gameObject.name);
    }


    void onTriggerExitEvent(Collider2D col)
    {
        Debug.Log("onTriggerExitEvent: " + col.gameObject.name);
    }

    #endregion

	void Awake()
    {
        _animator = GetComponent<Animator>();
        _controller = GetComponent<CharacterController2D>();

        // listen to some events for illustration purposes
        _controller.onControllerCollidedEvent += onControllerCollider;
        _controller.onTriggerEnterEvent += onTriggerEnterEvent;
        _controller.onTriggerExitEvent += onTriggerExitEvent;
    }


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


	}

	void KnockBack(){ //apply for up and back

	}

	void Damage(float damage){ //reduce health stat by X
		health -= damage;
	}

	void Root(){
		moveSpeed = 0;
	}

	void SlowDown(){ // slow down to a max of zero

	}

	void SpeedUp(){ //speed up to a max of?

	}




	
}