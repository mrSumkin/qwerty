using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;
using Ouroboros.Playfield.References;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001476 RID: 5238
[eiz("ETAA")]
[Serializable]
public sealed class ak4 : a6k, ISerializable
{
	// Token: 0x0600763C RID: 30268 RVA: 0x0031F684 File Offset: 0x0031D884
	private ak4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600763D RID: 30269 RVA: 0x0031F690 File Offset: 0x0031D890
	public ak4()
	{
	}

	// Token: 0x0600763E RID: 30270 RVA: 0x0031F69C File Offset: 0x0031D89C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		ak1 ak = base.vg().h() as ak1;
		if (ak == null || ak.Area == null)
		{
			return dc4.e;
		}
		base.vg().i();
		double a_ = aw1.a(base.vg().q(), ak);
		int a_2 = new v3().b(base.vg().e());
		int a_3 = euf.b(base.vg().e().b8(), a_2, a_, 0.0);
		ak1 ak2 = awq.a(this, ak, a_3, false);
		qy qy = new qy();
		qy.b(false);
		qy.c(false);
		b0b b0b = null;
		dvv item = es2.a(base.vg().q(), ak2.Location.a() + new Vector3(0.5f, 0.5f, 0f), "xpbl_shardProjectile", out b0b, null, null, true, 0.5f, null);
		if (b0b != null && b0b.Zone != null)
		{
			qy.ad().Add(item);
			c7 c = new c7(b0b, false, false, true, false);
			c.a(true);
			qy.ad().Add(c);
			ah7 ah = new ah7("etherealLightLantern", null);
			ah.LightFadeRate = 0.15f;
			ah.Range = 5f;
			ah.Light = new ae8(new Color(82, 255, 255), 0.8f, LightType.Increment);
			ah.g().be(b0b);
			c5x c5x = Enumerable.FirstOrDefault<b0b>(ak2.Entities) as c5x;
			if (c5x != null)
			{
				bfq bfq = new bfq();
				bfq.b("xpbl_EtherealTorchHit" + Guid.NewGuid().ToString());
				bfq.c("xpbl_EtherealTorchHit");
				bfq.a(bvl.c);
				qy.ad().Add(new a4s(bfq, null, new ar7(c5x), null));
				eym.a(qy, c5x, (double)aju.bm);
			}
			awb awb = new awb(ak2, new ak4.a(base.vg().e(), base.vg().q().h.b), new ae8?(ah.Light), (float)base.vg().e().g(), null, null, false);
			awb.r = true;
			awb.b(200.0);
			awb.c(0.2f);
			awb.b(0.15f);
			awb.a(6f);
			qy.ad().Add(awb);
			qy.ad().Add(new duh(base.vg().q().h.b, new string[]
			{
				b0c.a
			}));
			eu8 item2 = new eu8(base.vg().q(), d8o.g, ak2, base.vg().e().g() + 5, d0u.b * 2, null);
			qy.ad().Add(item2);
			b0b.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			base.vg().q().c().a("xpbl_EtherealTorchLaunch" + Guid.NewGuid().ToString(), "xpbl_EtherealTorchLaunch", 1f, c9z.a, false, false);
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				serviceOrThrow.aqu().r()["item_etherealTorch_used"] = true;
			}
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x02001477 RID: 5239
	[eiz("ETAAa")]
	[Serializable]
	private new class a : cci, ISerializable
	{
		// Token: 0x0600763F RID: 30271 RVA: 0x0031FA64 File Offset: 0x0031DC64
		protected a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (eu7)A_0.GetValue("ETAAa:P", typeof(eu7));
			di7.ReadList<Guid>("ETAAa:AE", ref this.b, A_0);
			this.c = (EntityAspectReference<amc, amc>)A_0.GetValue("ETAAa:IR", typeof(EntityAspectReference<amc, amc>));
		}

		// Token: 0x06007640 RID: 30272 RVA: 0x0031FAD4 File Offset: 0x0031DCD4
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("ETAAa:P", this.a);
			di7.WriteList<Guid>("ETAAa:AE", this.b, info);
			info.AddValue("ETAAa:IR", this.c);
		}

		// Token: 0x06007641 RID: 30273 RVA: 0x0031FB0C File Offset: 0x0031DD0C
		public a(eu7 A_0, amc A_1)
		{
			this.a = A_0;
			if (A_1 != null)
			{
				this.c = new EntityAspectReference<amc, amc>(A_1);
			}
		}

		// Token: 0x06007642 RID: 30274 RVA: 0x0031FB38 File Offset: 0x0031DD38
		public void cq(aud A_0, Point A_1, float A_2)
		{
			int value;
			if (A_2 == 0f)
			{
				value = 0;
			}
			else if (A_2 <= 1f)
			{
				value = 1 + cuo.a.Next(2);
			}
			else
			{
				value = 3 + cuo.a.Next(2);
			}
			Vector3 a_ = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
			HorizontalDirection? a_2 = null;
			string a_3 = "xpbl_ShardExplosion";
			int a_4 = 1;
			double maxValue = double.MaxValue;
			float? a_5 = dz6.b();
			int? a_6 = new int?(value);
			boj.a(A_0, a_, a_2, a_3, a_4, maxValue, null, null, a_5, a_6);
			ak1 ak = A_0.b(A_1.X, A_1.Y);
			if (ak != null)
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
				{
					c5x c5x = b0b as c5x;
					if (c5x != null)
					{
						if (c5x.h.b != null && !this.b.Contains(b0b.qe()))
						{
							this.a(this.c.ao(), c5x.h.b, A_2);
							this.b.Add(c5x.qe());
						}
						if (c5x.y.b != null)
						{
							c5x.y.b.a(null);
							this.b.Add(c5x.qe());
						}
					}
				}
			}
		}

		// Token: 0x06007643 RID: 30275 RVA: 0x0031FCE8 File Offset: 0x0031DEE8
		private void a(amc A_0, amc A_1, float A_2)
		{
			if (this.a == null || this.a.b8() == null || !(this.a.p() is v3))
			{
				return;
			}
			bool flag = false;
			if (A_1.am() == bln.g6 || A_1.am() == bln.g7 || A_1.am() == bln.g8 || A_1.am() == bln.g9)
			{
				flag = true;
			}
			if (!A_1.a8().IsPlayer)
			{
				awq.a(this.c.ao(), A_1, true, true, null, true, true, false, false);
			}
			a1q a_ = new v3().a(this.a);
			cwt cwt = new cwt();
			cwt.x = AmmoType.EtherealEnergy;
			cwt.b = true;
			if (flag)
			{
				cwt.e = euf.a(0.1);
				cwt.p = true;
				cwt.q = false;
			}
			else
			{
				cwt.e = (!A_1.aa().ImmuneToCriticalHits && euf.a(0.05));
				cwt.o = v3.a;
				cwt.q = true;
			}
			cwt.i = new ap9(this.a.b8());
			cwt.j = new ap9(A_1.aa());
			cwt.f = new List<csk>
			{
				euf.a(a_, true + (cwt.e > false))
			};
			cwt.k = this.a.p().Name;
			cwt.h = ImpactSpeed.VeryHigh;
			A_1.aa().Defense.a(cwt);
		}

		// Token: 0x0400303A RID: 12346
		private eu7 a;

		// Token: 0x0400303B RID: 12347
		private List<Guid> b = new List<Guid>();

		// Token: 0x0400303C RID: 12348
		private EntityAspectReference<amc, amc> c;
	}
}
