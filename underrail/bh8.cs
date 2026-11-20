using System;
using System.Linq;

// Token: 0x020007D7 RID: 2007
public static class bh8
{
	// Token: 0x06003246 RID: 12870 RVA: 0x00136D9C File Offset: 0x00134F9C
	public static c5x a(c5x A_0, string A_1 = null)
	{
		if (A_0 != null)
		{
			if (A_0.t.b != null && A_1 != null)
			{
				A_0.t.b.y6()[ddq.ay] = new bt4(A_1);
			}
			A_0.b("beachDefense");
			bn5 bn = A_0.GetAspect<j7>() as bn5;
			if (bn == null)
			{
				bn = new bn5(A_0);
				A_0.SetAspect<j7>(bn);
			}
			bn.a("speaker");
			bn.b("support\\xpbl\\le_aegis");
			bn.b(true);
			bn.a(true);
			a6p aspect = A_0.GetAspect<a6p>();
			if (aspect != null)
			{
				aspect.d().Add("-jobs");
			}
		}
		return A_0;
	}

	// Token: 0x06003247 RID: 12871 RVA: 0x00136E54 File Offset: 0x00135054
	public static c5x b(c5x A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xpbl_expedition_weaponSupply", new int?(0)).Value;
			int value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xpbl_expedition_techSupply", new int?(0)).Value;
			int value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xpbl_expedition_medicineSupply", new int?(0)).Value;
			if (A_0 != null && A_0.h.b != null && A_0.h.b != null)
			{
				if (value3 != 4)
				{
					if (value3 <= 3)
					{
						A_0.h.b.aa().Bag.a("morphineShot", int.MaxValue);
					}
					if (value3 <= 2)
					{
						A_0.h.b.aa().Bag.a("adrenalineShot", int.MaxValue);
						A_0.h.b.aa().Bag.a("med.antidote", int.MaxValue);
					}
					if (value3 <= 1)
					{
						coh coh = Enumerable.FirstOrDefault<coh>(A_0.h.b.aa().Bag.b("med.advancedHealthHypo"));
						if (coh != null)
						{
							if (coh.Stacks > 1)
							{
								coh coh2 = coh;
								int num = coh2.Stacks;
								coh2.Stacks = num - 1;
							}
							else
							{
								A_0.h.b.aa().Bag.z5(coh);
							}
						}
					}
				}
				if (value != 4)
				{
					if (value <= 3)
					{
						A_0.h.b.aa().Gear.a("flashbang", int.MaxValue);
					}
					if (value <= 2)
					{
						A_0.h.b.aa().Gear.a("heGrenade3", int.MaxValue);
					}
					if (value <= 1)
					{
						A_0.h.b.aa().Gear.a("fragGrenade3", int.MaxValue);
					}
				}
				if (value2 != 4)
				{
					if (value2 <= 3)
					{
						coh coh3 = Enumerable.FirstOrDefault<coh>(A_0.h.b.aa().Bag.b("Battery.FusionCell"));
						if (coh3 != null)
						{
							if (coh3.Stacks > 2)
							{
								coh3.Stacks -= 2;
							}
							else
							{
								A_0.h.b.aa().Bag.z5(coh3);
							}
						}
					}
					if (value2 <= 2 && A_0.h.b.aa().Gear.h().Item != null)
					{
						A_0.h.b.aa().Gear.h().Item = null;
					}
				}
			}
		}
		return A_0;
	}

	// Token: 0x06003248 RID: 12872 RVA: 0x00137150 File Offset: 0x00135350
	public static void a(cnk A_0, int A_1, aud A_2, bool A_3 = false)
	{
		bool value = A_0.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_briggs_dead", new bool?(false)).Value;
		bool value2 = A_0.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_marcus_dead", new bool?(false)).Value;
		bool value3 = A_0.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_ladelman_dead", new bool?(false)).Value;
		bool value4 = A_0.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_le_doc_dead", new bool?(false)).Value;
		bool value5 = A_0.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_briggs_summonedToBattle", new bool?(false)).Value;
		bool value6 = A_0.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_marcus_summonedToBattle", new bool?(false)).Value;
		bool value7 = A_0.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_ladelman_summonedToBattle", new bool?(false)).Value;
		bool value8 = A_0.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_savage_summonedToBattle", new bool?(false)).Value;
		for (int i = A_1; i < 5; i++)
		{
			if (!value2 && !value6)
			{
				c5x c5x = new ar7(new Guid("5e069237-f790-4a3d-a505-d667f88f2d83"), A_2.Zone.n("xpbl_e5_limbo")).ao() as c5x;
				string text;
				if (A_3)
				{
					text = "global:xpbl_marcus:fight";
				}
				else
				{
					text = "marcus_spawn";
				}
				if (c5x != null && aw1.a(new bt4(text), A_2, l9.a))
				{
					a0l.a(c5x, text, true);
					if (c5x.t.b != null)
					{
						c5x.t.b.y6()[ddq.ay] = new bt4("global:xpbl_marcus:fight");
					}
					if (c5x.h.b != null)
					{
						c5x.h.b.aa().Defense.a(1000, null, null, false, false, false, null);
					}
					A_0.aqu().r()["npc_xpbl_marcus_summonedToBattle"] = true;
				}
			}
			else if (!value3 && !value7)
			{
				c5x c5x2 = new ar7(new Guid("9a9e435f-ea2b-46f9-94bd-13cf592b262d"), A_2.Zone.n("xpbl_e5_limbo")).ao() as c5x;
				string text2;
				if (A_3)
				{
					text2 = "global:xpbl_ladelman:fight";
				}
				else
				{
					text2 = "ladelman_spawn";
				}
				if (c5x2 != null && aw1.a(new bt4(text2), A_2, l9.a))
				{
					a0l.a(c5x2, text2, true);
					if (c5x2.t.b != null)
					{
						c5x2.t.b.y6()[ddq.ay] = new bt4("global:xpbl_ladelman:fight");
					}
					if (c5x2.h.b != null)
					{
						c5x2.h.b.aa().Defense.a(1000, null, null, false, false, false, null);
					}
					A_0.aqu().r()["npc_xpbl_ladelman_summonedToBattle"] = true;
				}
			}
			else if (!value4 && !value8)
			{
				c5x c5x3 = new ar7(new Guid("419d485d-1c39-4698-8034-5710aa1df716"), A_2.Zone.n("xpbl_e5_limbo")).ao() as c5x;
				string text3;
				if (A_3)
				{
					text3 = "global:xpbl_savage:fight";
				}
				else
				{
					text3 = "savage_spawn";
				}
				if (c5x3 != null && aw1.a(new bt4(text3), A_2, l9.a))
				{
					a0l.a(c5x3, text3, true);
					if (c5x3.t.b != null)
					{
						c5x3.t.b.y6()[ddq.ay] = new bt4("global:xpbl_savage:fight");
					}
					if (c5x3.h.b != null)
					{
						c5x3.h.b.aa().Defense.a(1000, null, null, false, false, false, null);
					}
					A_0.aqu().r()["npc_xpbl_savage_summonedToBattle"] = true;
				}
			}
			else if (!value && !value5)
			{
				c5x c5x4 = new ar7(new Guid("fb77cf3a-ae4a-4ab8-9ef3-695f0920db83"), A_2.Zone.n("xpbl_e5_limbo")).ao() as c5x;
				string text4;
				if (A_3)
				{
					text4 = "global:xpbl_briggs:fight";
				}
				else
				{
					text4 = "briggs_spawn";
				}
				if (c5x4 != null && aw1.a(new bt4(text4), A_2, l9.a))
				{
					a0l.a(c5x4, text4, true);
					if (c5x4.t.b != null)
					{
						c5x4.t.b.y6()[ddq.ay] = new bt4("global:xpbl_briggs:fight");
					}
					if (c5x4.h.b != null)
					{
						c5x4.h.b.aa().Defense.a(1000, null, null, false, false, false, null);
					}
					A_0.aqu().r()["npc_xpbl_briggs_summonedToBattle"] = true;
				}
			}
		}
	}

	// Token: 0x06003249 RID: 12873 RVA: 0x001376CC File Offset: 0x001358CC
	public static c5x a(c5x A_0)
	{
		if (A_0 != null && A_0.h.b != null)
		{
			foreach (cze cze in A_0.h.b.ay())
			{
				if (cze is x6 && (cze as x6).c() == "global_xpbl_aegisSecTroopersAvailable")
				{
					A_0.h.b.ay().Remove(cze);
					break;
				}
			}
		}
		return A_0;
	}
}
