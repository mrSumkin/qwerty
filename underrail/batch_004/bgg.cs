using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001BFB RID: 7163
public sealed class bgg
{
	// Token: 0x06009BED RID: 39917 RVA: 0x003D283C File Offset: 0x003D0A3C
	public static cn5 b(AmmoType A_0)
	{
		cn5 cn;
		bgg.a.TryGetValue(A_0, out cn);
		if (cn == null)
		{
			cn = bgg.a[AmmoType.None];
		}
		return cn;
	}

	// Token: 0x06009BEE RID: 39918 RVA: 0x003D286C File Offset: 0x003D0A6C
	public static object[] a(AmmoType A_0)
	{
		object[] result;
		bgg.b.TryGetValue(A_0, out result);
		return result;
	}

	// Token: 0x06009BEF RID: 39919 RVA: 0x003D2888 File Offset: 0x003D0A88
	static bgg()
	{
		bgg.b[AmmoType.Rocket_84_He] = new object[]
		{
			0.5f.ToString("P0"),
			0.5f.ToString("P0"),
			3,
			c18.g.ToString("P0")
		};
		bgg.b[AmmoType.Rocket_84_Wp] = new object[]
		{
			0.2f.ToString("P0"),
			0.45f.ToString("P0"),
			3,
			2f.ToString("P0"),
			5,
			c18.c(1).LowerBoundary,
			c18.c(4).UpperBoundary
		};
		bgg.b[AmmoType.Rocket_84_Cs] = new object[]
		{
			1f.ToString("P0"),
			0.25f.ToString("P0"),
			4,
			2,
			0.5f.ToString("P0"),
			2
		};
		bgg.b[AmmoType.Rocket_84_Kin] = new object[]
		{
			2f.ToString("P0"),
			5,
			0.1f.ToString("P0"),
			0.1f.ToString("P0"),
			0.6f.ToString("P0")
		};
		bgg.b[AmmoType.Rocket_66_Incendiary] = new object[]
		{
			1f.ToString("P0"),
			3,
			1f.ToString("P0"),
			3
		};
		bgg.b[AmmoType.Rocket_40_Tandem] = new object[]
		{
			0.3f.ToString("P0"),
			0.3f.ToString("P0"),
			1,
			c18.g.ToString("P0"),
			bca.a.ToString("P0"),
			l4.a(2, false),
			0.5f.ToString("P0"),
			0.5f.ToString("P0"),
			3
		};
		cn5 cn = new cn5();
		bgg.a[AmmoType.None] = cn;
		cn = new cn5();
		cn.d[DamageType.Mechanical] = 1.25;
		cn.c[DamageType.Mechanical] = 1.25;
		bgg.a[AmmoType.Bolts] = cn;
		cn = new cn5();
		cn.d[DamageType.Mechanical] = 1.25;
		cn.c[DamageType.Mechanical] = 1.25 + emf.c;
		bgg.a[AmmoType.SerratedBolts] = cn;
		cn = new cn5();
		cn.d[DamageType.Mechanical] = 1.25;
		cn.c[DamageType.Mechanical] = 1.25 + bka.c;
		bgg.a[AmmoType.BroadheadBolts] = cn;
		cn = new cn5();
		cn.b = new Action<efk, List<csk>>(bgg.b.a.b);
		cn.d[DamageType.Mechanical] = 1.5;
		cn.c[DamageType.Mechanical] = 1.5;
		bgg.a[AmmoType.Caliber_5_JHP] = cn;
		bgg.a[AmmoType.Caliber_762_JHP] = cn;
		bgg.a[AmmoType.Caliber_86_JHP] = cn;
		bgg.a[AmmoType.Caliber_9_JHP] = cn;
		bgg.a[AmmoType.Caliber_44_JHP] = cn;
		bgg.a[AmmoType.Caliber_127_JHP] = cn;
		cn = new cn5();
		cn.b = new Action<efk, List<csk>>(bgg.b.a.e);
		bgg.a[AmmoType.Caliber_762_MS] = cn;
		cn = new cn5();
		cn.d[DamageType.Mechanical] = 0.699999988079071;
		cn.c[DamageType.Mechanical] = 0.3499999940395355;
		bgg.a[AmmoType.Caliber_5_W2C] = cn;
		cn = new cn5();
		cn.d[DamageType.Mechanical] = 0.699999988079071;
		cn.c[DamageType.Mechanical] = 0.3499999940395355;
		bgg.a[AmmoType.Caliber_762_W2C] = cn;
		cn = new cn5();
		cn.d[DamageType.Mechanical] = 0.6499999761581421;
		cn.c[DamageType.Mechanical] = 0.3499999940395355;
		bgg.a[AmmoType.Caliber_86_W2C] = cn;
		cn = new cn5();
		cn.d[DamageType.Mechanical] = 0.6499999761581421;
		cn.c[DamageType.Mechanical] = 0.3499999940395355;
		bgg.a[AmmoType.Caliber_9_W2C] = cn;
		cn = new cn5();
		cn.d[DamageType.Mechanical] = 0.6000000238418579;
		cn.c[DamageType.Mechanical] = 0.3499999940395355;
		bgg.a[AmmoType.Caliber_44_W2C] = cn;
		cn = new cn5();
		cn.d[DamageType.Mechanical] = 0.550000011920929;
		cn.c[DamageType.Mechanical] = 0.3499999940395355;
		bgg.a[AmmoType.Caliber_127_W2C] = cn;
		cn = new cn5();
		cn.e = new Action<efk, Dictionary<DamageType, du2>>(bgg.b.a.a);
		bgg.a[AmmoType.Sledgehammer] = cn;
		cn = new cn5();
		cn.d[DamageType.Mechanical] = (double)a0y.e;
		cn.c[DamageType.Mechanical] = (double)a0y.e;
		cn.b = new Action<efk, List<csk>>(bgg.b.a.a);
		bgg.a[AmmoType.ThrowingKnife] = cn;
		for (int i = 0; i <= ce9.b; i++)
		{
			bgg.a a = new bgg.a();
			a.a = i;
			AmmoType key = AmmoType.ThrowingKnifeFeat0 + i;
			cn = new cn5();
			cn.d[DamageType.Mechanical] = (double)a0y.e;
			cn.c[DamageType.Mechanical] = (double)a0y.e;
			cn.b = new Action<efk, List<csk>>(a.a);
			bgg.a[key] = cn;
		}
		cn = new cn5();
		cn.d[DamageType.Mechanical] = 1.25;
		cn.c[DamageType.Mechanical] = 1.25;
		bgg.a[AmmoType.Knife] = cn;
		cn = new cn5();
		cn.d[DamageType.Mechanical] = 1.25;
		cn.c[DamageType.Mechanical] = 1.25;
		cn.b = new Action<efk, List<csk>>(bgg.b.a.c);
		bgg.a[AmmoType.Dagger] = cn;
		cn = new cn5();
		cn.d[DamageType.Mechanical] = 1.399999976158142;
		cn.c[DamageType.Mechanical] = 1.399999976158142;
		bgg.a[AmmoType.Unarmed] = cn;
		cn = new cn5();
		cn.d[DamageType.Mechanical] = 1.399999976158142;
		cn.c[DamageType.Mechanical] = 1.399999976158142;
		bgg.a[AmmoType.FistWeapon] = cn;
		cn = new cn5();
		cn.e = new Action<efk, Dictionary<DamageType, du2>>(bgg.b.a.c);
		bgg.a[AmmoType.Spear] = cn;
		cn = new cn5();
		cn.d[DamageType.Mechanical] = 1.25;
		cn.c[DamageType.Mechanical] = 1.25;
		bgg.a[AmmoType.Sword] = cn;
		cn = new cn5();
		cn.d[DamageType.Electricity] = 0.0;
		cn.c[DamageType.Electricity] = 0.0;
		cn.f[DamageType.Electricity] = true;
		bgg.a[AmmoType.Mental] = cn;
		cn = new cn5();
		cn.d[DamageType.Mechanical] = 0.35;
		cn.c[DamageType.Mechanical] = 0.35;
		bgg.a[AmmoType.BigDrill] = cn;
		cn = new cn5();
		cn.d[DamageType.Mechanical] = 0.65;
		cn.c[DamageType.Mechanical] = 0.65;
		bgg.a[AmmoType.ExoskeletonDrill] = cn;
		cn = new cn5();
		cn.d[DamageType.Mechanical] = 0.5;
		cn.c[DamageType.Mechanical] = 0.5;
		bgg.a[AmmoType.PnemuaticHammer] = cn;
		cn = new cn5();
		cn.d[DamageType.Mechanical] = 1.0 - c18.g;
		cn.c[DamageType.Mechanical] = 1.0 - c18.g;
		cn.d[DamageType.Heat] = 1.0 - c18.g;
		cn.c[DamageType.Heat] = 1.0 - c18.g;
		bgg.a[AmmoType.HighExplosives] = cn;
		cn = new cn5();
		cn.d[DamageType.Mechanical] = 1.0 - c18.h;
		cn.c[DamageType.Mechanical] = 1.0 - c18.h;
		cn.d[DamageType.Heat] = 1.0 - c18.h;
		cn.c[DamageType.Heat] = 1.0 - c18.h;
		bgg.a[AmmoType.Thermobaric] = cn;
		cn = new cn5();
		cn.d[DamageType.Mechanical] = 0.3999999761581421;
		cn.c[DamageType.Mechanical] = 0.3999999761581421;
		bgg.a[AmmoType.Rocket_84_Kin] = cn;
		cn = new cn5();
		cn.c[DamageType.Mechanical] = 0.2;
		cn.d[DamageType.Mechanical] = 0.5;
		bgg.a[AmmoType.ShotgunShell_3] = cn;
		cn = new cn5();
		cn.c[DamageType.Mechanical] = 0.3;
		cn.d[DamageType.Mechanical] = 0.7;
		bgg.a[AmmoType.ShotgunShell_6] = cn;
		cn = new cn5();
		cn.c[DamageType.Mechanical] = 0.45;
		bgg.a[AmmoType.ShotgunShell_12] = cn;
		cn = new cn5();
		cn.c[DamageType.Mechanical] = 0.6;
		bgg.a[AmmoType.ShotgunShell_20] = cn;
		cn = new cn5();
		cn.a = new Action<efk, cwt, List<csk>>(bgg.b.a.a);
		bgg.a[AmmoType.Vial_Acid_Rusting] = cn;
		cn = new cn5();
		cn.c[DamageType.Mechanical] = 0.0;
		cn.d[DamageType.Mechanical] = 0.5;
		bgg.a[AmmoType.SonicWave] = cn;
		cn = new cn5();
		cn.b = new Action<efk, List<csk>>(bgg.b.a.d);
		cn.d[DamageType.Mechanical] = 1.5;
		cn.c[DamageType.Mechanical] = 1.5;
		bgg.a[AmmoType.ObsidianSword] = cn;
		cn = new cn5();
		cn.c[DamageType.Mechanical] = 0.5;
		cn.d[DamageType.Mechanical] = 0.5;
		bgg.a[AmmoType.BallistaBolt] = cn;
		cn = new cn5();
		cn.c[DamageType.Energy] = 0.2;
		cn.d[DamageType.Energy] = 0.2;
		cn.a = new Action<efk, cwt, List<csk>>(bgg.b.a.b);
		bgg.a[AmmoType.VoidEnergy] = cn;
		cn = new cn5();
		cn.e = new Action<efk, Dictionary<DamageType, du2>>(bgg.b.a.b);
		bgg.a[AmmoType.EtherealEnergy] = cn;
		cn = new cn5();
		cn.d[DamageType.Mechanical] = 0.10000000149011612;
		cn.c[DamageType.Mechanical] = 0.699999988079071;
		bgg.a[AmmoType.SiphonerTongue] = cn;
	}

