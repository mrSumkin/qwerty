using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200157C RID: 5500
[eiz("S24")]
[Serializable]
public sealed class e7d : d64, ISerializable
{
	// Token: 0x06007A48 RID: 31304 RVA: 0x003329B0 File Offset: 0x00330BB0
	private e7d(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007A49 RID: 31305 RVA: 0x003329BC File Offset: 0x00330BBC
	public e7d()
	{
	}

	// Token: 0x06007A4A RID: 31306 RVA: 0x003329C8 File Offset: 0x00330BC8
	protected override bool gq()
	{
		if (!base.gq())
		{
			return false;
		}
		awq.a(base.c().aa());
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			double a_ = aw1.b(base.c().a8(), base.b().a8());
			double a_2 = awq.a(base.vg().e(), base.b(), a_);
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), a_, awq.a(base.c(), base.b(), null, null), 0.0, base.b().a8().l(), base.c().aa().Darkvision, cd.CurrentBullet, awq.f(base.c()), a_2, false, null, null, true, null);
			double a_3;
			if (cwt.e)
			{
				a_3 = 1.0 + base.c().aa().Offense.am();
			}
			else
			{
				a_3 = 1.0;
			}
			int a_4 = eyv.a(base.vg().e().b9() as coh);
			cwt.f.Add(euf.a(ers.a(base.vg().e().b8(), a_4), a_3));
			awq.a(base.c(), base.b(), cwt, cd, new e7d.a(this, a_4), true, null, null, null, false, false, true, null, null);
			return true;
		}
		return false;
	}

	// Token: 0x0200157D RID: 5501
	[eiz("S24a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x06007A4B RID: 31307 RVA: 0x00332BC4 File Offset: 0x00330DC4
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("S24a:P", typeof(e7d)) as e7d);
			this.b = A_0.GetInt32("S24a:O");
		}

		// Token: 0x06007A4C RID: 31308 RVA: 0x00332C00 File Offset: 0x00330E00
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("S24a:P", this.a);
			info.AddValue("S24a:O", this.b);
		}

		// Token: 0x06007A4D RID: 31309 RVA: 0x00332C24 File Offset: 0x00330E24
		public a(e7d A_0, int A_1)
		{
			this.a = A_0;
			this.b = A_1;
		}

		// Token: 0x06007A4E RID: 31310 RVA: 0x00332C3C File Offset: 0x00330E3C
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && A_2.b)
			{
				dtb dtb = new dtb();
				dtb.b(false);
				dtb.c(false);
				List<auv> list = dtb.ad();
				c5x a_ = A_1.a8();
				string a_2 = "Electricity";
				int maxValue = int.MaxValue;
				double a_3 = (double)dz6.b(300);
				bool a_4 = true;
				bool a_5 = true;
				float? a_6 = dz6.b();
				list.Add(new a7j(a_, a_2, maxValue, a_3, a_4, a_5, null, null, null, a_6, false, null));
				dtb.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "Electroshock"), null, new ar7(A_1.a8()), null));
				eym.a(dtb, A_1.a8(), (double)aju.bf);
				if (A_3.a != null)
				{
					if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(e7d.a.a.a.b)), new Func<csk, int>(e7d.a.a.a.a)) > 0)
					{
						if (A_1.aa().Passive || (A_1.aa().c(d8o.e) && A_1.aa().d(CharacterImmunities.ShortCircuiting)) || (!A_1.aa().c(d8o.e) && A_1.aa().d(CharacterImmunities.Stun)))
						{
							if (A_0 != null)
							{
								etm a_7;
								if (A_1.aa().c(d8o.e))
								{
									a_7 = new etm(new ap9(A_1.aa()), "короткому замыканию");
								}
								else
								{
									a_7 = new etm(new ap9(A_1.aa()), "оглушению");
								}
								bey.a(a_7, A_0.aa(), A_1.aa(), A_1);
								a7v.a(a_7);
							}
							bmj.a(A_1.a8(), new ba0());
						}
						else
						{
							els els;
							if (A_1.aa().c(d8o.e))
							{
								els = new clt(ers.a * d0u.b);
								if (A_0.aa() is e3q && !(A_1.aa() is e3q))
								{
									cxc.a(eyy.bz);
								}
							}
							else
							{
								els = awq.a(A_1.aa(), ers.a * d0u.b);
								if (A_0.aa() is e3q && !(A_1.aa() is e3q) && els is ab3)
								{
									cxc.a(eyy.by);
								}
							}
							dtb.ad().Add(new amd(A_1, new els[]
							{
								els
							}));
						}
						List<amc> list2 = aw1.a(A_1.a8(), 1);
						if (list2.Count > 0)
						{
							dtb.ad().Add(new bm3(dz6.b(150)));
							bool a_8 = false;
							double a_9;
							if (A_0 != null && A_2.e)
							{
								a_9 = 1.0 + A_0.aa().Offense.am();
								a_8 = true;
							}
							else
							{
								a_9 = 1.0;
							}
							a1q a_10 = ers.b(this.a.vg().e().b8(), this.b);
							foreach (amc amc in list2)
							{
								List<auv> list3 = dtb.ad();
								c5x a_11 = amc.a8();
								string a_12 = "Electricity";
								int maxValue2 = int.MaxValue;
								double a_13 = (double)dz6.b(300);
								bool a_14 = true;
								bool a_15 = true;
								a_6 = dz6.b();
								list3.Add(new a7j(a_11, a_12, maxValue2, a_13, a_14, a_15, null, null, null, a_6, false, null));
								dtb.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "Electroshock"), null, new ar7(amc.a8()), null));
								dtb.ad().Add(new akg(A_0, amc, this.a(A_0.aa(), a_10, amc, a_9, a_8), new b7x(null), false));
								dtb.ad().Add(new bm3(dz6.b(50)));
							}
						}
					}
				}
				A_1.a8().Zone.ActionManager.g9(dtb, atp.a);
				dz6.a(dtb);
			}
		}

		// Token: 0x06007A4F RID: 31311 RVA: 0x003330EC File Offset: 0x003312EC
		private cwt a(efk A_0, a1q A_1, amc A_2, double A_3, bool A_4)
		{
			return new cwt
			{
				b = true,
				e = A_4,
				f = 
				{
					euf.a(A_1, A_3)
				},
				v = "электрошок",
				h = ImpactSpeed.VeryHigh,
				i = new ap9(A_0),
				j = new ap9(A_2.aa()),
				ae = new WeaponSubtype?(WeaponSubtype.Crossbow)
			};
		}

		// Token: 0x040030EA RID: 12522
		private e7d a;

		// Token: 0x040030EB RID: 12523
		private int b;

		// Token: 0x0200157E RID: 5502
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007A52 RID: 31314 RVA: 0x00333170 File Offset: 0x00331370
			internal bool b(csk A_0)
			{
				return A_0.DamageType == DamageType.Electricity;
			}

			// Token: 0x06007A53 RID: 31315 RVA: 0x0033317C File Offset: 0x0033137C
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x040030EC RID: 12524
			public static readonly e7d.a.a a = new e7d.a.a();

			// Token: 0x040030ED RID: 12525
			public static Func<csk, bool> b;

			// Token: 0x040030EE RID: 12526
			public static Func<csk, int> c;
		}
	}
}
