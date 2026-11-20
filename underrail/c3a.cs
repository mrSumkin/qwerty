using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020016C7 RID: 5831
[eiz("TWSA")]
[Serializable]
public sealed class c3a : a6k, ISerializable
{
	// Token: 0x06007F0C RID: 32524 RVA: 0x0035BFAC File Offset: 0x0035A1AC
	private c3a(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F0D RID: 32525 RVA: 0x0035BFB8 File Offset: 0x0035A1B8
	public c3a()
	{
	}

	// Token: 0x06007F0E RID: 32526 RVA: 0x0035BFC0 File Offset: 0x0035A1C0
	protected override dc4 dt()
	{
		return base.dt();
	}

	// Token: 0x06007F0F RID: 32527 RVA: 0x0035BFC8 File Offset: 0x0035A1C8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (!base.vg().e().b8().SpecialAbilities.a(typeof(bmb)))
		{
			base.vg().e().b8().SpecialAbilities.b(dgk.Get<bmb>());
		}
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead)
		{
			return dc4.e;
		}
		qy qy = new qy();
		qy.b(false);
		qy.c(false);
		b0b b0b = null;
		dvv item = es2.a(base.vg().q(), c5x, "xpbl_Spear", 0.75f, null, out b0b, true, 0.5f);
		if (b0b == null || b0b.Zone == null)
		{
			return dc4.e;
		}
		bfq a_ = new bfq("xpbl_SpearThrow");
		qy.ad().Add(new a4s(a_, null, new ar7(base.vg().q()), null));
		qy.ad().Add(item);
		c7 item2 = new c7(b0b, false, false, true, false);
		qy.ad().Add(item2);
		cmn cmn = awq.b(base.vg().q().h.b, c5x.h.b, null);
		cmn.b += base.vg().e().b8().Offense.an();
		double num = aw1.b(base.vg().q(), c5x);
		bg3 bg = euf.a(base.vg().e().b8(), c5x.h.b.aa(), Math.Min(num, (double)base.vg().e().c(c5x)), c5x.l(), base.vg().e().b8().Darkvision, awq.f(base.vg().q().h.b), 1.0, c3u.a, 0.0);
		bool value = cuo.a.NextDouble() < bg.a;
		cwt cwt = euf.a(base.vg().e().b8(), c5x.h.b.aa(), cmn, 0.0, new bool?(value), 1.0, base.vg().e().b8().Offense.u(), true);
		cwt.v = "бросок копья";
		for (int i = 0; i < cwt.f.Count; i++)
		{
			csk csk = cwt.f[i];
			if (csk.DamageType == DamageType.Mechanical)
			{
				cwt.f[i] = new csk(DamageType.Mechanical, (int)((double)csk.Amount * xd.a(base.vg().e(), num)));
			}
		}
		dtb dtb = awq.a(base.vg().q().h.b, c5x.h.b, cwt, base.vg().e().b8().Offense.u(), null, true, true);
		qy.ad().AddRange(dtb.ad());
		ak1 ak = c5x.Area.a(c5x.aj().a());
		if (ak != null)
		{
			List<auv> list = qy.ad();
			lt lt = new lt();
			lt.a(ak.Location);
			lt.a(b0b.VisualDirection);
			list.Add(new a4s(lt, null, new ar7(base.vg().q()), null));
			b0b.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			return dc4.c;
		}
		return dc4.e;
	}
}
