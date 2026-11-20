using System;
using System.Runtime.Serialization;

// Token: 0x02001A2F RID: 6703
[eiz("MPRME")]
[Serializable]
public sealed class bxr : d3e, ISerializable
{
	// Token: 0x0600912C RID: 37164 RVA: 0x0039C598 File Offset: 0x0039A798
	private bxr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("MPRME:A");
	}

	// Token: 0x0600912D RID: 37165 RVA: 0x0039C5B4 File Offset: 0x0039A7B4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MPRME:A", this.a);
	}

	// Token: 0x0600912E RID: 37166 RVA: 0x0039C5D0 File Offset: 0x0039A7D0
	public double a()
	{
		return this.a;
	}

	// Token: 0x0600912F RID: 37167 RVA: 0x0039C5D8 File Offset: 0x0039A7D8
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06009130 RID: 37168 RVA: 0x0039C5E4 File Offset: 0x0039A7E4
	public override bool ae5()
	{
		return this.a < 0.0;
	}

	// Token: 0x06009131 RID: 37169 RVA: 0x0039C5F8 File Offset: 0x0039A7F8
	public bxr()
	{
	}

	// Token: 0x06009132 RID: 37170 RVA: 0x0039C600 File Offset: 0x0039A800
	public bxr(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06009133 RID: 37171 RVA: 0x0039C610 File Offset: 0x0039A810
	protected override void @in(ll A_0)
	{
		dcu dcu = A_0.a().Offense;
		dcu.d(dcu.ah() + this.a);
	}

	// Token: 0x06009134 RID: 37172 RVA: 0x0039C63C File Offset: 0x0039A83C
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((bxr)A_0).a = this.a;
	}

	// Token: 0x06009135 RID: 37173 RVA: 0x0039C658 File Offset: 0x0039A858
	public override string b2()
	{
		if (this.a < 0.0)
		{
			return qv.a("StaticEffects/ModifyPsiRegenModifier_Decreased", new object[]
			{
				(int)(Math.Abs(this.a) * 100.0)
			});
		}
		return qv.a("StaticEffects/ModifyPsiRegenModifier_Increased", new object[]
		{
			(int)(this.a * 100.0)
		});
	}

	// Token: 0x06009136 RID: 37174 RVA: 0x0039C6D4 File Offset: 0x0039A8D4
	public override d3e b3()
	{
		bxr bxr = new bxr();
		this.xx(bxr);
		return bxr;
	}

	// Token: 0x04003823 RID: 14371
	private new double a;
}
