using System;
using System.Runtime.Serialization;

// Token: 0x02001A32 RID: 6706
[eiz("M51")]
[Serializable]
public sealed class a35 : d3e, ISerializable
{
	// Token: 0x0600914A RID: 37194 RVA: 0x0039C984 File Offset: 0x0039AB84
	private a35(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetSingle("M51:A");
	}

	// Token: 0x0600914B RID: 37195 RVA: 0x0039C9A0 File Offset: 0x0039ABA0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("M51:A", this.a);
	}

	// Token: 0x0600914C RID: 37196 RVA: 0x0039C9BC File Offset: 0x0039ABBC
	public float a()
	{
		return this.a;
	}

	// Token: 0x0600914D RID: 37197 RVA: 0x0039C9C4 File Offset: 0x0039ABC4
	public void a(float A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600914E RID: 37198 RVA: 0x0039C9D0 File Offset: 0x0039ABD0
	public override bool ae5()
	{
		return this.a > 0f;
	}

	// Token: 0x0600914F RID: 37199 RVA: 0x0039C9E0 File Offset: 0x0039ABE0
	public a35()
	{
	}

	// Token: 0x06009150 RID: 37200 RVA: 0x0039C9E8 File Offset: 0x0039ABE8
	public a35(float A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06009151 RID: 37201 RVA: 0x0039C9F8 File Offset: 0x0039ABF8
	protected override void @in(ll A_0)
	{
		nw nw = A_0.a().Defense;
		nw.c(nw.ah() + this.a);
	}

	// Token: 0x06009152 RID: 37202 RVA: 0x0039CA24 File Offset: 0x0039AC24
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((a35)A_0).a = this.a;
	}

	// Token: 0x06009153 RID: 37203 RVA: 0x0039CA40 File Offset: 0x0039AC40
	public override string b2()
	{
		if (this.a >= 0f)
		{
			return qv.a("StaticEffects/ModifyMedicineUsageCost_Increased", new object[]
			{
				(int)(this.a * 100f)
			});
		}
		return qv.a("StaticEffects/ModifyMedicineUsageCost_Decreased", new object[]
		{
			(int)(Math.Abs(this.a) * 100f)
		});
	}

	// Token: 0x06009154 RID: 37204 RVA: 0x0039CAB0 File Offset: 0x0039ACB0
	public override d3e b3()
	{
		a35 a = new a35();
		this.xx(a);
		return a;
	}

	// Token: 0x04003825 RID: 14373
	public new float a;
}
