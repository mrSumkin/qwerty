using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001830 RID: 6192
[eiz("PBTA")]
[Serializable]
public sealed class enc : a6k, ISerializable
{
	// Token: 0x060083FA RID: 33786 RVA: 0x003704B0 File Offset: 0x0036E6B0
	private enc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid)A_0.GetValue("PBTA:I", typeof(Guid));
	}

	// Token: 0x060083FB RID: 33787 RVA: 0x003704DC File Offset: 0x0036E6DC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PBTA:I", this.a);
	}

	// Token: 0x060083FC RID: 33788 RVA: 0x003704FC File Offset: 0x0036E6FC
	public enc()
	{
		this.a = Guid.NewGuid();
	}

	// Token: 0x060083FD RID: 33789 RVA: 0x00370510 File Offset: 0x0036E710
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		amc b = base.vg().q().h.b;
		c5x c5x = base.vg().h() as c5x;
		amc amc = (c5x != null) ? c5x.h.b : null;
		amc amc2 = amc;
		if (b == null || b.a8() == null || amc == null || amc.a8() == null)
		{
			return dc4.e;
		}
		cd1 cd = b.aa().Offense.u();
		bke bke = cd.TypedDefinition;
		if (bke == null || amc.a8().j != cgy.b || amc.a8().Area != b.a8().Area)
		{
			return dc4.e;
		}
		double num = aw1.b(b.a8(), amc.a8());
		if (num > (double)(bke.ad() + 1f))
		{
			return dc4.e;
		}
		double num2 = d54.a(num, bke);
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
					HashSet<amc> hashSet = enc.a(b, amc, bke.ad());
					if (hashSet.Count > 0)
					{
						Vector2 a_ = b.a8().aj().b();
						List<amc> list = new List<amc>();
						foreach (amc amc3 in hashSet)
						{
							if (e.LastImprintedNodes.Contains(amc3.a8().aj().a()))
							{
								double num3 = aw1.b(b.a8(), amc3.a8());
								double num4 = bnx.a(a_, amc.a8().aj().b(), amc3.a8().aj().b());
								if (num3 <= (double)(bke.ad() + 1f) && num4 <= 18.0)
								{
									list.Add(amc3);
								}
							}
						}
						if (cuo.a.NextDouble() < num2)
						{
							if (list.Count > 0)
							{
								amc = list[cuo.a.Next(list.Count)];
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
		if (awq.a(b, cd))
		{
			double a_3;
			if (flag)
			{
				a_3 = 0.0;
			}
			else
			{
				bon bon = base.vg().e().p() as bon;
				double a_4 = aw1.b(b.a8(), amc.a8());
				if (bon != null)
				{
					a_3 = bon.l9(new eoj(b.aa(), cd, null), a_4);
				}
				else
				{
					a_3 = 1.0;
				}
			}
			cmn a_5 = awq.a(b, amc, null, null);
			cwt cwt = euf.a(b.aa(), amc.aa(), num, a_5, 0.0, amc.a8().l(), b.aa().Darkvision, a_2, awq.f(b), a_3, false, null, null, true, null);
			cwt.af = this.a;
			cwt.k = "Очередь";
			if (bke.e() == btz.c || bke.e() == btz.j || bke.e() == btz.k)
			{
				cwt.ad["CanTriggerConcentratedFire"] = true;
			}
			amc a_6 = b;
			amc a_7 = amc;
			cwt a_8 = cwt;
			cd1 a_9 = cd;
			enp a_10 = null;
			bool a_11 = true;
			bool a_12 = amc != amc2;
			bool a_13 = amc != amc2 && !b.a8().IsPlayer;
			awq.a(a_6, a_7, a_8, a_9, a_10, a_11, null, null, null, a_12, a_13, true, null, null);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x060083FE RID: 33790 RVA: 0x00370950 File Offset: 0x0036EB50
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

	// Token: 0x040032A6 RID: 12966
	private new Guid a;
}
