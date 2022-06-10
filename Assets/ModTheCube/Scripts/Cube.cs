using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    float x;
    float y;
    float z;


    void Start()
    {
        transform.position =
            new Vector3(
                Random.Range(-1f, 2f),
                4f,
                Random.Range(-1f, 2f));

        transform.localScale = Vector3.one *
                Random.Range(.5f, 2f);

        Material material = Renderer.material;

        material.color =
            new Color(
                Random.Range(0f, 1f),
                Random.Range(0f, 1f),
                Random.Range(0f, 1f),
                0.4f);



        x = Random.Range(0, 360);
        y = Random.Range(0, 360);
        z = Random.Range(0, 360);

        //transform.rotation = Quaternion.Euler(
    }
    void Update()
    {
        transform.Rotate(
            new Vector3(x, y, z) * Time.deltaTime * Random.Range(.01f, 1.5f));
    }
}
