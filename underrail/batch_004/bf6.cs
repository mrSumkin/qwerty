using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;
using Ouroboros.Playfield.References;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001611 RID: 5649
[eiz("XSM")]
[Serializable]
public sealed class bf6 : a6k, ISerializable
{
	// Token: 0x06007C3B RID: 31803 RVA: 0x0034370C File Offset: 0x0034190C
	private bf6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007C3C RID: 31804 RVA: 0x00343718 File Offset: 0x00341918
	public bf6()
	{
	}

	// Token: 0x06007C3D RID: 31805 RVA: 0x00343724 File Offset: 0x00341924
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		ak1 ak = base.vg().h() as ak1;
		if (ak == null || ak.Area == null)
		{
			return dc4.e;
		}
		base.vg().i();
		eg2 eg = egy.a(base.vg().q());
		bool flag;
		if (eg == null || eg.a8().Area != ak.Area)
		{
			flag = true;
		}
		else if (aw1.a(eg.a8(), ak) > (double)(2f * base.vg().e().c(ak)))
		{
			flag = true;
		}
		else
		{
			bbg bbg = new bbg();
			bbg.a(false);
			bbg.a().Add(new bf6.a(ak.Area));
			bbg.a(float.MaxValue);
			bbg.a(true);
			flag = !new exm(bbg, eg.a8().Location.b() + new Vector2(0.5f, 0.5f), ak.Location.b() + new Vector2(0.5f, 0.5f)).a(null).b();
		}
		if (flag)
		{
			if (eg != null)
			{
				eg.d();
			}
			c5x c5x = vq.a("objects\\special\\PsiProxy", false);
			if (c5x != null)
			{
				c5x.Location = new Vector3((float)ak.Location.X, (float)ak.Location.Y, 0.5f);
				c5x.ae = new float?(0f);
				eg = new eg2(c5x);
				eg.a(new ar7(base.vg().q()));
				c5x.SetAspect<eg2>(eg);
				ny aspect = new ny(c5x);
				c5x.SetAspect<ny>(aspect);
				c5x.SetAspect<e3l>(new e3l(c5x)
				{
					a = 
					{
						"telekineticProxy"
					}
				});
				bpu bpu = new bpu(c5x);
				bpu.a(8f);
				bpu.b(8f);
				c5x.SetAspect<bpu>(bpu);
				mj aspect2 = new mj(c5x);
				c5x.SetAspect<mj>(aspect2);
				dha dha = new dha(c5x, c5x.p.b, 8, 100);
				c5x.SetAspect<dha>(dha);
				b30 aspect3 = new b30(c5x);
				c5x.SetAspect<b30>(aspect3);
				ak.Area.a(c5x);
				c5x.c().a("loop", "TelekineticProxyLoop", 1f, c9z.b, true, false);
				this.b(c5x);
				cix cix = c5x.Zone.ActionManager;
				ad6 ad = new ad6(c5x);
				ad.b(0.0);
				ad.c(1.0);
				ad.a(dz6.a(0.0005));
				cix.g9(ad, atp.a);
				bf6.a(c5x);
				dha.a(null, 0, 0.0);
				qy qy = new qy();
				qy.b(false);
				qy.c(false);
				List<auv> list = qy.ad();
				a4s a4s = new a4s(new bfq("TelekineticProxyCreate"), null, null, null);
				a4s.b(new ar7(c5x));
				list.Add(a4s);
				base.vg().q().Zone.ActionManager.g9(qy, atp.a);
				dz6.a(qy);
			}
		}
		else
		{
			eg.b();
			awx awx = new awx();
			awx.b(false);
			awx.c(false);
			List<auv> list2 = awx.ad();
			a4s a4s2 = new a4s(new bfq("TelekineticProxyMove"), null, null, null);
			a4s2.b(new ar7(eg.a8()));
			list2.Add(a4s2);
			List<auv> list3 = awx.ad();
			mj b = eg.a8().j.b;
			Vector3 a_ = new Vector3((float)ak.Location.X, (float)ak.Location.Y, 0.5f);
			aig[] a_2 = new aig[]
			{
				new bf6.b(eg.a8()),
				new bf6.c(ci5.a(base.vg().e()), base.vg().q().h.b)
			};
			list3.Add(new bpr(b, a_, null, a_2));
			eg.a8().i.b.b(awx, atp.a);
			dz6.a(awx);
		}
		return dc4.c;
	}

	// Token: 0x06007C3E RID: 31806 RVA: 0x00343B68 File Offset: 0x00341D68
	private void b(c5x A_0)
	{
		new ah7("__telekineticProxy", null)
		{
			Light = new ae8(new Color(186, 24, 248), 0.75f, LightType.Increment),
			LightFadeRate = 0.2f,
			Range = 3f
		}.g().be(A_0);
	}

	// Token: 0x06007C3F RID: 31807 RVA: 0x00343BC4 File Offset: 0x00341DC4
	private static void a(c5x A_0)
	{
		Vector3 vector = A_0.aj();
		for (int i = -1; i <= 1; i++)
		{
			for (int j = -1; j <= 1; j++)
			{
				if (i != 0 || j != 0)
				{
					Vector3 vector2 = new Vector3(vector.X + (float)i, vector.Y + (float)j, 0f);
					Point point = vector2.a();
					if (point.X >= 0 && point.Y >= 0 && point.X < A_0.Area.Size.c && point.Y < A_0.Area.Size.d)
					{
						for (float num = 0f; num <= 2f; num += 0.66f)
						{
							vector2.Z = num;
							bf6.a(A_0.Area, vector2, new Vector3(vector.X, vector.Y, vector.Z + 0.5f * (float)cuo.a.NextDouble()));
						}
					}
				}
			}
		}
	}

	// Token: 0x06007C40 RID: 31808 RVA: 0x00343CE0 File Offset: 0x00341EE0
	private static void a(aud A_0, Vector3 A_1, Vector3 A_2)
	{
		double num = (double)Vector3.Distance(A_1, A_2);
		b0b b0b;
		auv a_ = es2.a(A_1, A_2, A_0, "PsiFlake", null, out b0b);
		ad6 ad = new ad6(b0b as c5x);
		ad.b(0.9);
		ad.c(0.0);
		ad.a(dz6.a(0.0004 + 0.001 / num));
		qy qy = new qy();
		qy.ad().Add(ad);
		qy.ad().Add(new c7(b0b, false, false, true, false));
		A_0.Zone.ActionManager.g9(a_, atp.a);
		A_0.Zone.ActionManager.g9(qy, atp.a);
		dz6.a(a_);
		dz6.a(qy);
	}

	// Token: 0x02001612 RID: 5650
	private new class a : ok
	{
		// Token: 0x06007C41 RID: 31809 RVA: 0x00343DB0 File Offset: 0x00341FB0
		public a(aud A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06007C42 RID: 31810 RVA: 0x00343DC4 File Offset: 0x00341FC4
		public bool g5(anl A_0)
		{
			ak1 ak = this.a.a(A_0.d());
			return ak != null && !ak.Formation.c(4L);
		}

		// Token: 0x04003155 RID: 12629
		private aud a;
	}

	// Token: 0x02001613 RID: 5651
	[eiz("XSMa")]
	[Serializable]
	private class b : aig, ISerializable
	{
		// Token: 0x06007C43 RID: 31811 RVA: 0x00343DFC File Offset: 0x00341FFC
		public b(b0b A_0)
		{
			this.b = new ar7(A_0);
		}

		// Token: 0x06007C44 RID: 31812 RVA: 0x00343E14 File Offset: 0x00342014
		public bool hj(b0b A_0, Vector3 A_1, Vector3 A_2, float A_3)
		{
			if ((this.c += A_3) >= 0.1f)
			{
				this.c -= 0.1f;
				if (this.b != null && this.b.ao() != null && this.b.ao().Area != null)
				{
					aud a_ = this.b.ao().Area;
					Vector3 a_2 = A_1 + new Vector3(0f, 0f, 0.1f);
					HorizontalDirection? a_3 = null;
					string a_4 = "Psi";
					int a_5 = 1;
					double maxValue = double.MaxValue;
					float? a_6 = dz6.b();
					c5x c5x = boj.a(a_, a_2, a_3, a_4, a_5, maxValue, null, null, a_6, null);
					e4o e4o = new e4o(c5x);
					e4o.a(150);
					e4o.b(0);
					e4o.a(dz6.a(0.4));
					qy qy = new qy();
					qy.ad().Add(e4o);
					qy.ad().Add(new c7(c5x, false, false, true, false));
					c5x.Zone.ActionManager.g9(qy, atp.a);
				}
			}
			return false;
		}

		// Token: 0x06007C45 RID: 31813 RVA: 0x00343F60 File Offset: 0x00342160
		protected b(SerializationInfo A_0, StreamingContext A_1)
		{
			this.b = (ar7)A_0.GetValue("XSMa:ER", typeof(ar7));
			this.c = A_0.GetSingle("XSMa:DC");
		}

		// Token: 0x06007C46 RID: 31814 RVA: 0x00343F9C File Offset: 0x0034219C
		public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("XSMa:ER", this.b);
			info.AddValue("XSMa:DC", this.c);
		}

		// Token: 0x04003156 RID: 12630
		private const float a = 0.1f;

		// Token: 0x04003157 RID: 12631
		private ar7 b;

		// Token: 0x04003158 RID: 12632
		private float c;
	}

	// Token: 0x02001614 RID: 5652
	[eiz("XSMb")]
	[Serializable]
	private sealed class c : aig, ISerializable, enp
	{
		// Token: 0x06007C47 RID: 31815 RVA: 0x00343FC4 File Offset: 0x003421C4
		private c(SerializationInfo A_0, StreamingContext A_1)
		{
			this.b = A_0.GetSingle("XSMb:D");
			this.c = (a1q)A_0.GetValue("XSMb:B", typeof(a1q));
			this.d = (A_0.GetValue("XSMb:A", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
			this.e = (A_0.GetValue("XSMb:T", typeof(HashSet<Point>)) as HashSet<Point>);
			this.f = (A_0.GetValue("XSMb:E", typeof(HashSet<Guid>)) as HashSet<Guid>);
		}

		// Token: 0x06007C48 RID: 31816 RVA: 0x00344080 File Offset: 0x00342280
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("XSMb:D", this.b);
			info.AddValue("XSMb:B", this.c);
			info.AddValue("XSMb:A", this.d);
			info.AddValue("XSMb:T", this.e);
			info.AddValue("XSMb:E", this.f);
		}

		// Token: 0x06007C49 RID: 31817 RVA: 0x003440E8 File Offset: 0x003422E8
		public c(a1q A_0, amc A_1)
		{
			this.c = A_0;
			this.d = new EntityAspectReference<amc, amc>(A_1);
		}

		// Token: 0x06007C4A RID: 31818 RVA: 0x0034411C File Offset: 0x0034231C
		public bool hj(b0b A_0, Vector3 A_1, Vector3 A_2, float A_3)
		{
			if (this.d.ao() != null && A_0 != null && A_0.Area != null)
			{
				Point point = A_0.aj().a();
				if (!this.e.Contains(point))
				{
					ak1 ak = A_0.Area.a(point);
					if (ak != null)
					{
						foreach (b0b b0b in ak.c.Values)
						{
							c5x c5x = (c5x)b0b;
							if (c5x.h.b != null && !this.f.Contains(c5x.qe()))
							{
								if (c5x.h.b != this.d.ao())
								{
									dtb dtb = new dtb();
									dtb.b(false);
									dtb.c(false);
									List<auv> list = dtb.ad();
									c5x a_ = c5x;
									string a_2 = "Psi";
									int a_3 = 1;
									double maxValue = double.MaxValue;
									bool a_4 = true;
									bool a_5 = true;
									float? a_6 = dz6.b();
									list.Add(new a7j(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false, null));
									dtb.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "TelekineticProxyHit"), null, new ar7(c5x), null));
									eym.a(dtb, c5x, (double)aju.bn);
									dtb.ad().Add(new akg(this.d.ao(), c5x.h.b, this.a(c5x.h.b), this, false));
									awq.a(dtb, this.d.ao().a8(), c5x, true, true);
									c5x.Zone.ActionManager.g9(dtb, atp.a);
									dz6.a(dtb);
								}
								this.f.Add(c5x.qe());
							}
						}
					}
					this.e.Add(point);
				}
			}
			return false;
		}

		// Token: 0x06007C4B RID: 31819 RVA: 0x00344358 File Offset: 0x00342558
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_0 != null && A_0.aa().Feats.Contains<ns>() && A_1 != null && !A_1.aa().Dead && !A_1.aa().b(d8o.e) && !A_1.aa().Passive && cuo.a.NextDouble() < ns.a + (double)A_0.aa().GetSpecializationValue<e4j>(true) * e4j.a)
			{
				if (!A_1.aa().d(CharacterImmunities.Daze))
				{
					eok a_ = new eok(ns.b * d0u.b);
					A_1.aa().StatusEffects.a(a_, false, false, false);
					vr a_2 = new vr(new ap9(A_1.aa()), new ap9(A_0.aa()), "{0}: дезориентация.", new Color?(adi.j), null);
					bey.a(a_2, A_0.aa(), A_1.aa(), A_1);
					a7v.a(a_2);
					return;
				}
				etm a_3 = new etm(new ap9(A_1.aa()), "дезориентации");
				bey.a(a_3, A_0.aa(), A_1.aa(), A_1);
				a7v.a(a_3);
				bmj.a(A_1.a8(), new ba0());
			}
		}

		// Token: 0x06007C4C RID: 31820 RVA: 0x003444A0 File Offset: 0x003426A0
		private cwt a(amc A_0)
		{
			cwt cwt = new cwt();
			cwt.b = true;
			cwt.f.Add(euf.a(this.c, 1.0));
			cwt.v = "telekinetic proxy";
			cwt.h = ImpactSpeed.Low;
			cwt.ad["PsionicSource"] = PsiSchool.Psychokinesis;
			if (this.d.ao() != null)
			{
				cwt.i = new ap9(this.d.ao().aa());
			}
			cwt.j = new ap9(A_0.aa());
			return cwt;
		}

		// Token: 0x04003159 RID: 12633
		private const float a = 1.5f;

		// Token: 0x0400315A RID: 12634
		private float b;

		// Token: 0x0400315B RID: 12635
		private a1q c;

		// Token: 0x0400315C RID: 12636
		private EntityAspectReference<amc, amc> d;

		// Token: 0x0400315D RID: 12637
		private HashSet<Point> e = new HashSet<Point>();

		// Token: 0x0400315E RID: 12638
		private HashSet<Guid> f = new HashSet<Guid>();
	}
}
