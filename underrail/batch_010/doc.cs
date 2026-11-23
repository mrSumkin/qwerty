using System;
using System.Runtime.Serialization;

// Token: 0x02000C8C RID: 3212
[eiz("SIDLE")]
[Serializable]
public sealed class doc : d4
{
	// Token: 0x060048D7 RID: 18647 RVA: 0x001DB304 File Offset: 0x001D9504
	private doc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetInt32("SIDLE:A");
	}

	// Token: 0x060048D8 RID: 18648 RVA: 0x001DB320 File Offset: 0x001D9520
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SIDLE:A", this.b);
	}

	// Token: 0x060048D9 RID: 18649 RVA: 0x001DB33C File Offset: 0x001D953C
	public override TimeSpan ge()
	{
		return TimeSpan.FromMinutes(90.0);
	}

	// Token: 0x060048DA RID: 18650 RVA: 0x001DB34C File Offset: 0x001D954C
	public override TimeSpan gf()
	{
		return TimeSpan.FromMinutes(5.0);
	}

	// Token: 0x060048DB RID: 18651 RVA: 0x001DB35C File Offset: 0x001D955C
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(2.5);
	}

	// Token: 0x060048DC RID: 18652 RVA: 0x001DB36C File Offset: 0x001D956C
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(2.5);
	}

	// Token: 0x060048DD RID: 18653 RVA: 0x001DB37C File Offset: 0x001D957C
	public doc() : base(doc.a)
	{
	}

	// Token: 0x060048DE RID: 18654 RVA: 0x001DB38C File Offset: 0x001D958C
	public doc(int A_0) : base(doc.a)
	{
		this.b = A_0;
	}

	// Token: 0x060048DF RID: 18655 RVA: 0x001DB3A4 File Offset: 0x001D95A4
	protected override bool ez(cyt A_0)
	{
		return base.ez(A_0) && !A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_underAttack", new bool?(false)).Value && ((this.b >= 3 && A_0.r().GetPrimitivePropertyValue<bool>("interface_xpbl_mc_microChipImplanter_extractedChipFromPhilsHand", new bool?(false)).Value) || (this.b >= 1 && this.b < 3 && (A_0.r().GetPrimitivePropertyValue<bool>("loc_le_openedFort", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rf_locatedMicrochipEncoder", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_hc_removedRootsFromConsole", new bool?(false)).Value)));
	}

	// Token: 0x060048E0 RID: 18656 RVA: 0x001DB49C File Offset: 0x001D969C
	protected override void gg(cyt A_0)
	{
		if (!A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionDestroyed", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_sormirbaren_defeated", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionUndeployed", new bool?(false)).Value && this.b <= 5)
		{
			qj qj;
			if (this.b != 0)
			{
				qj = new qj(this.b);
			}
			else
			{
				qj = new qj();
			}
			qj.ym(A_0.v().b(), null, null);
			if (!A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_expedition_cutCommunication", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_le_camp_wipedOut", new bool?(false)).Value)
			{
				A_0.r()["interfacing_xpbl_navcom_campAttackCall"] = true;
				bjv.a(A_0, "interfacing_xpbl_navcom_savagesAttackCall");
			}
			c88 a_ = new c88(false);
			A_0.b(a_);
		}
	}

	// Token: 0x04001CC5 RID: 7365
	public new static readonly string a = "lemurianSavageInvasion";

	// Token: 0x04001CC6 RID: 7366
	private int b;
}
