using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020015FB RID: 5627
[eiz("TB0")]
[Serializable]
public sealed class cov : a6k, ISerializable
{
	// Token: 0x06007BD0 RID: 31696 RVA: 0x0033E664 File Offset: 0x0033C864
	private cov(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetInt32("LPS0:F");
	}

	// Token: 0x06007BD1 RID: 31697 RVA: 0x0033E680 File Offset: 0x0033C880
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("LPS0:F", this.b);
	}

	// Token: 0x06007BD2 RID: 31698 RVA: 0x0033E69C File Offset: 0x0033C89C
	public cov()
	{
	}

	// Token: 0x06007BD3 RID: 31699 RVA: 0x0033E6A4 File Offset: 0x0033C8A4
	protected override dc4 dt()
	{
		return base.dt();
	}

	// Token: 0x06007BD4 RID: 31700 RVA: 0x0033E6AC File Offset: 0x0033C8AC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		ak1 ak = base.vg().h() as ak1;
		if (ak == null || base.vg().q().h.b == null || base.vg().q().h.b.aa().Dead || base.vg().e().b8() == null)
		{
			return dc4.e;
		}
		f9 f = Enumerable.FirstOrDefault<f9>(base.vg().q().h.b.aa().StatusEffects.Get<f9>());
		if (f != null)
		{
			base.vg().q().h.b.aa().StatusEffects.d(f);
		}
		int num = this.b + 1;
		this.b = num;
		if (num == 4)
		{
			this.b = 0;
		}
		aw1.b(base.vg().q().h.b.a8(), ak, false);
		qy qy = new qy();
		qy.b(false);
		qy.c(false);
		b0b b0b = null;
		Vector3 vector = es2.a(base.vg().q(), 0.9f, true);
		Vector3 vector2 = ak.Location.a() + new Vector3((float)(-0.15000000596046448 + cuo.a.NextDouble() * 0.15000000596046448 * 2.0), (float)(-0.15000000596046448 + cuo.a.NextDouble() * 0.15000000596046448 * 2.0), (float)((double)(-0.15f + vector.Z) + cuo.a.NextDouble() * 0.15000000596046448 * 2.0));
		aig[] a_;
		if (this.b == 0)
		{
			a_ = new aig[]
			{
				new cov.a(base.vg().q().h.b)
			};
		}
		else
		{
			a_ = null;
		}
		dvv item = es2.a(vector, vector2, ak.Area, "pyroStream", a_, out b0b);
		if (b0b != null && b0b.Zone != null)
		{
			qy.ad().Add(item);
			c7 item2 = new c7(b0b, false, false, true, false);
			qy.ad().Add(item2);
			aud a_2 = ak.Area;
			Vector3 a_3 = vector2;
			string a_4 = "ExplosionSmall";
			int a_5 = 1;
			double maxValue = double.MaxValue;
			float? a_6 = dz6.b();
			au0 item3 = new au0(a_2, a_3, a_4, a_5, maxValue, null, null, a_6);
			qy.ad().Add(item3);
			if (this.b % 2 == 0)
			{
				base.vg().q().c().a("fireballLaunch" + Guid.NewGuid().ToString(), "FireballLaunch", 1f, c9z.a, false, false);
			}
			b0b.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x06007BD5 RID: 31701 RVA: 0x0033E9C0 File Offset: 0x0033CBC0
	protected override void agp()
	{
		u6.a(base.vg().q().h.b);
		u6.a(base.vg().q().h.b, false);
		base.agp();
	}

	// Token: 0x06007BD6 RID: 31702 RVA: 0x0033EA08 File Offset: 0x0033CC08
	protected override void j4()
	{
		u6.a(base.vg().q().h.b);
		u6.a(base.vg().q().h.b, false);
		base.j4();
	}

	// Token: 0x04003134 RID: 12596
	private new const float a = 0.15f;

	// Token: 0x04003135 RID: 12597
	private int b;

	// Token: 0x020015FC RID: 5628
	[eiz("TB0b")]
	[Serializable]
	private new sealed class a : aig, ISerializable, enp
	{
		// Token: 0x06007BD7 RID: 31703 RVA: 0x0033EA50 File Offset: 0x0033CC50
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.b = (a1q)A_0.GetValue("LPS0b:B", typeof(a1q));
			this.c = (A_0.GetValue("LPS0b:A", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
			this.d = (A_0.GetValue("LPS0b:T", typeof(HashSet<Point>)) as HashSet<Point>);
			this.e = (A_0.GetValue("LPS0b:E", typeof(HashSet<Guid>)) as HashSet<Guid>);
		}

		// Token: 0x06007BD8 RID: 31704 RVA: 0x0033EAFC File Offset: 0x0033CCFC
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("LPS0b:B", this.b);
			info.AddValue("LPS0b:A", this.c);
			info.AddValue("LPS0b:T", this.d);
			info.AddValue("LPS0b:E", this.e);
		}

		// Token: 0x06007BD9 RID: 31705 RVA: 0x0033EB54 File Offset: 0x0033CD54
		public a(amc A_0)
		{
			this.b = dw7.a(new eoj(A_0.aa(), null, null));
			this.c = new EntityAspectReference<amc, amc>(A_0);
		}

		// Token: 0x06007BDA RID: 31706 RVA: 0x0033EBA4 File Offset: 0x0033CDA4
		public bool hj(b0b A_0, Vector3 A_1, Vector3 A_2, float A_3)
		{
			if (this.c.ao() != null && A_0 != null && A_0.Area != null)
			{
				Point point = A_0.aj().a();
				if (!this.d.Contains(point))
				{
					ak1 ak = A_0.Area.a(point);
					if (ak != null)
					{
						foreach (b0b b0b in ak.c.Values)
						{
							c5x c5x = (c5x)b0b;
							if (c5x.h.b != null && !this.e.Contains(c5x.qe()))
							{
								if (c5x.h.b != this.c.ao())
								{
									dtb dtb = new dtb();
									dtb.b(false);
									dtb.c(false);
									List<auv> list = dtb.ad();
									c5x a_ = c5x;
									string a_2 = "ExplosionSmall";
									int a_3 = 1;
									double maxValue = double.MaxValue;
									bool a_4 = true;
									bool a_5 = true;
									float? a_6 = dz6.b();
									list.Add(new a7j(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false, null));
									dtb.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "Flare"), null, new ar7(c5x), null));
									dtb.ad().Add(new akg(this.c.ao(), c5x.h.b, this.a(c5x.h.b), this, false));
									awq.a(dtb, this.c.ao().a8(), c5x, true, true);
									dtb.ad().Add(new eu8(this.c.ao().a8(), d8o.g, ak, 5, d0u.b * 2, null));
									c5x.Zone.ActionManager.g9(dtb, atp.a);
									dz6.a(dtb);
								}
								this.e.Add(c5x.qe());
							}
						}
					}
					this.d.Add(point);
				}
			}
			return false;
		}

		// Token: 0x06007BDB RID: 31707 RVA: 0x0033EE00 File Offset: 0x0033D000
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			bhd.a(A_0, A_1, A_3.a, dw7.f, 1.0, 3);
		}

		// Token: 0x06007BDC RID: 31708 RVA: 0x0033EE20 File Offset: 0x0033D020
		private cwt a(amc A_0)
		{
			cwt cwt = new cwt();
			cwt.b = true;
			cwt.f.Add(euf.a(this.b, 1.0));
			cwt.k = "Огнемёт";
			cwt.h = ImpactSpeed.VeryHigh;
			cwt.ad["PsionicSource"] = PsiSchool.Metathermics;
			if (this.c.ao() != null)
			{
				cwt.i = new ap9(this.c.ao().aa());
			}
			cwt.j = new ap9(A_0.aa());
			return cwt;
		}

		// Token: 0x04003136 RID: 12598
		private const float a = 1.5f;

		// Token: 0x04003137 RID: 12599
		private a1q b;

		// Token: 0x04003138 RID: 12600
		private EntityAspectReference<amc, amc> c;

		// Token: 0x04003139 RID: 12601
		private HashSet<Point> d = new HashSet<Point>();

		// Token: 0x0400313A RID: 12602
		private HashSet<Guid> e = new HashSet<Guid>();
	}
}
