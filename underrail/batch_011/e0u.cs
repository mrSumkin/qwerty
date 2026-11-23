using System;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000C5F RID: 3167
public sealed class e0u : jn
{
	// Token: 0x06004721 RID: 18209 RVA: 0x001D57C8 File Offset: 0x001D39C8
	public override string cc()
	{
		return "xphw";
	}

	// Token: 0x06004722 RID: 18210 RVA: 0x001D57D0 File Offset: 0x001D39D0
	public e0u() : base("xphw_gunslinger", "creature\\characters\\xphw\\gunslinger")
	{
	}

	// Token: 0x06004723 RID: 18211 RVA: 0x001D57E4 File Offset: 0x001D39E4
	public override string b1(cyt A_0)
	{
		if (string.Equals(A_0.c().b(), "TestZone-Events", StringComparison.OrdinalIgnoreCase))
		{
			return A_0.c().b();
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xphw_gunslinger_died", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("npc_xphw_gunslinger_leavesForever", new bool?(false)).Value)
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_xphw_tripToNorthUnderrail_completed", new bool?(false)).Value)
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xphw_gunslinger_coreCityMet", new bool?(false)).Value && (A_0.r().GetPrimitivePropertyValue<bool>("npc_rahmUmbra_toldToGoNorth", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("loc_sgs_finalCouncil", new bool?(false)).Value) && (string.Equals(A_0.c().b(), "LU-SouthGateStation", StringComparison.OrdinalIgnoreCase) || string.Equals(A_0.c().b(), "cc_cityEnter", StringComparison.OrdinalIgnoreCase)))
			{
				return A_0.c().b();
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xphw_gunslinger_meetAfterExobase", new bool?(false)).Value)
			{
				return "up-cc";
			}
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_xphw_tripToNorthUnderrail_started", new bool?(false)).Value)
		{
			if (!A_0.r().GetPrimitivePropertyValue<bool>("quest_xphw_tripToNorthUnderrail_theTripContinues", new bool?(false)).Value)
			{
				return "xphw_darkTer2";
			}
			if (!A_0.r().GetPrimitivePropertyValue<bool>("quest_xphw_tripToNorthUnderrail_ambushed", new bool?(false)).Value)
			{
				return "xphw_exobase_tun";
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xphw_gunslinger_followPlayer", new bool?(false)).Value)
			{
				if (A_0.c().b().StartsWith("xphw"))
				{
					return A_0.c().b();
				}
			}
			else
			{
				string text = A_0.r().GetClassPropertyValue<string>(c29.b);
				if (!string.IsNullOrEmpty(text))
				{
					if (text.StartsWith("xphv"))
					{
						text = "xphw" + text.Substring(4);
						A_0.r()[c29.b] = text;
					}
					return text;
				}
				return "xphw_exobase_tun";
			}
		}
		return "xphw_up";
	}

	// Token: 0x06004724 RID: 18212 RVA: 0x001D5A74 File Offset: 0x001D3C74
	public override string ce(cyt A_0, string A_1)
	{
		if (A_1.StartsWith("xphw_"))
		{
			if (A_1.Equals("xphw_exobase_tun") && !A_0.r().GetPrimitivePropertyValue<bool>("quest_xphw_tripToNorthUnderrail_ambushed", new bool?(false)).Value)
			{
				return "railcar";
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xphw_gunslinger_followPlayer", new bool?(false)).Value)
			{
				A_0.r().RemoveProperty(c29.c);
				if (dh7.a != null && dh7.a.d != null)
				{
					return dh7.a.d;
				}
				e0u.a a = new e0u.a();
				a.a = (A_0.v().b() as c5x);
				if (a.a != null)
				{
					string text = Enumerable.FirstOrDefault<csd>(Enumerable.Where<csd>(a.a.Zone.Waypoints, new Func<csd, bool>(a.a))).Name;
					if (!string.IsNullOrWhiteSpace(text) && (text.StartsWith("From") || text.StartsWith("Rift")))
					{
						return text;
					}
				}
			}
			else
			{
				string classPropertyValue = A_0.r().GetClassPropertyValue<string>(c29.b);
				string classPropertyValue2 = A_0.r().GetClassPropertyValue<string>(c29.c);
				if (!string.IsNullOrEmpty(classPropertyValue2))
				{
					return classPropertyValue2;
				}
				if (A_1.Equals("xphw_exobase_tun") && string.IsNullOrEmpty(classPropertyValue))
				{
					return "outsideRailcar";
				}
			}
		}
		return null;
	}

	// Token: 0x06004725 RID: 18213 RVA: 0x001D5BF8 File Offset: 0x001D3DF8
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bool value = A_1.r().GetPrimitivePropertyValue<bool>("npc_xphw_gunslinger_teamUp", new bool?(false)).Value;
		amc aspect = A_0.GetAspect<amc>();
		if (aspect != null)
		{
			if (!A_1.r().GetPrimitivePropertyValue<bool>("quest_xphw_tripToNorthUnderrail_ambushed", new bool?(false)).Value)
			{
				aspect.aa().FactionId = asp.gp;
				aspect.aa().HostilityBroadcastMode = c2n.c;
			}
			else if (string.Equals(A_2, "up-cc", StringComparison.OrdinalIgnoreCase))
			{
				aspect.aa().FactionId = asp.di;
				aspect.aa().HostilityBroadcastMode = c2n.d;
			}
			else
			{
				aspect.aa().FactionId = asp.go;
				aspect.aa().HostilityBroadcastMode = c2n.b;
			}
			if (value && !string.Equals(A_2, "xphw_up", StringComparison.OrdinalIgnoreCase) && !string.Equals(A_2, "up-cc", StringComparison.OrdinalIgnoreCase))
			{
				aspect.aa().AttributesBase |= d8o.u;
			}
			else
			{
				aspect.aa().AttributesBase &= ~d8o.u;
			}
		}
		bm6 aspect2 = A_0.GetAspect<bm6>();
		if (aspect2 != null)
		{
			if (!string.IsNullOrEmpty(aspect2.y6().GetClassPropertyValue<string>(ddq.bz)))
			{
				aspect2.y6().RemoveProperty(ddq.ay);
			}
			else
			{
				aspect2.y6()[ddq.ay] = new bt4("global:xphw_gunslinger");
			}
			if (A_2.Equals("xphw_up"))
			{
				if (!A_1.r().GetPrimitivePropertyValue<bool>("quest_xphw_tripToNorthUnderrail_started", new bool?(false)).Value)
				{
					aspect2.y6()[ddq.w] = CharacterState.Custom1;
					aspect2.y6()[ddq.y] = 12000;
					aspect2.y6()[ddq.x] = 100;
				}
				else if (!A_1.r().GetPrimitivePropertyValue<bool>("npc_xphw_gunslinger_returnedToUpper", new bool?(false)).Value)
				{
					aspect2.y6()[ddq.bc] = "npc_xphw_gunslinger_returnedToUpper";
				}
			}
			else if (aspect2.y6().HasProperty(ddq.w) && aspect2.y6().GetPrimitivePropertyValue<CharacterState>(ddq.w, null).GetValueOrDefault() == CharacterState.Custom1)
			{
				aspect2.y6().RemoveProperty(ddq.w);
				aspect2.y6().RemoveProperty(ddq.y);
				aspect2.y6().RemoveProperty(ddq.x);
			}
		}
		if (string.Equals(A_2, "xphw_exobase_com", StringComparison.OrdinalIgnoreCase))
		{
			A_1.r()["npc_xphw_gunslinger_canGiveStunner"] = true;
		}
	}

	// Token: 0x02000C60 RID: 3168
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004727 RID: 18215 RVA: 0x001D5EDC File Offset: 0x001D40DC
		internal bool a(csd A_0)
		{
			return A_0.Location.Equals(this.a.Location);
		}

		// Token: 0x04001C72 RID: 7282
		public c5x a;
	}
}
