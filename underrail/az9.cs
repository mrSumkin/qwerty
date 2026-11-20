using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x02001A3A RID: 6714
public static class az9
{
	// Token: 0x0600918F RID: 37263 RVA: 0x0039D2E4 File Offset: 0x0039B4E4
	public static IEnumerable<buu> a()
	{
		return az9.a.Values;
	}

	// Token: 0x06009190 RID: 37264 RVA: 0x0039D2F4 File Offset: 0x0039B4F4
	static az9()
	{
		foreach (Type type in Enumerable.Where<Type>(typeof(buu).Assembly.GetTypes(), new Func<Type, bool>(az9.a.a.a)))
		{
			ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
			if (constructor != null)
			{
				buu value = constructor.Invoke(null) as buu;
				az9.a[az9.a(type)] = value;
			}
		}
	}

	// Token: 0x06009191 RID: 37265 RVA: 0x0039D3A8 File Offset: 0x0039B5A8
	public static buu a(string A_0)
	{
		if (!string.IsNullOrWhiteSpace(A_0))
		{
			buu result;
			az9.a.TryGetValue(A_0.ToLowerInvariant(), out result);
			return result;
		}
		return null;
	}

	// Token: 0x06009192 RID: 37266 RVA: 0x0039D3D8 File Offset: 0x0039B5D8
	private static string a(Type A_0)
	{
		dn2 dn = Enumerable.FirstOrDefault<object>(A_0.GetCustomAttributes(typeof(dn2), false)) as dn2;
		string text;
		if (dn != null && !string.IsNullOrWhiteSpace(dn.a()))
		{
			text = dn.a();
		}
		else
		{
			text = A_0.Name;
		}
		return text.ToLowerInvariant();
	}

	// Token: 0x0400382F RID: 14383
	private static Dictionary<string, buu> a = new Dictionary<string, buu>();

	// Token: 0x02001A3B RID: 6715
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06009195 RID: 37269 RVA: 0x0039D444 File Offset: 0x0039B644
		internal bool a(Type A_0)
		{
			return A_0.IsClass && !A_0.IsAbstract && typeof(buu).IsAssignableFrom(A_0);
		}

		// Token: 0x04003830 RID: 14384
		public static readonly az9.a a = new az9.a();
	}
}
