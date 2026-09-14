using UnityEngine;

public class bagShaking : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        public int bagShake = 0;
        public bool isShaking = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.A) ||
            Input.GetKey(KeyCode.D))
        {
            bagShake += 1;
        }

        if (bagShake % 2 == 1)
        {
            isShaking = true;
        }
        else
        {
            isShaking = false;
        }
    }
}
