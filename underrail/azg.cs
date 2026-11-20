using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules;

// Token: 0x0200032D RID: 813
[apc("superSeaWyrmTactic")]
public sealed class azg : bh7
{
	// Token: 0x06001747 RID: 5959 RVA: 0x000749C4 File Offset: 0x00072BC4
	public azg()
	{
		this.a = new ej0();
		this.b = new ej0();
		this.j.a.Insert(0, new arr(this.a, new Func<e1k, bool>(azg.b.a.a)));
		this.a.a = new Action<ej0>(azg.b.a.a);
		this.a.a = this.b;
		this.b.a = new Action<ej0>(azg.b.a.b);
		this.b.a = this.c;
	}

	// Token: 0x06001748 RID: 5960 RVA: 0x00074AA8 File Offset: 0x00072CA8
	private new static csd a(e1k A_0, amc A_1)
	{
		azg.a a = new azg.a();
		a.a = A_0;
		if (A_1 != null && A_1.a8() != null && A_1.a8().t.b != null && a.a.g().a8().Area != null && a.a.g().a8().Area.Zone != null && A_1.a8().Area == a.a.g().a8().Area)
		{
			d02 serviceOrThrow = bpo.GetServiceOrThrow<d02>();
			HashSet<r0> hashSet = A_1.a8().t.b.b(serviceOrThrow);
			List<csd> list = Enumerable.ToList<csd>(Enumerable.Where<csd>(a.a.g().a8().Area.Zone.Waypoints, new Func<csd, bool>(a.a)));
			if (list.Count > 0)
			{
				List<csd> list2 = new List<csd>();
				List<double> list3 = new List<double>();
				foreach (csd csd in list)
				{
					r0 r = new r0(csd.Area.c(), new Vector2((float)((int)csd.Location.X), (float)((int)csd.Location.Y)));
					if (!hashSet.Contains(r))
					{
						ak1 ak = csd.Area.a(csd.Location.a());
						if (ak != null && !aw1.a(ak, false, a.a.g().a8(), l9.b))
						{
							double num = aw1.a(A_1.a8(), ak);
							if (num >= 10.0 && num <= 1.7976931348623157E+308)
							{
								list2.Add(csd);
								list3.Add(num);
							}
						}
					}
				}
				if (list2.Count > 0)
				{
					return list2[list3.IndexOf(Enumerable.Max(list3))];
				}
			}
		}
		return null;
	}

	// Token: 0x04000DD8 RID: 3544
	private new ej0 a;

	// Token: 0x04000DD9 RID: 3545
	private new ej0 b;

	// Token: 0x0200032E RID: 814
	[CompilerGenerated]
	[Serializable]
	private new sealed class b
	{
		// Token: 0x0600174B RID: 5963 RVA: 0x00074CF4 File Offset: 0x00072EF4
		internal bool a(e1k A_0)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				int num;
				switch (serviceOrThrow.aqu().ae())
				{
				case GameDifficulty.Hard:
					num = 2;
					goto IL_4A;
				case GameDifficulty.Dominating:
					num = 2;
					goto IL_4A;
				}
				num = 1;
				IL_4A:
				if (A_0.g().aa().Defense.q().zo() <= A_0.g().aa().Defense.q().zm() / 2f && A_0.c().y6().GetPrimitivePropertyValue<int>("TimesFeasted", new int?(0)).Value < num)
				{
					amc amc = new bzv(A_0.c().y6()).g();
					if (amc != null && amc.a8() != null && amc.aa().IsInControl)
					{
						return azg.a(A_0, amc) != null;
					}
				}
			}
			return false;
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x00074DFC File Offset: 0x00072FFC
		internal void a(ej0 A_0)
		{
			amc amc = new bzv(A_0.b().c().y6()).g();
			if (amc != null)
			{
				csd csd = azg.a(A_0.b(), amc);
				if (csd != null)
				{
					d02 serviceOrThrow = bpo.GetServiceOrThrow<d02>();
					d4n d4n = serviceOrThrow.ahu(A_0.b().g().aa());
					if (d4n == serviceOrThrow.ahe())
					{
						d4n.b((int)(d4n.d + d4n.c), true);
					}
					if (d4n.b.aa().SpecialAbilities.a(typeof(e5b)))
					{
						d4n.b.aa().SpecialAbilities.a(dgk.Get<e5b>());
					}
					e3i.a(A_0, null, csd.Tile);
					new bzv(A_0.b().c().y6()).e();
					A_0.b().g().aa().PersonalAttitudes.Clear();
					A_0.b().c().y6()["TimesFeasted"] = A_0.b().c().y6().GetPrimitivePropertyValue<int>("TimesFeasted", new int?(0)).Value + 1;
					A_0.b().c().y6()["Regenerating"] = true;
					A_0.b().c().y6()[ddq.ay] = new bt4(csd.Name);
					A_0.b().c().y6()[ddq.az] = true;
					cnk serviceOrThrow2 = bpo.GetServiceOrThrow<cnk>();
					if (serviceOrThrow2.aqu() != null && serviceOrThrow2.aqu().v() != null)
					{
						c5x c5x = new ar7(new Guid("de53fd98-31fe-4f49-b4e6-20437dbd6150"), serviceOrThrow2.aqu().v().b().Area).ao() as c5x;
						if (c5x != null && c5x.t.b != null)
						{
							A_0.b().c().a(c5x);
							bzv bzv = new bzv(c5x.t.b.y6());
							blk blk = bzv.c(serviceOrThrow2.aqu().v().b().qe());
							if (blk != null && blk.b())
							{
								c5x.u.b.a("На этот раз, хр-р-р... На этот раз ты никуда не денешься.", true, null, null);
								bzv.e();
								return;
							}
							(serviceOrThrow2.aqu().v().b() as c5x).u.b.a("Оно уплыло. Но не могло уйти далеко.", true, null, null);
							return;
						}
						else
						{
							(serviceOrThrow2.aqu().v().b() as c5x).u.b.a("Оно уплыло. Но не могло уйти далеко.", true, null, null);
						}
					}
				}
			}
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x00075128 File Offset: 0x00073328
		internal void b(ej0 A_0)
		{
			bpo.GetServiceOrThrow<d02>().ahs(true, false);
		}

		// Token: 0x04000DDA RID: 3546
		public static readonly azg.b a = new azg.b();

		// Token: 0x04000DDB RID: 3547
		public static Func<e1k, bool> b;

		// Token: 0x04000DDC RID: 3548
		public static Action<ej0> c;

		// Token: 0x04000DDD RID: 3549
		public static Action<ej0> d;
	}

	// Token: 0x0200032F RID: 815
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x0600174F RID: 5967 RVA: 0x00075144 File Offset: 0x00073344
		internal bool a(csd A_0)
		{
			return A_0.Area == this.a.g().a8().Area && A_0.Name.StartsWith("feeding", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x04000DDE RID: 3550
		public e1k a;
	}
}
