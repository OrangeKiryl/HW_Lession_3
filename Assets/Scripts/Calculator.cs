using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
  public float NumberFirstSum;
  public float NumberSecondSum;
  public float NumberFirstDif;
  public float NumberSecondDif;
  public float NumberFirstMul;
  public float NumberSecondMul;
  public float NumberFirstDiv;
  public float NumberSecondDiv;
  public float ResultSum;
  public float ResultDif;
  public float ResultMul;
  public float ResultDiv;

  public float NumberFirst;
  public float NumberSecond;
  public float Result;
  public string TextError;
  public OperationSigns Operation;

  void Start()
  {
    Summa();
    Difference();
    Multiplication();
    Division();

    RealizationOperation();
  }

  private void Summa()
  {
    ResultSum = NumberFirstSum + NumberSecondSum;
    Debug.Log(ResultSum);
  }

  private void Difference()
  {
    ResultDif = NumberFirstDif - NumberSecondDif;
    Debug.Log(ResultDif);
  }

  private void Multiplication()
  {
    ResultMul = NumberFirstMul * NumberSecondMul;
    Debug.Log(ResultMul);
  }

  private void Division()
  {
    if (NumberSecondDiv != 0)
    {
      ResultDiv = NumberFirstDiv / NumberSecondDiv;
      Debug.Log(ResultDiv);
    }
    else
      Debug.Log("Division by zero is impossible");
  }

  private void RealizationOperation()
  {
    TextError = null;
    switch (Operation)
    {
      case OperationSigns.Sum:
        Result = NumberFirst + NumberSecond;
        break;
      case OperationSigns.Dif:
        Result = NumberFirst - NumberSecond;
        break;
      case OperationSigns.Mul:
        Result = NumberFirstMul * NumberSecondMul;
        break;
      case OperationSigns.Div:
        if (NumberSecond != 0)
          Result = NumberFirstDiv / NumberSecondDiv;
        else
          TextError = "Division by zero is impossible";
        break;
    }
    if (string.IsNullOrEmpty(TextError))
      Debug.Log(Result);
    else
      Debug.Log(TextError);

  }
}

public enum OperationSigns
{
  Sum,
  Dif,
  Mul,
  Div
}