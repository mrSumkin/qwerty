using System;
using System.Runtime.Serialization;

// Token: 0x02001968 RID: 6504
[eiz("RSDEF")]
[Serializable]
public sealed class a7g : wq, ISerializable
{
	// Token: 0x06008B30 RID: 35632 RVA: 0x0038EC5C File Offset: 0x0038CE5C
	private a7g(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("RSDEF:A");
	}

	// Token: 0x06008B31 RID: 35633 RVA: 0x0038EC78 File Offset: 0x0038CE78
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RSDEF:A", this.a);
	}

	// Token: 0x06008B32 RID: 35634 RVA: 0x0038EC94 File Offset: 0x0038CE94
	public int a()
	{
		return this.a;
	}

	// Token: 0x06008B33 RID: 35635 RVA: 0x0038EC9C File Offset: 0x0038CE9C
	public a7g()
	{
	}

	// Token: 0x06008B34 RID: 35636 RVA: 0x0038ECA4 File Offset: 0x0038CEA4
	public a7g(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008B35 RID: 35637 RVA: 0x0038ECB4 File Offset: 0x0038CEB4
	public override void dk(ll A_0, int A_1)
	{
		this.dl(A_0, A_1);
	}

	// Token: 0x06008B36 RID: 35638 RVA: 0x0038ECC4 File Offset: 0x0038CEC4
	public override void dl(ll A_0, int A_1)
	{
		if (A_0 != null && A_0.a() != null && !A_0.a().Dead && !A_0.a().SpecialStates.h)
		{
			A_0.a().Defense.a((float)this.a, false);
		}
	}

	// Token: 0x06008B37 RID: 35639 RVA: 0x0038ED20 File Offset: 0x0038CF20
	public override string dm()
	{
		return qv.a("DynamicEffects/RegenerateShield", new object[]
		{
			this.a
		});
	}

	// Token: 0x06008B38 RID: 35640 RVA: 0x0038ED44 File Offset: 0x0038CF44
	public override wq dn()
	{
		a7g a7g = new a7g();
		this.@do(a7g);
		return a7g;
	}

	// Token: 0x06008B39 RID: 35641 RVA: 0x0038ED60 File Offset: 0x0038CF60
	protected override void @do(wq A_0)
	{
		base.@do(A_0);
		((a7g)A_0).a = this.a;
	}

	// Token: 0x0400378E RID: 14222
	private int a;
}
