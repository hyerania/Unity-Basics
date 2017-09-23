﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Humanoid {
    private int poisonDamage = 3;

	// Use this for initialization
	public override void Move() {
        base.Move();
        transform.Translate(Vector3.left * 3 * Time.deltaTime);
    }
    public int AcidPuke() {
        return attackDamage + poisonDamage;
    }
}
