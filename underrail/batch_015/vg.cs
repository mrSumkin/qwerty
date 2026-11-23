using System;
using TimelapseVertigo.Rules.Comm;

// Token: 0x020015CC RID: 5580
[d1q("Burst")]
public sealed class vg : @if
{
	// Token: 0x06007B2D RID: 31533 RVA: 0x00336484 File Offset: 0x00334684
	public override bool mk()
	{
		return true;
	}

	// Token: 0x06007B2E RID: 31534 RVA: 0x00336488 File Offset: 0x00334688
	public override afq ba()
	{
		return new c1w();
	}

	// Token: 0x06007B2F RID: 31535 RVA: 0x00336490 File Offset: 0x00334690
	public override afq g3()
	{
		return new avt();
	}

	// Token: 0x06007B30 RID: 31536 RVA: 0x00336498 File Offset: 0x00334698
	public override afq ml()
	{
		return new ctw();
	}

	// Token: 0x06007B31 RID: 31537 RVA: 0x003364A0 File Offset: 0x003346A0
	public override CombatSpeakEvent[] b6(amc A_0)
	{
		return new CombatSpeakEvent[]
		{
			CombatSpeakEvent.Battlecry_Burst
		};
	}
}
