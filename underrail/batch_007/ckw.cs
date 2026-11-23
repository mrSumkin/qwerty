using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x02001143 RID: 4419
public static class ckw
{
	// Token: 0x06005EAD RID: 24237 RVA: 0x002811D0 File Offset: 0x0027F3D0
	private static void a()
	{
		ckw.a = new Dictionary<string, lh>();
		ei2 service = bpo.GetService<ei2>();
		if (service != null)
		{
			foreach (Type type in service.av2(new Func<Type, bool>(ckw.a.a.a)))
			{
				ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
				if (constructor != null)
				{
					lh lh = constructor.Invoke(null) as lh;
					if (lh != null)
					{
						ckw.a[lh.md()] = lh;
					}
				}
			}
		}
	}

	// Token: 0x06005EAE RID: 24238 RVA: 0x00281294 File Offset: 0x0027F494
	public static lh a(string A_0)
	{
		if (ckw.a == null)
		{
			ckw.a();
		}
		if (!string.IsNullOrEmpty(A_0))
		{
			lh result;
			ckw.a.TryGetValue(A_0, out result);
			return result;
		}
		return null;
	}

	// Token: 0x06005EAF RID: 24239 RVA: 0x002812CC File Offset: 0x0027F4CC
	public static lh a(c5x A_0)
	{
		if (A_0 != null && A_0.h.b != null)
		{
			string classPropertyValue = A_0.h.b.aa().CustomProperties.GetClassPropertyValue<string>(ddm.i);
			if (!string.IsNullOrEmpty(classPropertyValue))
			{
				return ckw.a(classPropertyValue);
			}
		}
		return null;
	}

	// Token: 0x04002599 RID: 9625
	private static Dictionary<string, lh> a;

	// Token: 0x02001144 RID: 4420
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06005EB2 RID: 24242 RVA: 0x00281338 File Offset: 0x0027F538
		internal bool a(Type A_0)
		{
			return A_0.IsClass && !A_0.IsAbstract && typeof(lh).IsAssignableFrom(A_0);
		}

		// Token: 0x0400259A RID: 9626
		public static readonly ckw.a a = new ckw.a();

		// Token: 0x0400259B RID: 9627
		public static Func<Type, bool> b;
	}
}
