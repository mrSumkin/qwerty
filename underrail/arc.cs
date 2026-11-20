using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B0C RID: 2828
[eiz("XPBLPKJ")]
[Serializable]
public sealed class arc : cze, ISerializable
{
	// Token: 0x06004172 RID: 16754 RVA: 0x00190DE0 File Offset: 0x0018EFE0
	private arc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004173 RID: 16755 RVA: 0x00190DEC File Offset: 0x0018EFEC
	public arc()
	{
	}

	// Token: 0x06004174 RID: 16756 RVA: 0x00190DF8 File Offset: 0x0018EFF8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xpbl_pirates_totalPiratesKilled", new int?(0)).Value < 50 && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_flinger_dead", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_e3_piratesCleared", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_dead", new bool?(false)).Value)
			{
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_le_technician_discovered", new bool?(false)).Value)
				{
					serviceOrThrow.aqu().r()["faction_xpbl_aegis_importantNpcsCanJoinBattle"] = true;
					serviceOrThrow.aqu().r()["loc_xpbl_fu_pirateAttackFailed"] = true;
					if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_xpbl_pirates_joined", new bool?(false)).Value)
					{
						this.a(serviceOrThrow, true);
					}
					if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_cruzer_dead", new bool?(false)).Value)
					{
						serviceOrThrow.aqu().r()["npc_xpbl_pir_cruzer_diedBeforeProfessorsKidnapping"] = true;
					}
				}
				else
				{
					serviceOrThrow.aqu().r()["quests_xpbl_expedition_professorKidnapped"] = true;
					if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_xpbl_pirates_joined", new bool?(false)).Value)
					{
						this.a(serviceOrThrow, false);
					}
					serviceOrThrow.aqu().a(new bw0("xpbl_i5u", new aap(), 1));
				}
			}
			if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionDestroyed", new bool?(false)).Value)
			{
				bo7 a_ = new bo7(false);
				serviceOrThrow.aqu().b(a_);
				serviceOrThrow.aqu().a(new bw0("xpbl_fu", new akd(), 1));
			}
			serviceOrThrow.aqu().r()["loc_xpbl_fu_pirateAttackHandled"] = true;
		}
	}

	// Token: 0x06004175 RID: 16757 RVA: 0x00191068 File Offset: 0x0018F268
	private void a(cnk A_0, bool A_1)
	{
		int value = A_0.aqu().r().GetPrimitivePropertyValue<int>("faction_xpbl_pirates_jetPiratesKilled", new int?(0)).Value;
		int value2 = A_0.aqu().r().GetPrimitivePropertyValue<int>("faction_xpbl_pirates_outskirtPiratesKilled", new int?(0)).Value;
		int value3 = A_0.aqu().r().GetPrimitivePropertyValue<int>("faction_xpbl_pirates_cragPiratesKilled", new int?(0)).Value;
		int num = value + value2 + value3;
		if (num > 10 || A_1)
		{
			this.a(asp.fr, h.a);
			this.a(asp.fv, h.a);
			this.a(asp.ft, h.a);
			this.a(asp.fu, h.a);
			this.a(asp.fs, h.a);
			return;
		}
		this.a(asp.fr, h.b);
		this.a(asp.fv, h.b);
		this.a(asp.ft, h.b);
		this.a(asp.fu, h.b);
		this.a(asp.fs, h.b);
		if (num > 0)
		{
			A_0.aqu().r()["faction_xpbl_pir_thereWasHostility"] = true;
		}
	}

	// Token: 0x06004176 RID: 16758 RVA: 0x0019118C File Offset: 0x0018F38C
	private void a(string A_0, h A_1)
	{
		eaq eaq = new eaq();
		eaq.b(A_0);
		eaq.a(asp.a);
		eaq.a(A_1);
		eaq.a(true);
		eaq.ym(null, null, null);
	}
}
