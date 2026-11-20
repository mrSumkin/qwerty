using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000467 RID: 1127
[eiz("VMEXA")]
[Serializable]
internal sealed class b2b : b1z, ISerializable
{
	// Token: 0x06001D48 RID: 7496 RVA: 0x000A2640 File Offset: 0x000A0840
	private b2b(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (A_0.GetValue("VMEXA:ME", typeof(ar7)) as ar7);
	}

	// Token: 0x06001D49 RID: 7497 RVA: 0x000A266C File Offset: 0x000A086C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("VMEXA:ME", this.b);
	}

	// Token: 0x06001D4A RID: 7498 RVA: 0x000A2688 File Offset: 0x000A0888
	public b2b(b0b A_0)
	{
		this.b = new ar7(A_0);
	}

	// Token: 0x06001D4B RID: 7499 RVA: 0x000A26A0 File Offset: 0x000A08A0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.b != null)
		{
			c5x c5x = this.b.ao() as c5x;
			if (c5x != null && c5x.s.b != null && c5x.o.b != null && c5x.o.b.b.Y != 4)
			{
				return dc4.c;
			}
		}
		return dc4.e;
	}

	// Token: 0x04001033 RID: 4147
	private new EntityAspectReference<bm6, bm6> a;

	// Token: 0x04001034 RID: 4148
	private ar7 b;
}
