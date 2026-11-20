using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001412 RID: 5138
[bs6("HeartbreakPoisonExpiresAction")]
[eiz("HBPEAX")]
[Serializable]
public sealed class xr : bhv, ISerializable
{
	// Token: 0x06007359 RID: 29529 RVA: 0x00309E5C File Offset: 0x0030805C
	private xr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600735A RID: 29530 RVA: 0x00309E68 File Offset: 0x00308068
	public xr()
	{
	}

	// Token: 0x0600735B RID: 29531 RVA: 0x00309E70 File Offset: 0x00308070
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.x0().a() != null && !base.x0().a().Dead && base.x2() != null && base.x2().a8() != null)
		{
			ef5 ef = base.xy() as ef5;
			if (ef != null)
			{
				int a_ = cl5.a(ef.Power, ef.Stacks);
				cwt cwt = new cwt();
				cwt.i = new ap9("Poison", null);
				cwt.f.Add(new csk(DamageType.Bio, a_));
				cwt.l = true;
				cwt.p = true;
				cwt.r = true;
				cwt.b = true;
				cwt.w = true;
				cwt.ag = true;
				cwt.v = "остановка сердца";
				dtb dtb = new dtb();
				dtb.b(false);
				dtb.c(false);
				dtb.a(m7.k);
				dtb.ad().Add(new a4s(new bfq("xpbl_Heartbreaker"), null, new ar7(base.x2().a8()), null));
				dtb.ad().Add(new a7j(base.x2().a8(), "Остановка сердца", 1, double.MaxValue, true, true, null, null, null, null, false, null));
				dtb.ad().Add(new bm3(dz6.b(1000)));
				dtb.ad().Add(new akg(null, base.x2(), cwt, null, false));
				base.x2().a8().Zone.ActionManager.g9(dtb, atp.a);
				dz6.a(dtb);
			}
		}
		return dc4.c;
	}
}
