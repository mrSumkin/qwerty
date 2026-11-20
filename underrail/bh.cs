using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules;

// Token: 0x02000B09 RID: 2825
[eiz("XPBLLECIARTSAADE")]
[Serializable]
public sealed class bh : cze, ISerializable
{
	// Token: 0x06004161 RID: 16737 RVA: 0x00190408 File Offset: 0x0018E608
	private bh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("XPBLLECIARTSAADE:ZI");
	}

	// Token: 0x06004162 RID: 16738 RVA: 0x00190424 File Offset: 0x0018E624
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPBLLECIARTSAADE:ZI", this.a);
	}

	// Token: 0x06004163 RID: 16739 RVA: 0x00190440 File Offset: 0x0018E640
	public string a()
	{
		return this.a;
	}

	// Token: 0x06004164 RID: 16740 RVA: 0x00190448 File Offset: 0x0018E648
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004165 RID: 16741 RVA: 0x00190454 File Offset: 0x0018E654
	public bh()
	{
	}

	// Token: 0x06004166 RID: 16742 RVA: 0x00190460 File Offset: 0x0018E660
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			int num = 30;
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_investigateDepotStarted", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_le_openedFort", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_xpbl_aegis_betrayed", new bool?(false)).Value)
			{
				eaq eaq = new eaq();
				eaq.b(asp.f5);
				eaq.a(asp.a);
				eaq.a(h.a);
				eaq.a(true);
				eaq.ym(null, null, null);
				serviceOrThrow.aqu().r()["faction_xpbl_aegis_betrayed"] = true;
				num = 100;
			}
			if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionDestroyed", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionUndeployed", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_leavingDueToProfessorsDeath", new bool?(false)).Value && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("global_xpbl_aegisSecTroopersAvailable", new int?(0)).Value > 10)
			{
				int num2 = new Random().Next(0, 101);
				bv9 bv = serviceOrThrow.aqu().ac() as bv9;
				if (bv != null)
				{
					cky cky = bv.abu(asp.a, asp.f5);
					if (cky != null && (cky.a == h.a || serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_xpbl_aegis_betrayed", new bool?(false)).Value || !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_beginExpedition", new bool?(false)).Value || serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_xpbl_expedition_playerFired", new bool?(false)).Value))
					{
						bu6 service = bpo.GetService<bu6>();
						if (service != null && num != 100)
						{
							if (service.aq2() >= GameDifficulty.Dominating)
							{
							}
							if (service.aq2() == GameDifficulty.Hard)
							{
								num = 80;
							}
							else
							{
								num = 60;
							}
						}
						if (num2 < num)
						{
							serviceOrThrow.aqu().a(new bw0(this.a, new e8y(), 1));
							serviceOrThrow.aqu().b(new bet(this.a, false));
							serviceOrThrow.aqu().r()["loc_xpbl_le_aegisRecoveryTeamAtDungeonEntrance_active"] = true;
						}
					}
				}
			}
		}
	}

	// Token: 0x04001C15 RID: 7189
	private new string a;
}
