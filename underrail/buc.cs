using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02001408 RID: 5128
[eiz("HXSDA")]
[Serializable]
public sealed class buc : b1z, ISerializable
{
	// Token: 0x0600732F RID: 29487 RVA: 0x00308CE0 File Offset: 0x00306EE0
	private buc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("HXSDA:T", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
	}

	// Token: 0x06007330 RID: 29488 RVA: 0x00308D0C File Offset: 0x00306F0C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("HXSDA:T", this.a);
	}

	// Token: 0x06007331 RID: 29489 RVA: 0x00308D28 File Offset: 0x00306F28
	public buc(EntityAspectReference<amc, amc> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06007332 RID: 29490 RVA: 0x00308D38 File Offset: 0x00306F38
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a == null || this.a.ao() == null)
		{
			return dc4.c;
		}
		awq.a(this.a.ao(), 1);
		return dc4.c;
	}

	// Token: 0x04002F12 RID: 12050
	private new EntityAspectReference<amc, amc> a;
}
