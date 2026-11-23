using System;
using System.Runtime.Serialization;

// Token: 0x020019F9 RID: 6649
[eiz("M53")]
[Serializable]
public sealed class e2e : d3e, d7s, ISerializable
{
	// Token: 0x06008F4E RID: 36686 RVA: 0x0039779C File Offset: 0x0039599C
	private e2e(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("M53:A");
	}

	// Token: 0x06008F4F RID: 36687 RVA: 0x003977B8 File Offset: 0x003959B8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("M53:A", this.a);
	}

	// Token: 0x06008F50 RID: 36688 RVA: 0x003977D4 File Offset: 0x003959D4
	public double a()
	{
		return this.a;
	}

	// Token: 0x06008F51 RID: 36689 RVA: 0x003977DC File Offset: 0x003959DC
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008F52 RID: 36690 RVA: 0x003977E8 File Offset: 0x003959E8
	public override bool ae5()
	{
		return this.a > 0.0;
	}

	// Token: 0x06008F53 RID: 36691 RVA: 0x003977FC File Offset: 0x003959FC
	public e2e()
	{
	}

	// Token: 0x06008F54 RID: 36692 RVA: 0x00397804 File Offset: 0x00395A04
	public e2e(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008F55 RID: 36693 RVA: 0x00397818 File Offset: 0x00395A18
	protected override void @in(ll A_0)
	{
		nw nw = A_0.a().Defense;
		nw.e(nw.ac() + this.a);
	}

	// Token: 0x06008F56 RID: 36694 RVA: 0x00397844 File Offset: 0x00395A44
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((e2e)A_0).a = this.a;
	}

	// Token: 0x06008F57 RID: 36695 RVA: 0x00397860 File Offset: 0x00395A60
	public void cn(d3e A_0)
	{
		e2e e2e = A_0 as e2e;
		if (e2e != null)
		{
			this.a += e2e.a;
		}
	}

	// Token: 0x06008F58 RID: 36696 RVA: 0x00397890 File Offset: 0x00395A90
	public bool co(d3e A_0)
	{
		e2e e2e = A_0 as e2e;
		return e2e != null && e2e.Condition == base.Condition;
	}

	// Token: 0x06008F59 RID: 36697 RVA: 0x003978BC File Offset: 0x00395ABC
	public override string b2()
	{
		if (this.a > 0.0)
		{
			return string.Format("Шанс получить критический урон от пси-способности увеличен на {0}%", (this.a * 100.0).ToString("0.00"));
		}
		return string.Format("Шанс получить критический урон от пси-способности уменьшен на {0}%", (Math.Abs(this.a) * 100.0).ToString("0.00"));
	}

	// Token: 0x06008F5A RID: 36698 RVA: 0x00397934 File Offset: 0x00395B34
	public override d3e b3()
	{
		e2e e2e = new e2e();
		this.xx(e2e);
		return e2e;
	}

	// Token: 0x040037F0 RID: 14320
	private new double a;
}
