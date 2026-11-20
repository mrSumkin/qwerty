using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x02001B5E RID: 7006
public static class d79
{
	// Token: 0x060097B4 RID: 38836 RVA: 0x003B2170 File Offset: 0x003B0370
	public static IEnumerable<cwp> b()
	{
		return d79.a.Values;
	}

	// Token: 0x060097B5 RID: 38837 RVA: 0x003B2180 File Offset: 0x003B0380
	static d79()
	{
		foreach (Type type in Enumerable.Where<Type>(typeof(cwp).Assembly.GetTypes(), new Func<Type, bool>(d79.a.a.a)))
		{
			ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
			if (constructor != null)
			{
				cwp value = constructor.Invoke(null) as cwp;
				d79.a[d79.a(type)] = value;
			}
		}
	}

	// Token: 0x060097B6 RID: 38838 RVA: 0x003B2234 File Offset: 0x003B0434
	public static cwp b(Type A_0)
	{
		if (A_0 == null)
		{
			return null;
		}
		return d79.a(d79.a(A_0));
	}

	// Token: 0x060097B7 RID: 38839 RVA: 0x003B2250 File Offset: 0x003B0450
	public static cwp a(string A_0)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			return null;
		}
		cwp result;
		d79.a.TryGetValue(A_0.ToLowerInvariant(), out result);
		return result;
	}

	// Token: 0x060097B8 RID: 38840 RVA: 0x003B2280 File Offset: 0x003B0480
	public static T Get<T>() where T : cwp
	{
		return d79.b(typeof(T)) as T;
	}

	// Token: 0x060097B9 RID: 38841 RVA: 0x003B22A0 File Offset: 0x003B04A0
	public static string a(Type A_0)
	{
		dgg dgg = Enumerable.FirstOrDefault<object>(A_0.GetCustomAttributes(typeof(dgg), false)) as dgg;
		if (dgg != null && !string.IsNullOrWhiteSpace(dgg.a()))
		{
			string text = dgg.a();
			return text.ToLowerInvariant();
		}
		return null;
	}

	// Token: 0x060097BA RID: 38842 RVA: 0x003B22F4 File Offset: 0x003B04F4
	public static List<cwp> a()
	{
		return Enumerable.ToList<cwp>(d79.a.Values);
	}

	// Token: 0x04003A4A RID: 14922
	private static Dictionary<string, cwp> a = new Dictionary<string, cwp>();

	// Token: 0x02001B5F RID: 7007
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x060097BD RID: 38845 RVA: 0x003B231C File Offset: 0x003B051C
		internal bool a(Type A_0)
		{
			return A_0.IsClass && !A_0.IsAbstract && typeof(cwp).IsAssignableFrom(A_0);
		}

		// Token: 0x04003A4B RID: 14923
		public static readonly d79.a a = new d79.a();
	}
}
