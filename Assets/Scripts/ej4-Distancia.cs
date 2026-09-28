using UnityEngine;

public class DistanceTracker : MonoBehaviour
{
  void Start()
  {
    // Buscamos los objetos en la escena por su Tag o Nombre
    GameObject cubeObj = GameObject.FindWithTag("Cube");
    GameObject cylinderObj = GameObject.FindWithTag("Cylinder");

    // Si prefieres buscar directamente por el nombre del GameObject en la jerarquía:
    if (cubeObj == null) cubeObj = GameObject.Find("Cube");
    if (cylinderObj == null) cylinderObj = GameObject.Find("Cylinder");

    // Comprobamos que existan para evitar errores de referencia nula (NullReferenceException)
    if (cubeObj != null && cylinderObj != null)
    {
      float distanceToCube = Vector3.Distance(transform.position, cubeObj.transform.position);
      float distanceToCylinder = Vector3.Distance(transform.position, cylinderObj.transform.position);

      Debug.Log($"Distancia de la esfera al Cubo: {distanceToCube:F2} unidades");
      Debug.Log($"Distancia de la esfera al Cilindro: {distanceToCylinder:F2} unidades");
    }
    else
    {
      Debug.LogWarning("No se encontró el Cubo o el Cilindro en la escena. Comprueba sus nombres o etiquetas.");
    }
  }
}