	// Token: 0x04003BF1 RID: 15345
	private static Dictionary<AmmoType, cn5> a = new Dictionary<AmmoType, cn5>();

	// Token: 0x04003BF2 RID: 15346
	private static Dictionary<AmmoType, object[]> b = new Dictionary<AmmoType, object[]>();

	// Token: 0x02001BFC RID: 7164
	[CompilerGenerated]
	[Serializable]
	private sealed class b
	{
		// Token: 0x06009BF3 RID: 39923 RVA: 0x003D3624 File Offset: 0x003D1824
		internal void b(efk A_0, List<csk> A_1)
		{
			if (A_0 != null && !A_0.Passive && !A_0.c(d8o.e) && A_1 != null && A_1.Count > 0)
			{
				for (int i = A_1.Count - 1; i >= 0; i--)
				{
					csk csk = A_1[i];
					if (csk.DamageType == DamageType.Mechanical && csk.Amount > 0)
					{
						int num = Convert.ToInt32((double)csk.Amount * 0.4);
						if (num > 0)
						{
							csk value = new csk(csk.DamageType, csk.Amount + num);
							A_1[i] = value;
						}
					}
				}
			}
		}

		// Token: 0x06009BF4 RID: 39924 RVA: 0x003D36D8 File Offset: 0x003D18D8
		internal void e(efk A_0, List<csk> A_1)
		{
			if (A_0 != null && !A_0.Passive && !A_0.c(d8o.e) && A_1 != null && A_1.Count > 0)
			{
				for (int i = A_1.Count - 1; i >= 0; i--)
				{
					csk csk = A_1[i];
					if (csk.DamageType == DamageType.Mechanical && csk.Amount > 0)
					{
						int num = Convert.ToInt32((double)csk.Amount * 0.25);
						if (num > 0)
						{
							csk value = new csk(csk.DamageType, csk.Amount + num);
							A_1[i] = value;
						}
					}
				}
			}
		}

