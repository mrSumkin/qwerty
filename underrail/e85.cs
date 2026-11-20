using System;
using System.Runtime.Serialization;

// Token: 0x0200196A RID: 6506
[eiz("0P")]
[Serializable]
public sealed class e85 : wq, ISerializable
{
	// Token: 0x06008B47 RID: 35655 RVA: 0x0038EF6C File Offset: 0x0038D16C
	private e85(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008B48 RID: 35656 RVA: 0x0038EF78 File Offset: 0x0038D178
	public e85()
	{
	}

	// Token: 0x06008B49 RID: 35657 RVA: 0x0038EF80 File Offset: 0x0038D180
	public override void dk(ll A_0, int A_1)
	{
		this.dl(A_0, A_1);
	}

	// Token: 0x06008B4A RID: 35658 RVA: 0x0038EF8C File Offset: 0x0038D18C
	public override void dl(ll A_0, int A_1)
	{
		if (A_0 != null && A_0.a() != null)
		{
			euf.g(A_0.a());
		}
	}

	// Token: 0x06008B4B RID: 35659 RVA: 0x0038EFAC File Offset: 0x0038D1AC
	public override wq dn()
	{
		e85 e = new e85();
		this.@do(e);
		return e;
	}
}
