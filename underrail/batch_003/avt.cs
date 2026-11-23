using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Items;

// Token: 0x0200158D RID: 5517
[eiz("BTA")]
[Serializable]
public sealed class avt : a6k, ISerializable
{
	// Token: 0x06007A87 RID: 31367 RVA: 0x00334674 File Offset: 0x00332874
	private avt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid)A_0.GetValue("BTA:I", typeof(Guid));
		if (ell.a() >= 682)
		{
			this.b = A_0.GetBoolean("BTA:B");
		}
	}

	// Token: 0x06007A88 RID: 31368 RVA: 0x003346D0 File Offset: 0x003328D0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("BTA:I", this.a);
		info.AddValue("BTA:B", this.b);
	}

	// Token: 0x06007A89 RID: 31369 RVA: 0x00334704 File Offset: 0x00332904
	public avt()
	{
		this.a = Guid.NewGuid();
	}

	// Token: 0x06007A8A RID: 31370 RVA: 0x00334720 File Offset: 0x00332920
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		amc amc = base.vg().q().h.b;
		c5x c5x = base.vg().h() as c5x;
		amc amc2 = (c5x != null) ? c5x.h.b : null;
		amc amc3 = amc2;
		if (amc == null || amc.a8() == null || amc2 == null || amc2.a8() == null)
		{
			return dc4.e;
		}
		cd1 cd = amc.aa().Offense.u();
		bke bke = cd.TypedDefinition;
		if (bke == null || amc2.a8().j != cgy.b || amc2.a8().Area != amc.a8().Area)
		{
			return dc4.e;
		}
		avt.a(amc, amc2);
		double num = aw1.b(amc.a8(), amc2.a8());
		if (num > (double)(bke.ad() + 1f))
		{
			return dc4.e;
		}
		double num2 = c91.a(num, bke);
		bool flag = false;
		d5g d5g = Enumerable.FirstOrDefault<d5g>(Enumerable.OfType<d5g>(base.vg().ad()));
		if (d5g != null)
		{
			boa boa = Enumerable.FirstOrDefault<boa>(Enumerable.OfType<boa>(d5g.ad()));
			if (boa != null && boa.Validators != null)
			{
				e71 e = Enumerable.FirstOrDefault<e71>(Enumerable.OfType<e71>(boa.Validators));
				if (e != null && e.LastImprintedNodes != null)
				{
					HashSet<amc> hashSet = avt.a(amc, amc2, bke.ad());
					if (hashSet.Count > 0)
					{
						Vector2 a_ = amc.a8().aj().b();
						List<amc> list = new List<amc>();
						foreach (amc amc4 in hashSet)
						{
							if (e.LastImprintedNodes.Contains(amc4.a8().aj().a()))
							{
								double num3 = aw1.b(amc.a8(), amc4.a8());
								int valueOrDefault = bke.x().GetValueOrDefault(36);
								double num4 = bnx.a(a_, amc2.a8().aj().b(), amc4.a8().aj().b());
								if (num3 <= (double)(bke.ad() + 1f) && num4 <= (double)(valueOrDefault / 2))
								{
									list.Add(amc4);
									avt.a(amc, amc4);
								}
							}
						}
						if (cuo.a.NextDouble() < num2)
						{
							if (list.Count > 0)
							{
								amc2 = list[cuo.a.Next(list.Count)];
							}
							else
							{
								flag = true;
							}
						}
					}
				}
			}
		}
		AmmoType a_2 = cd.CurrentBullet;
		if (awq.a(amc, cd))
		{
			double a_3;
			if (flag)
			{
				a_3 = 0.0;
			}
			else
			{
				bon bon = base.vg().e().p() as bon;
				double a_4 = aw1.b(amc.a8(), amc2.a8());
				if (bon != null)
				{
					a_3 = bon.l9(new eoj(amc.aa(), cd, null), a_4);
				}
				else
				{
					a_3 = 1.0;
				}
			}
			cmn cmn = awq.a(amc, amc2, null, null);
			cmn.b += (double)amc.aa().GetSpecializationValue<be5>(true) * be5.a;
			cwt cwt = euf.a(amc.aa(), amc2.aa(), num, cmn, 0.0, amc2.a8().l(), amc.aa().Darkvision, a_2, awq.f(amc), a_3, false, null, null, true, null);
			if ((bke.e() == btz.c || bke.e() == btz.j || bke.e() == btz.k) && amc.aa().Feats.Contains<c12>())
			{
				b3i b3i = Enumerable.FirstOrDefault<b3i>(amc2.aa().StatusEffects.Get<b3i>());
				if (b3i != null)
				{
					double num5 = 1.0 + (double)b3i.Stacks * (c12.b + (double)b3i.Spec * enf.a);
					for (int i = 0; i < cwt.f.Count; i++)
					{
						csk csk = cwt.f[i];
						cwt.f[i] = new csk(csk.DamageType, (int)Math.Max(1.0, (double)csk.Amount * num5));
					}
				}
			}
			cwt.af = this.a;
			cwt.k = "Очередь";
			cwt.ad["IsBurst"] = true;
			if (bke.e() == btz.c || bke.e() == btz.j || bke.e() == btz.k)
			{
				cwt.ad["CanTriggerConcentratedFire"] = true;
			}
			bool flag2 = bke.e() == btz.j || bke.e() == btz.k;
			amc a_5 = amc;
			amc a_6 = amc2;
			cwt a_7 = cwt;
			cd1 a_8 = cd;
			enp a_9 = null;
			bool a_10 = amc2 != amc3;
			bool a_11 = amc2 != amc3 && !amc.a8().IsPlayer;
			awq.a(a_5, a_6, a_7, a_8, a_9, !flag2, null, null, null, a_10, a_11, true, null, null);
			if (flag2)
			{
				string a_12;
				if (this.b)
				{
					a_12 = "MachineGun_first";
				}
				else
				{
					a_12 = "MachineGun_" + cuo.a.Next(1, 9).ToString();
				}
				amc.a8().c().a(a_12);
				amc.a8().c().a("MachineGun_tail");
				if (this.b)
				{
					eym.a(amc.a8(), (double)aju.av);
				}
			}
			this.b = false;
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x06007A8B RID: 31371 RVA: 0x00334D4C File Offset: 0x00332F4C
	public static HashSet<amc> a(amc A_0, amc A_1, float A_2)
	{
		HashSet<amc> hashSet = new HashSet<amc>();
		if (A_1.a8() != null && A_0.a8() != null && A_1.a8().Area != null && A_0.a8().Area != null && !A_1.a8().TileFormationModifiers.c(4L))
		{
			foreach (b0b b0b in A_1.a8().Area.Entities)
			{
				c5x c5x = (c5x)b0b;
				if (c5x.h.b != null && c5x.h.b.a8().j == cgy.b && !c5x.h.b.aa().Dead && c5x.h.b != A_1 && c5x.h.b != A_0 && aw1.b(A_0.a8(), c5x) <= (double)(A_2 + 1f))
				{
					hashSet.Add(c5x.h.b);
				}
			}
		}
		return hashSet;
	}

	// Token: 0x06007A8C RID: 31372 RVA: 0x00334E98 File Offset: 0x00333098
	public static void a(amc A_0, amc A_1)
	{
		if ((A_0.aa().Feats.Contains<be1>() || A_0.aa().GetMicrofeat<tz>() != null) && A_0.a(A_1) == h.a && !A_1.aa().StatusEffects.a(cyw.a))
		{
			A_1.aa().StatusEffects.a(new cyw(be1.d * d0u.b, be1.a + (double)A_0.aa().GetSpecializationValue<blp>(true) * blp.a, be1.b + A_0.aa().GetSpecializationValue<cej>(true) * cej.a, be1.c + A_0.aa().GetSpecializationValue<clj>(true) * clj.a), false, false, false);
		}
	}

	// Token: 0x04003100 RID: 12544
	private new Guid a;

	// Token: 0x04003101 RID: 12545
	private bool b = true;
}
