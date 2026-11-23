using System;
using System.Runtime.Serialization;

// Token: 0x020019F7 RID: 6647
[eiz("DCCI")]
[Serializable]
public sealed class apj : cdh, ISerializable, d7s
{
	// Token: 0x06008F37 RID: 36663 RVA: 0x003974F8 File Offset: 0x003956F8
	private apj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("DCCI:M");
	}

	// Token: 0x06008F38 RID: 36664 RVA: 0x00397514 File Offset: 0x00395714
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DCCI:M", this.a);
	}

	// Token: 0x06008F39 RID: 36665 RVA: 0x00397530 File Offset: 0x00395730
	public double a()
	{
		return this.a;
	}

	// Token: 0x06008F3A RID: 36666 RVA: 0x00397538 File Offset: 0x00395738
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008F3B RID: 36667 RVA: 0x00397544 File Offset: 0x00395744
	public override bool ae5()
	{
		return this.a < 0.0;
	}

	// Token: 0x06008F3C RID: 36668 RVA: 0x00397558 File Offset: 0x00395758
	public apj()
	{
	}

	// Token: 0x06008F3D RID: 36669 RVA: 0x00397560 File Offset: 0x00395760
	public override string b2()
	{
		if (this.a < 0.0)
		{
			return string.Format("Шанс критического удар Обезглавливания уменьшен на {0}%", Convert.ToInt32(Math.Abs(this.a) * 100.0));
		}
		return string.Format("Шанс критического удар Обезглавливания увеличен на {0}%", Convert.ToInt32(Math.Abs(this.a) * 100.0));
	}

	// Token: 0x06008F3E RID: 36670 RVA: 0x003975D4 File Offset: 0x003957D4
	public override d3e b3()
	{
		apj apj = new apj();
		this.xx(apj);
		return apj;
	}

	// Token: 0x06008F3F RID: 36671 RVA: 0x003975F0 File Offset: 0x003957F0
	public void cn(d3e A_0)
	{
		apj apj = A_0 as apj;
		if (apj != null)
		{
			this.a += apj.a;
		}
	}

	// Token: 0x06008F40 RID: 36672 RVA: 0x00397620 File Offset: 0x00395820
	public bool co(d3e A_0)
	{
		return A_0 is apj;
	}

	// Token: 0x06008F41 RID: 36673 RVA: 0x0039762C File Offset: 0x0039582C
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((apj)A_0).a = this.a;
	}

	// Token: 0x040037ED RID: 14317
	private new double a;
}
