using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001617 RID: 5655
[eiz("L88")]
[Serializable]
public sealed class ci9 : a6k, ISerializable
{
	// Token: 0x06007C55 RID: 31829 RVA: 0x00344BF4 File Offset: 0x00342DF4
	private ci9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 302)
		{
			this.a = A_0.GetBoolean("L88:C");
		}
	}

	// Token: 0x06007C56 RID: 31830 RVA: 0x00344C20 File Offset: 0x00342E20
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("L88:C", this.a);
	}

	// Token: 0x06007C57 RID: 31831 RVA: 0x00344C3C File Offset: 0x00342E3C
	public ci9()
	{
	}

	// Token: 0x06007C58 RID: 31832 RVA: 0x00344C44 File Offset: 0x00342E44
	protected override dc4 dt()
	{
		return base.dt();
	}

	// Token: 0x06007C59 RID: 31833 RVA: 0x00344C50 File Offset: 0x00342E50
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead)
		{
			return dc4.e;
		}
		aw1.b(base.vg().q().h.b.a8(), c5x, false);
		qy qy = new qy();
		qy.b(false);
		qy.c(false);
		b0b b0b = null;
		dvv item = es2.a(base.vg().q(), c5x, "Electrobolt", 0.5f, null, out b0b, true, 0.5f);
		if (b0b != null && b0b.Zone != null)
		{
			this.a = base.vg().e().b8().StatusEffects.a(b0c.a);
			qy.ad().Add(item);
			c7 item2 = new c7(b0b, false, false, true, false);
			qy.ad().Add(item2);
			awq.a(qy, base.vg().q(), c5x, true, true);
			int a_ = 0;
			ah8 ah = Enumerable.FirstOrDefault<ah8>(base.vg().e().b8().StatusEffects.Get<ah8>());
			if (ah != null)
			{
				a_ = ah.Stacks;
				base.vg().e().b8().StatusEffects.d(ah);
			}
			cwt cwt = this.a(base.vg().q().h.b.aa(), c5x.h.b.aa(), a_, 0);
			a3f aspect = base.vg().q().GetAspect<a3f>();
			if (aspect != null && aspect.a().GetPrimitivePropertyValue<bool>("SingleTargetElectrokinesis", new bool?(false)).Value)
			{
				cwt.ad["JumpsAllowed"] = false;
			}
			bm6 aspect2 = base.vg().q().GetAspect<bm6>();
			if (aspect2 != null && aspect2.ad().GetPrimitivePropertyValue<bool>("SingleTargetElectrokinesis", new bool?(false)).Value)
			{
				cwt.ad["JumpsAllowed"] = false;
			}
			akg akg = new akg(base.vg().q().h.b, c5x.h.b, cwt, null, false);
			qy.ad().Add(akg);
			akg.q(new EventHandler<EventArgs>(this.a));
			bfq bfq = new bfq();
			bfq.b("electroshock" + Guid.NewGuid().ToString());
			bfq.c("Electroshock");
			qy.ad().Add(new a4s(bfq, null, new ar7(c5x), null));
			eym.a(qy, c5x, (double)aju.bf);
			c5x a_2 = c5x;
			string a_3 = "Electricity";
			int a_4 = 1;
			double maxValue = double.MaxValue;
			bool a_5 = true;
			bool a_6 = true;
			float? a_7 = dz6.b();
			a7j item3 = new a7j(a_2, a_3, a_4, maxValue, a_5, a_6, null, null, null, a_7, false, null);
			qy.ad().Add(item3);
			qy.ad().Add(new duh(base.vg().q().h.b, new string[]
			{
				b0c.a
			}));
			base.vg().q().c().a("launchElectrobolt" + Guid.NewGuid().ToString(), "LaunchElectrobolt", 1f, c9z.a, false, false);
			eym.a(base.vg().q(), (double)aju.ao);
			b0b.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x06007C5A RID: 31834 RVA: 0x00345044 File Offset: 0x00343244
	private cwt a(efk A_0, efk A_1, int A_2, int A_3)
	{
		bas bas = A_0.Offense.ag()[PsiSchool.Psychokinesis];
		a1q a_ = dl3.a(base.vg().e(), A_2, A_3);
		cwt cwt = new cwt();
		cwt.b = true;
		cwt.e = (!A_1.ImmuneToCriticalHits && (this.a || euf.a(euf.a(bas, A_1))));
		cwt.i = new ap9(A_0);
		cwt.j = new ap9(A_1);
		cwt.f = new List<csk>();
		cwt.f.Add(euf.a(a_, (double)(1f + (cwt.e ? bas.g() : 0f))));
		cwt.h = ImpactSpeed.VeryHigh;
		cwt.k = "Электрокинез";
		cwt.ac = new object[]
		{
			A_3
		};
		cwt.ad["PsionicSource"] = PsiSchool.Psychokinesis;
		cwt.ad["BonusDamage"] = A_2;
		return cwt;
	}

	// Token: 0x06007C5B RID: 31835 RVA: 0x00345164 File Offset: 0x00343364
	[dcc("L88:mARA_F")]
	private void a(object A_0, EventArgs A_1)
	{
		akg akg = A_0 as akg;
		if (akg == null || akg.b() == null || akg.b().a == null || akg.b().a.Count == 0 || akg.m() == null || akg.n() == null)
		{
			return;
		}
		c5x c5x = akg.m().a8();
		if (c5x == null || c5x.h.b == null || c5x.Zone == null || base.vg().q() == null || base.vg().q().h.b == null)
		{
			return;
		}
		if (Enumerable.Sum<csk>(Enumerable.Where<csk>(akg.b().a, new Func<csk, bool>(ci9.a.a.b)), new Func<csk, int>(ci9.a.a.a)) > 0)
		{
			if (base.vg().q().h.b.aa().Feats.Contains<e59>())
			{
				c5x.h.b.aa().StatusEffects.a(new cyi(base.vg().e().b8()), false, false, false);
			}
			dtb dtb = new dtb();
			dtb.b(false);
			dtb.c(false);
			efk efk = c5x.h.b.aa();
			int num = 0;
			bool value = akg.d().ad.GetPrimitivePropertyValue<bool>("JumpsAllowed", new bool?(true)).Value;
			if (akg.d() != null && akg.d().ac != null && akg.d().ac.Length >= 1 && akg.d().ac[0] is int)
			{
				num = (int)akg.d().ac[0];
			}
			if (!c5x.h.b.aa().Dead && num == 0)
			{
				if (efk.Passive || (efk.c(d8o.e) && efk.d(CharacterImmunities.ShortCircuiting)) || (!efk.c(d8o.e) && efk.d(CharacterImmunities.Stun)))
				{
					c5x c5x2 = base.vg().q();
					if (c5x2 != null && c5x2.h.b != null)
					{
						etm a_;
						if (efk.c(d8o.e))
						{
							a_ = new etm(new ap9(efk), "короткому замыканию");
						}
						else
						{
							a_ = new etm(new ap9(efk), "оглушению");
						}
						bey.a(a_, c5x2.h.b.aa(), efk, c5x.h.b);
						a7v.a(a_);
					}
					bmj.a(c5x, new ba0());
				}
				else
				{
					els els;
					if (efk.c(d8o.e))
					{
						els = new clt(dl3.f * d0u.b);
						if (base.vg().q().IsPlayer && !c5x.IsPlayer)
						{
							cxc.a(eyy.bz);
						}
					}
					else
					{
						els = awq.a(c5x.h.b.aa(), dl3.f * d0u.b);
						if (base.vg().q().IsPlayer && !c5x.IsPlayer && els is ab3)
						{
							cxc.a(eyy.by);
						}
					}
					dtb.ad().Add(new amd(c5x.h.b, new els[]
					{
						els
					}));
				}
			}
			if (num < dl3.d && value)
			{
				c5x c5x3 = null;
				d02 service = bpo.GetService<d02>();
				if (service != null)
				{
					bool flag = false;
					HashSet<c5x> hashSet = new HashSet<c5x>();
					if (c5x.t.b != null)
					{
						HashSet<r0> hashSet2 = c5x.t.b.b(service);
						if (hashSet2 != null && hashSet2.Count > 0)
						{
							flag = true;
							foreach (r0 r in hashSet2)
							{
								ak1 ak = c5x.Area.a(r.a.a());
								if (ak != null)
								{
									double num2 = aw1.a(c5x, ak);
									double num3 = 4.0;
									kl.a(ref num3, base.vg().e().b8());
									if (num2 <= num3)
									{
										foreach (b0b b0b in ak.c.Values)
										{
											c5x c5x4 = (c5x)b0b;
											if (c5x4 != base.vg().q() && c5x4 != c5x && c5x4.h.b != null && !c5x4.h.b.aa().Dead && euf.d(c5x4.h.b.aa()))
											{
												hashSet.Add(c5x4);
											}
										}
									}
								}
							}
						}
					}
					if (!flag)
					{
						foreach (d4n d4n in service.ahl())
						{
							if (d4n.b != null && !d4n.b.aa().Dead && euf.d(d4n.b.aa()) && d4n.b.a8() != null && d4n.b != c5x.h.b && d4n.b != base.vg().q().h.b && d4n.b.a8().t.b != null && d4n.b.a8().Zone == c5x.Zone)
							{
								double num4 = aw1.b(d4n.b.a8(), c5x);
								double num5 = 4.0;
								kl.a(ref num5, base.vg().e().b8());
								if (num4 <= num5 && d4n.b.a8().t.b.b(c5x.h.b, false))
								{
									hashSet.Add(d4n.b.a8());
								}
							}
						}
					}
					if (hashSet.Count > 0)
					{
						c5x3 = Enumerable.ToList<c5x>(hashSet)[cuo.a.Next(hashSet.Count)];
					}
				}
				if (c5x3 != null)
				{
					b0b b0b2 = null;
					Vector3 a_2 = c5x.Location + new Vector3(0f, 0f, c5x.Size.Z * 0.9f);
					Vector3 a_3 = c5x3.Location + new Vector3(0f, 0f, c5x3.Size.Z * 0.9f);
					dvv item = es2.a(a_2, a_3, c5x3.Area, "Electrobolt", null, out b0b2);
					if (b0b2 != null && b0b2.Zone != null)
					{
						dtb.ad().Add(item);
						c7 item2 = new c7(b0b2, false, false, true, false);
						dtb.ad().Add(item2);
						awq.a(dtb, base.vg().q(), c5x3, true, true);
						int a_4 = 0;
						if (akg != null && akg.d() != null)
						{
							a_4 = akg.d().ad.GetPrimitivePropertyValue<int>("BonusDamage", null).Value;
						}
						cwt a_5 = this.a(base.vg().q().h.b.aa(), c5x3.h.b.aa(), a_4, num + 1);
						akg akg2 = new akg(base.vg().q().h.b, c5x3.h.b, a_5, null, false);
						dtb.ad().Add(akg2);
						akg2.q(new EventHandler<EventArgs>(this.a));
						bfq bfq = new bfq();
						bfq.b("electroshock" + Guid.NewGuid().ToString());
						bfq.c("Electroshock");
						dtb.ad().Add(new a4s(bfq, null, new ar7(c5x3), null));
						eym.a(dtb, c5x3, (double)aju.bf);
						c5x a_6 = c5x3;
						string a_7 = "Electricity";
						int a_8 = 1;
						double maxValue = double.MaxValue;
						bool a_9 = true;
						bool a_10 = true;
						float? a_11 = dz6.b();
						a7j item3 = new a7j(a_6, a_7, a_8, maxValue, a_9, a_10, null, null, null, a_11, false, null);
						dtb.ad().Add(item3);
					}
				}
			}
			c5x.Zone.ActionManager.g9(dtb, atp.a);
			dz6.a(dtb);
		}
	}

	// Token: 0x04003162 RID: 12642
	private new bool a;

	// Token: 0x02001618 RID: 5656
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007C5E RID: 31838 RVA: 0x00345B48 File Offset: 0x00343D48
		internal bool b(csk A_0)
		{
			return A_0.DamageType == DamageType.Electricity;
		}

		// Token: 0x06007C5F RID: 31839 RVA: 0x00345B54 File Offset: 0x00343D54
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04003163 RID: 12643
		public static readonly ci9.a a = new ci9.a();

		// Token: 0x04003164 RID: 12644
		public static Func<csk, bool> b;

		// Token: 0x04003165 RID: 12645
		public static Func<csk, int> c;
	}
}
