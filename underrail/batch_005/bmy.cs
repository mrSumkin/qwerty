using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;

// Token: 0x020015E3 RID: 5603
[eiz("EMPB")]
[Serializable]
public sealed class bmy : a6k, ISerializable
{
	// Token: 0x06007B83 RID: 31619 RVA: 0x0033A724 File Offset: 0x00338924
	private bmy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007B84 RID: 31620 RVA: 0x0033A730 File Offset: 0x00338930
	public bmy()
	{
	}

	// Token: 0x06007B85 RID: 31621 RVA: 0x0033A738 File Offset: 0x00338938
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		ak1 ak = base.vg().h() as ak1;
		if (ak == null || ak.Area == null)
		{
			return dc4.e;
		}
		base.vg().i();
		double a_ = aw1.a(base.vg().q(), ak);
		int a_2 = euf.b(base.vg().e().b8(), base.vg().e().b8().Skills.Get<fd>().g(), a_, 0.0);
		ak1 ak2 = awq.a(this, ak, a_2, false);
		qy qy = new qy();
		qy.b(false);
		qy.c(false);
		b0b b0b = null;
		dvv item = es2.a(base.vg().q(), ak2.Location.a() + new Vector3(0.5f, 0.5f, 0f), "EmpBall", out b0b, null, null, true, 0.5f, null);
		base.vg().q().c().a("LaunchElectrobolt");
		if (b0b != null && b0b.Zone != null)
		{
			qy.ad().Add(item);
			c7 c = new c7(b0b, false, false, true, false);
			c.a(true);
			qy.ad().Add(c);
			c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak2.Entities, new Func<b0b, bool>(bmy.a.a.a))) as c5x;
			if (c5x != null)
			{
				bfq bfq = new bfq();
				bfq.b("EmpBlast" + Guid.NewGuid().ToString());
				bfq.c(bby.a());
				bfq.a(bvl.c);
				qy.ad().Add(new a4s(bfq, null, new ar7(c5x), null));
				eym.a(qy, c5x, (double)aju.a2);
			}
			qy.ad().Add(new au0(ak2.Area, ak2.Location.a(), "EmpBlast", 1, double.MaxValue, null, null, null));
			ak1 a_3 = ak2;
			dug dug = new dug();
			dug.ty("electromagnetic burst");
			dug.e(base.vg().e());
			dug.g(new EntityAspectReference<amc, amc>(base.vg().q().h.b));
			awb awb = new awb(a_3, dug, bby.c(), (float)base.vg().e().g(), null);
			awb.r = true;
			awb.b((double)bby.b());
			qy.ad().Add(awb);
			b0b.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			eym.a(base.vg().q(), (double)aju.bf);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x020015E4 RID: 5604
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007B88 RID: 31624 RVA: 0x0033AA68 File Offset: 0x00338C68
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x04003123 RID: 12579
		public static readonly bmy.a a = new bmy.a();

		// Token: 0x04003124 RID: 12580
		public static Func<b0b, bool> b;
	}
}
