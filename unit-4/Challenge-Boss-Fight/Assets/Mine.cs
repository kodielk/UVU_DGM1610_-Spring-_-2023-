using UnityEngine;
[CreateAssetMenu(fileName = "Mine")]
public class Mine : ScriptableObject
{
  public float mineDamage;

  public void UpdateValue(float num)
  {
    mineDamage += num;
  }
  
}
