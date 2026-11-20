using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Common.Data;
using Ouroboros.Core.Logging;

// Token: 0x02000481 RID: 1153
public static class eph
{
	// Token: 0x06001DA4 RID: 7588 RVA: 0x000A422C File Offset: 0x000A242C
	static eph()
	{
		eph.a(true);
	}

	// Token: 0x06001DA5 RID: 7589 RVA: 0x000A4254 File Offset: 0x000A2454
	public static el7 a(string A_0, object A_1)
	{
		if (A_0 == null)
		{
			return null;
		}
		Type type;
		eph.b.TryGetValue(A_0.ToLowerInvariant(), out type);
		if (type != null)
		{
			try
			{
				el7 el = Activator.CreateInstance(type, new object[]
				{
					A_1
				}) as el7;
				if (el == null)
				{
					dux.b(LogSeverity.Error, "BehaviorManager - Created behavior '{0}' did not implement IBehavior interface.", new object[]
					{
						type.FullName
					});
				}
				return el;
			}
			catch (Exception ex)
			{
				dux.b(LogSeverity.Error, "BehaviorManager - Failed to create an instance of behavior of type: {0}. Exception: {1}.", new object[]
				{
					type.FullName,
					ex.ToString()
				});
				return null;
			}
		}
		dux.b(LogSeverity.Error, "BehaviorManager - Failed to retrieve behavior type: '{0}'", new object[]
		{
			A_0
		});
		return null;
	}

	// Token: 0x06001DA6 RID: 7590 RVA: 0x000A4318 File Offset: 0x000A2518
	public static ot a(string A_0)
	{
		if (A_0 == null)
		{
			return null;
		}
		Type type;
		eph.a.TryGetValue(A_0.ToLowerInvariant(), out type);
		if (type != null)
		{
			try
			{
				ot ot = Activator.CreateInstance(type) as ot;
				if (ot == null)
				{
					dux.b(LogSeverity.Error, "BehaviorManager - Created scanner '{0}' did not implement IScanner interface.", new object[]
					{
						type.FullName
					});
				}
				return ot;
			}
			catch (Exception ex)
			{
				dux.b(LogSeverity.Error, "BehaviorManager - Failed to create an instance of scanner of type: {0}. Exception: {1}.", new object[]
				{
					type.FullName,
					ex.ToString()
				});
				return null;
			}
		}
		dux.b(LogSeverity.Error, "BehaviorManager - Failed to retrieve scanner type: '{0}'", new object[]
		{
			A_0
		});
		return null;
	}

	// Token: 0x06001DA7 RID: 7591 RVA: 0x000A43D4 File Offset: 0x000A25D4
	public static ckn a(string A_0, PropertyCollection A_1 = null)
	{
		if (A_0 == null)
		{
			return null;
		}
		Type type;
		eph.c.TryGetValue(A_0.ToLowerInvariant(), out type);
		if (type != null)
		{
			try
			{
				ckn ckn = Activator.CreateInstance(type) as ckn;
				if (ckn == null)
				{
					dux.b(LogSeverity.Error, "BehaviorManager - Created tactic '{0}' did not implement ITactic interface.", new object[]
					{
						type.FullName
					});
				}
				if (ckn != null && A_1 != null)
				{
					A_1.WriteToObject(ckn, false);
				}
				return ckn;
			}
			catch (Exception ex)
			{
				dux.b(LogSeverity.Error, "BehaviorManager - Failed to create an instance of tactic of type: {0}. Exception: {1}.", new object[]
				{
					type.FullName,
					ex.ToString()
				});
				return null;
			}
		}
		dux.b(LogSeverity.Error, "BehaviorManager - Failed to retrieve tactic type: '{0}'", new object[]
		{
			A_0
		});
		return null;
	}

	// Token: 0x06001DA8 RID: 7592 RVA: 0x000A44A4 File Offset: 0x000A26A4
	private static void a(bool A_0)
	{
		ei2 serviceOrThrow = bpo.GetServiceOrThrow<ei2>();
		eph.a.Clear();
		eph.b.Clear();
		eph.c.Clear();
		serviceOrThrow.av2(new Func<Type, bool>(eph.a.a.a));
		if (A_0)
		{
			serviceOrThrow.avy(new EventHandler<EventArgs>(eph.a));
		}
	}

	// Token: 0x06001DA9 RID: 7593 RVA: 0x000A4518 File Offset: 0x000A2718
	private static void a(object A_0, EventArgs A_1)
	{
		eph.a(false);
	}

	// Token: 0x06001DAA RID: 7594 RVA: 0x000A4524 File Offset: 0x000A2724
	private static bool a(Type A_0)
	{
		if (typeof(ot).IsAssignableFrom(A_0))
		{
			ajo ajo = Enumerable.FirstOrDefault<object>(A_0.GetCustomAttributes(typeof(ajo), false)) as ajo;
			string text;
			if (ajo != null && !string.IsNullOrWhiteSpace(ajo.a()))
			{
				text = ajo.a();
			}
			else
			{
				text = A_0.Name;
			}
			eph.a[text.ToLowerInvariant()] = A_0;
			return true;
		}
		if (typeof(el7).IsAssignableFrom(A_0))
		{
			fe fe = Enumerable.FirstOrDefault<object>(A_0.GetCustomAttributes(typeof(fe), false)) as fe;
			string text2;
			if (fe != null && !string.IsNullOrWhiteSpace(fe.a()))
			{
				text2 = fe.a();
			}
			else
			{
				text2 = A_0.Name;
			}
			eph.b[text2.ToLowerInvariant()] = A_0;
			return true;
		}
		if (typeof(ckn).IsAssignableFrom(A_0))
		{
			foreach (apc apc in Enumerable.OfType<apc>(A_0.GetCustomAttributes(typeof(apc), false)))
			{
				eph.c[apc.Name.ToLowerInvariant()] = A_0;
			}
			return true;
		}
		return false;
	}

	// Token: 0x040010B9 RID: 4281
	private static Dictionary<string, Type> a = new Dictionary<string, Type>();

	// Token: 0x040010BA RID: 4282
	private static Dictionary<string, Type> b = new Dictionary<string, Type>();

	// Token: 0x040010BB RID: 4283
	private static Dictionary<string, Type> c = new Dictionary<string, Type>();

	// Token: 0x02000482 RID: 1154
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06001DAD RID: 7597 RVA: 0x000A46A8 File Offset: 0x000A28A8
		internal bool a(Type A_0)
		{
			return A_0.IsClass && !A_0.IsAbstract && eph.a(A_0);
		}

		// Token: 0x040010BC RID: 4284
		public static readonly eph.a a = new eph.a();

		// Token: 0x040010BD RID: 4285
		public static Func<Type, bool> b;
	}
}
