using UnityEngine;

public class RainbowCubeController : MonoBehaviour
{
    public float speed = 1.0f; // 色の変化速度
    public float rotationSpeed = 30.0f; // 回転速度
    private Material material;

    void Start()
    {
        // キューブのマテリアルを取得
        material = GetComponent<Renderer>().material;
    }

    void Update()
    {
        // 時間に基づいて虹色を計算
        float r = Mathf.Sin(Time.time * speed + 0.0f) * 0.5f + 0.5f;
        float g = Mathf.Sin(Time.time * speed + 2.0f) * 0.5f + 0.5f;
        float b = Mathf.Sin(Time.time * speed + 4.0f) * 0.5f + 0.5f;

        // マテリアルの色を更新
        material.color = new Color(r, g, b);

        // キューブを回転
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}