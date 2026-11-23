using System;
using System.Runtime.Serialization;

// Token: 0x02001A2A RID: 6698
[eiz("RP")]
[Serializable]
public sealed class ag8 : wq, ISerializable
{
	// Token: 0x06009106 RID: 37126 RVA: 0x0039C048 File Offset: 0x0039A248
	private ag8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("RP:A");
		this.b = A_0.GetBoolean("RP:P");
	}

	// Token: 0x06009107 RID: 37127 RVA: 0x0039C07C File Offset: 0x0039A27C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RP:A", this.a);
		info.AddValue("RP:P", this.b);
	}

	// Token: 0x06009108 RID: 37128 RVA: 0x0039C0A8 File Offset: 0x0039A2A8
	public int a()
	{
		return this.a;
	}

	// Token: 0x06009109 RID: 37129 RVA: 0x0039C0B0 File Offset: 0x0039A2B0
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600910A RID: 37130 RVA: 0x0039C0BC File Offset: 0x0039A2BC
	public bool b()
	{
		return this.b;
	}

	// Token: 0x0600910B RID: 37131 RVA: 0x0039C0C4 File Offset: 0x0039A2C4
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600910C RID: 37132 RVA: 0x0039C0D0 File Offset: 0x0039A2D0
	public ag8()
	{
	}

	// Token: 0x0600910D RID: 37133 RVA: 0x0039C0E0 File Offset: 0x0039A2E0
	public ag8(int A_0, bool A_1 = true)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x0600910E RID: 37134 RVA: 0x0039C100 File Offset: 0x0039A300
	public override wq dn()
	{
		ag8 ag = new ag8();
		this.@do(ag);
		return ag;
	}

	// Token: 0x0600910F RID: 37135 RVA: 0x0039C11C File Offset: 0x0039A31C
	public override void dk(ll A_0, int A_1)
	{
		this.dl(A_0, A_1);
	}

	// Token: 0x06009110 RID: 37136 RVA: 0x0039C12C File Offset: 0x0039A32C
	public override void dl(ll A_0, int A_1)
	{
		if (this.a != 0 && A_0 != null && A_0.a() != null)
		{
			A_0.a().Offense.d(this.a, this.b);
		}
	}

	// Token: 0x06009111 RID: 37137 RVA: 0x0039C174 File Offset: 0x0039A374
	protected override void @do(wq A_0)
	{
		base.@do(A_0);
		ag8 ag = (ag8)A_0;
		ag.a = this.a;
		ag.b = this.b;
	}

	// Token: 0x0400381E RID: 14366
	private int a;

	// Token: 0x0400381F RID: 14367
	private bool b = true;
}
