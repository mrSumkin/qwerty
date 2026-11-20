using System;

// Token: 0x02000C15 RID: 3093
public sealed class a8 : jn
{
	// Token: 0x06004625 RID: 17957 RVA: 0x001CBB7C File Offset: 0x001C9D7C
	public override string cc()
	{
		return "xpbl";
	}

	// Token: 0x06004626 RID: 17958 RVA: 0x001CBB84 File Offset: 0x001C9D84
	public a8() : base("xpbl_seeger", "creature\\characters\\xpbl\\Seeger")
	{
	}

	// Token: 0x06004627 RID: 17959 RVA: 0x001CBB98 File Offset: 0x001C9D98
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionUndeployed", new bool?(false)).Value)
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("global_beginExpedition", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_le_philsImplantAcquired", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("loc_le_openedFort", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorKidnapped", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_fu_pirateAttackFailed", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_sc_foundDispatcherCoordinates", new bool?(false)).Value)
		{
			return "xpbl_fu";
		}
		return "xpbl_e6";
	}

	// Token: 0x06004628 RID: 17960 RVA: 0x001CBCA8 File Offset: 0x001C9EA8
	public override string ce(cyt A_0, string A_1)
	{
		cky cky = (A_0.ac() as bv9).abu(asp.a, asp.f6);
		if (string.Equals(A_1, "xpbl_e6", StringComparison.OrdinalIgnoreCase))
		{
			if (!A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_le_philsImplantAcquired", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("loc_le_openedFort", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorKidnapped", new bool?(false)).Value || !A_0.r().GetPrimitivePropertyValue<bool>("global_beginExpedition", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_pirates_joined", new bool?(false)).Value || cky.a == h.a)
			{
				return "tent";
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("event_xpbl_enteringFort_moveSeeger", new bool?(false)).Value)
			{
				return "move";
			}
			return "fort";
		}
		else
		{
			if (!string.Equals(A_1, "xpbl_fu", StringComparison.OrdinalIgnoreCase))
			{
				return null;
			}
			if (!A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_fu_descended", new bool?(false)).Value)
			{
				return "up";
			}
			return "research";
		}
	}

	// Token: 0x06004629 RID: 17961 RVA: 0x001CBE14 File Offset: 0x001CA014
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		if (aspect != null)
		{
			bool flag = true;
			if (string.Equals(A_2, "xpbl_e6", StringComparison.OrdinalIgnoreCase))
			{
				if (A_1.r().GetPrimitivePropertyValue<bool>("global_beginExpedition", new bool?(false)).Value)
				{
					if (!A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorKidnapped", new bool?(false)).Value)
					{
						if (!A_1.r().GetPrimitivePropertyValue<bool>("loc_le_openedFort", new bool?(false)).Value)
						{
							if (A_1.r().GetPrimitivePropertyValue<bool>("event_xpbl_enteringFort_moveSeeger", new bool?(false)).Value)
							{
								aspect.y6()[ddq.ay] = new bt4("global:xpbl_seeger:move");
								flag = false;
							}
							else if (A_1.r().GetPrimitivePropertyValue<bool>("global_xpbl_le_philsImplantAcquired", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_saveTheProfessor_completed", new bool?(false)).Value)
							{
								aspect.y6()[ddq.ay] = new bt4("global:xpbl_seeger:fort");
								flag = false;
							}
							else
							{
								aspect.y6()[ddq.ay] = new bt4("global:xpbl_seeger:tent");
							}
						}
						else
						{
							aspect.y6()[ddq.ay] = new bt4("global:xpbl_seeger:tent");
						}
					}
					else
					{
						aspect.y6()[ddq.ay] = new bt4("global:xpbl_seeger:tent");
					}
				}
				else
				{
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_seeger:tent");
				}
			}
			else if (string.Equals(A_2, "xpbl_fu", StringComparison.OrdinalIgnoreCase))
			{
				aspect.y6()[ddq.ay] = new bt4("global:xpbl_seeger:research");
				flag = false;
			}
			else
			{
				aspect.y6()[ddq.ay] = new bt4("global:xpbl_seeger");
			}
			if (flag)
			{
				aspect.y6()[ddq.b2] = true;
				aspect.y6()[ddq.b3] = "coffee";
				aspect.y6()[ddq.b5] = 0;
				aspect.y6()[ddq.b4] = 500;
			}
			else
			{
				aspect.y6().RemoveProperty(ddq.b2);
				aspect.y6().RemoveProperty(ddq.b3);
				aspect.y6().RemoveProperty(ddq.b5);
				aspect.y6().RemoveProperty(ddq.b3);
			}
		}
		string a_ = "characters\\xpbl\\le_jeremy";
		if (A_1.r().GetPrimitivePropertyValue<bool>("global_xpbl_le_philsImplantAcquired", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("loc_le_openedFort", new bool?(false)).Value)
		{
			a_ = "events\\xpbl\\le_openingFort";
		}
		bn5 bn = A_0.GetAspect<j7>() as bn5;
		if (bn == null)
		{
			bn = new bn5(A_0 as c5x);
			A_0.SetAspect<j7>(bn);
		}
		bn.b(a_);
	}
}
