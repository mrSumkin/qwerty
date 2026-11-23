using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B97 RID: 2967
[eiz("XPBLRAJ")]
[Serializable]
public sealed class b3k : cze, ISerializable
{
	// Token: 0x06004389 RID: 17289 RVA: 0x001A743C File Offset: 0x001A563C
	private b3k(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600438A RID: 17290 RVA: 0x001A7448 File Offset: 0x001A5648
	public b3k()
	{
	}

	// Token: 0x0600438B RID: 17291 RVA: 0x001A7454 File Offset: 0x001A5654
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
			bpo.GetService<d02>();
			if (serviceOrThrow.aqu() != null)
			{
				serviceOrThrow.aqu().v().b();
				bool flag = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_alarmRaised", new bool?(false)).Value;
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_attacked", new bool?(false)).Value;
				int value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_rig_eelsKilled", new int?(0)).Value;
				if (!flag && value2 >= 3)
				{
					flag = true;
					serviceOrThrow.aqu().r()["loc_xpbl_rig_alarmRaised"] = true;
					if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_partyDocksAtRig", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_partyLeavesRig", new bool?(false)).Value)
					{
						serviceOrThrow.aqu().r()["quests_xpbl_pirates_theRig_prematureAttackStarted"] = true;
					}
				}
				if (flag && !value)
				{
					serviceOrThrow.aqu().r()["loc_xpbl_rig_attacked"] = true;
				}
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_partyDocksAtRig", new bool?(false)).Value)
				{
					c5x c5x = new ar7(new Guid("0f53f89f-6d8e-4e59-b1f7-a6c8c897f8b2"), aud).ao() as c5x;
					c5x c5x2 = new ar7(new Guid("a622d718-a037-4470-8fc8-eb8f9d78f79f"), aud).ao() as c5x;
					c5x c5x3 = new ar7(new Guid("0f86b490-9107-4805-bac7-bf56f6dd9f30"), aud).ao() as c5x;
					c5x c5x4 = new ar7(new Guid("af08c49d-4b20-4569-a088-a6730a87c4f1"), aud).ao() as c5x;
					bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_prematureAttackStarted", new bool?(false)).Value;
					bool value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_attackStarted", new bool?(false)).Value;
					bool value5 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_attackSecondZone", new bool?(false)).Value;
					bool value6 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_sonarDestroyed", new bool?(false)).Value;
					if (!value4)
					{
						c5x c5x5 = new ar7(new Guid("6c68ee45-d1b9-4af9-8d12-21b010028609"), aud).ao() as c5x;
						if (value3)
						{
							serviceOrThrow.aqz().atd("theRigSonarPartyTurrets", true);
							this.a(serviceOrThrow, c5x, c5x2, c5x3, c5x4);
							return;
						}
						if (c5x5 != null)
						{
							axh aspect = c5x5.GetAspect<axh>();
							if ((aspect != null && !aspect.i()) || value3)
							{
								this.a(serviceOrThrow, c5x, c5x2, c5x3, c5x4);
								serviceOrThrow.aqz().atc("theRigSonarPartyTurrets", true);
								return;
							}
						}
					}
					else if (serviceOrThrow.aqw().y8() == "xpbl_rig2")
					{
						if (!value6)
						{
							this.a(c5x, "cruzer_sonar", false);
							this.a(c5x2, "pirateRaider1_sonar", false);
							this.a(c5x3, "pirateRaider2_sonar", false);
							this.a(c5x4, "pirateRaider3_sonar", false);
							return;
						}
						this.a(c5x, "global:xpbl_cruzer", true);
						this.a(c5x2, "global:xpbl_pirateRaider1", true);
						this.a(c5x3, "global:xpbl_pirateRaider2", true);
						this.a(c5x4, "global:xpbl_pirateRaider3", true);
					}
				}
			}
		}
	}

	// Token: 0x0600438C RID: 17292 RVA: 0x001A783C File Offset: 0x001A5A3C
	private c5x a(c5x A_0, string A_1, bool A_2 = false)
	{
		if (A_0 != null && A_0.t.b != null && A_0.t.b.y6().GetClassPropertyValue<bt4>(ddq.ay).b() != A_1)
		{
			A_0.t.b.y6()[ddq.ay] = new bt4(A_1);
			if (A_2)
			{
				A_0.t.b.y6()[ddq.bg] = true;
			}
		}
		return A_0;
	}

	// Token: 0x0600438D RID: 17293 RVA: 0x001A78D0 File Offset: 0x001A5AD0
	private void a(cnk A_0, c5x A_1, c5x A_2, c5x A_3, c5x A_4)
	{
		if (!A_0.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_hostilitiesSet", new bool?(false)).Value)
		{
			bv9 bv = A_0.aqu().ac() as bv9;
			if (bv != null)
			{
				bv.a(asp.fw, asp.gg, h.a, null, true, false, false);
				bv.a(asp.fw, asp.gh, h.a, null, true, false, false);
				bv.a(asp.gi, asp.fw, h.a, null, false, false, false);
				bv.a(asp.gi, asp.a, h.a, null, false, false, false);
				bv.a(asp.a, asp.gg, h.a, null, true, false, false);
				bv.a(asp.a, asp.gh, h.a, null, true, false, false);
				A_0.aqu().r()["quests_xpbl_pirates_theRig_hostilitiesSet"] = true;
			}
		}
		A_0.aqu().r()["quests_xpbl_pirates_theRig_attackStarted"] = true;
		this.a(A_1, "cruzer_attack", true);
		this.a(A_2, "pirateRaider1_attack", true);
		this.a(A_3, "pirateRaider2_attack", true);
		this.a(A_4, "pirateRaider3_attack", true);
	}
}
