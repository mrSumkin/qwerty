using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020014EC RID: 5356
[eiz("TRAVA")]
[Serializable]
public sealed class dxy : mo, ISerializable
{
	// Token: 0x06007839 RID: 30777 RVA: 0x00325EC0 File Offset: 0x003240C0
	private dxy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600783A RID: 30778 RVA: 0x00325ECC File Offset: 0x003240CC
	public dxy()
	{
	}

	// Token: 0x0600783B RID: 30779 RVA: 0x00325ED4 File Offset: 0x003240D4
	protected override string ao8()
	{
		return "acidSplash";
	}

	// Token: 0x0600783C RID: 30780 RVA: 0x00325EDC File Offset: 0x003240DC
	protected override string ao9()
	{
		return "AcidVial";
	}

	// Token: 0x0600783D RID: 30781 RVA: 0x00325EE4 File Offset: 0x003240E4
	protected override a1q apa()
	{
		return boc.a(base.vg().e());
	}

	// Token: 0x0600783E RID: 30782 RVA: 0x00325EF8 File Offset: 0x003240F8
	protected override cze apc(edx A_0, EntityAspectReference<amc, amc> A_1)
	{
		return new dku(A_0, A_1, false, true, false);
	}
}
