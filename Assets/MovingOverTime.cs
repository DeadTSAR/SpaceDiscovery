using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingOverTime : MonoBehaviour
{
    public Vector3 target;
    public float duration;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveTo(target, duration));
    }
    
    // Update is called once per frame
    void Update()
    {

        //DotProduct(a, b);
    }
    public IEnumerator MoveTo(Vector3 target, float duration)
    {
        Vector3 diff = (target - transform.position);

        float counter = 0;

        while (counter <= duration)
        {
            float step = (diff.magnitude * Time.deltaTime) / duration;
            transform.position += diff.normalized * step;
            counter += Time.deltaTime;
            yield return null;
        }
        transform.position = target;
    }

    public void DotProduct(Vector3 a, Vector3 b)
    {
        Debug.DrawLine(transform.position, transform.position + a);
        Debug.DrawLine(transform.position, transform.position + b);

        Vector3 ab = (a - b);

        float angle = (180 * Mathf.Acos(Vector3.Dot(a.normalized, ab.normalized))) / Mathf.PI;
        print("angle " + angle + "'");
    }
}
