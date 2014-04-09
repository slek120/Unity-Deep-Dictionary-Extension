using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public static class DictionaryReader
{
	public static T[] SubArray<T> (this T[] data, int index)
	{
		return data.SubArray (index, data.Length - index);
	}
	
	public static T[] SubArray<T> (this T[] data, int index, int length)
	{
		T[] result = new T[length];
		Array.Copy (data, index, result, 0, length);
		return result;
	}
	
	public static object GetElement<T> (this Dictionary<T,object> dictionary, T key, params T[] keys)
	{
		if (dictionary == null) {
			Debug.LogWarning ("Dictionary is null");
			return null;
		}
		object result;
		if (keys.Length == 0) {
			if (dictionary.TryGetValue (key, out result)) {
				return result;
			} else {
				Debug.LogWarning ("The key (" + key + ") was not found");
				return null;
			}
		} else {
			if (dictionary.TryGetValue (key, out result)) {
				return GetElement ((Dictionary<T,object>)result, keys [0], keys.SubArray (1));
			} else {
				Debug.LogWarning ("The key (" + key + ") was not found");
				return null;
			}
		}
	}
}
