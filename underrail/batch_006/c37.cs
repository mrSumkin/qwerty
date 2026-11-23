using System;
using System.Runtime.Serialization;

// Token: 0x020019F8 RID: 6648
[eiz("NOIME")]
[Serializable]
public sealed class c37 : cdh, ISerializable, d7s
{
	// Token: 0x06008F42 RID: 36674 RVA: 0x00397648 File Offset: 0x00395848
	private c37(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("NOIME:S");
		this.b = A_0.GetInt32("NOIME:D");
	}

	// Token: 0x06008F43 RID: 36675 RVA: 0x0039767C File Offset: 0x0039587C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("NOIME:S", this.a);
		info.AddValue("NOIME:D", this.b);
	}

	// Token: 0x06008F44 RID: 36676 RVA: 0x003976A8 File Offset: 0x003958A8
	public int a()
	{
		return this.a;
	}

	// Token: 0x06008F45 RID: 36677 RVA: 0x003976B0 File Offset: 0x003958B0
	public void b(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008F46 RID: 36678 RVA: 0x003976BC File Offset: 0x003958BC
	public int b()
	{
		return this.b;
	}

	// Token: 0x06008F47 RID: 36679 RVA: 0x003976C4 File Offset: 0x003958C4
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008F48 RID: 36680 RVA: 0x003976D0 File Offset: 0x003958D0
	public c37()
	{
	}

	// Token: 0x06008F49 RID: 36681 RVA: 0x003976E0 File Offset: 0x003958E0
	public override string b2()
	{
		return string.Format("Невральная перегрузка запугивает цели, уменьшая их наступательные навыки на {0} в течение {1}.", this.a, l4.a(this.b, false));
	}

	// Token: 0x06008F4A RID: 36682 RVA: 0x00397708 File Offset: 0x00395908
	public override d3e b3()
	{
		c37 c = new c37();
		this.xx(c);
		return c;
	}

	// Token: 0x06008F4B RID: 36683 RVA: 0x00397724 File Offset: 0x00395924
	public void cn(d3e A_0)
	{
		c37 c = A_0 as c37;
		if (c != null)
		{
			this.a += c.a;
			this.b = Math.Max(this.b, c.b);
		}
	}

	// Token: 0x06008F4C RID: 36684 RVA: 0x00397768 File Offset: 0x00395968
	public bool co(d3e A_0)
	{
		return A_0 is c37;
	}

	// Token: 0x06008F4D RID: 36685 RVA: 0x00397774 File Offset: 0x00395974
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		c37 c = (c37)A_0;
		c.a = this.a;
		c.b = this.b;
	}

	// Token: 0x040037EE RID: 14318
	private new int a;

	// Token: 0x040037EF RID: 14319
	private int b = 2;
}
