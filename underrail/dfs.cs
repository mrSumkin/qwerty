using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;
using Ouroboros.Playfield.References;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001629 RID: 5673
[eiz("LPA1")]
[Serializable]
public sealed class dfs : a6k, ISerializable
{
	// Token: 0x06007CA3 RID: 31907 RVA: 0x00348F68 File Offset: 0x00347168
	private dfs(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007CA4 RID: 31908 RVA: 0x00348F74 File Offset: 0x00347174
	public dfs()
	{
	}

	// Token: 0x06007CA5 RID: 31909 RVA: 0x00348F80 File Offset: 0x00347180
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		ak1 ak = base.vg().h() as ak1;
		if (ak == null || ak.Area == null)
		{
			return dc4.e;
		}
		base.vg().i();
		double a_ = aw1.a(base.vg().q(), ak);
		int a_2 = euf.b(base.vg().e().b8(), base.vg().e().b8().Skills.Get<rs>().g(), a_, 0.0);
		ak1 ak2 = awq.a(this, ak, a_2, false);
		qy qy = new qy();
		qy.b(false);
		qy.c(false);
		b0b b0b = null;
		dvv item = es2.a(base.vg().q(), ak2.Location.a() + new Vector3(0.5f, 0.5f, 0f), "fireball", out b0b, null, null, true, 0.5f, null);
		if (b0b != null && b0b.Zone != null)
		{
			c5x c5x = b0b as c5x;
			if (c5x != null)
			{
				b4u aspect = c5x.GetAspect<b4u>();
				if (aspect != null)
				{
					aspect.b().Add(new cvz());
				}
			}
			qy.ad().Add(item);
			c7 c = new c7(b0b, false, false, true, false);
			c.a(true);
			qy.ad().Add(c);
			ah7 ah = new ah7("fireballLantern", null);
			ah.LightFadeRate = 0.2f;
			ah.Range = 4f;
			ah.Light = new ae8(Color.White, 1f, LightType.Increment);
			ah.g().be(b0b);
			c5x c5x2 = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak2.Entities, new Func<b0b, bool>(dfs.b.a.a))) as c5x;
			if (c5x2 != null)
			{
				bfq bfq = new bfq();
				bfq.b("FireballSpread" + Guid.NewGuid().ToString());
				bfq.c("FireballSpread");
				bfq.a(bvl.c);
				qy.ad().Add(new a4s(bfq, null, new ar7(c5x2), null));
				eym.a(qy, c5x2, (double)aju.bm);
			}
			awb awb = new awb(ak2, new dfs.a(base.vg().e(), base.vg().q().h.b), new ae8?(ah.Light), (float)base.vg().e().g(), null, null, false);
			awb.r = true;
			awb.c(0.2f);
			awb.b(0.15f);
			awb.a(6f);
			qy.ad().Add(awb);
			qy.ad().Add(new duh(base.vg().q().h.b, new string[]
			{
				b0c.a
			}));
			if (base.vg().q() != null && base.vg().q().h.b != null && base.vg().q().Zone != null)
			{
				u6.a(base.vg().q().h.b);
				u6.a(base.vg().q().h.b, false);
			}
			eu8 item2 = new eu8(base.vg().q(), d8o.g, ak2, base.vg().e().g() + 5, d0u.b * 2, null);
			qy.ad().Add(item2);
			b0b.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			base.vg().q().c().a("fireballLaunch" + Guid.NewGuid().ToString(), "FireballLaunch", 1f, c9z.a, false, false);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x0200162A RID: 5674
	[eiz("FS")]
	[Serializable]
	private new class a : cci, ISerializable
	{
		// Token: 0x06007CA6 RID: 31910 RVA: 0x003493CC File Offset: 0x003475CC
		protected a(SerializationInfo A_0, StreamingContext A_1)
		{
			if (ell.a() != 0)
			{
				this.a = (eu7)A_0.GetValue("FS:P", typeof(eu7));
				di7.ReadList<Guid>("FS:AE", ref this.b, A_0);
				this.c = (EntityAspectReference<amc, amc>)A_0.GetValue("FS:IR", typeof(EntityAspectReference<amc, amc>));
				return;
			}
			if (base.GetType() == typeof(dfs.a))
			{
				this.a = (eu7)A_0.GetValue("_Proxy", typeof(eu7));
				this.b = (List<Guid>)A_0.GetValue("_AffectedEntities", typeof(List<Guid>));
				this.c = (EntityAspectReference<amc, amc>)A_0.GetValue("_InvokerRef", typeof(EntityAspectReference<amc, amc>));
				return;
			}
			this.a = (eu7)A_0.GetValue("FireSpawner+_Proxy", typeof(eu7));
			this.b = (List<Guid>)A_0.GetValue("FireSpawner+_AffectedEntities", typeof(List<Guid>));
			this.c = (EntityAspectReference<amc, amc>)A_0.GetValue("FireSpawner+_InvokerRef", typeof(EntityAspectReference<amc, amc>));
		}

		// Token: 0x06007CA7 RID: 31911 RVA: 0x00349524 File Offset: 0x00347724
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("FS:P", this.a);
			di7.WriteList<Guid>("FS:AE", this.b, info);
			info.AddValue("FS:IR", this.c);
		}