		// Token: 0x06009BF5 RID: 39925 RVA: 0x003D378C File Offset: 0x003D198C
		internal void a(efk A_0, Dictionary<DamageType, du2> A_1)
		{
			if (!A_0.Passive && !A_0.b(d8o.e))
			{
				A_1[DamageType.Mechanical] = new du2(DamageType.Mechanical, 0, A_1[DamageType.Mechanical].c());
			}
		}

		// Token: 0x06009BF6 RID: 39926 RVA: 0x003D37D0 File Offset: 0x003D19D0
		internal void a(efk A_0, List<csk> A_1)
		{
			if (A_0 != null && !A_0.Passive && !A_0.c(d8o.e) && A_1 != null && A_1.Count > 0)
			{
				for (int i = A_1.Count - 1; i >= 0; i--)
				{
					csk csk = A_1[i];
					if (csk.DamageType == DamageType.Mechanical && csk.Amount > 0)
					{
						int num = Convert.ToInt32((double)csk.Amount * a0y.d);
						if (num > 0)
						{
							csk value = new csk(csk.DamageType, csk.Amount + num);
							A_1[i] = value;
						}
					}
				}
			}
		}

		// Token: 0x06009BF7 RID: 39927 RVA: 0x003D3880 File Offset: 0x003D1A80
		internal void c(efk A_0, List<csk> A_1)
		{
			if (A_0 != null && !A_0.c(d8o.e) && A_1 != null && A_1.Count > 0)
			{
				for (int i = A_1.Count - 1; i >= 0; i--)
				{
					csk csk = A_1[i];
					if (csk.DamageType == DamageType.Mechanical && csk.Amount > 0)
					{
						int num = Convert.ToInt32((double)csk.Amount * 0.25);
						if (num > 0)
						{
							csk value = new csk(csk.DamageType, csk.Amount + num);
							A_1[i] = value;
						}
					}
				}
			}
		}

