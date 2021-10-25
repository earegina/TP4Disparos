using UnityEngine;

public class MunitionController : MonoBehaviour
{
    public float speedMunition = 10.0f;
    public float destroyBullet = 5.0f; 
    bool isForward = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isForward)
        {
            MoveBullet(Vector3.forward);
        }

        else
        {
            MoveBullet(Vector3.back);
        }

        if (transform.position.x < 0f && !isForward)
        {
            isForward = true;
        }

        if (transform.position.x > 3f && isForward)
        {
            isForward = false;
        }

        destroyBullet -= speedMunition * Time.deltaTime;

        if (destroyBullet <= 0)
        {
            Destroy(gameObject);
        }

        Debug.Log(destroyBullet);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key was pressed");
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
    private void MoveBullet(Vector3 direction)
    {
        transform.Translate(speedMunition * Time.deltaTime * direction);
    }


}
