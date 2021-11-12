using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LilyCheck : MonoBehaviour
{

    [SerializeField]
    float moveAmount = .05f;
    Vector3 startPos;
    bool ready;
    [SerializeField]
    GameObject rock;
    [SerializeField]
    Transform rockPosition;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        if (ready)
        {
            rock.transform.position = Vector3.MoveTowards(rock.transform.position, rockPosition.position, .5f * Time.deltaTime);
        }
    }

    public void MoveUp()
    {
        if (transform.position.y < startPos.y + moveAmount)
        {
            transform.position += new Vector3(0, moveAmount, 0);
            ready = true;
        }
    }
}
