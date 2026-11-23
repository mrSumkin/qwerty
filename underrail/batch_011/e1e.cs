using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02001749 RID: 5961
[eiz("TC04")]
[Serializable]
public sealed class e1e : bkj, ISerializable
{
	// Token: 0x06008071 RID: 32881 RVA: 0x0036457C File Offset: 0x0036277C
	private e1e(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008072 RID: 32882 RVA: 0x00364588 File Offset: 0x00362788
	protected override string om()
	{
		return "CrawlerPoisonCaltrops";
	}

	// Token: 0x06008073 RID: 32883 RVA: 0x00364590 File Offset: 0x00362790
	public e1e()
	{
	}

	// Token: 0x06008074 RID: 32884 RVA: 0x00364598 File Offset: 0x00362798
	protected override arn on(c5x A_0, amc A_1, int A_2)
	{
		return new ev1(A_0, new EntityAspectReference<amc, amc>(A_1), A_2, base.vg().e().b9() as coh);
	}
}
