using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02001320 RID: 4896
[eiz("PCX")]
[Serializable]
public sealed class ext : c47, ISerializable
{
	// Token: 0x06006EE4 RID: 28388 RVA: 0x002E92CC File Offset: 0x002E74CC
	private ext(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("PCX:A", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
		this.b = (A_0.GetValue("PCX:B", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
	}

	// Token: 0x06006EE5 RID: 28389 RVA: 0x002E9324 File Offset: 0x002E7524
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PCX:A", this.a);
		info.AddValue("PCX:B", this.b);
	}

	// Token: 0x06006EE6 RID: 28390 RVA: 0x002E9350 File Offset: 0x002E7550
	public ext(amc A_0, amc A_1)
	{
		this.a = new EntityAspectReference<amc, amc>(A_0);
		this.b = new EntityAspectReference<amc, amc>(A_1);
	}

	// Token: 0x04002D56 RID: 11606
	public EntityAspectReference<amc, amc> a;

	// Token: 0x04002D57 RID: 11607
	public EntityAspectReference<amc, amc> b;
}
