using System;
using System.Runtime.Serialization;

// Token: 0x020017FF RID: 6143
[eiz("WBDTS")]
[Serializable]
public sealed class cc5 : dxa
{
	// Token: 0x06008280 RID: 33408 RVA: 0x0036C8B0 File Offset: 0x0036AAB0
	private cc5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("WBDTS:D");
	}

	// Token: 0x06008281 RID: 33409 RVA: 0x0036C8CC File Offset: 0x0036AACC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("WBDTS:D", this.a);
	}

	// Token: 0x06008282 RID: 33410 RVA: 0x0036C8E8 File Offset: 0x0036AAE8
	public double a()
	{
		return this.a;
	}

	// Token: 0x06008283 RID: 33411 RVA: 0x0036C8F0 File Offset: 0x0036AAF0
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008284 RID: 33412 RVA: 0x0036C8FC File Offset: 0x0036AAFC
	public override bool ae5()
	{
		return this.a < 0.0;
	}

	// Token: 0x06008285 RID: 33413 RVA: 0x0036C910 File Offset: 0x0036AB10
	public cc5()
	{
	}

	// Token: 0x06008286 RID: 33414 RVA: 0x0036C918 File Offset: 0x0036AB18
	public override void afb(cmn A_0, amc A_1, amc A_2, cd1 A_3)
	{
		if (A_2 != null && A_2.am() != null && A_2.am().StartsWith("xpbl_ssrp"))
		{
			A_0.b = Math.Max(0.0, A_0.b + this.a);
		}
	}

	// Token: 0x06008287 RID: 33415 RVA: 0x0036C96C File Offset: 0x0036AB6C
	public override string b2()
	{
		if (this.a < 0.0)
		{
			return string.Format("Уменьшает дополнительный урон от морских змеев на {0}%.", Math.Abs(Convert.ToInt32(this.a * 100.0)));
		}
		return string.Format("Увеличивает дополнительный урон от морских змеев на {0}%.", Convert.ToInt32(this.a * 100.0));
	}

	// Token: 0x06008288 RID: 33416 RVA: 0x0036C9DC File Offset: 0x0036ABDC
	public override d3e b3()
	{
		cc5 cc = new cc5();
		this.xx(cc);
		return cc;
	}

	// Token: 0x06008289 RID: 33417 RVA: 0x0036C9F8 File Offset: 0x0036ABF8
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		cc5 cc = A_0 as cc5;
		if (cc != null)
		{
			cc.a = this.a;
		}
	}

	// Token: 0x04003261 RID: 12897
	private new double a;
}