		// Token: 0x06009BF8 RID: 39928 RVA: 0x003D3928 File Offset: 0x003D1B28
		internal void c(efk A_0, Dictionary<DamageType, du2> A_1)
		{
			if (!A_0.Passive && !A_0.b(d8o.e) && A_1[DamageType.Mechanical].c() < 1.0)
			{
				A_1[DamageType.Mechanical] = new du2(DamageType.Mechanical, A_1[DamageType.Mechanical].a(), A_1[DamageType.Mechanical].c() * 0.75);
			}
		}

		// Token: 0x06009BF9 RID: 39929 RVA: 0x003D39A0 File Offset: 0x003D1BA0
		internal void a(efk A_0, cwt A_1, List<csk> A_2)
		{
			if (A_1.c.GetValueOrDefault() || A_0.c(d8o.e))
			{
				for (int i = 0; i < A_2.Count; i++)
				{
					A_2[i] = new csk(A_2[i].DamageType, (int)((double)A_2[i].Amount * (1.0 + d9b.a)));
				}
			}
		}

		// Token: 0x06009BFA RID: 39930 RVA: 0x003D3A1C File Offset: 0x003D1C1C
		internal void d(efk A_0, List<csk> A_1)
		{
			if (A_0 != null && !A_0.Passive && !A_0.c(d8o.e) && A_1 != null && A_1.Count > 0)
			{
				for (int i = A_1.Count - 1; i >= 0; i--)
				{
					csk csk = A_1[i];
					if (csk.DamageType == DamageType.Mechanical && csk.Amount > 0)
					{
						int num = Convert.ToInt32((double)csk.Amount * 0.4);
						if (num > 0)
						{
							csk value = new csk(csk.DamageType, csk.Amount + num);
							A_1[i] = value;
						}
					}
				}
			}
		}

