using UnityEngine;

public class VectorInspectorOps : MonoBehaviour
{
  [Header("Configuración de Vectores")]
  public Vector3 vectorA = new Vector3(0.0f, 1.0f, 0.0f);
  public Vector3 vectorB = new Vector3(1.0f, 2.0f, 0.0f);

  [Header("Resultados (Solo lectura)")]
  public float magnitudeA;
  public float magnitudeB;
  public float angleBetween;
  public float distanceBetween;
  public string higherVector;

  void Start()
  {
    // a. Magnitudes
    magnitudeA = vectorA.magnitude;
    magnitudeB = vectorB.magnitude;
    Debug.Log($"Magnitud Vector A: {magnitudeA} | Magnitud Vector B: {magnitudeB}");

    // b. Ángulo entre ambos
    angleBetween = Vector3.Angle(vectorA, vectorB);
    Debug.Log($"Ángulo entre A y B: {angleBetween}°");

    // c. Distancia entre ambos
    distanceBetween = Vector3.Distance(vectorA, vectorB);
    Debug.Log($"Distancia entre A y B: {distanceBetween}");

    // d. Cuál está a mayor altura (eje Y)
    if (vectorA.y > vectorB.y)
    {
        higherVector = "El Vector A está a mayor altura.";
    }
    else if (vectorB.y > vectorA.y)
    {
        higherVector = "El Vector B está a mayor altura.";
    }
    else
    {
        higherVector = "Ambos vectores están a la misma altura.";
    }

    Debug.Log(higherVector);
  }
}