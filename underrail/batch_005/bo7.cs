using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000C88 RID: 3208
[eiz("PGMDE")]
[Serializable]
public sealed class bo7 : d4
{
	// Token: 0x060048A6 RID: 18598 RVA: 0x001DA7D4 File Offset: 0x001D89D4
	private bo7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetBoolean("PGMDE:CA");
	}

	// Token: 0x060048A7 RID: 18599 RVA: 0x001DA7F0 File Offset: 0x001D89F0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PGMDE:CA", this.b);
	}

	// Token: 0x060048A8 RID: 18600 RVA: 0x001DA80C File Offset: 0x001D8A0C
	public bool a()
	{
		return this.b;
	}

	// Token: 0x060048A9 RID: 18601 RVA: 0x001DA814 File Offset: 0x001D8A14
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060048AA RID: 18602 RVA: 0x001DA820 File Offset: 0x001D8A20
	public override TimeSpan ge()
	{
		if (this.b)
		{
			return TimeSpan.FromMinutes(1.0);
		}
		return TimeSpan.FromMinutes(5.0);
	}

	// Token: 0x060048AB RID: 18603 RVA: 0x001DA84C File Offset: 0x001D8A4C
	public override TimeSpan gf()
	{
		return TimeSpan.FromMinutes(0.2);
	}

	// Token: 0x060048AC RID: 18604 RVA: 0x001DA85C File Offset: 0x001D8A5C
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(0.2);
	}

	// Token: 0x060048AD RID: 18605 RVA: 0x001DA86C File Offset: 0x001D8A6C
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(0.2);
	}

	// Token: 0x060048AE RID: 18606 RVA: 0x001DA87C File Offset: 0x001D8A7C
	public bo7() : base(bo7.a)
	{
	}

	// Token: 0x060048AF RID: 18607 RVA: 0x001DA88C File Offset: 0x001D8A8C
	public bo7(bool A_0) : base(bo7.a)
	{
		this.b = A_0;
	}

	// Token: 0x060048B0 RID: 18608 RVA: 0x001DA8A4 File Offset: 0x001D8AA4
	protected override bool ez(cyt A_0)
	{
		if (base.ez(A_0))
		{
			List<string> list = new List<string>
			{
				"D5",
				"D6",
				"E5",
				"E6"
			};
			string text = e3m.a();
			if (A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_investigateNexus_started", new bool?(false)).Value && (!A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_investigateNexus_completed", new bool?(false)).Value || !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_investigateHorticulture_completed", new bool?(false)).Value))
			{
				return false;
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorKidnapped", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorSaved", new bool?(false)).Value)
			{
				return false;
			}
			if (!A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_oldfield_dead", new bool?(false)).Value)
			{
				return text == null || !list.Contains(text);
			}
		}
		return false;
	}

	// Token: 0x060048B1 RID: 18609 RVA: 0x001DA9E0 File Offset: 0x001D8BE0
	protected override void gg(cyt A_0)
	{
		cky cky = (A_0.ac() as bv9).abu(asp.a, asp.f5);
		if (cky != null && cky.a != h.a && !A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_expedition_cutCommunication", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionDestroyed", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionUndeployed", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_aegis_betrayed", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_faction_xpbl_expedition_playerFired", new bool?(false)).Value)
		{
			bjv.a(A_0, "interfacing_xpbl_navcom_newMission");
		}
	}

	// Token: 0x04001CBE RID: 7358
	public new static readonly string a = "professorGivesMission";

	// Token: 0x04001CBF RID: 7359
	private bool b;
}
