using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020017BB RID: 6075
[bs6("TemporaryRewindExpiresAction")]
[eiz("TRWE")]
[Serializable]
public sealed class dms : bhv, ISerializable
{
	// Token: 0x060081BD RID: 33213 RVA: 0x00369D04 File Offset: 0x00367F04
	private dms(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060081BE RID: 33214 RVA: 0x00369D10 File Offset: 0x00367F10
	public dms()
	{
	}

	// Token: 0x060081BF RID: 33215 RVA: 0x00369D1C File Offset: 0x00367F1C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.x2() != null && base.x2().a8() != null && base.x2().a8().j == cgy.b && base.x2().a8().Zone != null)
		{
			qy qy = new qy();
			qy.b(false);
			qy.c(false);
			dk6 dk = base.xy() as dk6;
			if (dk != null)
			{
				bfq bfq = new bfq();
				bfq.b("xpbl_TemporalDistorsionHit" + Guid.NewGuid().ToString());
				bfq.c("xpbl_TemporalDistorsionHit");
				qy.ad().Add(new a4s(bfq, null, new ar7(base.x2().a8()), null));
				eym.a(qy, base.x2().a8(), (double)aju.bt);
				List<auv> list = qy.ad();
				c5x a_ = base.x2().a8();
				string a_2 = "Xpbl_TemporalDistorsionDamage";
				int a_3 = 1;
				double maxValue = double.MaxValue;
				bool a_4 = true;
				bool a_5 = true;
				float? a_6 = dz6.b();
				list.Add(new a7j(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false, null));
				qy.ad().Add(new bm3((int)(500f * dz6.b().GetValueOrDefault(1f))));
				cwt cwt = new cwt();
				cwt.i = null;
				cwt.j = new ap9(base.x2().aa());
				cwt.p = true;
				cwt.l = true;
				cwt.f.Add(new csk(DamageType.Mechanical, dk.a()));
				cwt.b = true;
				cwt.v = "повтор";
				cwt.w = true;
				qy.ad().Add(new akg(base.x2(), base.x2(), cwt, null, false));
			}
			base.x2().a8().Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			return dc4.c;
		}
		return dc4.e;
	}
}
