using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

// Token: 0x02000095 RID: 149
public static class az6
{
	// Token: 0x0600037E RID: 894 RVA: 0x0001014C File Offset: 0x0000E34C
	public static List<Type> a(Assembly A_0, Func<Type, bool> A_1)
	{
		List<Type> list = new List<Type>();
		if (A_0 != null)
		{
			foreach (Type item in Enumerable.Where<Type>(A_0.GetTypes(), A_1))
			{
				list.Add(item);
			}
		}
		return list;
	}
}
