using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000D0E RID: 3342
[e79("Cc_DanArrives")]
public sealed class lv : dgy
{
	// Token: 0x06004A16 RID: 18966 RVA: 0x001F2524 File Offset: 0x001F0724
	public lv()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				aud aud = c5x.Area;
				if (aud != null)
				{
					lv.a a = new lv.a();
					a.b = (new ar7(new Guid("5b6e2069-f7a5-4ce0-92a0-3fac8085f6be"), aud).ao() as c5x);
					a.a = (new ar7(new Guid("94e5185a-506d-41ca-87c8-8595e7cd28fb"), c5x.Area).ao() as c5x);
					if (a.b != null && a.a != null)
					{
						if (a.b.h.b != null)
						{
							a.b.h.b.aa().FactionId = asp.dw;
							if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_cc_robProtWarehouse_playerBroughOwnShields", new bool?(false)).Value)
							{
								List<cgd> classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<List<cgd>>("quest_cc_robProtWarehouse_shieldItemList");
								if (Enumerable.Any<cgd>(classPropertyValue))
								{
									cgd cgd = Enumerable.FirstOrDefault<cgd>(classPropertyValue);
									if (cgd != null)
									{
										classPropertyValue.RemoveAt(0);
										cgd.Battery = (double)cgd.MaxBattery;
										a.b.h.b.aa().Gear.h().a(cgd, true);
										serviceOrThrow.aqu().r()["quest_cc_robProtWarehouse_shieldItemList"] = classPropertyValue;
									}
								}
							}
							else
							{
								xm xm = new xm();
								xm.na(12);
								xm.nc(14);
								cgd cgd2 = Enumerable.FirstOrDefault<coh>(xm.np()) as cgd;
								if (cgd2 != null)
								{
									cgd2.Battery = (double)cgd2.MaxBattery;
									a.b.h.b.aa().Gear.h().a(cgd2, true);
								}
							}
						}
						base.a(new btm[]
						{
							new ace(new e80(false))
						});
						btm[] array = new btm[1];
						int num = 0;
						kw kw = new kw();
						kw.a(new bt4("danEnd1"));
						kw.a(false);
						kw.IsAsync = false;
						array[num] = kw;
						base.a(array);
						string a_ = "danEnd1";
						csd csd = aud.Zone.g("danEnd1");
						if (csd != null && csd.Tile != null && aw1.a(null, csd.Tile, false, null))
						{
							a_ = "danEnd2";
						}
						base.a(new btm[]
						{
							new ace(new be6
							{
								DestinationWaypoint = "danStart"
							})
							{
								InitiatorRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.a), null, null, null)
						});
						btm[] array2 = new btm[1];
						int num2 = 0;
						s5 s = new s5();
						s.a(new ar7(a.b));
						s.a(new bt4(a_));
						s.IsAsync = false;
						s.a(true);
						array2[num2] = s;
						base.a(array2);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array3 = new btm[1];
						int num3 = 0;
						d92 d = new d92();
						d.a("events\\cc_gorskyTunneler");
						d.b(new ar7(a.b));
						d.a(new ar7(a.a));
						array3[num3] = d;
						base.a(array3);
						base.a(new btm[]
						{
							new ace(new e80(true))
						});
					}
				}
			}
		}
	}

	// Token: 0x02000D0F RID: 3343
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004A18 RID: 18968 RVA: 0x001F28D8 File Offset: 0x001F0AD8
		internal bool a(e6d A_0)
		{
			aw1.b(this.a, this.b, false);
			return true;
		}

		// Token: 0x04001D7E RID: 7550
		public c5x a;

		// Token: 0x04001D7F RID: 7551
		public c5x b;
	}
}
