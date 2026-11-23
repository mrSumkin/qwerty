using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x02000556 RID: 1366
public static class es6
{
	// Token: 0x060022FD RID: 8957 RVA: 0x000C0628 File Offset: 0x000BE828
	public static void a(cnk A_0, double A_1)
	{
		es6.a();
		for (int i = 0; i < es6.a.Count; i++)
		{
			cm9 cm = es6.a[i];
			double num = es6.b[i] + A_1;
			while (num >= cm.ot())
			{
				num -= cm.ot();
				cm.ou(A_0);
			}
			es6.b[i] = num;
		}
	}

	// Token: 0x060022FE RID: 8958 RVA: 0x000C0698 File Offset: 0x000BE898
	private static void a()
	{
		if (es6.c)
		{
			return;
		}
		es6.a = new List<cm9>();
		es6.b = new List<double>();
		ei2 service = bpo.GetService<ei2>();
		if (service != null)
		{
			es6.c = true;
			foreach (Type type in service.av2(new Func<Type, bool>(es6.a.a.a)))
			{
				ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
				if (constructor != null)
				{
					cm9 cm = constructor.Invoke(null) as cm9;
					if (cm != null)
					{
						es6.a.Add(cm);
						es6.b.Add(0.0);
					}
				}
			}
		}
	}

	// Token: 0x04001495 RID: 5269
	private static List<cm9> a;

	// Token: 0x04001496 RID: 5270
	private static List<double> b;

	// Token: 0x04001497 RID: 5271
	private static bool c;

	// Token: 0x02000557 RID: 1367
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06002301 RID: 8961 RVA: 0x000C0798 File Offset: 0x000BE998
		internal bool a(Type A_0)
		{
			return A_0.IsClass && !A_0.IsAbstract && typeof(cm9).IsAssignableFrom(A_0);
		}

		// Token: 0x04001498 RID: 5272
		public static readonly es6.a a = new es6.a();

		// Token: 0x04001499 RID: 5273
		public static Func<Type, bool> b;
	}
}
