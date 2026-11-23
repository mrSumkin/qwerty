using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;
using Ouroboros.Playfield.References;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020016C0 RID: 5824
[eiz("SHPFA")]
[Serializable]
public sealed class ebh : a6k, ISerializable
{
	// Token: 0x06007EF5 RID: 32501 RVA: 0x0035A700 File Offset: 0x00358900
	private ebh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007EF6 RID: 32502 RVA: 0x0035A70C File Offset: 0x0035890C
	public ebh()
	{
	}

	// Token: 0x06007EF7 RID: 32503 RVA: 0x0035A718 File Offset: 0x00358918
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		ak1 ak = base.vg().h() as ak1;
		if (ak == null || ak.Area == null || base.vg().q() == null || base.vg().q().i.b == null)
		{
			return dc4.e;
		}
		base.vg().i();
		double a_ = aw1.a(base.vg().q(), ak);
		int a_2 = euf.b(base.vg().e().b8(), f4.a(base.vg().e()), a_, 0.0);
		ak1 ak2 = awq.a(this, ak, a_2, true);
		b0b b0b = null;
		c5x a_3 = base.vg().q();
		Vector3 a_4 = ak2.Location.a() + new Vector3(0.5f, 0.5f, 0f);
		string a_5 = "PlasmaFlare";
		aig[] a_6 = new aig[]
		{
			new ebh.b(base.vg().q().h.b, new List<a1q>
			{
				f4.c(base.vg().e(), 1.0),
				f4.b(base.vg().e(), 1.0)
			})
		};
		dvv item = es2.a(a_3, a_4, a_5, out b0b, null, a_6, true, 0.5f, null);
		if (b0b != null && b0b.Zone != null)
		{
			new ah7("plasmaFlare", null)
			{
				LightFadeRate = 0.1f,
				Range = 4f,
				Light = new ae8(new Color(80, 255, 255), 0.5f, LightType.Increment)
			}.g().be(b0b);
			awx awx = new awx();
			awx awx2 = awx;
			awx2.a(awx2.kh() | m7.b);
			awx.b(false);
			awx.c(false);
			awx.ad().Add(new e4t(base.vg().q().h.b, CharacterState.Attack1, dz6.b(cux.m), 0, null, 1));
			base.vg().q().i.b.b(awx, atp.a);
			base.vg().q().h.b.aa().Offense.u().Battery = Math.Max(0.0, base.vg().q().h.b.aa().Offense.u().Battery - (double)f4.f);
			dtb dtb = new dtb();
			dtb.b(false);
			dtb.c(false);
			dtb.ad().Add(new a4s(new bfq("ShootPlasmaFlare"), null, new ar7(base.vg().q()), null));
			dtb.ad().Add(item);
			c7 c = new c7(b0b, false, false, true, false);
			c.a(true);
			dtb.ad().Add(c);
			c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak2.Entities, new Func<b0b, bool>(ebh.a.a.a))) as c5x;
			if (c5x != null)
			{
				dtb.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "Flare"), null, new ar7(c5x), null));
			}
			dtb.ad().Add(new a4s(new b20("Locale\\Object\\Items\\PlasmaFlare", new bt4(ak2.Area.y8(), ak2.Location.a()), null), null, null, null));
			awb item2 = new awb(ak2, new ekm.b(base.vg().e(), base.vg().q().h.b), null, (float)base.vg().e().g(), null, null, true);
			dtb.ad().Add(item2);
			eu8 item3 = new eu8(base.vg().q(), d8o.g, ak2, base.vg().e().g() + 5, d0u.b, null);
			dtb.ad().Add(item3);
			base.vg().q().i.b.b(dtb, atp.a);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x020016C1 RID: 5825
	[eiz("SHPFAb")]
	[Serializable]
	private sealed class b : aig, ISerializable
	{
		// Token: 0x06007EF8 RID: 32504 RVA: 0x0035ABC8 File Offset: 0x00358DC8
		private b(SerializationInfo A_0, StreamingContext A_1)
		{
			this.b = A_0.GetSingle("SHPFAb:D");
			this.c = (A_0.GetValue("SHPFAb:B", typeof(List<a1q>)) as List<a1q>);
			this.d = (A_0.GetValue("SHPFAb:A", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
			this.e = (A_0.GetValue("SHPFAb:T", typeof(HashSet<Point>)) as HashSet<Point>);
			this.f = (A_0.GetValue("SHPFAb:E", typeof(HashSet<Guid>)) as HashSet<Guid>);
			this.g = (Guid)A_0.GetValue("SHPFAb:I", typeof(Guid));
		}

		// Token: 0x06007EF9 RID: 32505 RVA: 0x0035ACB0 File Offset: 0x00358EB0
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("SHPFAb:D", this.b);
			info.AddValue("SHPFAb:B", this.c);
			info.AddValue("SHPFAb:A", this.d);
			info.AddValue("SHPFAb:T", this.e);
			info.AddValue("SHPFAb:E", this.f);
			info.AddValue("SHPFAb:I", this.g);
		}

		// Token: 0x06007EFA RID: 32506 RVA: 0x0035AD28 File Offset: 0x00358F28
		public b(amc A_0, List<a1q> A_1)
		{
			this.c = A_1;
			this.d = new EntityAspectReference<amc, amc>(A_0);
		}

		// Token: 0x06007EFB RID: 32507 RVA: 0x0035AD64 File Offset: 0x00358F64
		public bool hj(b0b A_0, Vector3 A_1, Vector3 A_2, float A_3)
		{
			if ((this.b += A_3) >= 1.5f)
			{
				this.b -= 1.5f;
				if (A_0 != null && A_0.Area != null)
				{
					aud a_ = A_0.Area;
					HorizontalDirection? a_2 = null;
					string a_3 = "Smoke";
					int a_4 = 1;
					double maxValue = double.MaxValue;
					float? a_5 = dz6.b();
					c5x c5x = boj.a(a_, A_1, a_2, a_3, a_4, maxValue, null, null, a_5, null);
					if (c5x != null)
					{
						c5x.ad = new Color?(new Color(80, 255, 255));
						c5x.ae = new float?(0.1f);
					}
				}
			}
			if (this.d.ao() != null && A_0 != null && A_0.Area != null)
			{
				Point point = A_0.aj().a();
				if (!this.e.Contains(point))
				{
					ak1 ak = A_0.Area.a(point);
					if (ak != null)
					{
						foreach (b0b b0b in Enumerable.ToList<b0b>(ak.c.Values))
						{
							c5x c5x2 = (c5x)b0b;
							if (c5x2.h.b != null && !this.f.Contains(c5x2.qe()))
							{
								if (c5x2.h.b != this.d.ao())
								{
									string a_6;
									string a_7;
									string a_8;
									string a_9;
									float a_10;
									float a_11;
									awq.a(c5x2.h.b, new esu?(esu.l), out a_6, out a_7, out a_8, out a_9, out a_10, out a_11, null, false);
									kg a_12 = new kg(null, a_6, a_7, a_8, a_9, a_10, a_11);
									dtb dtb = new dtb();
									dtb.b(false);
									dtb.c(false);
									dtb.ad().Add(new akg(this.d.ao(), c5x2.h.b, this.a(c5x2.h.b), new b7x(a_12), false));
									if (this.d.ao().aa() is e3q)
									{
										awq.a(dtb, this.d.ao().a8(), c5x2, true, true);
									}
									dtb.ad().Add(new eu8(this.d.ao().a8(), d8o.g, ak, 5, d0u.b * 2, null));
									c5x2.Zone.ActionManager.g9(dtb, atp.a);
									dz6.a(dtb);
								}
								this.f.Add(c5x2.qe());
							}
						}
					}
					this.e.Add(point);
				}
			}
			return false;
		}

		// Token: 0x06007EFC RID: 32508 RVA: 0x0035B064 File Offset: 0x00359264
		private cwt a(amc A_0)
		{
			cwt cwt = new cwt();
			cwt.b = true;
			if (this.c != null)
			{
				foreach (a1q a_ in this.c)
				{
					cwt.f.Add(euf.a(a_, 1.0));
				}
			}
			cwt.v = "плазменная вспышка";
			cwt.h = ImpactSpeed.VeryHigh;
			cwt.ae = new WeaponSubtype?(WeaponSubtype.Pistol_Plasma);
			cwt.af = this.g;
			if (this.d.ao() != null)
			{
				cwt.i = new ap9(this.d.ao().aa());
			}
			cwt.j = new ap9(A_0.aa());
			return cwt;
		}

		// Token: 0x04003227 RID: 12839
		private const float a = 1.5f;

		// Token: 0x04003228 RID: 12840
		private float b;

		// Token: 0x04003229 RID: 12841
		private List<a1q> c;

		// Token: 0x0400322A RID: 12842
		private EntityAspectReference<amc, amc> d;

		// Token: 0x0400322B RID: 12843
		private HashSet<Point> e = new HashSet<Point>();

		// Token: 0x0400322C RID: 12844
		private HashSet<Guid> f = new HashSet<Guid>();

		// Token: 0x0400322D RID: 12845
		private Guid g = Guid.NewGuid();
	}

	// Token: 0x020016C2 RID: 5826
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007EFF RID: 32511 RVA: 0x0035B164 File Offset: 0x00359364
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x0400322E RID: 12846
		public static readonly ebh.a a = new ebh.a();

		// Token: 0x0400322F RID: 12847
		public static Func<b0b, bool> b;
	}
}
