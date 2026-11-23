using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.Serialization;

// Token: 0x0200009B RID: 155
public static class di7
{
	// Token: 0x0600038B RID: 907 RVA: 0x0001066C File Offset: 0x0000E86C
	public static void WriteDictionary<TKey, TValue>(string dictionaryName, Dictionary<TKey, TValue> dictionary, SerializationInfo info)
	{
		if (dictionary != null)
		{
			info.AddValue(dictionaryName + ":Count", dictionary.Count);
			int num = 0;
			using (Dictionary<TKey, TValue>.Enumerator enumerator = dictionary.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<TKey, TValue> keyValuePair = enumerator.Current;
					info.AddValue(dictionaryName + ":" + num.ToString() + ":Key", keyValuePair.Key);
					info.AddValue(dictionaryName + ":" + num.ToString() + ":Value", keyValuePair.Value);
					num++;
				}
				return;
			}
		}
		info.AddValue(dictionaryName + ":Count", -1);
	}

	// Token: 0x0600038C RID: 908 RVA: 0x00010740 File Offset: 0x0000E940
	public static void WriteDataModelTypeKeyedDictionary<TValue>(string dictionaryName, Dictionary<Type, TValue> dictionary, SerializationInfo info)
	{
		if (dictionary != null)
		{
			info.AddValue(dictionaryName + ":C", dictionary.Count);
			int num = 0;
			using (Dictionary<Type, TValue>.Enumerator enumerator = dictionary.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<Type, TValue> keyValuePair = enumerator.Current;
					di7.a(dictionaryName + ":" + num.ToString() + ":K", keyValuePair.Key, info);
					info.AddValue(dictionaryName + ":" + num.ToString() + ":V", keyValuePair.Value);
					num++;
				}
				return;
			}
		}
		info.AddValue(dictionaryName + ":C", -1);
	}

	// Token: 0x0600038D RID: 909 RVA: 0x00010810 File Offset: 0x0000EA10
	public static void WriteDataModelTypeKeyedPairList<TValue>(string pairListName, List<KeyValuePair<Type, TValue>> pairList, SerializationInfo info)
	{
		if (pairList != null)
		{
			info.AddValue(pairListName + ":C", pairList.Count);
			int num = 0;
			using (List<KeyValuePair<Type, TValue>>.Enumerator enumerator = pairList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<Type, TValue> keyValuePair = enumerator.Current;
					di7.a(pairListName + ":" + num.ToString() + ":K", keyValuePair.Key, info);
					info.AddValue(pairListName + ":" + num.ToString() + ":V", keyValuePair.Value);
					num++;
				}
				return;
			}
		}
		info.AddValue(pairListName + ":C", -1);
	}

	// Token: 0x0600038E RID: 910 RVA: 0x000108E0 File Offset: 0x0000EAE0
	public static void WriteList<T>(string listName, List<T> list, SerializationInfo info)
	{
		if (list != null)
		{
			info.AddValue(listName + ":Count", list.Count);
			for (int i = 0; i < list.Count; i++)
			{
				info.AddValue(listName + ":" + i.ToString(), list[i]);
			}
			return;
		}
		info.AddValue(listName + ":Count", -1);
	}

	// Token: 0x0600038F RID: 911 RVA: 0x00010958 File Offset: 0x0000EB58
	public static void WriteCollection<T>(string listName, Collection<T> col, SerializationInfo info)
	{
		if (col != null)
		{
			info.AddValue(listName + ":Count", col.Count);
			for (int i = 0; i < col.Count; i++)
			{
				info.AddValue(listName + ":" + i.ToString(), col[i]);
			}
			return;
		}
		info.AddValue(listName + ":Count", -1);
	}

	// Token: 0x06000390 RID: 912 RVA: 0x000109D0 File Offset: 0x0000EBD0
	public static void WriteArray<T>(string arrayName, T[] array, SerializationInfo info)
	{
		if (array != null)
		{
			info.AddValue(arrayName + ":Length", array.Length);
			for (int i = 0; i < array.Length; i++)
			{
				info.AddValue(arrayName + ":" + i.ToString(), array[i]);
			}
			return;
		}
		info.AddValue(arrayName + ":Length", -1);
	}

	// Token: 0x06000391 RID: 913 RVA: 0x00010A40 File Offset: 0x0000EC40
	public static void WriteArray<T>(string arrayName, T[,] array, SerializationInfo info)
	{
		if (array != null)
		{
			int length = array.GetLength(0);
			int length2 = array.GetLength(1);
			info.AddValue(arrayName + ":LengthX", length);
			info.AddValue(arrayName + ":LengthY", length2);
			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < length2; j++)
				{
					info.AddValue(string.Concat(new object[]
					{
						arrayName,
						":",
						i,
						",",
						j
					}), array[i, j]);
				}
			}
			return;
		}
		info.AddValue(arrayName + ":LengthX", -1);
	}

	// Token: 0x06000392 RID: 914 RVA: 0x00010AFC File Offset: 0x0000ECFC
	public static void a(string A_0, Type A_1, SerializationInfo A_2)
	{
		string value;
		string value2;
		dds.a.av5(A_1, out value, out value2, false);
		A_2.AddValue(A_0, value);
		A_2.AddValue(A_0 + ":A", value2);
	}

	// Token: 0x06000393 RID: 915 RVA: 0x00010B34 File Offset: 0x0000ED34
	public static void WriteEvent<T>(string eventName, EventHandler<T> eventHandler, SerializationInfo info) where T : EventArgs
	{
		czh.a(eventName, "eventName");
		ch1 ch = null;
		if (eventHandler != null)
		{
			ch = new ch1();
			Delegate[] invocationList = eventHandler.GetInvocationList();
			for (int i = 0; i < invocationList.Length; i++)
			{
				b7v b7v = di7.a(invocationList[i]);
				if (b7v != null)
				{
					ch.a.Add(b7v);
				}
			}
		}
		info.AddValue(eventName, ch, typeof(ch1));
	}

	// Token: 0x06000394 RID: 916 RVA: 0x00010BA4 File Offset: 0x0000EDA4
	public static void ReadDictionary<TKey, TValue>(string dictionaryName, ref Dictionary<TKey, TValue> dictionary, SerializationInfo info)
	{
		int @int = info.GetInt32(dictionaryName + ":Count");
		if (@int != -1)
		{
			if (dictionary == null)
			{
				dictionary = new Dictionary<TKey, TValue>();
			}
			for (int i = 0; i < @int; i++)
			{
				TKey key = (TKey)((object)info.GetValue(dictionaryName + ":" + i.ToString() + ":Key", typeof(TKey)));
				object value = info.GetValue(dictionaryName + ":" + i.ToString() + ":Value", typeof(TValue));
				TValue value2;
				if (value is TValue)
				{
					value2 = (TValue)((object)value);
				}
				else
				{
					value2 = default(TValue);
				}
				dictionary.Add(key, value2);
			}
		}
	}

	// Token: 0x06000395 RID: 917 RVA: 0x00010C6C File Offset: 0x0000EE6C
	public static void ReadDataModelTypeKeyedDictionary<TValue>(string dictionaryName, ref Dictionary<Type, TValue> dictionary, SerializationInfo info)
	{
		int @int = info.GetInt32(dictionaryName + ":C");
		if (@int != -1)
		{
			if (dictionary == null)
			{
				dictionary = new Dictionary<Type, TValue>();
			}
			for (int i = 0; i < @int; i++)
			{
				Type key = di7.a(dictionaryName + ":" + i.ToString() + ":K", info);
				TValue value = (TValue)((object)info.GetValue(dictionaryName + ":" + i.ToString() + ":V", typeof(TValue)));
				dictionary.Add(key, value);
			}
		}
	}

	// Token: 0x06000396 RID: 918 RVA: 0x00010D04 File Offset: 0x0000EF04
	public static void ReadDataModelTypeKeyedPairList<TValue>(string pairListName, ref List<KeyValuePair<Type, TValue>> pairList, SerializationInfo info)
	{
		int @int = info.GetInt32(pairListName + ":C");
		if (@int != -1)
		{
			if (pairList == null)
			{
				pairList = new List<KeyValuePair<Type, TValue>>();
			}
			for (int i = 0; i < @int; i++)
			{
				Type key = di7.a(pairListName + ":" + i.ToString() + ":K", info);
				TValue value = (TValue)((object)info.GetValue(pairListName + ":" + i.ToString() + ":V", typeof(TValue)));
				pairList.Add(new KeyValuePair<Type, TValue>(key, value));
			}
		}
	}

	// Token: 0x06000397 RID: 919 RVA: 0x00010DA0 File Offset: 0x0000EFA0
	public static void ReadList<T>(string listName, ref List<T> list, SerializationInfo info)
	{
		int @int = info.GetInt32(listName + ":Count");
		if (@int != -1)
		{
			if (list == null)
			{
				list = new List<T>();
			}
			for (int i = 0; i < @int; i++)
			{
				object value = info.GetValue(listName + ":" + i.ToString(), typeof(T));
				T item;
				if (value is T)
				{
					item = (T)((object)value);
				}
				else
				{
					item = default(T);
				}
				list.Add(item);
			}
		}
	}

	// Token: 0x06000398 RID: 920 RVA: 0x00010E30 File Offset: 0x0000F030
	public static void ReadCollection<T>(string listName, ref Collection<T> col, SerializationInfo info)
	{
		int @int = info.GetInt32(listName + ":Count");
		if (@int != -1)
		{
			if (col == null)
			{
				col = new Collection<T>();
			}
			for (int i = 0; i < @int; i++)
			{
				object value = info.GetValue(listName + ":" + i.ToString(), typeof(T));
				T item;
				if (value is T)
				{
					item = (T)((object)value);
				}
				else
				{
					item = default(T);
				}
				col.Add(item);
			}
		}
	}

	// Token: 0x06000399 RID: 921 RVA: 0x00010EC0 File Offset: 0x0000F0C0
	public static void ReadArray<T>(string arrayName, ref T[] array, SerializationInfo info)
	{
		int @int = info.GetInt32(arrayName + ":Length");
		if (@int != -1)
		{
			if (array == null || array.Length != @int)
			{
				array = new T[@int];
			}
			for (int i = 0; i < @int; i++)
			{
				object value = info.GetValue(arrayName + ":" + i.ToString(), typeof(T));
				T t;
				if (value is T)
				{
					t = (T)((object)value);
				}
				else
				{
					t = default(T);
				}
				array[i] = t;
			}
		}
	}

	// Token: 0x0600039A RID: 922 RVA: 0x00010F5C File Offset: 0x0000F15C
	public static void ReadArray<T>(string arrayName, ref T[,] array, SerializationInfo info)
	{
		int @int = info.GetInt32(arrayName + ":LengthX");
		if (@int != -1)
		{
			int int2 = info.GetInt32(arrayName + ":LengthY");
			if (array == null || array.GetLength(0) != @int || array.GetLength(1) != int2)
			{
				array = new T[@int, int2];
			}
			for (int i = 0; i < @int; i++)
			{
				for (int j = 0; j < int2; j++)
				{
					object value = info.GetValue(string.Concat(new object[]
					{
						arrayName,
						":",
						i,
						",",
						j
					}), typeof(T));
					T t;
					if (value is T)
					{
						t = (T)((object)value);
					}
					else
					{
						t = default(T);
					}
					array[i, j] = t;
				}
			}
		}
	}

	// Token: 0x0600039B RID: 923 RVA: 0x00011054 File Offset: 0x0000F254
	public static Type a(string A_0, SerializationInfo A_1)
	{
		if (ell.b() >= 4)
		{
			return dds.a.av3(A_1.GetString(A_0), A_1.GetString(A_0 + ":A"), true);
		}
		return dds.a.av3(A_1.GetString(A_0), "X", true);
	}

	// Token: 0x0600039C RID: 924 RVA: 0x000110A8 File Offset: 0x0000F2A8
	public static void ReadEvent<T>(string eventName, ref EventHandler<T> eventHandler, SerializationInfo info) where T : EventArgs
	{
		ch1 ch = info.GetValue(eventName, typeof(ch1)) as ch1;
		if (ch != null && ch.a != null)
		{
			foreach (b7v a_ in ch.a)
			{
				Delegate @delegate = di7.a(a_);
				if (@delegate != null)
				{
					eventHandler = (Delegate.Combine(eventHandler, @delegate) as EventHandler<T>);
				}
			}
		}
	}

	// Token: 0x0600039D RID: 925 RVA: 0x0001113C File Offset: 0x0000F33C
	private static b7v a(Delegate A_0)
	{
		string text = dds.a.av6(A_0.Method);
		if (text != null)
		{
			return new b7v
			{
				c = A_0.GetType(),
				b = A_0.Target,
				a = text
			};
		}
		throw new SerializationException(string.Format("Failed to retrieve method element name for method '{0}' declared in type '{1}'.", A_0.Method, A_0.Method.DeclaringType));
	}

	// Token: 0x0600039E RID: 926 RVA: 0x000111A8 File Offset: 0x0000F3A8
	private static Delegate a(b7v A_0)
	{
		if (A_0.c == null)
		{
			throw new SerializationException("Delegate type not found.");
		}
		MethodInfo methodInfo = dds.a.av7(A_0.a);
		if (methodInfo == null)
		{
			throw new SerializationException("Data model method not found: " + A_0.a);
		}
		Delegate result;
		if (methodInfo.IsStatic)
		{
			result = Delegate.CreateDelegate(A_0.c, methodInfo);
		}
		else
		{
			if (A_0.b == null)
			{
				throw new SerializationException("Target not found for delegate. Method: " + A_0.a);
			}
			result = Delegate.CreateDelegate(A_0.c, A_0.b, methodInfo);
		}
		return result;
	}
}
