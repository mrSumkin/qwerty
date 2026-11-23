using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x02001E1C RID: 7708
public static class ck
{
	// Token: 0x0600AAC2 RID: 43714 RVA: 0x003F49E4 File Offset: 0x003F2BE4
	public static IEnumerable<ai8> b()
	{
		return new HashSet<ai8>(ck.a.Values);
	}

	// Token: 0x0600AAC3 RID: 43715 RVA: 0x003F49F8 File Offset: 0x003F2BF8
	static ck()
	{
		ck.a();
	}

	// Token: 0x0600AAC4 RID: 43716 RVA: 0x003F4A0C File Offset: 0x003F2C0C
	public static ai8 GetFeat<T>() where T : ai8
	{
		return ck.b(typeof(T));
	}

	// Token: 0x0600AAC5 RID: 43717 RVA: 0x003F4A20 File Offset: 0x003F2C20
	public static ai8 b(Type A_0)
	{
		czh.a(A_0, "featType");
		return ck.a(ck.a(A_0));
	}

	// Token: 0x0600AAC6 RID: 43718 RVA: 0x003F4A38 File Offset: 0x003F2C38
	public static ai8 a(string A_0)
	{
		if (A_0 != null)
		{
			ai8 result;
			ck.a.TryGetValue(A_0.ToLowerInvariant(), out result);
			return result;
		}
		return null;
	}

	// Token: 0x0600AAC7 RID: 43719 RVA: 0x003F4A64 File Offset: 0x003F2C64
	public static List<T> GetFeats<T>() where T : ai8
	{
		return Enumerable.ToList<T>(Enumerable.OfType<T>(ck.a.Values));
	}

	// Token: 0x0600AAC8 RID: 43720 RVA: 0x003F4A7C File Offset: 0x003F2C7C
	public static string a(Type A_0)
	{
		d29 d = Enumerable.FirstOrDefault<object>(A_0.GetCustomAttributes(typeof(d29), false)) as d29;
		string text;
		if (d != null && !string.IsNullOrWhiteSpace(d.b()))
		{
			text = d.b();
		}
		else
		{
			text = A_0.Name;
		}
		return text.ToLowerInvariant();
	}

	// Token: 0x0600AAC9 RID: 43721 RVA: 0x003F4AD4 File Offset: 0x003F2CD4
	private static void a()
	{
		foreach (Type type in Enumerable.Where<Type>(Assembly.GetExecutingAssembly().GetTypes(), new Func<Type, bool>(ck.a.a.a)))
		{
			ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
			if (constructor != null)
			{
				ai8 ai = constructor.Invoke(null) as ai8;
				if (ai != null)
				{
					ck.a[ck.a(type)] = ai;
				}
			}
		}
	}

	// Token: 0x04003FCA RID: 16330
	private static Dictionary<string, ai8> a = new Dictionary<string, ai8>();

	// Token: 0x02001E1D RID: 7709
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x0600AACC RID: 43724 RVA: 0x003F4BA0 File Offset: 0x003F2DA0
		internal bool a(Type A_0)
		{
			return typeof(ai8).IsAssignableFrom(A_0) && !A_0.IsAbstract;
		}

		// Token: 0x04003FCB RID: 16331
		public static readonly ck.a a = new ck.a();

		// Token: 0x04003FCC RID: 16332
		public static Func<Type, bool> b;
	}
}
