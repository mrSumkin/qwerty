using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200105A RID: 4186
[eiz("LVFBDJ")]
[Serializable]
public sealed class c75 : cze, ISerializable
{
	// Token: 0x060056EB RID: 22251 RVA: 0x00260DCC File Offset: 0x0025EFCC
	private c75(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060056EC RID: 22252 RVA: 0x00260DD8 File Offset: 0x0025EFD8
	public c75()
	{
	}

	// Token: 0x060056ED RID: 22253 RVA: 0x00260DE4 File Offset: 0x0025EFE4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.p.b != null && c5x.p.b.a.Count == 2 && c5x.h.b != null)
		{
			bool flag = c5x.a();
			axh aspect = c5x.GetAspect<axh>();
			if (aspect != null)
			{
				aspect.a(null, false, null);
			}
			List<amc> list = new List<amc>();
			if (flag)
			{
				d02 serviceOrThrow = bpo.GetServiceOrThrow<d02>();
				if (serviceOrThrow != null)
				{
					foreach (d4n d4n in serviceOrThrow.ahl())
					{
						if (d4n.b != null && d4n.b.a8() != null && d4n.b.a8().t.b != null && d4n.b.a8().t.b.b(c5x.h.b, false) && aw1.b(c5x, d4n.b.a8()) <= 2.5)
						{
							list.Add(d4n.b);
						}
					}
				}
			}
			try
			{
				c5k c5k = bpo.GetServiceOrThrow<d6j>().dv().a("locale\\objects\\devices\\Xpbl_LemurianVolatileFuseBoxRemains");
				if (c5k != null)
				{
					c5x c5x2 = c5k.a(null, false) as c5x;
					c5x2.o.b.b = new Point(c5x.p.b.a[0].b.X, 1);
					c5x2.VisualPriority = c5x.VisualPriority;
					c5x2.Location = c5x.Location;
					c5x2.Size = c5x.Size;
					c5x2.TileFormationModifiers = new bjp(c5x.TileFormationModifiers.b);
					c5x.Area.a(c5x2);
					string str;
					if (c5x.p.b.a[0].b.X == 1)
					{
						str = "X";
					}
					else
					{
						str = "Y";
					}
					if (flag)
					{
						c5x a_ = c5x2;
						string a_2 = "Xpbl_LemurianVolatileFuseBoxExplosion" + str;
						int a_3 = 1;
						double maxValue = double.MaxValue;
						bool a_4 = false;
						bool a_5 = false;
						float? a_6 = dz6.b();
						boj.a(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false);
						c5x2.c().a("death", "Xpbl_LemurianVolatileFuseBoxDeath", 1f, c9z.a, false, false);
						a1q a_7 = new a1q(DamageType.Electricity, 100, 250);
						dtb dtb = new dtb();
						dtb.ad().Add(new bm3(dz6.b(100)));
						cwt cwt = null;
						if (A_2 != null && A_2.ContainsKey("killingBlow"))
						{
							cwt = (A_2["killingBlow"] as cwt);
						}
						bool a_8 = cwt != null && cwt.i != null && cwt.i.b == asp.a;
						foreach (amc amc in list)
						{
							cwt cwt2 = new cwt();
							cwt2.b = true;
							cwt2.f.Add(euf.a(a_7, 1.0));
							cwt2.v = "электроказнь";
							cwt2.h = ImpactSpeed.VeryHigh;
							cwt2.j = new ap9(amc.aa());
							if (cwt != null && cwt.i != null)
							{
								cwt2.i = cwt.i.b();
							}
							dtb.b(false);
							dtb.c(false);
							List<auv> list2 = dtb.ad();
							c5x a_9 = amc.a8();
							string a_10 = "Electricity";
							int maxValue2 = int.MaxValue;
							double a_11 = (double)dz6.b(300);
							bool a_12 = true;
							bool a_13 = true;
							a_6 = dz6.b();
							list2.Add(new a7j(a_9, a_10, maxValue2, a_11, a_12, a_13, null, null, null, a_6, false, null));
							dtb.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "Electroshock"), null, new ar7(amc.a8()), null));
							eym.a(dtb, amc.a8(), (double)aju.bf);
							dtb.ad().Add(new akg(null, amc, cwt2, new c75.a(a_8), false));
						}
						c5x.Zone.ActionManager.g9(dtb, atp.a);
						dz6.a(dtb);
					}
					else
					{
						c5x a_14 = c5x2;
						string a_15 = "Xpbl_LemurianVolatileFuseBoxExplosion" + str;
						int a_16 = 1;
						double maxValue3 = double.MaxValue;
						bool a_17 = false;
						bool a_18 = false;
						float? a_6 = dz6.b();
						float? a_19 = new float?(0.5f);
						boj.a(a_14, a_15, a_16, maxValue3, a_17, a_18, null, null, a_19, a_6, false);
						c5x2.c().a("death", "Xpbl_LemurianVolatileFuseBoxDeath", 0.65f, c9z.a, false, false);
					}
				}
			}
			catch
			{
			}
		}
	}

	// Token: 0x0200105B RID: 4187
	[eiz("LVFBDJa")]
	[Serializable]
	private new class a : enp, ISerializable
	{
		// Token: 0x060056EE RID: 22254 RVA: 0x002613A0 File Offset: 0x0025F5A0
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = A_0.GetBoolean("LVFBDJa:P");
		}

		// Token: 0x060056EF RID: 22255 RVA: 0x002613BC File Offset: 0x0025F5BC
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("LVFBDJa:P", this.a);
		}

		// Token: 0x060056F0 RID: 22256 RVA: 0x002613D0 File Offset: 0x0025F5D0
		public a(bool A_0)
		{
			this.a = A_0;
		}

		// Token: 0x060056F1 RID: 22257 RVA: 0x002613E0 File Offset: 0x0025F5E0
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && A_3 != null && !A_3.c && A_3.a != null)
			{
				if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(c75.a.a.a.a)), new Func<csk, int>(c75.a.a.a.b)) > 0)
				{
					if (A_1.aa().Passive || (A_1.aa().c(d8o.e) && A_1.aa().d(CharacterImmunities.ShortCircuiting)) || (!A_1.aa().c(d8o.e) && A_1.aa().d(CharacterImmunities.Stun)))
					{
						etm a_;
						if (A_1.aa().c(d8o.e))
						{
							a_ = new etm(new ap9(A_1.aa()), "короткому замыканию");
						}
						else
						{
							a_ = new etm(new ap9(A_1.aa()), "оглушению");
						}
						bey.a(a_, A_1.aa(), A_1);
						a7v.a(a_);
						bmj.a(A_1.a8(), new ba0());
						return;
					}
					els els = awq.a(A_1.aa(), d0u.b);
					A_1.aa().StatusEffects.a(els, false, false, false);
					if (this.a && (els is ab3 || els is clt))
					{
						if (A_1.aa().c(d8o.e))
						{
							cxc.a(eyy.bz);
							return;
						}
						cxc.a(eyy.by);
					}
				}
			}
		}

		// Token: 0x0400233A RID: 9018
		private bool a;

		// Token: 0x0200105D RID: 4189
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x060056F5 RID: 22261 RVA: 0x002615B4 File Offset: 0x0025F7B4
			internal bool a(csk A_0)
			{
				return A_0.DamageType == DamageType.Electricity;
			}

			// Token: 0x060056F6 RID: 22262 RVA: 0x002615C0 File Offset: 0x0025F7C0
			internal int b(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x0400233B RID: 9019
			public static readonly c75.a.a a = new c75.a.a();

			// Token: 0x0400233C RID: 9020
			public static Func<csk, bool> b;

			// Token: 0x0400233D RID: 9021
			public static Func<csk, int> c;
		}
	}
}
