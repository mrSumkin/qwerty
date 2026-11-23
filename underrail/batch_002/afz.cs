using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x0200174B RID: 5963
[eiz("TC02")]
[Serializable]
public sealed class afz : bkj, ISerializable
{
	// Token: 0x06008079 RID: 32889 RVA: 0x00364614 File Offset: 0x00362814
	private afz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600807A RID: 32890 RVA: 0x00364620 File Offset: 0x00362820
	protected override string om()
	{
		return "BurrowerPoisonCaltrops";
	}

	// Token: 0x0600807B RID: 32891 RVA: 0x00364628 File Offset: 0x00362828
	public afz()
	{
	}

	// Token: 0x0600807C RID: 32892 RVA: 0x00364630 File Offset: 0x00362830
	protected override arn on(c5x A_0, amc A_1, int A_2)
	{
		return new cdr(A_0, new EntityAspectReference<amc, amc>(A_1), A_2, base.vg().e().b9() as coh);
	}
}
