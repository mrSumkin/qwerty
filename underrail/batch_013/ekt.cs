using System;
using System.Runtime.Serialization;

// Token: 0x020013E1 RID: 5089
[eiz("AOEWAI")]
[Serializable]
public sealed class ekt : ISerializable
{
	// Token: 0x060072AA RID: 29354 RVA: 0x00302544 File Offset: 0x00300744
	private ekt(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetDouble("AOEWAI:C");
		this.b = A_0.GetDouble("AOEWAI:B");
		this.c = (A_0.GetValue("AOEWAI:W", typeof(cd1)) as cd1);
	}

	// Token: 0x060072AB RID: 29355 RVA: 0x0030259C File Offset: 0x0030079C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("AOEWAI:C", this.a);
		info.AddValue("AOEWAI:B", this.b);
		info.AddValue("AOEWAI:W", this.c);
	}

	// Token: 0x060072AC RID: 29356 RVA: 0x003025D4 File Offset: 0x003007D4
	public ekt()
	{
	}

	// Token: 0x060072AD RID: 29357 RVA: 0x003025E0 File Offset: 0x003007E0
	public xo a(amc A_0, amc A_1)
	{
		cmn cmn = awq.a(A_0, A_1, this.c, null);
		xo xo = new xo();
		xo.a = this.a + cmn.c;
		xo.b = this.b + cmn.d;
		xo.c = cmn.b;
		xo.d = cmn.i;
		xo.e = cmn.g;
		xo.a += A_1.aa().Defense.w();
		euf.a(ref xo.a, A_0.aa(), A_1.aa());
		kl.b(ref xo.a, A_0.aa(), A_1.aa());
		return xo;
	}

	// Token: 0x04002ECE RID: 11982
	public double a;

	// Token: 0x04002ECF RID: 11983
	public double b;

	// Token: 0x04002ED0 RID: 11984
	public cd1 c;
}
