using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B10 RID: 2832
[eiz("XPBLECAJ")]
[Serializable]
public sealed class hn : cze, ISerializable
{
	// Token: 0x06004180 RID: 16768 RVA: 0x00191714 File Offset: 0x0018F914
	private hn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004181 RID: 16769 RVA: 0x00191720 File Offset: 0x0018F920
	public hn()
	{
	}

	// Token: 0x06004182 RID: 16770 RVA: 0x0019172C File Offset: 0x0018F92C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqu().r()["loc_xpbl_camp_underAttack"] = false;
			serviceOrThrow.aqu().r()["loc_xpbl_e5_invasionPrepDone"] = false;
			serviceOrThrow.aqu().r()["loc_xpbl_camp_underAttack"] = false;
			serviceOrThrow.aqu().r()["loc_xpbl_e5_setUpDefense"] = false;
			serviceOrThrow.aqu().r()["loc_xpbl_e5_invadersKilled"] = 0;
			serviceOrThrow.aqu().r()["loc_xpbl_e5_invadersLanded"] = 0;
			serviceOrThrow.aqu().r()["loc_xpbl_e5_specialAttackersCounter"] = 0;
			serviceOrThrow.aqu().r()["loc_xpbl_e5_invasionPrepDone"] = false;
			serviceOrThrow.aqu().r()["loc_xpbl_e5_specialCaseIndexes"] = null;
			serviceOrThrow.aqu().r()["loc_xpbl_e5_invasionStarted"] = false;
			serviceOrThrow.aqu().r()["loc_xpbl_e5_invasionEnded"] = false;
			serviceOrThrow.aqu().r()["loc_xpbl_e5_invasion_shieldsTurnedOn"] = false;
			serviceOrThrow.aqu().r()["loc_xpbl_e5_wavesDone"] = 0;
			serviceOrThrow.aqu().r()["loc_xpbl_e5_queueCleanup"] = true;
			this.a(serviceOrThrow);
			if (serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_xpbl_e5_invadersType") == "Sormirbaren")
			{
				int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_e5_battleNumber", new int?(0)).Value;
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_xpbl_savageInvasion_completed", new bool?(false)).Value)
				{
					serviceOrThrow.aqu().r()["loc_xpbl_e5_allInvadersKilled"] = false;
				}
				if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionDestroyed", new bool?(false)).Value && value <= 4)
				{
					doc a_ = new doc(value + 1);
					serviceOrThrow.aqu().a(a_);
				}
			}
		}
	}

	// Token: 0x06004183 RID: 16771 RVA: 0x0019199C File Offset: 0x0018FB9C
	private void a(cnk A_0)
	{
		foreach (string a_ in new List<string>
		{
			"xpbl_c7",
			"xpbl_d7",
			"xpbl_e7",
			"xpbl_f5",
			"xpbl_f6",
			"xpbl_f7"
		})
		{
			A_0.aqu().a(new bw0(a_, new erw(false), 1));
			new dvn(a_, "xpbl_BlackSea").ym(null, null, null);
		}
	}
}
