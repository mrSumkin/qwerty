using System;
using System.Collections.Generic;

// Token: 0x020000CD RID: 205
public static class gm
{
	// Token: 0x06000484 RID: 1156 RVA: 0x000147A0 File Offset: 0x000129A0
	public static T MoveToBeginning<T>(this IList<T> list, T item)
	{
		czh.a(list, "list");
		czh.a(item, "item");
		if (!list.Contains(item))
		{
			throw new ArgumentException("The list does not contain the provided item.");
		}
		list.Remove(item);
		list.Insert(0, item);
		return item;
	}

	// Token: 0x06000485 RID: 1157 RVA: 0x000147F0 File Offset: 0x000129F0
	public static T MoveToEnd<T>(this IList<T> list, T item)
	{
		czh.a(list, "list");
		czh.a(item, "item");
		if (!list.Contains(item))
		{
			throw new ArgumentException("The list does not contain the provided item.");
		}
		list.Remove(item);
		list.Add(item);
		return item;
	}
}
