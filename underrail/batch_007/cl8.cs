using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x0200139C RID: 5020
[bs6("HFX:spearGuard")]
[eiz("SGHFX2")]
[Serializable]
public sealed class cl8 : cpl, ISerializable
{
	// Token: 0x06007169 RID: 29033 RVA: 0x002F9B34 File Offset: 0x002F7D34
	private cl8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600716A RID: 29034 RVA: 0x002F9B40 File Offset: 0x002F7D40
	public cl8()
	{
	}

	// Token: 0x0600716B RID: 29035 RVA: 0x002F9B48 File Offset: 0x002F7D48
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.a() == null || base.b() == null || base.b().a8() == null || base.agu() == null || base.b() == null || base.b().aa() == null)
		{
			return dc4.e;
		}
		if (!base.agw().b || base.b().aa().Passive || base.agw().v == "spear throw")
		{
			return dc4.c;
		}
		int a_ = euf.a(base.a().aa(), base.agu().Power, 1.0);
		cl8.a(base.a().aa(), a_);
		return dc4.c;
	}

	// Token: 0x0600716C RID: 29036 RVA: 0x002F9C1C File Offset: 0x002F7E1C
	public static void a(efk A_0, int A_1)
	{
		if (A_0 != null)
		{
			ar3 ar = new ar3(d0u.b * 2, euf.c(A_0), A_1);
			ar3 ar2 = Enumerable.FirstOrDefault<ar3>(A_0.StatusEffects.Get<ar3>());
			if (ar2 != null && ar2.Power > ar.Power)
			{
				if (ar2.TimeLeft > (double)d0u.b)
				{
					return;
				}
				A_0.StatusEffects.d(ar2);
			}
			A_0.StatusEffects.a(ar, false, false, false);
		}
	}
}
