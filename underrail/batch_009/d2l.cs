using System;
using System.Runtime.Serialization;

// Token: 0x02000F52 RID: 3922
[eiz("PIMC")]
[Serializable]
public sealed class d2l : dnh, ISerializable
{
	// Token: 0x06004F6B RID: 20331 RVA: 0x0023CD08 File Offset: 0x0023AF08
	private d2l(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("PIMC:I");
	}

	// Token: 0x06004F6C RID: 20332 RVA: 0x0023CD24 File Offset: 0x0023AF24
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PIMC:I", this.a);
	}

	// Token: 0x06004F6D RID: 20333 RVA: 0x0023CD40 File Offset: 0x0023AF40
	public bool b()
	{
		return this.a;
	}

	// Token: 0x06004F6E RID: 20334 RVA: 0x0023CD48 File Offset: 0x0023AF48
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004F6F RID: 20335 RVA: 0x0023CD54 File Offset: 0x0023AF54
	public d2l()
	{
	}

	// Token: 0x06004F70 RID: 20336 RVA: 0x0023CD5C File Offset: 0x0023AF5C
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		return d8s.b() ^ this.a;
	}

	// Token: 0x06004F71 RID: 20337 RVA: 0x0023CD6C File Offset: 0x0023AF6C
	public string a()
	{
		return "Player is mutant";
	}

	// Token: 0x0400208D RID: 8333
	private bool a;
}
