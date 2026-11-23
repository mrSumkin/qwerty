using System;
using System.Runtime.Serialization;

// Token: 0x020019E0 RID: 6624
[eiz("YSRMME")]
[Serializable]
public sealed class ab7 : cdh, ISerializable, d7s
{
	// Token: 0x06008E4C RID: 36428 RVA: 0x00395028 File Offset: 0x00393228
	private ab7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("YSRMME:M");
	}

	// Token: 0x06008E4D RID: 36429 RVA: 0x00395044 File Offset: 0x00393244
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("YSRMME:M", this.a);
	}

	// Token: 0x06008E4E RID: 36430 RVA: 0x00395060 File Offset: 0x00393260
	public double a()
	{
		return this.a;
	}

	// Token: 0x06008E4F RID: 36431 RVA: 0x00395068 File Offset: 0x00393268
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008E50 RID: 36432 RVA: 0x00395074 File Offset: 0x00393274
	public override bool ae5()
	{
		return this.a < 0.0;
	}

	// Token: 0x06008E51 RID: 36433 RVA: 0x00395088 File Offset: 0x00393288
	public ab7()
	{
	}

	// Token: 0x06008E52 RID: 36434 RVA: 0x00395090 File Offset: 0x00393290
	public override string b2()
	{
		if (this.a < 0.0)
		{
			return string.Format("Снижение боевых навыков от способности \"Крик\" уменьшено на {0}% (дополнительно).", Convert.ToInt32(Math.Abs(this.a) * 100.0));
		}
		return string.Format("Снижение боевых навыков от способности \"Крик\" увеличено на {0}% (дополнительно).", Convert.ToInt32(Math.Abs(this.a) * 100.0));
	}

	// Token: 0x06008E53 RID: 36435 RVA: 0x00395104 File Offset: 0x00393304
	public override d3e b3()
	{
		ab7 ab = new ab7();
		this.xx(ab);
		return ab;
	}

	// Token: 0x06008E54 RID: 36436 RVA: 0x00395120 File Offset: 0x00393320
	public void cn(d3e A_0)
	{
		ab7 ab = A_0 as ab7;
		if (ab != null)
		{
			this.a += ab.a;
		}
	}

	// Token: 0x06008E55 RID: 36437 RVA: 0x00395150 File Offset: 0x00393350
	public bool co(d3e A_0)
	{
		return A_0 is ab7;
	}

	// Token: 0x06008E56 RID: 36438 RVA: 0x0039515C File Offset: 0x0039335C
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((ab7)A_0).a = this.a;
	}

	// Token: 0x040037D3 RID: 14291
	private new double a;
}
