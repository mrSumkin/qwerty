using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B9D RID: 2973
[eiz("XPBLLELMD")]
[Serializable]
public sealed class yb : cze, ISerializable
{
	// Token: 0x0600439D RID: 17309 RVA: 0x001A899C File Offset: 0x001A6B9C
	private yb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600439E RID: 17310 RVA: 0x001A89A8 File Offset: 0x001A6BA8
	public yb()
	{
	}

	// Token: 0x0600439F RID: 17311 RVA: 0x001A89B4 File Offset: 0x001A6BB4
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
			if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_xpbl_expedition_playerFired", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_leavingDueToProfessorsDeath", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_xpbl_le_ladelmanMarcusFinalDialog", new bool?(false)).Value)
			{
				TimeSpan? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>("global_xpbl_le_timeBeforeLadelmanMarcusNextDialog", null);
				if ((serviceOrThrow.aqu().ac() as bv9).abu(asp.a, asp.f6).a != h.a)
				{
					if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_xpbl_savageInvasion_completed", new bool?(false)).Value && primitivePropertyValue == null)
					{
						this.a(aud);
						return;
					}
					if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_finalDungeon_completed", new bool?(false)).Value)
					{
						this.a(aud);
						return;
					}
					if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("events_xpbl_tonyAndMarcus_kidnapping", new bool?(false)).Value && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorKidnapped", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorSaved", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_saveTheProfessor_started", new bool?(false)).Value)
					{
						this.a(aud);
						return;
					}
					if (serviceOrThrow.aqu().p() > primitivePropertyValue)
					{
						if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("events_xpbl_tonyAndMarcus_bored", new bool?(false)).Value)
						{
							if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_le_openedFort", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("events_xpbl_tonyAndMarcus_fort", new bool?(false)).Value)
							{
								this.a(aud);
								return;
							}
						}
						else
						{
							this.a(aud);
						}
					}
				}
			}
		}
	}

	// Token: 0x060043A0 RID: 17312 RVA: 0x001A8C8C File Offset: 0x001A6E8C
	private void a(aud A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		c5x c5x = new ar7(new Guid("9a9e435f-ea2b-46f9-94bd-13cf592b262d"), A_0).ao() as c5x;
		c5x c5x2 = new ar7(new Guid("5e069237-f790-4a3d-a505-d667f88f2d83"), A_0).ao() as c5x;
		if (serviceOrThrow != null && c5x != null && c5x2 != null)
		{
			serviceOrThrow.aqu().r()["global_xpbl_le_timeBeforeLadelmanMarcusNextDialog"] = serviceOrThrow.aqu().p() + TimeSpan.FromMinutes(60.0);
			cu4 cu = new cu4();
			cu.a("events\\xpbl\\le_tonyAndMarcus");
			cu.a(new Guid?(c5x.qe()));
			cu.ym(serviceOrThrow.aqu().v().b(), c5x, null);
		}
	}
}
