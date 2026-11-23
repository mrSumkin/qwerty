using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000C8A RID: 3210
[eiz("PKDE")]
[Serializable]
public sealed class edn : d4
{
	// Token: 0x060048BD RID: 18621 RVA: 0x001DACE4 File Offset: 0x001D8EE4
	private edn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("PKDE:CA");
	}

	// Token: 0x060048BE RID: 18622 RVA: 0x001DAD00 File Offset: 0x001D8F00
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PKDE:CA", this.a);
	}

	// Token: 0x060048BF RID: 18623 RVA: 0x001DAD1C File Offset: 0x001D8F1C
	public bool a()
	{
		return this.a;
	}

	// Token: 0x060048C0 RID: 18624 RVA: 0x001DAD24 File Offset: 0x001D8F24
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060048C1 RID: 18625 RVA: 0x001DAD30 File Offset: 0x001D8F30
	public override TimeSpan ge()
	{
		if (this.a)
		{
			return TimeSpan.FromMinutes(0.5);
		}
		return TimeSpan.FromMinutes(80.0);
	}

	// Token: 0x060048C2 RID: 18626 RVA: 0x001DAD5C File Offset: 0x001D8F5C
	public override TimeSpan gf()
	{
		if (this.a)
		{
			return TimeSpan.FromMinutes(0.5);
		}
		return TimeSpan.FromMinutes(30.0);
	}

	// Token: 0x060048C3 RID: 18627 RVA: 0x001DAD88 File Offset: 0x001D8F88
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(1.0);
	}

	// Token: 0x060048C4 RID: 18628 RVA: 0x001DAD98 File Offset: 0x001D8F98
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(1.0);
	}

	// Token: 0x060048C5 RID: 18629 RVA: 0x001DADA8 File Offset: 0x001D8FA8
	public edn() : base(edn.b)
	{
	}

	// Token: 0x060048C6 RID: 18630 RVA: 0x001DADB8 File Offset: 0x001D8FB8
	public edn(bool A_0) : base(edn.b)
	{
		this.a = A_0;
	}

	// Token: 0x060048C7 RID: 18631 RVA: 0x001DADD0 File Offset: 0x001D8FD0
	protected override bool ez(cyt A_0)
	{
		if (base.ez(A_0) && (A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rf_locatedMicrochipEncoder", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_hc_removedRootsFromConsole", new bool?(false)).Value))
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

	// Token: 0x060048C8 RID: 18632 RVA: 0x001DAE7C File Offset: 0x001D907C
	protected override void gg(cyt A_0)
	{
		if (!A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionDestroyed", new bool?(false)).Value)
		{
			if (!A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_fu_pirateAttackHandled", new bool?(false)).Value)
			{
				new arc().ym(null, null, null);
			}
			if (!A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_saveTheProfessor_toldAboutEvent", new bool?(false)).Value && (A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorKidnapped", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_fu_pirateAttackFailed", new bool?(false)).Value))
			{
				bv9 bv = A_0.ac() as bv9;
				cky cky = bv.abu(asp.a, asp.f5);
				if (cky != null && cky.a != h.a)
				{
					if (A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorKidnapped", new bool?(false)).Value && this.a)
					{
						bv.a(asp.f5, asp.a, h.a, null, true, false, false);
						bv.a(asp.f7, asp.a, h.a, null, true, false, false);
						bv.a(asp.f6, asp.a, h.a, null, true, false, false);
						A_0.r()["faction_xpbl_aegis_betrayed"] = true;
						A_0.r()["loc_xpbl_camp_allowed"] = false;
						new c8z(null).ym(null, null, null);
						bjv.a(A_0, "interfacing_xpbl_navcom_briggsCallsBetrayal");
						return;
					}
					bjv.a(A_0, "interfacing_xpbl_navcom_pirateSneakAttackEvent");
				}
			}
		}
	}

	// Token: 0x04001CC1 RID: 7361
	private new bool a;

	// Token: 0x04001CC2 RID: 7362
	public static readonly string b = "professorsKidnapping";
}
