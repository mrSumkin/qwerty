using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000BCE RID: 3022
public sealed class d5f : jn
{
	// Token: 0x06004533 RID: 17715 RVA: 0x001C1E80 File Offset: 0x001C0080
	public d5f() : base("forger", "creature\\characters\\forger")
	{
	}

	// Token: 0x06004534 RID: 17716 RVA: 0x001C1E94 File Offset: 0x001C0094
	public override string b1(cyt A_0)
	{
		bq8 bq = A_0.e();
		if (bq.GetPrimitivePropertyValue<bool>("npc_forger_pretHelpedEscape", new bool?(false)).Value)
		{
			return null;
		}
		if (bq.GetPrimitivePropertyValue<bool>("npc_forger_captured", new bool?(false)).Value)
		{
			if (bq.GetPrimitivePropertyValue<bool>("npc_forger_CoretechEnding", new bool?(false)).Value)
			{
				return "cc19";
			}
			if (bq.GetPrimitivePropertyValue<bool>("npc_forger_JkkEnding", new bool?(false)).Value)
			{
				return "up-cc";
			}
			if (bq.GetPrimitivePropertyValue<bool>("npc_forger_PraetorianEnding", new bool?(false)).Value)
			{
				return "cc10";
			}
			return null;
		}
		else
		{
			if (!bq.GetPrimitivePropertyValue<bool>("cc_ps_acidHunters_started", new bool?(false)).Value && !bq.GetPrimitivePropertyValue<bool>("cc_ct_acidHunters_started", new bool?(false)).Value && !bq.GetPrimitivePropertyValue<bool>("cc_jkk_acidHunters_started", new bool?(false)).Value)
			{
				return "cc_utility2";
			}
			return null;
		}
	}

	// Token: 0x06004535 RID: 17717 RVA: 0x001C1FB8 File Offset: 0x001C01B8
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		amc aspect = A_0.GetAspect<amc>();
		if (aspect != null)
		{
			if (A_2.Equals("CC_utility2", StringComparison.OrdinalIgnoreCase) && !aspect.aa().CustomProperties.GetPrimitivePropertyValue<bool>("ForgerAdjusted", new bool?(false)).Value)
			{
				aspect.aa().CustomProperties["ForgerAdjusted"] = true;
				e3l e3l = new e3l(A_0 as c5x);
				if (e3l != null)
				{
					e3l.a.Add("forger");
					A_0.SetAspect<e3l>(e3l);
				}
				bm6 aspect2 = A_0.GetAspect<bm6>();
				if (aspect2 != null)
				{
					aspect2.y6()[ddq.bc] = "npc_forger_met";
					aspect2.y6()[ddq.bd] = 5;
					aspect2.y6()[ddq.n] = true;
					aspect2.y6()[ddq.s] = 100;
					aspect2.y6()[ddq.o] = CharacterState.Operating;
					aspect2.y6()[ddq.k] = new List<string>
					{
						"forger_p1",
						"forger_p2",
						"forger_p3",
						"forger_p4"
					};
					aspect2.y6()[ddq.l] = 7500;
				}
			}
			if (A_2.Equals("up-cc", StringComparison.OrdinalIgnoreCase) || A_2.Equals("cc10", StringComparison.OrdinalIgnoreCase) || A_2.Equals("cc19", StringComparison.OrdinalIgnoreCase))
			{
				bm6 aspect3 = A_0.GetAspect<bm6>();
				bn5 bn = A_0.GetAspect<j7>() as bn5;
				if (aspect3 != null && bn != null)
				{
					A_1.r()["npc_forger_captured"] = true;
					aspect3.y6()[ddq.ay] = new bt4("global:forger");
					aspect.aa().FactionId = asp.di;
					aspect.aa().HostilityBroadcastMode = c2n.d;
					aspect.aa().PersonalAttitudes.Clear();
					aspect3.y6().RemoveProperty(ddq.k);
					aspect3.y6().RemoveProperty(ddq.l);
					aspect3.y6().RemoveProperty(ddq.o);
					aspect3.y6().RemoveProperty(ddq.s);
					aspect3.y6().RemoveProperty(ddq.n);
					aspect3.y6().RemoveProperty(ddq.bc);
					aspect3.y6().RemoveProperty(ddq.bd);
					bn.a(false);
					if (A_2.Equals("cc19", StringComparison.OrdinalIgnoreCase) && !aspect.aa().CustomProperties.GetPrimitivePropertyValue<bool>("ForgerAdditionalImports", new bool?(false)).Value)
					{
						aspect.aa().CustomProperties["ForgerAdditionalImports"] = true;
						aspect3.y6()[ddq.w] = CharacterState.Stunned;
						aspect.aa().FactionId = asp.dz;
						aspect3.y6()[ddq.w] = CharacterState.Custom2;
						return;
					}
					if ((A_2.Equals("cc10", StringComparison.OrdinalIgnoreCase) || A_2.Equals("up-cc", StringComparison.OrdinalIgnoreCase)) && !aspect.aa().CustomProperties.GetPrimitivePropertyValue<bool>("ForgerAdditionalImports", new bool?(false)).Value)
					{
						aspect.aa().CustomProperties["ForgerAdditionalImports"] = true;
						this.a(A_0);
						aspect3.y6()[ddq.w] = CharacterState.Stunned;
						eok eok = Enumerable.FirstOrDefault<eok>(aspect.aa().StatusEffects.Get<eok>());
						if (eok == null)
						{
							aspect.aa().StatusEffects.a(new eok(0), false, false, false);
						}
						else
						{
							eok.Duration = 0;
							eok.ad();
						}
						if (A_2.Equals("cc10", StringComparison.OrdinalIgnoreCase))
						{
							doq a_ = doq.a(Path.Combine(d5x.q(), "cc10_l3") + ".uzl");
							A_1.v().b().Zone.a(a_, aju.x, null);
							c5x c5x = new ar7(new Guid("6a33e755-7fcd-4c93-964a-c9fdce9242a8"), A_1.v().b().Zone.Areas[0]).ao() as c5x;
							if (c5x != null && c5x.s != null && c5x.s.b != null)
							{
								cnb cnb = c5x.s.b as cnb;
								if (cnb != null)
								{
									cnb.d(false);
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004536 RID: 17718 RVA: 0x001C2490 File Offset: 0x001C0690
	private void a(b0b A_0)
	{
		amc aspect = A_0.GetAspect<amc>();
		if (aspect != null)
		{
			aspect.aa().Bag.z7();
			aspect.aa().a("remoteControlEnergizerGlove", 1, true);
			aspect.aa().Gear.j()[WeaponKey.Primary].b(null);
			aspect.aa().Gear.j()[WeaponKey.Secondary].b(null);
			aspect.aa().bl();
		}
	}
}
