using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public const float X_SPEED = 75f;
    public const float X_NEW_POS_MIN = -50;
    public const float X_NEW_POS_MAX = 50;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = CrossPlatformInputManager.GetAxis("Horizontal");
        float xOffset = horizontal * Time.deltaTime * X_SPEED;
        float xNewPos = xOffset + transform.localPosition.x;
        transform.localPosition = new Vector3(Mathf.Clamp(xNewPos, X_NEW_POS_MIN, X_NEW_POS_MAX), transform.localPosition.y, transform.localPosition.z);

    }
}