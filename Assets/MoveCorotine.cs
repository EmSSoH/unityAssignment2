﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCorotine : MonoBehaviour
{
    private float movementDuration = 2.0f;
    private float waitBeforeMoving = 2.0f;
    private bool hasArrived = false;


    private void Start()
    {
        
    }


    private void Update()
    {
        if (!hasArrived)
        {
            hasArrived = true;
            float randX = Random.Range(-15.0f, 15.0f);
            float randZ = Random.Range(-15.0f, 15.0f);

            Vector3 pos = new Vector3(transform.position.x + randX, transform.position.y, transform.position.z + randZ);

            StartCoroutine(MoveToPoint(pos));
        }
    }

    private IEnumerator MoveToPoint(Vector3 targetPos)
    {
        float timer = 0.0f;
        Vector3 startPos = transform.position;

        while (timer < movementDuration)
        {
            timer += Time.deltaTime;
            float t = timer / movementDuration;
            t = t * t * t * (t * (6f * t - 15f) + 10f);
            transform.position = Vector3.Lerp(startPos, targetPos, t);

            yield return null;
        }

        yield return new WaitForSeconds(waitBeforeMoving);
        hasArrived = false;
    }
}
