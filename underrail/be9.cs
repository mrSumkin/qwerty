using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02001428 RID: 5160
[eiz("DA3")]
[Serializable]
public sealed class be9 : b1z, ISerializable
{
	// Token: 0x060073B3 RID: 29619 RVA: 0x0030DF64 File Offset: 0x0030C164
	private be9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (EntityAspectReference<bm6, bm6>)A_0.GetValue("DA3:I", typeof(EntityAspectReference<bm6, bm6>));
	}

	// Token: 0x060073B4 RID: 29620 RVA: 0x0030DF90 File Offset: 0x0030C190
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DA3:I", this.a);
	}

	// Token: 0x060073B5 RID: 29621 RVA: 0x0030DFAC File Offset: 0x0030C1AC
	public be9(bm6 A_0)
	{
		this.a = new EntityAspectReference<bm6, bm6>(A_0);
	}

	// Token: 0x060073B6 RID: 29622 RVA: 0x0030DFC0 File Offset: 0x0030C1C0
	protected override dc4 dt()
	{
		if (this.a != null && this.a.ao() != null)
		{
			this.a.ao().ah();
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x060073B7 RID: 29623 RVA: 0x0030DFF0 File Offset: 0x0030C1F0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		return dc4.e;
	}

	// Token: 0x04002F45 RID: 12101
	private new EntityAspectReference<bm6, bm6> a;
}
