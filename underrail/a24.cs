using System;
using System.Runtime.Serialization;

// Token: 0x02001A13 RID: 6675
[eiz("MSRF")]
[Serializable]
public sealed class a24 : d3e, ISerializable
{
	// Token: 0x0600904B RID: 36939 RVA: 0x0039A09C File Offset: 0x0039829C
	private a24(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("MSRF:R");
		this.b = A_0.GetBoolean("MSRF:N");
	}

	// Token: 0x0600904C RID: 36940 RVA: 0x0039A0C8 File Offset: 0x003982C8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MSRF:R", this.a);
		info.AddValue("MSRF:N", this.b);
	}

	// Token: 0x0600904D RID: 36941 RVA: 0x0039A0F4 File Offset: 0x003982F4
	public override bool ae5()
	{
		return this.b;
	}

	// Token: 0x0600904E RID: 36942 RVA: 0x0039A0FC File Offset: 0x003982FC
	public a24()
	{
		base.Priority = int.MaxValue;
	}

	// Token: 0x0600904F RID: 36943 RVA: 0x0039A110 File Offset: 0x00398310
	public a24(int A_0, bool A_1) : this()
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06009050 RID: 36944 RVA: 0x0039A128 File Offset: 0x00398328
	protected override void @in(ll A_0)
	{
		A_0.a().SightRange = (float)this.a;
	}

	// Token: 0x06009051 RID: 36945 RVA: 0x0039A13C File Offset: 0x0039833C
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		a24 a = (a24)A_0;
		a.b = this.b;
		a.a = this.a;
	}

	// Token: 0x06009052 RID: 36946 RVA: 0x0039A164 File Offset: 0x00398364
	public override string b2()
	{
		return qv.a("StaticEffects/ModifySightRangeFixed", new object[]
		{
			this.a
		});
	}

	// Token: 0x06009053 RID: 36947 RVA: 0x0039A184 File Offset: 0x00398384
	public override d3e b3()
	{
		a24 a = new a24();
		this.xx(a);
		return a;
	}

	// Token: 0x04003809 RID: 14345
	private new int a;

	// Token: 0x0400380A RID: 14346
	private bool b;
}
