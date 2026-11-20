using System;
using System.Runtime.Serialization;

// Token: 0x02001CF5 RID: 7413
[eiz("LRQX")]
[Serializable]
public sealed class c6x : brl, ICloneable
{
	// Token: 0x0600A2E1 RID: 41697 RVA: 0x003EA4FC File Offset: 0x003E86FC
	private c6x(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("LRQX:M");
	}

	// Token: 0x0600A2E2 RID: 41698 RVA: 0x003EA518 File Offset: 0x003E8718
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("LRQX:M", this.a);
	}

	// Token: 0x0600A2E3 RID: 41699 RVA: 0x003EA534 File Offset: 0x003E8734
	public int a()
	{
		return this.a;
	}

	// Token: 0x0600A2E4 RID: 41700 RVA: 0x003EA53C File Offset: 0x003E873C
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600A2E5 RID: 41701 RVA: 0x003EA548 File Offset: 0x003E8748
	public override int og()
	{
		return this.a;
	}

	// Token: 0x0600A2E6 RID: 41702 RVA: 0x003EA550 File Offset: 0x003E8750
	public c6x()
	{
	}

	// Token: 0x0600A2E7 RID: 41703 RVA: 0x003EA558 File Offset: 0x003E8758
	public c6x(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600A2E8 RID: 41704 RVA: 0x003EA568 File Offset: 0x003E8768
	public override bool oh(efk A_0)
	{
		return A_0 != null && A_0.Level >= this.a;
	}

	// Token: 0x0600A2E9 RID: 41705 RVA: 0x003EA584 File Offset: 0x003E8784
	public override string ToString()
	{
		return dh9.c("Level") + " " + this.a.ToString();
	}

	// Token: 0x0600A2EA RID: 41706 RVA: 0x003EA5A8 File Offset: 0x003E87A8
	public object Clone()
	{
		return new c6x
		{
			a = this.a
		};
	}

	// Token: 0x04003E51 RID: 15953
	private int a;
}
