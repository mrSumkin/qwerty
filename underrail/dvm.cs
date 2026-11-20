using System;
using System.Runtime.Serialization;

// Token: 0x020019E1 RID: 6625
[eiz("MPSACMMFE")]
[Serializable]
public sealed class dvm : cdh, ISerializable, d7s
{
	// Token: 0x06008E57 RID: 36439 RVA: 0x00395178 File Offset: 0x00393378
	private dvm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("MPSACMMFE:M");
	}

	// Token: 0x06008E58 RID: 36440 RVA: 0x00395194 File Offset: 0x00393394
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MPSACMMFE:M", this.a);
	}

	// Token: 0x06008E59 RID: 36441 RVA: 0x003951B0 File Offset: 0x003933B0
	public double a()
	{
		return this.a;
	}

	// Token: 0x06008E5A RID: 36442 RVA: 0x003951B8 File Offset: 0x003933B8
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008E5B RID: 36443 RVA: 0x003951C4 File Offset: 0x003933C4
	public override bool ae5()
	{
		return this.a > 0.0;
	}

	// Token: 0x06008E5C RID: 36444 RVA: 0x003951D8 File Offset: 0x003933D8
	public dvm()
	{
	}

	// Token: 0x06008E5D RID: 36445 RVA: 0x003951E0 File Offset: 0x003933E0
	public override string b2()
	{
		if (this.a < 0.0)
		{
			return string.Format("Стоимость очков действия \"Выстрел навскидку\" уменьшена на {0}% (дополнительно).", Convert.ToInt32(Math.Abs(this.a) * 100.0));
		}
		return string.Format("Стоимость очков действия \"Выстрел навскидку\" увеличена на {0}% (дополнительно).", Convert.ToInt32(Math.Abs(this.a) * 100.0));
	}

	// Token: 0x06008E5E RID: 36446 RVA: 0x00395254 File Offset: 0x00393454
	public override d3e b3()
	{
		dvm dvm = new dvm();
		this.xx(dvm);
		return dvm;
	}

	// Token: 0x06008E5F RID: 36447 RVA: 0x00395270 File Offset: 0x00393470
	public void cn(d3e A_0)
	{
		dvm dvm = A_0 as dvm;
		if (dvm != null)
		{
			this.a += dvm.a;
		}
	}

	// Token: 0x06008E60 RID: 36448 RVA: 0x003952A0 File Offset: 0x003934A0
	public bool co(d3e A_0)
	{
		return A_0 is dvm;
	}

	// Token: 0x06008E61 RID: 36449 RVA: 0x003952AC File Offset: 0x003934AC
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((dvm)A_0).a = this.a;
	}

	// Token: 0x040037D4 RID: 14292
	private new double a;
}
