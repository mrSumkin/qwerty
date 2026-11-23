using System;
using Ouroboros.Core.Logging;

// Token: 0x02001456 RID: 5206
public static class cp
{
	// Token: 0x0600751F RID: 29983 RVA: 0x0031A380 File Offset: 0x00318580
	public static ad5 b(eu7 A_0, c5x A_1, object A_2)
	{
		ad5 ad = cp.a(A_0, A_1, A_2);
		if (ad != null)
		{
			A_1.i.b.a(ad, atp.a, true, false);
		}
		return ad;
	}

	// Token: 0x06007520 RID: 29984 RVA: 0x0031A3B4 File Offset: 0x003185B4
	public static ad5 a(eu7 A_0, c5x A_1, object A_2)
	{
		czh.a(A_0, "proxy");
		czh.a(A_1, "invoker");
		czh.a(A_2, "target");
		if (!cp.a(A_1))
		{
			return null;
		}
		ad5 result;
		if (A_0.p() is ce5)
		{
			result = new agc(A_0, A_1, A_2);
		}
		else if (A_0.p() is c0z)
		{
			result = new bu4(A_0, A_1, A_2, (A_0.p() as c0z).ar4());
		}
		else if (A_0.p() is bon)
		{
			result = new dl(A_0, A_1, A_2);
		}
		else if (A_0.p() is cxf)
		{
			result = new a62(A_0, A_1, A_2);
		}
		else if (A_0.p() is m0)
		{
			result = new e4y(A_0, A_1, A_2);
		}
		else if (A_0.p() is ami)
		{
			result = new b2s(A_0, A_1, A_2);
		}
		else
		{
			result = new bu4(A_0, A_1, A_2, false);
		}
		return result;
	}

	// Token: 0x06007521 RID: 29985 RVA: 0x0031A4C0 File Offset: 0x003186C0
	private static bool a(c5x A_0)
	{
		if (A_0.i == null)
		{
			dux.b(LogSeverity.Error, "Entity '{0}' cannot act as an invoker because it does not have the Action Entity aspect.", new object[]
			{
				A_0.ToString()
			});
			return false;
		}
		return true;
	}

	// Token: 0x06007522 RID: 29986 RVA: 0x0031A4EC File Offset: 0x003186EC
	public static aty a(bl6 A_0, c5x A_1, bool A_2 = false)
	{
		czh.a(A_0, "proxy");
		czh.a(A_1, "invoker");
		if (!cp.a(A_1))
		{
			return null;
		}
		aty aty = new aty(A_0, A_1);
		if (A_2 && A_1.Zone != null)
		{
			A_1.Zone.ActionManager.g9(aty, atp.a);
		}
		else
		{
			A_1.i.b.a(aty, atp.a, true, false);
		}
		return aty;
	}

	// Token: 0x06007523 RID: 29987 RVA: 0x0031A564 File Offset: 0x00318764
	public static void a(c5x A_0, av A_1)
	{
		czh.a(A_0, "invoker");
		czh.a(A_1, "proxy");
		v5 a_ = dz6.e() ? v5.a : v5.b;
		A_0.h.b.aa().Cooldowns.a(A_1.a(a_));
		A_0.h.b.aa().Cooldowns.a(A_1.b(a_));
	}
}
