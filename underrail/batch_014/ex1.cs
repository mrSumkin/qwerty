using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A1D RID: 2589
[eiz("XPBLE5")]
[Serializable]
public sealed class ex1 : bdw, ISerializable
{
	// Token: 0x06003D95 RID: 15765 RVA: 0x00170FD4 File Offset: 0x0016F1D4
	private ex1(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D96 RID: 15766 RVA: 0x00170FDC File Offset: 0x0016F1DC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D97 RID: 15767 RVA: 0x00170FE0 File Offset: 0x0016F1E0
	public ex1()
	{
	}

	// Token: 0x06003D98 RID: 15768 RVA: 0x00170FEC File Offset: 0x0016F1EC
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("xpbl_e5");
			if (aud != null)
			{
				axh aspect = (new ar7(new Guid("62c9052e-cb54-4820-a1aa-99aaae3b10e1"), aud).ao() as c5x).GetAspect<axh>();
				this.a(A_1, aud);
				string classPropertyValue = A_1.r().GetClassPropertyValue<string>("loc_xpbl_e5_invadersType");
				if (A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_e5_queueCleanup", new bool?(false)).Value)
				{
					foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
					{
						c5x c5x = (c5x)b0b;
						if (c5x != null)
						{
							if (c5x.a("beachDefense"))
							{
								if (c5x.y8() == null || !c5x.y8().Contains("Naga"))
								{
									c5x.w();
									c5x.an();
								}
							}
							else if (!A_1.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionDestroyed", new bool?(false)).Value)
							{
								if ((c5x.GetAspect<a3f>() != null && c5x.GetAspect<a3f>().a().GetPrimitivePropertyValue<bool>("IsCorpse", new bool?(false)).Value) || (c5x.o.b != null && c5x.o.b.a == "Effects\\BloodPool"))
								{
									c5x.w();
									c5x.an();
								}
							}
							else if (c5x.h.b != null && (c5x.h.b.aa().FactionId == asp.fx || c5x.h.b.aa().FactionId == asp.fr))
							{
								c5x.w();
								c5x.an();
							}
						}
					}
					this.a(A_1, aud, classPropertyValue, false);
					A_1.r()["loc_xpbl_e5_queueCleanup"] = false;
				}
				if (A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_underAttack", new bool?(false)).Value)
				{
					azq azq = new azq();
					azq.a("autoResolveSavageInvasion");
					azq.ym(null, null, null);
					if (!A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_e5_setUpDefense", new bool?(false)).Value)
					{
						this.b(A_1, aud);
						this.a(A_1, aud, classPropertyValue, true);
						if (classPropertyValue == "Pirates")
						{
							new dvn("xpbl_e5", "xpbl_PirateBase").ym(null, null, null);
						}
						else
						{
							new dvn("xpbl_e5", "xpbl_SavagesBattle").ym(null, null, null);
						}
						doq a_ = doq.a(Path.Combine(d5x.q(), "xpbl_e5_L2") + ".uzl");
						aud.Zone.a(a_, 1, null);
						if (aspect != null)
						{
							aspect.a(null, false, null);
						}
						int value = A_1.r().GetPrimitivePropertyValue<int>("loc_xpbl_e5_battleNumber", new int?(0)).Value;
						int value2 = A_1.r().GetPrimitivePropertyValue<int>("faction_xpbl_expedition_weaponSupply", new int?(0)).Value;
						if (value > 1)
						{
							if (value == 2 && value2 > 1)
							{
								doq a_2 = doq.a(Path.Combine(d5x.q(), "xpbl_e5_L3_traps1") + ".uzl");
								aud.Zone.a(a_2, 1, null);
							}
							else if (value == 3 && value2 > 2)
							{
								doq a_2 = doq.a(Path.Combine(d5x.q(), "xpbl_e5_L4_traps2") + ".uzl");
								aud.Zone.a(a_2, 1, null);
							}
							else if (value == 4 && value2 > 3)
							{
								doq a_2 = doq.a(Path.Combine(d5x.q(), "xpbl_e5_L5_traps3") + ".uzl");
								aud.Zone.a(a_2, 1, null);
							}
						}
						A_1.r()["loc_xpbl_e5_setUpDefense"] = true;
						A_1.r()["loc_xpbl_e5_removedDefense"] = false;
					}
				}
				if (!A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_underAttack", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_e5_removedDefense", new bool?(false)).Value)
				{
					if (!A_1.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionDestroyed", new bool?(false)).Value)
					{
						if (aspect != null)
						{
							aspect.a(null, true, null);
						}
					}
					else
					{
						foreach (b0b b0b2 in Enumerable.ToList<b0b>(aud.Entities))
						{
							c5x c5x2 = (c5x)b0b2;
							if (c5x2 != null && c5x2.h.b != null && (c5x2.h.b.aa().FactionId == asp.f5 || c5x2.h.b.aa().FactionId == asp.f7 || c5x2.h.b.aa().FactionId == asp.f6 || c5x2.h.b.aa().FactionId == asp.gb || c5x2.y8().Contains("Auto-Turret")))
							{
								c5x2.h.b.aa().a(null, null, false);
							}
						}
					}
					new dvn("xpbl_e5", "xpbl_BlackSea").ym(null, null, null);
					A_1.r()["loc_xpbl_e5_removedDefense"] = true;
				}
			}
		}
	}

	// Token: 0x06003D99 RID: 15769 RVA: 0x00171664 File Offset: 0x0016F864
	private void b(cyt A_0, aud A_1)
	{
		List<csd> list = new List<csd>();
		gx gx = new gx();
		int value = A_0.r().GetPrimitivePropertyValue<int>("global_xpbl_aegisSecTroopersAvailable", new int?(0)).Value;
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Zone.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("aegisTrooper", StringComparison.OrdinalIgnoreCase))
			{
				list.Add(csd);
			}
		}
		int num;
		if (value >= list.Count)
		{
			num = list.Count;
		}
		else
		{
			num = value;
		}
		if (num > 0)
		{
			for (int i = 0; i < num; i++)
			{
				if (list[i] != null)
				{
					c5x c5x = gx.a(list[i], new int?(10), "Aegis", null, null, null, null, false, null, false);
					if (c5x != null)
					{
						c5x = bh8.a(c5x, null);
						c5x = bh8.b(c5x);
					}
				}
			}
			foreach (b0b b0b in Enumerable.ToList<b0b>(A_1.Entities))
			{
				c5x c5x2 = (c5x)b0b;
				if (c5x2 != null && c5x2.h.b != null && c5x2.h.b.aa().FactionId == asp.f5 && !c5x2.h.b.aa().b(d8o.e))
				{
					c5x2.h.b.aa().Defense.a(1000, null, null, false, false, false, null);
				}
			}
		}
		if (num < 5)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow != null)
			{
				bh8.a(serviceOrThrow, num, A_1, true);
			}
		}
	}

	// Token: 0x06003D9A RID: 15770 RVA: 0x00171890 File Offset: 0x0016FA90
	private void a(cyt A_0, aud A_1)
	{
		if (!A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_e5_nagaStatueSet", new bool?(false)).Value && (A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_knowServants", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_knowNaga", new bool?(false)).Value))
		{
			c5x c5x = new ar7(new Guid("5cf6446a-1863-4f10-812d-16e7cfde5fec"), A_1).ao() as c5x;
			if (c5x != null)
			{
				if (c5x.GetAspect<bim>() is d85)
				{
					c5x.RemoveAspect<d85>();
				}
				bim bim = c5x.GetAspect<bim>();
				bim = new bim(c5x);
				List<cze> list = bim.s();
				a72 a = new a72();
				a.b("interfacing\\xpbl\\e5_nagaProtector");
				a.c("Naga Protector");
				a.c(false);
				list.Add(a);
				c5x.SetAspect<bim>(bim);
				A_0.r()["loc_xpbl_e5_nagaStatueSet"] = true;
			}
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_e5_nagaActivated", new bool?(false)).Value && A_0.r().GetClassPropertyValue<string>("loc_xpbl_e5_nagaAttitude") != "ally" && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_e5_naga_died", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_e5_killNaga", new bool?(false)).Value)
		{
			d60 d = A_1.Zone.a();
			if (d != null)
			{
				c5x c5x2 = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
				{
					"xpbl_e5_damagedNaga"
				})) as c5x;
				if (c5x2 != null)
				{
					c5x2.h.b.aa().a(null, null, false);
				}
			}
		}
	}

	// Token: 0x06003D9B RID: 15771 RVA: 0x00171A70 File Offset: 0x0016FC70
	private void a(cyt A_0, aud A_1, string A_2, bool A_3)
	{
		string str = "xpbl_sorBoat_inv";
		string str2 = "InvaderBoat";
		if (A_2 == "Pirates")
		{
			str = "xpbl_pirBoat_inv";
		}
		for (int i = 1; i < 4; i++)
		{
			if (A_3)
			{
				erb.a(A_0, A_1.Zone, str + i.ToString(), A_1.Zone.g(str2 + i.ToString()));
			}
			else
			{
				erb.a(str + i.ToString(), A_1.Zone.g(str2 + i.ToString()));
			}
		}
	}
}
