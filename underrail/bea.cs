using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02001418 RID: 5144
[eiz("YA0")]
[Serializable]
public sealed class bea : b1z, ISerializable
{
	// Token: 0x0600736F RID: 29551 RVA: 0x0030A8F8 File Offset: 0x00308AF8
	private bea(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("YA0:T", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
		this.b = A_0.GetInt32("YA0:A");
		this.c = A_0.GetBoolean("YA0:P");
	}

	// Token: 0x06007370 RID: 29552 RVA: 0x0030A950 File Offset: 0x00308B50
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("YA0:T", this.a);
		info.AddValue("YA0:A", this.b);
		info.AddValue("YA0:P", this.c);
	}

	// Token: 0x06007371 RID: 29553 RVA: 0x0030A998 File Offset: 0x00308B98
	public bea(EntityAspectReference<amc, amc> A_0, int A_1, bool A_2)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x06007372 RID: 29554 RVA: 0x0030A9B8 File Offset: 0x00308BB8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a == null || this.a.ao() == null)
		{
			return dc4.e;
		}
		this.a.ao().aa().Offense.d(this.b, this.c);
		return dc4.c;
	}

	// Token: 0x04002F31 RID: 12081
	private new EntityAspectReference<amc, amc> a;

	// Token: 0x04002F32 RID: 12082
	private int b;

	// Token: 0x04002F33 RID: 12083
	private bool c;
}
