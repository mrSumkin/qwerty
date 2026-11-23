using System;
using System.Runtime.Serialization;

// Token: 0x02000155 RID: 341
[eiz("RC8")]
[Serializable]
public sealed class a1i : dnh
{
	// Token: 0x06000877 RID: 2167 RVA: 0x00023C20 File Offset: 0x00021E20
	private a1i(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetDouble("RC8:C");
	}

	// Token: 0x06000878 RID: 2168 RVA: 0x00023C3C File Offset: 0x00021E3C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RC8:C", this.b);
	}

	// Token: 0x06000879 RID: 2169 RVA: 0x00023C58 File Offset: 0x00021E58
	public double a()
	{
		return this.b;
	}

	// Token: 0x0600087A RID: 2170 RVA: 0x00023C60 File Offset: 0x00021E60
	public void a(double A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600087B RID: 2171 RVA: 0x00023C6C File Offset: 0x00021E6C
	public a1i()
	{
	}

	// Token: 0x0600087C RID: 2172 RVA: 0x00023C74 File Offset: 0x00021E74
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		return a1i.a.NextDouble() < this.b;
	}

	// Token: 0x040005AD RID: 1453
	private static Random a = new Random();

	// Token: 0x040005AE RID: 1454
	private double b;
}
