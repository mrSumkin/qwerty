using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02001741 RID: 5953
[eiz("TC05")]
[Serializable]
public sealed class ecv : bkj, ISerializable
{
	// Token: 0x06008050 RID: 32848 RVA: 0x00363248 File Offset: 0x00361448
	private ecv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008051 RID: 32849 RVA: 0x00363254 File Offset: 0x00361454
	protected override string om()
	{
		return "Xpbl_BlindingPoisonCaltrops";
	}

	// Token: 0x06008052 RID: 32850 RVA: 0x0036325C File Offset: 0x0036145C
	public ecv()
	{
	}

	// Token: 0x06008053 RID: 32851 RVA: 0x00363264 File Offset: 0x00361464
	protected override arn on(c5x A_0, amc A_1, int A_2)
	{
		return new dn(A_0, new EntityAspectReference<amc, amc>(A_1), A_2, base.vg().e().b9() as coh);
	}
}
