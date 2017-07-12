﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieInSeconds : MonoBehaviour
{
  [SerializeField]
  float timeTillDeath;

  void Start()
  {
    StartCoroutine(Suicide());
  }

  IEnumerator Suicide()
  {
    yield return new WaitForSeconds(timeTillDeath);
    Destroy(gameObject);
  }
}