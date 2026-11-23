using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x0200174C RID: 5964
[eiz("TC01")]
[Serializable]
public sealed class dnk : bkj, ISerializable
{
	// Token: 0x0600807D RID: 32893 RVA: 0x00364660 File Offset: 0x00362860
	private dnk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600807E RID: 32894 RVA: 0x0036466C File Offset: 0x0036286C
	protected override string om()
	{
		return "MetalCaltrops";
	}

	// Token: 0x0600807F RID: 32895 RVA: 0x00364674 File Offset: 0x00362874
	public dnk()
	{
	}

	// Token: 0x06008080 RID: 32896 RVA: 0x0036467C File Offset: 0x0036287C
	protected override arn on(c5x A_0, amc A_1, int A_2)
	{
		return new dq5(A_0, new EntityAspectReference<amc, amc>(A_1), A_2, base.vg().e().b9() as coh);
	}
}
