using System;
using System.Runtime.Serialization;

// Token: 0x02001B4C RID: 6988
[eiz("Y26")]
[Serializable]
public class b8c : c3e
{
	// Token: 0x06009725 RID: 38693 RVA: 0x003B0090 File Offset: 0x003AE290
	protected b8c(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("Y26:M");
	}

	// Token: 0x06009726 RID: 38694 RVA: 0x003B00AC File Offset: 0x003AE2AC
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("Y26:M", this.a);
	}

	// Token: 0x17000283 RID: 643
	// (get) Token: 0x06009727 RID: 38695 RVA: 0x003B00C8 File Offset: 0x003AE2C8
	// (set) Token: 0x06009728 RID: 38696 RVA: 0x003B00D0 File Offset: 0x003AE2D0
	public double Reduction
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x06009729 RID: 38697 RVA: 0x003B00DC File Offset: 0x003AE2DC
	public b8c()
	{
	}

	// Token: 0x0600972A RID: 38698 RVA: 0x003B00E4 File Offset: 0x003AE2E4
	public override string xq()
	{
		return qv.a("Items\\ArmorItemModifier/CriticalHitUnblockedDamageArmorReduction", new object[]
		{
			(int)(this.a * 100.0)
		});
	}

	// Token: 0x0600972B RID: 38699 RVA: 0x003B0110 File Offset: 0x003AE310
	public override c3e xr()
	{
		b8c b8c = new b8c();
		this.ael(b8c);
		return b8c;
	}

	// Token: 0x0600972C RID: 38700 RVA: 0x003B012C File Offset: 0x003AE32C
	public override c3e xs(int A_0)
	{
		return new b8c
		{
			a = (double)A_0 * 0.0035
		};
	}

	// Token: 0x0600972D RID: 38701 RVA: 0x003B0148 File Offset: 0x003AE348
	public virtual bool xt(cwt A_0)
	{
		return true;
	}

	// Token: 0x0600972E RID: 38702 RVA: 0x003B014C File Offset: 0x003AE34C
	protected override void ael(c3e A_0)
	{
		base.ael(A_0);
		((b8c)A_0).a = this.a;
	}

	// Token: 0x04003A1C RID: 14876
	private double a;
}
