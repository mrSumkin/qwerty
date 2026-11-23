using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Ouroboros.Core.Logging;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x020005F1 RID: 1521
internal static class a5v
{
	// Token: 0x060027F1 RID: 10225 RVA: 0x000E71E0 File Offset: 0x000E53E0
	static a5v()
	{
		a5v.a(true);
	}

	// Token: 0x060027F2 RID: 10226 RVA: 0x000E71F4 File Offset: 0x000E53F4
	public static bad a(av A_0)
	{
		czh.a(A_0, "proxy");
		if (A_0.p() == null)
		{
			return null;
		}
		eu7 eu = A_0 as eu7;
		if (eu != null)
		{
			return new du(eu);
		}
		return null;
	}

	// Token: 0x060027F3 RID: 10227 RVA: 0x000E7230 File Offset: 0x000E5430
	public static lu a(SpellTargetType A_0, av A_1)
	{
		lu lu = null;
		ConstructorInfo constructorInfo;
		a5v.a.TryGetValue(A_0, out constructorInfo);
		if (constructorInfo != null)
		{
			lu = (constructorInfo.Invoke(new object[]
			{
				A_1
			}) as lu);
			if (lu == null)
			{
				dux.a(LogSeverity.CriticalError, rz.i, new object[]
				{
					A_0.ToString()
				});
			}
		}
		return lu;
	}

	// Token: 0x060027F4 RID: 10228 RVA: 0x000E7298 File Offset: 0x000E5498
	private static void a(bool A_0)
	{
		ei2 service = bpo.GetService<ei2>();
		a5v.a.Clear();
		if (service != null)
		{
			service.av2(new Func<Type, bool>(a5v.a.a.a));
			if (A_0)
			{
				service.avy(new EventHandler<EventArgs>(a5v.a));
			}
		}
	}

	// Token: 0x060027F5 RID: 10229 RVA: 0x000E72FC File Offset: 0x000E54FC
	private static void a(object A_0, EventArgs A_1)
	{
		a5v.a(false);
	}

	// Token: 0x060027F6 RID: 10230 RVA: 0x000E7304 File Offset: 0x000E5504
	private static bool a(Type A_0)
	{
		e7l e7l = Enumerable.FirstOrDefault<object>(A_0.GetCustomAttributes(typeof(e7l), false)) as e7l;
		if (e7l != null)
		{
			ConstructorInfo constructor = A_0.GetConstructor(new Type[]
			{
				typeof(av)
			});
			if (constructor != null)
			{
				a5v.a[e7l.a()] = constructor;
				return true;
			}
		}
		return false;
	}

	// Token: 0x0400164A RID: 5706
	private static Dictionary<SpellTargetType, ConstructorInfo> a = new Dictionary<SpellTargetType, ConstructorInfo>();

	// Token: 0x020005F2 RID: 1522
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x060027F9 RID: 10233 RVA: 0x000E7384 File Offset: 0x000E5584
		internal bool a(Type A_0)
		{
			return A_0.IsClass && !A_0.IsAbstract && typeof(lu).IsAssignableFrom(A_0) && a5v.a(A_0);
		}

		// Token: 0x0400164B RID: 5707
		public static readonly a5v.a a = new a5v.a();

		// Token: 0x0400164C RID: 5708
		public static Func<Type, bool> b;
	}
}
