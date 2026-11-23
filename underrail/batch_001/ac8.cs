using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x02001DD3 RID: 7635
public static class ac8
{
	// Token: 0x0600A8EC RID: 43244 RVA: 0x003EF148 File Offset: 0x003ED348
	public static IEnumerable<apq> b()
	{
		return ac8.a.Values;
	}

	// Token: 0x0600A8ED RID: 43245 RVA: 0x003EF154 File Offset: 0x003ED354
	static ac8()
	{
		ac8.a();
	}

	// Token: 0x0600A8EE RID: 43246 RVA: 0x003EF170 File Offset: 0x003ED370
	public static apq GetSpecialization<T>() where T : apq
	{
		return ac8.a(typeof(T));
	}

	// Token: 0x0600A8EF RID: 43247 RVA: 0x003EF184 File Offset: 0x003ED384
	public static apq a(string A_0)
	{
		if (A_0 != null)
		{
			apq result;
			ac8.a.TryGetValue(A_0, out result);
			return result;
		}
		return null;
	}

	// Token: 0x0600A8F0 RID: 43248 RVA: 0x003EF1A8 File Offset: 0x003ED3A8
	public static apq a(Type A_0)
	{
		if (A_0 != null)
		{
			apq result;
			ac8.b.TryGetValue(A_0, out result);
			return result;
		}
		return null;
	}

	// Token: 0x0600A8F1 RID: 43249 RVA: 0x003EF1D4 File Offset: 0x003ED3D4
	public static List<T> GetSpecializations<T>() where T : apq
	{
		return Enumerable.ToList<T>(Enumerable.OfType<T>(ac8.a.Values));
	}

	// Token: 0x0600A8F2 RID: 43250 RVA: 0x003EF1EC File Offset: 0x003ED3EC
	private static void a()
	{
		foreach (Type type in Enumerable.Where<Type>(Assembly.GetExecutingAssembly().GetTypes(), new Func<Type, bool>(ac8.a.a.a)))
		{
			ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
			if (constructor != null)
			{
				apq apq = constructor.Invoke(null) as apq;
				if (apq != null)
				{
					ac8.a[apq.e4()] = apq;
					ac8.b[type] = apq;
				}
			}
		}
	}

	// Token: 0x04003F29 RID: 16169
	private static Dictionary<string, apq> a = new Dictionary<string, apq>();

	// Token: 0x04003F2A RID: 16170
	private static Dictionary<Type, apq> b = new Dictionary<Type, apq>();

	// Token: 0x02001DD4 RID: 7636
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x0600A8F5 RID: 43253 RVA: 0x003EF2C4 File Offset: 0x003ED4C4
		internal bool a(Type A_0)
		{
			return typeof(apq).IsAssignableFrom(A_0) && !A_0.IsAbstract;
		}

		// Token: 0x04003F2B RID: 16171
		public static readonly ac8.a a = new ac8.a();

		// Token: 0x04003F2C RID: 16172
		public static Func<Type, bool> b;
	}
}
