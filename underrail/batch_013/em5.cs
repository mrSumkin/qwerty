using System;
using System.Runtime.Serialization;

// Token: 0x0200028F RID: 655
[eiz("NEM")]
[Serializable]
public sealed class em5 : dvv, ISerializable
{
	// Token: 0x06001323 RID: 4899 RVA: 0x0004F4B4 File Offset: 0x0004D6B4
	private em5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("NEM:T", typeof(edx)) as edx);
		this.b = (A_0.GetValue("NEM:E", typeof(ar7)) as ar7);
	}

	// Token: 0x06001324 RID: 4900 RVA: 0x0004F50C File Offset: 0x0004D70C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("NEM:T", this.a);
		info.AddValue("NEM:E", this.b);
	}

	// Token: 0x06001325 RID: 4901 RVA: 0x0004F538 File Offset: 0x0004D738
	public em5(b0b A_0, ak1 A_1)
	{
		this.a = new edx(A_1);
		this.b = new ar7(A_0);
	}

	// Token: 0x06001326 RID: 4902 RVA: 0x0004F558 File Offset: 0x0004D758
	protected override dc4 dt()
	{
		return dc4.b;
	}

	// Token: 0x06001327 RID: 4903 RVA: 0x0004F55C File Offset: 0x0004D75C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.b.ao() == null || this.a.ao() == null)
		{
			return dc4.e;
		}
		this.a.ao().h(this.b.ao());
		return dc4.c;
	}

	// Token: 0x04000A6A RID: 2666
	private new edx a;

	// Token: 0x04000A6B RID: 2667
	private ar7 b;
}
