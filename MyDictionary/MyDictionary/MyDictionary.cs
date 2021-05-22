using System;

namespace MyDictPro
{
  class MyDictionary<TKey,TValue>
  {
    TValue[] _valueArray;
    TKey[] _keyArray;
   
    
    public MyDictionary()
    {
      _keyArray = new TKey[0];
      _valueArray = new TValue[0];
      //dictList = new T1[0];
    }

    public int Length()
    { return _keyArray.Length; }

    public void Add(TKey tKey,TValue tValue)
    {
      TKey[] _tempKey = _keyArray;
      _keyArray = new TKey[_keyArray.Length + 1];
      for (int i = 0; i < _tempKey.Length; i++)
      {
        _keyArray[i] = _tempKey[i];
      }
      _keyArray[_keyArray.Length-1] = tKey;

      TValue[] _tempValue = _valueArray;
      _valueArray = new TValue[_valueArray.Length + 1];
      for (int i = 0; i < _tempValue.Length; i++)
      {
        _valueArray[i] = _tempValue[i];
      }
      _valueArray[_valueArray.Length-1] = tValue;

    }
    public TValue this[TKey key]
    {
      get
      {
        return _valueArray[Array.IndexOf(_keyArray,key)];
      }
      set
      {
        _valueArray[Array.IndexOf(_keyArray, key)] = value;
      }
    }
  }
}
