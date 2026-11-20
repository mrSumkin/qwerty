using System;
using System.Runtime.Serialization;

// Token: 0x020019CC RID: 6604
[eiz("CDPE")]
[Serializable]
public sealed class cfx : d3e, ISerializable
{
	// Token: 0x06008D84 RID: 36228 RVA: 0x0039372C File Offset: 0x0039192C
	private cfx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008D85 RID: 36229 RVA: 0x00393738 File Offset: 0x00391938
	public cfx()
	{
	}

	// Token: 0x06008D86 RID: 36230 RVA: 0x00393740 File Offset: 0x00391940
	protected override void @in(ll A_0)
	{
	}

	// Token: 0x06008D87 RID: 36231 RVA: 0x00393744 File Offset: 0x00391944
	public override d3e b3()
	{
		cfx cfx = new cfx();
		this.xx(cfx);
		return cfx;
	}

	// Token: 0x06008D88 RID: 36232 RVA: 0x00393760 File Offset: 0x00391960
	public override string b2()
	{
		return qv.a("StatusEffects/ChemicalDestabilizationProvider", new object[]
		{
			(int)(r9.a * 100.0),
			l4.a(r9.c, false),
			r9.b
		});
	}
}
