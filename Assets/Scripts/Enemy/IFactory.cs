using UnityEngine;

public interface IFactory
{
   GameObject FactoryMethod(int tag, Transform location);
}