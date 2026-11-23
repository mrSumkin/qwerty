using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001522 RID: 5410
[eiz("YPSA")]
[Serializable]
public sealed class d1x : d64, ISerializable
{
	// Token: 0x060078FB RID: 30971 RVA: 0x0032A3F8 File Offset: 0x003285F8
	private d1x(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060078FC RID: 30972 RVA: 0x0032A404 File Offset: 0x00328604
	public d1x()
	{
	}

	// Token: 0x060078FD RID: 30973 RVA: 0x0032A410 File Offset: 0x00328610
	protected override bool gq()
	{
		if (!base.gq())
		{
			return false;
		}
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			double a_ = aw1.b(base.c().a8(), base.b().a8());
			double a_2 = awq.a(base.vg().e(), base.b(), a_);
			cmn cmn = awq.a(base.c(), base.b(), null, null);
			cmn.b += base.c().aa().Offense.an();
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), a_, cmn, 0.0, base.b().a8().l(), base.c().aa().Darkvision, cd.CurrentBullet, awq.f(base.c()), a_2, false, null, null, true, null);
			amc a_3 = base.c();
			amc a_4 = base.b();
			cwt a_5 = cwt;
			cd1 a_6 = cd;
			enp a_7 = null;
			bool a_8 = true;
			aig[] a_9 = new aig[]
			{
				new d1x.a(cd, base.c(), base.b(), base.c().aa().Offense.an())
			};
			awq.a(a_3, a_4, a_5, a_6, a_7, a_8, null, "Bolt_Piercing", a_9, false, false, true, null, null);
			return true;
		}
		return false;
	}

	// Token: 0x02001523 RID: 5411
	[eiz("YPSAb")]
	[Serializable]
	private new sealed class a : aig, ISerializable
	{
		// Token: 0x060078FE RID: 30974 RVA: 0x0032A5D0 File Offset: 0x003287D0
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.b = A_0.GetSingle("YPSAb:D");
			this.c = (A_0.GetValue("YPSAb:W", typeof(cd1)) as cd1);
			this.d = A_0.GetDouble("YPSAb:B");
			this.e = (A_0.GetValue("YPSAb:A", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
			this.f = (A_0.GetValue("YPSAb:P", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
			this.g = (A_0.GetValue("YPSAb:T", typeof(HashSet<Point>)) as HashSet<Point>);
			this.h = (A_0.GetValue("YPSAb:E", typeof(HashSet<Guid>)) as HashSet<Guid>);
		}

		// Token: 0x060078FF RID: 30975 RVA: 0x0032A6BC File Offset: 0x003288BC
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("YPSAb:D", this.b);
			info.AddValue("YPSAb:W", this.c);
			info.AddValue("YPSAb:B", this.d);
			info.AddValue("YPSAb:A", this.e);
			info.AddValue("YPSAb:P", this.f);
			info.AddValue("YPSAb:T", this.g);
			info.AddValue("YPSAb:E", this.h);
		}

		// Token: 0x06007900 RID: 30976 RVA: 0x0032A740 File Offset: 0x00328940
		public a(cd1 A_0, amc A_1, amc A_2, double A_3)
		{
			this.c = A_0;
			this.e = new EntityAspectReference<amc, amc>(A_1);
			this.f = new EntityAspectReference<amc, amc>(A_2);
			this.d = A_3;
		}

		// Token: 0x06007901 RID: 30977 RVA: 0x0032A790 File Offset: 0x00328990
		public bool hj(b0b A_0, Vector3 A_1, Vector3 A_2, float A_3)
		{
			if ((this.b += A_3) >= 1f)
			{
				this.b -= 1f;
				if (A_0 != null && A_0.Area != null)
				{
					aud a_ = A_0.Area;
					HorizontalDirection? a_2 = null;
					string a_3 = "Bolt_Piercing_Trail";
					int a_4 = 1;
					double maxValue = double.MaxValue;
					float? a_5 = dz6.b();
					boj.a(a_, A_1, a_2, a_3, a_4, maxValue, null, null, a_5, null);
				}
			}
			if (this.e.ao() != null && this.e.ao().a8() != null && A_0 != null && A_0.Area != null)
			{
				Point point = A_0.aj().a();
				if (!this.g.Contains(point))
				{
					ak1 ak = A_0.Area.a(point);
					if (ak != null)
					{
						foreach (b0b b0b in Enumerable.ToList<b0b>(ak.c.Values))
						{
							c5x c5x = (c5x)b0b;
							if (c5x.h.b != null && !this.h.Contains(c5x.qe()))
							{
								if (c5x.h.b != this.e.ao() && c5x.h.b != this.f.ao())
								{
									cwt a_6 = this.a(c5x.h.b);
									dtb dtb = new dtb();
									dtb.b(false);
									dtb.c(false);
									awq.a(dtb, this.e.ao(), c5x.h.b, this.c.TypedDefinition, a_6, new b7x(null), null, false);
									if (this.e.ao().aa() is e3q)
									{
										awq.a(dtb, this.e.ao().a8(), c5x, true, true);
									}
									c5x.Zone.ActionManager.g9(dtb, atp.a);
									dz6.a(dtb);
								}
								this.h.Add(c5x.qe());
							}
						}
					}
					this.g.Add(point);
				}
			}
			return false;
		}

		// Token: 0x06007902 RID: 30978 RVA: 0x0032AA28 File Offset: 0x00328C28
		private cwt a(amc A_0)
		{
			double num = aw1.b(this.e.ao().a8(), A_0.a8());
			double a_ = awq.a(dgk.Get<ez7>(), this.e.ao().aa(), null, A_0, num);
			cmn cmn = awq.a(this.e.ao(), A_0, null, null);
			cmn.b += this.d;
			cwt cwt = euf.a(this.e.ao().aa(), A_0.aa(), num, cmn, 0.0, A_0.a8().l(), this.e.ao().aa().Darkvision, AmmoType.Bolts, awq.f(this.e.ao()), a_, false, null, null, true, null);
			cwt.k = "Пронзающий выстрел";
			return cwt;
		}

		// Token: 0x0400307F RID: 12415
		private const float a = 1f;

		// Token: 0x04003080 RID: 12416
		private float b;

		// Token: 0x04003081 RID: 12417
		private cd1 c;

		// Token: 0x04003082 RID: 12418
		private double d;

		// Token: 0x04003083 RID: 12419
		private EntityAspectReference<amc, amc> e;

		// Token: 0x04003084 RID: 12420
		private EntityAspectReference<amc, amc> f;

		// Token: 0x04003085 RID: 12421
		private HashSet<Point> g = new HashSet<Point>();

		// Token: 0x04003086 RID: 12422
		private HashSet<Guid> h = new HashSet<Guid>();
	}
}
