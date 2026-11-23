using System;
using System.Collections.Generic;

// Token: 0x02000C24 RID: 3108
public sealed class ar2 : jn
{
	// Token: 0x0600465A RID: 18010 RVA: 0x001CF970 File Offset: 0x001CDB70
	public ar2() : base("fd_rocksteady", "creature\\characters\\support\\fd_rocksteady")
	{
	}

	// Token: 0x0600465B RID: 18011 RVA: 0x001CF984 File Offset: 0x001CDB84
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

	// Token: 0x0600465C RID: 18012 RVA: 0x001CFA34 File Offset: 0x001CDC34
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

	// Token: 0x0600465D RID: 18013 RVA: 0x001CFB08 File Offset: 0x001CDD08
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
				text += "fd_rocksteady";
				a_ = "";
				if (aspect2 != null)
				{
					aspect2.aa().FactionId = "free_drone_squad";
				}
			}
			else if (string.Equals(A_2, "lu-b30", StringComparison.OrdinalIgnoreCase))
			{
				text += "fd_rocksteady";
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
				aspect.y6()[ddq.ay] = new bt4("global:fd_rocksteady:end");
			}
			else if (string.Equals(A_2, "lu-b31", StringComparison.OrdinalIgnoreCase))
			{
				text += "fd_rocksteady";
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
					"global:fd_rocksteady:end",
					"global:fd_rocksteady:clear"
				};
			}
			else
			{
				text += "fd_c2";
				if (aspect2 != null)
				{
					aspect2.aa().FactionId = "free_drones";
				}
				aspect.y6()[ddq.ay] = new bt4("global:fd_rocksteady");
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
