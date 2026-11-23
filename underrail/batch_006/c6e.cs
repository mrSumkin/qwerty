using System;
using System.Runtime.Serialization;

// Token: 0x020019F6 RID: 6646
[eiz("RBMXSME")]
[Serializable]
public sealed class c6e : cdh, ISerializable, d7s
{
	// Token: 0x06008F2C RID: 36652 RVA: 0x003973F0 File Offset: 0x003955F0
	private c6e(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("RBMXSME:S");
	}

	// Token: 0x06008F2D RID: 36653 RVA: 0x0039740C File Offset: 0x0039560C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RBMXSME:S", this.a);
	}

	// Token: 0x06008F2E RID: 36654 RVA: 0x00397428 File Offset: 0x00395628
	public int a()
	{
		return this.a;
	}

	// Token: 0x06008F2F RID: 36655 RVA: 0x00397430 File Offset: 0x00395630
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008F30 RID: 36656 RVA: 0x0039743C File Offset: 0x0039563C
	public override bool ae5()
	{
		return this.a < 0;
	}

	// Token: 0x06008F31 RID: 36657 RVA: 0x00397448 File Offset: 0x00395648
	public c6e()
	{
	}

	// Token: 0x06008F32 RID: 36658 RVA: 0x00397450 File Offset: 0x00395650
	public override string b2()
	{
		return string.Format("Ответный удар может складываться до {0} дополнительного времени.", this.a, (this.a > 1) ? "а" : "");
	}

	// Token: 0x06008F33 RID: 36659 RVA: 0x00397484 File Offset: 0x00395684
	public override d3e b3()
	{
		c6e c6e = new c6e();
		this.xx(c6e);
		return c6e;
	}

	// Token: 0x06008F34 RID: 36660 RVA: 0x003974A0 File Offset: 0x003956A0
	public void cn(d3e A_0)
	{
		c6e c6e = A_0 as c6e;
		if (c6e != null)
		{
			this.a += c6e.a;
		}
	}

	// Token: 0x06008F35 RID: 36661 RVA: 0x003974D0 File Offset: 0x003956D0
	public bool co(d3e A_0)
	{
		return A_0 is c6e;
	}

	// Token: 0x06008F36 RID: 36662 RVA: 0x003974DC File Offset: 0x003956DC
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((c6e)A_0).a = this.a;
	}

	// Token: 0x040037EC RID: 14316
	private new int a;
}
