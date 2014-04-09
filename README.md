UnityDictionaryExtension
========================

Extension method for Dictionary&lt;string,object> for JSON parsed dictionaries. This offers an easy way to retreive objects within dictionaries within dictionaries.

Example Usage:
------------------

	Dictionary<string,object> dict1 = new Dictionary<string, object> ();
	Dictionary<string,object> dict2 = new Dictionary<string, object> ();
	Dictionary<string,object> dict3 = new Dictionary<string, object> ();
	Dictionary<string,object> dict4 = new Dictionary<string, object> ();
	Dictionary<string,object> dict5 = new Dictionary<string, object> ();
	string test = "Test";
	dict1.Add ("key1", dict2);
	dict2.Add ("key2", dict3);
	dict3.Add ("key3", dict4);
	dict4.Add ("key4", dict5);
	dict5.Add ("key5", test);
	Debug.Log ((string)dict1.GetElement ("key1", "key2", "key3", "key4", "key5"));
