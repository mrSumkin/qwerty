using System;
using System.Collections.Generic;

// Token: 0x02000C26 RID: 3110
public sealed class b1u : jn
{
	// Token: 0x06004662 RID: 18018 RVA: 0x001D0224 File Offset: 0x001CE424
	public b1u() : base("fd_jazz", "creature\\characters\\support\\fd_jazz")
	{
	}

	// Token: 0x06004663 RID: 18019 RVA: 0x001D0238 File Offset: 0x001CE438
	public override string b1(cyt A_0)
	{
		if (!A_0.r().GetPrimitivePropertyValue<bool>("quest_fd_AttackSROStarted", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("quest_fd_AttackSROCompleted", new bool?(false)).Value)
		{
			return "lup_freeDroneBase";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_fd_AttackSROStarted_moveNextStage", new bool?(false)).Value)
		{
			return "lu-b31";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_fd_AttackSROStarted_startAttack", new bool?(false)).Value)
		{
			return "lu-b30";
		}
		return "lu-b6";
	}

	// Token: 0x06004664 RID: 18020 RVA: 0x001D02E8 File Offset: 0x001CE4E8
	public override string ce(cyt A_0, string A_1)
	{
		if (string.Equals(A_1, "lu-b30", StringComparison.OrdinalIgnoreCase))
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("loc_b30_clearedProtectorate", new bool?(false)).Value || (!A_0.r().GetPrimitivePropertyValue<bool>("quest_fd_AttackSROSpyRevealed", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("quest_fd_AttackSRO_entered_lu-b30", new bool?(false)).Value))
			{
				return "end";
			}
			return "start";
		}
		else
		{
			if (!string.Equals(A_1, "lu-b31", StringComparison.OrdinalIgnoreCase))
			{
				return null;
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("loc_b31_clearedProtectorate", new bool?(false)).Value)
			{
				return "end";
			}
			return "start";
		}
	}

	// Token: 0x06004665 RID: 18021 RVA: 0x001D03BC File Offset: 0x001CE5BC
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		amc aspect2 = A_0.GetAspect<amc>();
		if (aspect2 != null && (aspect2.am().StartsWith("mutated_human") || aspect2.am().StartsWith("mhun")))
		{
			return;
		}
		string text = "support\\";
		string a_ = "speaker";
		if (aspect != null)
		{
			if (string.Equals(A_2, "lu-b6", StringComparison.OrdinalIgnoreCase))
			{
				text += "fd_jazz";
				a_ = "";
				if (aspect2 != null)
				{
					aspect2.aa().FactionId = "free_drone_squad";
				}
			}
			else if (string.Equals(A_2, "lu-b30", StringComparison.OrdinalIgnoreCase))
			{
				text += "fd_jazz";
				a_ = "";
				aspect.y6().RemoveProperty(ddq.bg);
				if (aspect2 != null)
				{
					aspect2.aa().FactionId = "free_drone_squad";
					if (!A_1.r().GetPrimitivePropertyValue<bool>("quest_fd_AttackSROSpyRevealed", new bool?(false)).Value && aspect2.aa().Gear.h().Item != null)
					{
						aspect2.aa().Defense.a(true);
					}
				}
				aspect.y6()[ddq.ay] = new bt4("global:fd_jazz:end");
			}
			else if (string.Equals(A_2, "lu-b31", StringComparison.OrdinalIgnoreCase))
			{
				text += "fd_jazz";
				a_ = "";
				aspect.y6().RemoveProperty(ddq.bg);
				if (aspect2 != null)
				{
					aspect2.aa().FactionId = "free_drone_squad";
					if (!A_1.r().GetPrimitivePropertyValue<bool>("loc_b31_clearedProtectorate", new bool?(false)).Value && aspect2.aa().Gear.h().Item != null)
					{
						aspect2.aa().Defense.a(true);
					}
				}
				aspect.y6()[ddq.k] = new List<string>
				{
					"global:fd_jazz:end",
					"global:fd_jazz:clear"
				};
			}
			else
			{
				text += "fd_c1";
				if (aspect2 != null)
				{
					aspect2.aa().FactionId = "free_drones";
				}
				aspect.y6()[ddq.ay] = new bt4("global:fd_jazz");
			}
		}
		bn5 bn = A_0.GetAspect<j7>() as bn5;
		if (bn == null)
		{
			bn = new bn5(A_0 as c5x);
			A_0.SetAspect<j7>(bn);
		}
		bn.b(text);
		bn.a(a_);
	}
}
