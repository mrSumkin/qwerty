using System;
using System.Runtime.Serialization;

// Token: 0x020019DE RID: 6622
[eiz("TKPAM")]
[Serializable]
public sealed class ea3 : cdh, ISerializable, d7s
{
	// Token: 0x06008E36 RID: 36406 RVA: 0x00394DC8 File Offset: 0x00392FC8
	private ea3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("TKPAM:M");
	}

	// Token: 0x06008E37 RID: 36407 RVA: 0x00394DE4 File Offset: 0x00392FE4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TKPAM:M", this.a);
	}

	// Token: 0x06008E38 RID: 36408 RVA: 0x00394E00 File Offset: 0x00393000
	public double a()
	{
		return this.a;
	}

	// Token: 0x06008E39 RID: 36409 RVA: 0x00394E08 File Offset: 0x00393008
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008E3A RID: 36410 RVA: 0x00394E14 File Offset: 0x00393014
	public override bool ae5()
	{
		return this.a < 0.0;
	}

	// Token: 0x06008E3B RID: 36411 RVA: 0x00394E28 File Offset: 0x00393028
	public ea3()
	{
	}

	// Token: 0x06008E3C RID: 36412 RVA: 0x00394E30 File Offset: 0x00393030
	public override string b2()
	{
		if (this.a < 0.0)
		{
			return string.Format("Точность метания ножа уменьшена на {0}% (дополнительно).", Math.Abs(Convert.ToInt32(this.a * 100.0)));
		}
		return string.Format("Точность метания ножа увеличена на {0}% (дополнительно).", Convert.ToInt32(this.a * 100.0));
	}

	// Token: 0x06008E3D RID: 36413 RVA: 0x00394EA0 File Offset: 0x003930A0
	public override d3e b3()
	{
		ea3 ea = new ea3();
		this.xx(ea);
		return ea;
	}

	// Token: 0x06008E3E RID: 36414 RVA: 0x00394EBC File Offset: 0x003930BC
	public void cn(d3e A_0)
	{
		ea3 ea = A_0 as ea3;
		if (ea != null)
		{
			this.a += ea.a;
		}
	}

	// Token: 0x06008E3F RID: 36415 RVA: 0x00394EEC File Offset: 0x003930EC
	public bool co(d3e A_0)
	{
		return A_0 is ea3;
	}

	// Token: 0x06008E40 RID: 36416 RVA: 0x00394EF8 File Offset: 0x003930F8
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((ea3)A_0).a = this.a;
	}

	// Token: 0x040037D1 RID: 14289
	private new double a;
}