		// Token: 0x06007CA8 RID: 31912 RVA: 0x0034955C File Offset: 0x0034775C
		public a(eu7 A_0, amc A_1)
		{
			this.a = A_0;
			if (A_1 != null)
			{
				this.c = new EntityAspectReference<amc, amc>(A_1);
			}
		}

		// Token: 0x06007CA9 RID: 31913 RVA: 0x0034958C File Offset: 0x0034778C
		public void cq(aud A_0, Point A_1, float A_2)
		{
			Vector3 a_ = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
			HorizontalDirection? a_2 = null;
			string a_3 = "ScorchGround";
			int a_4 = 1;
			double maxValue = double.MaxValue;
			float? a_5 = dz6.b();
			boj.a(A_0, a_, a_2, a_3, a_4, maxValue, null, null, a_5, null);
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
						ce1 aspect = c5x.GetAspect<ce1>();
						if (aspect != null)
						{
							aspect.n3(c18.y);
						}
					}
				}
			}
		}

		// Token: 0x06007CAA RID: 31914 RVA: 0x00349718 File Offset: 0x00347918
		private void a(amc A_0, amc A_1, float A_2)
		{
			if (this.a == null || this.a.b8() == null || !(this.a.p() is c67))
			{
				return;
			}
			if (!A_1.a8().IsPlayer)
			{
				awq.a(this.c.ao(), A_1, true, true, null, true, true, false, false);
			}
			bas bas = this.a.b8().Offense.ag()[PsiSchool.Metathermics];
			a1q a_ = c67.a(this.a);
			double num;
			if (A_2 > 0f)
			{
				num = Math.Min(c18.az, (double)A_2 * 0.15);
			}
			else
			{
				num = 0.0;
			}
			cwt cwt = new cwt();
			cwt.b = true;
			cwt.e = (!A_1.aa().ImmuneToCriticalHits && euf.a(euf.a(bas, A_1.aa())));
			cwt.i = new ap9(this.a.b8());
			cwt.j = new ap9(A_1.aa());
			cwt.f = new List<csk>
			{
				euf.a(a_, (double)(1f + (cwt.e ? bas.g() : 0f)) * (1.0 - num))
			};
			cwt.k = this.a.p().Name;
			cwt.q = true;
			cwt.h = ImpactSpeed.High;
			cwt.ad["PsionicSource"] = PsiSchool.Metathermics;
			cwt.ad["IsExplosion"] = true;
			cru cru = A_1.aa().Defense.a(cwt);
			if (this.a.b8().Feats.Contains<xk>())
			{
				bhd.a(A_0, A_1, cru.a, c67.f, xk.a(this.a), 3);
			}
		}

		// Token: 0x04003186 RID: 12678
		private eu7 a;

		// Token: 0x04003187 RID: 12679
		private List<Guid> b = new List<Guid>();

		// Token: 0x04003188 RID: 12680
		private EntityAspectReference<amc, amc> c;
	}

	// Token: 0x0200162B RID: 5675
	[CompilerGenerated]
	[Serializable]
	private sealed class b
	{
		// Token: 0x06007CAD RID: 31917 RVA: 0x00349930 File Offset: 0x00347B30
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x04003189 RID: 12681
		public static readonly dfs.b a = new dfs.b();

		// Token: 0x0400318A RID: 12682
		public static Func<b0b, bool> b;
	}
}
