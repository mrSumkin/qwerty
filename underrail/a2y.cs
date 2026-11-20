using System;
using System.Runtime.Serialization;

// Token: 0x02000FEA RID: 4074
[eiz("P11")]
[Serializable]
public sealed class a2y : ISerializable
{
	// Token: 0x060053ED RID: 21485 RVA: 0x00251C48 File Offset: 0x0024FE48
	private a2y(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetDouble("P11:C");
		this.b = (b1j)A_0.GetValue("P11:D", typeof(b1j));
	}

	// Token: 0x060053EE RID: 21486 RVA: 0x00251C8C File Offset: 0x0024FE8C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("P11:C", this.a);
		info.AddValue("P11:D", this.b);
	}

	// Token: 0x060053EF RID: 21487 RVA: 0x00251CB8 File Offset: 0x0024FEB8
	public double b()
	{
		return this.a;
	}

	// Token: 0x060053F0 RID: 21488 RVA: 0x00251CC0 File Offset: 0x0024FEC0
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060053F1 RID: 21489 RVA: 0x00251CCC File Offset: 0x0024FECC
	public b1j a()
	{
		return this.b;
	}

	// Token: 0x060053F2 RID: 21490 RVA: 0x00251CD4 File Offset: 0x0024FED4
	public void a(b1j A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060053F3 RID: 21491 RVA: 0x00251CE0 File Offset: 0x0024FEE0
	public a2y()
	{
	}

	// Token: 0x04002243 RID: 8771
	private double a;

	// Token: 0x04002244 RID: 8772
	private b1j b;
}
