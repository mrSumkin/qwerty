using System;
using System.Runtime.Serialization;

// Token: 0x02001339 RID: 4921
[eiz("IA")]
[Serializable]
public sealed class bx5 : b1z, ISerializable
{
	// Token: 0x06006F82 RID: 28546 RVA: 0x002ECD98 File Offset: 0x002EAF98
	private bx5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (ar7)A_0.GetValue("IA:IR", typeof(ar7));
			return;
		}
		if (base.GetType() == typeof(bx5))
		{
			this.a = (ar7)A_0.GetValue("_InvestigatorRef", typeof(ar7));
			return;
		}
		this.a = (ar7)A_0.GetValue("InvestigateAction+_InvestigatorRef", typeof(ar7));
	}

	// Token: 0x06006F83 RID: 28547 RVA: 0x002ECE34 File Offset: 0x002EB034
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("IA:IR", this.a);
	}

	// Token: 0x06006F84 RID: 28548 RVA: 0x002ECE50 File Offset: 0x002EB050
	public override m7 kh()
	{
		return m7.b | m7.g | m7.j;
	}

	// Token: 0x06006F85 RID: 28549 RVA: 0x002ECE58 File Offset: 0x002EB058
	public c5x a()
	{
		return this.a.ao() as c5x;
	}

	// Token: 0x06006F86 RID: 28550 RVA: 0x002ECE6C File Offset: 0x002EB06C
	public bx5(c5x A_0)
	{
		this.a = new ar7(A_0);
	}

	// Token: 0x06006F87 RID: 28551 RVA: 0x002ECE80 File Offset: 0x002EB080
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		return dc4.b;
	}

	// Token: 0x04002D94 RID: 11668
	private new ar7 a;
}
