using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x02001E63 RID: 7779
public static class dgk
{
	// Token: 0x0600AC5F RID: 44127 RVA: 0x003F9ABC File Offset: 0x003F7CBC
	public static IEnumerable<c3n> b()
	{
		dgk.a();
		return dgk.a.Values;
	}

	// Token: 0x0600AC61 RID: 44129 RVA: 0x003F9AD4 File Offset: 0x003F7CD4
	public static c3n c(Type A_0)
	{
		czh.a(A_0, "capabilityType");
		dgk.a();
		c3n c3n;
		dgk.a.TryGetValue(A_0.FullName, out c3n);
		if (c3n == null)
		{
			c3n = dgk.a(dgk.b(A_0));
			dgk.a[A_0.FullName] = c3n;
		}
		return c3n;
	}

	// Token: 0x0600AC62 RID: 44130 RVA: 0x003F9B28 File Offset: 0x003F7D28
	public static c3n a(string A_0)
	{
		dgk.a();
		if (string.IsNullOrEmpty(A_0))
		{
			return null;
		}
		c3n result;
		dgk.a.TryGetValue(A_0.ToLowerInvariant(), out result);
		return result;
	}

	// Token: 0x0600AC63 RID: 44131 RVA: 0x003F9B5C File Offset: 0x003F7D5C
	public static T Get<T>() where T : c3n
	{
		return dgk.c(typeof(T)) as T;
	}

	// Token: 0x0600AC64 RID: 44132 RVA: 0x003F9B7C File Offset: 0x003F7D7C
	public static string b(Type A_0)
	{
		ayj ayj = Enumerable.FirstOrDefault<object>(A_0.GetCustomAttributes(typeof(ayj), false)) as ayj;
		if (ayj != null && !string.IsNullOrWhiteSpace(ayj.a()))
		{
			return ayj.a().ToLowerInvariant();
		}
		return null;
	}

	// Token: 0x0600AC65 RID: 44133 RVA: 0x003F9BC8 File Offset: 0x003F7DC8
	public static string a(Type A_0)
	{
		if (A_0 != null)
		{
			c3n c3n = dgk.c(A_0);
			if (c3n != null)
			{
				string text = c3n.Name;
				string text2 = qv.b("AbilityNames/" + text);
				if (!string.IsNullOrEmpty(text2))
				{
					text = text2;
				}
				return text;
			}
		}
		return null;
	}

	// Token: 0x0600AC66 RID: 44134 RVA: 0x003F9C18 File Offset: 0x003F7E18
	private static void a()
	{
		if (!dgk.b)
		{
			dgk.b = true;
			ei2 serviceOrThrow = bpo.GetServiceOrThrow<ei2>();
			dgk.a = new Dictionary<string, c3n>();
			foreach (Type type in Enumerable.Where<Type>(serviceOrThrow.avx(), new Func<Type, bool>(dgk.a.a.a)))
			{
				ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
				if (constructor != null)
				{
					c3n value = constructor.Invoke(null) as c3n;
					dgk.a[dgk.b(type)] = value;
				}
			}
		}
	}

	// Token: 0x04004045 RID: 16453
	private static Dictionary<string, c3n> a;

	// Token: 0x04004046 RID: 16454
	private static bool b;

	// Token: 0x02001E64 RID: 7780
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x0600AC69 RID: 44137 RVA: 0x003F9CF8 File Offset: 0x003F7EF8
		internal bool a(Type A_0)
		{
			return A_0.IsClass && !A_0.IsAbstract && typeof(c3n).IsAssignableFrom(A_0);
		}

		// Token: 0x04004047 RID: 16455
		public static readonly dgk.a a = new dgk.a();

		// Token: 0x04004048 RID: 16456
		public static Func<Type, bool> b;
	}
}
