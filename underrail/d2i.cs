using System;
using System.Runtime.CompilerServices;

// Token: 0x02001A4A RID: 6730
internal static class d2i
{
	// Token: 0x0600920F RID: 37391 RVA: 0x0039E704 File Offset: 0x0039C904
	public static Type[] a()
	{
		if (d2i.a == null)
		{
			object obj = d2i.b;
			lock (obj)
			{
				if (d2i.a == null)
				{
					d2i.a = az6.a(typeof(d3e).Assembly, new Func<Type, bool>(d2i.a.a.a)).ToArray();
				}
			}
		}
		return d2i.a;
	}

	// Token: 0x04003842 RID: 14402
	private static volatile Type[] a;

	// Token: 0x04003843 RID: 14403
	private static object b = new object();

	// Token: 0x02001A4B RID: 6731
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06009213 RID: 37395 RVA: 0x0039E7C4 File Offset: 0x0039C9C4
		internal bool a(Type A_0)
		{
			return typeof(d3e).IsAssignableFrom(A_0);
		}

		// Token: 0x04003844 RID: 14404
		public static readonly d2i.a a = new d2i.a();

		// Token: 0x04003845 RID: 14405
		public static Func<Type, bool> b;
	}
}
