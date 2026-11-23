using System;
using System.Collections.Generic;
using Ouroboros.Common.Data;

// Token: 0x020000A5 RID: 165
public static class jw
{
	// Token: 0x060003BD RID: 957 RVA: 0x00011D64 File Offset: 0x0000FF64
	public static CollectionDelta<T> GetDelta<T>(ICollection<T> oldCollection, ICollection<T> newCollection)
	{
		czh.a(oldCollection, "oldCollection");
		czh.a(newCollection, "newCollection");
		List<T> list = new List<T>();
		List<T> list2 = new List<T>();
		foreach (T item in oldCollection)
		{
			if (!newCollection.Contains(item))
			{
				list.Add(item);
			}
		}
		foreach (T item2 in newCollection)
		{
			if (!oldCollection.Contains(item2))
			{
				list2.Add(item2);
			}
		}
		return new CollectionDelta<T>(newCollection, oldCollection, list2, list);
	}
}