		// Token: 0x06009BFB RID: 39931 RVA: 0x003D3AD0 File Offset: 0x003D1CD0
		internal void b(efk A_0, cwt A_1, List<csk> A_2)
		{
			if (!A_0.StatusEffects.a(cwy.a))
			{
				for (int i = 0; i < A_2.Count; i++)
				{
					A_2[i] = new csk(A_2[i].DamageType, Math.Max(1, Convert.ToInt32((double)A_2[i].Amount * 0.666)));
				}
			}
		}

		// Token: 0x06009BFC RID: 39932 RVA: 0x003D3B48 File Offset: 0x003D1D48
		internal void b(efk A_0, Dictionary<DamageType, du2> A_1)
		{
			if (A_0 != null && (A_0.Id == "g_shadowlith" || A_0.Id == "g_shadowlithFragment"))
			{
				foreach (DamageType damageType in Enumerable.ToList<DamageType>(A_1.Keys))
				{
					A_1[damageType] = new du2(damageType, 0, 0.0);
				}
			}
		}

		// Token: 0x04003BF3 RID: 15347
		public static readonly bgg.b a = new bgg.b();
	}

	// Token: 0x02001BFD RID: 7165
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x06009BFE RID: 39934 RVA: 0x003D3BF0 File Offset: 0x003D1DF0
		internal void a(efk A_0, List<csk> A_1)
		{
			if (A_0 != null && !A_0.Passive && !A_0.c(d8o.e) && A_1 != null && A_1.Count > 0)
			{
				for (int i = A_1.Count - 1; i >= 0; i--)
				{
					csk csk = A_1[i];
					if (csk.DamageType == DamageType.Mechanical && csk.Amount > 0)
					{
						int num = Convert.ToInt32((double)csk.Amount * (a0y.d + jh.a(this.a)));
						if (num > 0)
						{
							csk value = new csk(csk.DamageType, csk.Amount + num);
							A_1[i] = value;
						}
					}
				}
			}
		}

		// Token: 0x04003BF4 RID: 15348
		public int a;
	}
}
