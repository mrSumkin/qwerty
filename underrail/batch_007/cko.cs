using System;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000F33 RID: 3891
[e79("Xpbl_Pir_Meeting_NegotiationsSucceeded")]
public sealed class cko : dgy
{
	// Token: 0x06004EFD RID: 20221 RVA: 0x00238CD0 File Offset: 0x00236ED0
	public cko()
	{
		cko.a a = new cko.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			c5x c5x = a.a.aqu().v().b() as c5x;
			if (c5x != null && c5x.Area != null)
			{
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array = new btm[1];
				int num = 0;
				dky dky = new dky();
				dky.a(0.2f);
				dky.a(false);
				array[num] = dky;
				base.a(array);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				base.a(new btm[]
				{
					new di4(new c2w("xpbl_g3", "player_abandonJet"), false, new bool?(false), 0, null, false, false, false)
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				c6w c6w = new c6w(new Func<auv>(a.a));
				c6w.a(new ar7(aju.a, new Guid("0c191f1a-d6df-40a0-b764-327a3c05a595"), new Guid("1e5bec4e-078d-43a9-8c30-ef099898a952"), bl1.a));
				array2[num2] = c6w;
				base.a(array2);
				base.a(new btm[]
				{
					new di4(new c2w("xpbl_d5", "player_abandonJet"), false, new bool?(false), 0, null, false, false, false)
				});
				base.a(new btm[]
				{
					new ace(new an9())
					{
						InitiatorRef = new ar7(aju.a, new Guid("9b12167a-09d6-488c-a45d-c0c968225b7c"), new Guid("61fa2bf3-e47b-4008-bbeb-75f2c57a143d"), bl1.a)
					}
				});
				base.a(new btm[]
				{
					new di4(new c2w("xpbl_d6", "player_oldTent"), false, new bool?(false), 0, null, false, false, false)
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.a(false);
				array3[num3] = c8s;
				base.a(array3);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000F34 RID: 3892
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004EFF RID: 20223 RVA: 0x00238F3C File Offset: 0x0023713C
		internal auv a()
		{
			this.a.aqu().r()["loc_g2_innerShip_canEnterCabin"] = false;
			this.a.aqu().r()["quests_xpbl_expedition_professorSaved"] = true;
			c5x c5x = new ar7(aju.a, new Guid("0c191f1a-d6df-40a0-b764-327a3c05a595"), new Guid("1e5bec4e-078d-43a9-8c30-ef099898a952"), bl1.a).ao() as c5x;
			d60 addon = this.a.aqw().GetAddon<d60>();
			if (addon != null)
			{
				c5x c5x2 = Enumerable.FirstOrDefault<b0b>(addon.ab4(new string[]
				{
					"playersJetTakenByPirates"
				})) as c5x;
				if (c5x2 != null)
				{
					wv wv = c5x2.GetAspect<bim>() as wv;
					if (wv != null)
					{
						return new kp(wv, c5x.h.b);
					}
				}
			}
			return null;
		}

		// Token: 0x0400205F RID: 8287
		public cnk a;
	}
}
