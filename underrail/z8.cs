using System;
using System.Runtime.Serialization;

// Token: 0x02001A6B RID: 6763
[eiz("MUTVSE")]
[Serializable]
public sealed class z8 : els, ISerializable
{
	// Token: 0x060092E7 RID: 37607 RVA: 0x003A04CC File Offset: 0x0039E6CC
	private z8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetInt32("MUTVSE:I");
	}

	// Token: 0x060092E8 RID: 37608 RVA: 0x003A04E8 File Offset: 0x0039E6E8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MUTVSE:I", this.b);
	}

	// Token: 0x060092E9 RID: 37609 RVA: 0x003A0504 File Offset: 0x0039E704
	public z8(int A_0, int A_1) : base(z8.a, "Усиление мутации", ci8.b)
	{
		base.Icon = "Status.MutationVigor";
		base.Duration = A_0;
		this.b = A_1;
		base.StaticEffects.Add(new bh1((double)(0.05f * (float)this.b))
		{
			Priority = int.MaxValue
		});
	}

	// Token: 0x060092EA RID: 37610 RVA: 0x003A0564 File Offset: 0x0039E764
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/MutationVigor", new object[]
		{
			5 * this.b
		});
	}

	// Token: 0x04003866 RID: 14438
	public new static readonly string a = "mutationVigor";

	// Token: 0x04003867 RID: 14439
	private int b;
}
