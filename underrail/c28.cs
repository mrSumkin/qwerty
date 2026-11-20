using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001619 RID: 5657
[eiz("LPS0")]
[Serializable]
public sealed class c28 : a6k, ISerializable
{
	// Token: 0x06007C60 RID: 31840 RVA: 0x00345B60 File Offset: 0x00343D60
	private c28(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetInt32("LPS0:T");
		this.c = A_0.GetInt32("LPS0:F");
	}

	// Token: 0x06007C61 RID: 31841 RVA: 0x00345B8C File Offset: 0x00343D8C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("LPS0:T", this.b);
		info.AddValue("LPS0:F", this.c);
	}

	// Token: 0x06007C62 RID: 31842 RVA: 0x00345BB8 File Offset: 0x00343DB8
	public c28()
	{
	}

	// Token: 0x06007C63 RID: 31843 RVA: 0x00345BC0 File Offset: 0x00343DC0
	protected override dc4 dt()
	{
		return base.dt();
	}

	// Token: 0x06007C64 RID: 31844 RVA: 0x00345BCC File Offset: 0x00343DCC
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
		int num = this.c + 1;
		this.c = num;
		if (num == 4)
		{
			if (this.b >= 3)
			{
				d02 service = bpo.GetService<d02>();
				bool flag = false;
				bool flag2 = false;
				d4n d4n = null;
				if (service != null && service.ahg())
				{
					d4n = service.ahu(base.vg().e().b8());
					flag2 = true;
				}
				int num2 = c5y.e;
				if ((base.vg().e().b8().bb & eom.b) != eom.a)
				{
					num2 = (int)((double)num2 * (1.0 - dyi.a(base.vg().e().b8())));
				}
				if (base.vg().e().b8().i(c5y.f) && (!flag2 || d4n.c >= (double)num2))
				{
					if (flag2)
					{
						d4n.a(num2, true);
					}
					base.vg().e().b8().j(c5y.f);
					flag = true;
				}
				if (!flag)
				{
					return dc4.e;
				}
			}
			this.b++;
			this.c = 0;
		}
		aw1.b(base.vg().q().h.b.a8(), ak, false);
		qy qy = new qy();
		qy.b(false);
		qy.c(false);
		b0b b0b = null;
		Vector3 vector = es2.a(base.vg().q(), 0.9f, true);
		Vector3 vector2 = ak.Location.a() + new Vector3((float)(-0.15000000596046448 + cuo.a.NextDouble() * 0.15000000596046448 * 2.0), (float)(-0.15000000596046448 + cuo.a.NextDouble() * 0.15000000596046448 * 2.0), (float)((double)(-0.15f + vector.Z) + cuo.a.NextDouble() * 0.15000000596046448 * 2.0));
		aig[] a_;
		if (this.c == 0)
		{
			a_ = new aig[]
			{
				new c28.a(base.vg().q().h.b)
			};
		}
		else
		{
			a_ = null;
		}
		dvv item = es2.a(vector, vector2, ak.Area, "pyroStream", a_, out b0b);
		if (b0b != null && b0b.Zone != null)
		{
			new ah7("fireballLantern", null)
			{
				LightFadeRate = 0.15f,
				Range = 2f,
				Light = new ae8(Color.White, 0.37f, LightType.Increment)
			}.g().be(b0b);
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
			if (this.c % 2 == 0)
			{
				base.vg().q().c().a("fireballLaunch" + Guid.NewGuid().ToString(), "FireballLaunch", 1f, c9z.a, false, false);
			}
			b0b.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x06007C65 RID: 31845 RVA: 0x00346034 File Offset: 0x00344234
	protected override void agp()
	{
		u6.a(base.vg().q().h.b);
		u6.a(base.vg().q().h.b, false);
		base.agp();
	}

	// Token: 0x06007C66 RID: 31846 RVA: 0x0034607C File Offset: 0x0034427C
	protected override void j4()
	{
		u6.a(base.vg().q().h.b);
		u6.a(base.vg().q().h.b, false);
		base.j4();
	}

	// Token: 0x04003166 RID: 12646
	private new const float a = 0.15f;

	// Token: 0x04003167 RID: 12647
	private int b;

	// Token: 0x04003168 RID: 12648
	private int c;

	// Token: 0x0200161A RID: 5658
	[eiz("LPS0b")]
	[Serializable]
	private new sealed class a : aig, ISerializable, enp
	{
		// Token: 0x06007C67 RID: 31847 RVA: 0x003460C4 File Offset: 0x003442C4
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.b = (a1q)A_0.GetValue("LPS0b:B", typeof(a1q));
			this.c = (A_0.GetValue("LPS0b:A", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
			this.d = (A_0.GetValue("LPS0b:T", typeof(HashSet<Point>)) as HashSet<Point>);
			this.e = (A_0.GetValue("LPS0b:E", typeof(HashSet<Guid>)) as HashSet<Guid>);
		}

		// Token: 0x06007C68 RID: 31848 RVA: 0x00346170 File Offset: 0x00344370
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("LPS0b:B", this.b);
			info.AddValue("LPS0b:A", this.c);
			info.AddValue("LPS0b:T", this.d);
			info.AddValue("LPS0b:E", this.e);
		}

		// Token: 0x06007C69 RID: 31849 RVA: 0x003461C8 File Offset: 0x003443C8
		public a(amc A_0)
		{
			this.b = c5y.a(new eoj(A_0.aa(), null, null));
			this.c = new EntityAspectReference<amc, amc>(A_0);
		}

		// Token: 0x06007C6A RID: 31850 RVA: 0x00346218 File Offset: 0x00344418
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

		// Token: 0x06007C6B RID: 31851 RVA: 0x00346474 File Offset: 0x00344674
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_0 != null && A_0.aa().Feats.Contains<xk>())
			{
				bhd.a(A_0, A_1, A_3.a, c5y.g, xk.a(new eoj(A_0.aa(), null, null)), 3);
			}
		}

		// Token: 0x06007C6C RID: 31852 RVA: 0x003464C4 File Offset: 0x003446C4
		private cwt a(amc A_0)
		{
			cwt cwt = new cwt();
			cwt.b = true;
			cwt.f.Add(euf.a(this.b, 1.0));
			cwt.k = "Пирокинетический поток";
			cwt.h = ImpactSpeed.VeryHigh;
			cwt.ad["PsionicSource"] = PsiSchool.Metathermics;
			if (this.c.ao() != null)
			{
				cwt.i = new ap9(this.c.ao().aa());
			}
			cwt.j = new ap9(A_0.aa());
			return cwt;
		}

		// Token: 0x04003169 RID: 12649
		private const float a = 1.5f;

		// Token: 0x0400316A RID: 12650
		private a1q b;

		// Token: 0x0400316B RID: 12651
		private EntityAspectReference<amc, amc> c;

		// Token: 0x0400316C RID: 12652
		private HashSet<Point> d = new HashSet<Point>();

		// Token: 0x0400316D RID: 12653
		private HashSet<Guid> e = new HashSet<Guid>();
	}
}
