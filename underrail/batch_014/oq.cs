using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules;

// Token: 0x02000B89 RID: 2953
[eiz("CCUWIJ")]
[Serializable]
public sealed class oq : cze, ISerializable
{
	// Token: 0x06004356 RID: 17238 RVA: 0x001A5250 File Offset: 0x001A3450
	private oq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004357 RID: 17239 RVA: 0x001A525C File Offset: 0x001A345C
	public oq()
	{
	}

	// Token: 0x06004358 RID: 17240 RVA: 0x001A5264 File Offset: 0x001A3464
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				int num = (int)(3 + serviceOrThrow.aqu().ae());
				int num2 = Math.Max(2, (int)((GameDifficulty)5 - serviceOrThrow.aqu().ae()));
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_cc_warehouse_invasionStarted", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_cc_warehouse_invasionEnded", new bool?(false)).Value;
				int num3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_cc_warehouse_invasionWavesDone", new int?(0)).Value;
				int num4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_cc_warehouse_turnsTillNextWave", new int?(0)).Value;
				int value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_cc_warehouse_invadersKilled", new int?(0)).Value;
				bool flag = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_cc_warehouse_allInvadersKilled", new bool?(false)).Value;
				if (value2 && value3 >= num * 3 && !flag)
				{
					flag = true;
					serviceOrThrow.aqu().r()["loc_cc_warehouse_allInvadersKilled"] = flag;
				}
				if (value && !value2)
				{
					if (--num4 <= 0)
					{
						num4 = num2;
						serviceOrThrow.aqu().r()["loc_cc_warehouse_invasionWavesDone"] = ++num3;
						bu6 service = bpo.GetService<bu6>();
						if (service != null)
						{
							List<string> list = null;
							if (service.aq2() >= GameDifficulty.Dominating)
							{
								list = new List<string>
								{
									"LurkerAssassin",
									"LurkerSniper",
									"LurkerTrapper",
									"IronheadBerserker",
									"IronheadHeavyGunner",
									"IronheadDemolisher"
								};
							}
							else if (service.aq2() >= GameDifficulty.Hard)
							{
								list = new List<string>
								{
									"LurkerAssassin",
									"LurkerSniper",
									"LurkerTrapper",
									"LurkerMurderer",
									"LurkerGunslinger",
									"LurkerHunter",
									"IronheadBerserker",
									"IronheadHeavyGunner",
									"IronheadDemolisher",
									"IronheadCommando",
									"IronheadBomber"
								};
								if (dk2.b("xpbl"))
								{
									list.Add("xpbl\\ironheadShotgunner");
								}
							}
							else if (service.aq2() >= GameDifficulty.Normal)
							{
								list = new List<string>
								{
									"LurkerCutthroat",
									"LurkerGunner",
									"LurkerAssassin",
									"LurkerSniper",
									"LurkerTrapper",
									"LurkerMurderer",
									"LurkerGunslinger",
									"LurkerHunter",
									"IronheadGrenadier",
									"IronheadSmasher",
									"ironheadGunner",
									"IronheadBerserker",
									"IronheadHeavyGunner",
									"IronheadDemolisher",
									"IronheadCommando",
									"IronheadBomber"
								};
								if (dk2.b("xpbl"))
								{
									list.Add("xpbl\\ironheadShotgunner");
								}
							}
							else
							{
								list = new List<string>
								{
									"LurkerCutthroat",
									"LurkerGunner",
									"LurkerMurderer",
									"LurkerGunslinger",
									"LurkerHunter",
									"IronheadGrenadier",
									"IronheadSmasher",
									"ironheadGunner",
									"IronheadCommando",
									"IronheadBomber"
								};
								if (dk2.b("xpbl"))
								{
									list.Add("xpbl\\ironheadShotgunner");
								}
							}
							if (dk2.b("xpbl"))
							{
								list.Add("xpbl\\ironheadHeavyShotgunner");
							}
							int num5 = 1;
							foreach (string str in new string[]
							{
								"a",
								"b",
								"c"
							})
							{
								csd a_ = aud.Zone.g(str + 1.ToString());
								c5x c5x = vq.a("creatures\\genericHumans\\" + list[cuo.a.Next(list.Count)], a_, false);
								if (c5x != null)
								{
									c5x.RemoveAspect<a6p>();
									c5x.q("Mercenary");
									if (c5x.h.b != null)
									{
										c5x.h.b.aa().Name = c5x.y8();
										c5x.h.b.aa().FactionId = asp.d4;
										List<cze> list2 = c5x.h.b.ay();
										x6 x = new x6();
										x.a("loc_cc_warehouse_invadersKilled");
										list2.Add(x);
										c5x.h.b.g(true);
										c5x.h.b.i(true);
										gx gx = new gx();
										if (gx != null)
										{
											c5x.h.b.a(gx.a(c5x.h.b.am(), null, null));
										}
										foreach (coh coh in Enumerable.ToList<coh>(c5x.h.b.aa().Bag.z2()))
										{
											if (coh.Definition is x2 || coh.Definition.a7().GetPrimitivePropertyValue<bool>("MonsterInfrequent", new bool?(false)).Value)
											{
												c5x.h.b.aa().Bag.z5(coh);
											}
										}
										foreach (coh coh2 in c5x.h.b.aa().Gear.i())
										{
											if (coh2.Definition.a7().GetPrimitivePropertyValue<bool>("MonsterInfrequent", new bool?(false)).Value)
											{
												c5x.h.b.aa().Gear.c(coh2);
											}
										}
									}
									if (c5x.t.b != null)
									{
										List<string> list3 = new List<string>();
										for (int j = 2; j <= 7; j++)
										{
											list3.Add(str + j.ToString());
										}
										c5x.t.b.y6()[ddq.l] = 2000;
										c5x.t.b.y6()[ddq.k] = list3;
										c5x.t.b.y6()["InvaderNumber"] = (num3 - 1) * 3 + num5;
										c5x.t.b.a("");
									}
								}
								num5++;
							}
							if (num3 >= num)
							{
								serviceOrThrow.aqu().r()["loc_cc_warehouse_invasionEnded"] = true;
							}
						}
					}
					serviceOrThrow.aqu().r()["loc_cc_warehouse_turnsTillNextWave"] = num4;
				}
			}
		}
	}
}
