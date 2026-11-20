using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000C77 RID: 3191
[eiz("BCAMS")]
[Serializable]
public sealed class ejy : d4
{
	// Token: 0x060047F9 RID: 18425 RVA: 0x001D8F54 File Offset: 0x001D7154
	private ejy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060047FA RID: 18426 RVA: 0x001D8F60 File Offset: 0x001D7160
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x060047FB RID: 18427 RVA: 0x001D8F6C File Offset: 0x001D716C
	public override TimeSpan ge()
	{
		return TimeSpan.FromMinutes(2.0);
	}

	// Token: 0x060047FC RID: 18428 RVA: 0x001D8F7C File Offset: 0x001D717C
	public override TimeSpan gf()
	{
		return TimeSpan.FromMinutes(0.2);
	}

	// Token: 0x060047FD RID: 18429 RVA: 0x001D8F8C File Offset: 0x001D718C
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(0.2);
	}

	// Token: 0x060047FE RID: 18430 RVA: 0x001D8F9C File Offset: 0x001D719C
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(0.2);
	}

	// Token: 0x060047FF RID: 18431 RVA: 0x001D8FAC File Offset: 0x001D71AC
	public ejy() : base(ejy.a)
	{
	}

	// Token: 0x06004800 RID: 18432 RVA: 0x001D8FBC File Offset: 0x001D71BC
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
			return text == null || !list.Contains(text);
		}
		return false;
	}

	// Token: 0x06004801 RID: 18433 RVA: 0x001D9024 File Offset: 0x001D7224
	protected override void gg(cyt A_0)
	{
		cky cky = (A_0.ac() as bv9).abu(asp.a, asp.f5);
		if (cky != null && cky.a != h.a && !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorSaved", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_le_marcus_askTechnicianRadio", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_investigateMedical_started", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_briggs_talkedSuppliesForMuties", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_briggs_dead", new bool?(false)).Value)
		{
			bjv.a(A_0, "interfacing_xpbl_navcom_briggsCallsAboutMutieSupplies");
		}
	}

	// Token: 0x04001CA9 RID: 7337
	public new static readonly string a = "briggsCallsAboutMutieSupplies";
}
