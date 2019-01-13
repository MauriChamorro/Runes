﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{

    public IEnumerator Shake(float pDuration, float pMagnitude)
    {
        Vector3 originalPosition = transform.localPosition;

        float elapsed = 0.0f;

        while (elapsed < pDuration)
        {
            float x = Random.Range(-1f, 1f) * pMagnitude;
            float y = Random.Range(-1f, 1f) * pMagnitude;

            Debug.Log(x);
            print(y);

            transform.localPosition = new Vector3(x, y, originalPosition.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = originalPosition;
    }
}
