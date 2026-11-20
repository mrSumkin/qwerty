using System;
using System.Runtime.Serialization;

// Token: 0x020004DF RID: 1247
[eiz("PFC")]
[Serializable]
public sealed class vb : dnh
{
	// Token: 0x0600201A RID: 8218 RVA: 0x000AEF08 File Offset: 0x000AD108
	private vb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("PFC:LL", typeof(float?)) as float?);
		this.b = (A_0.GetValue("PFC:UL", typeof(float?)) as float?);
		this.c = A_0.GetBoolean("PFC:I");
	}

	// Token: 0x0600201B RID: 8219 RVA: 0x000AEF78 File Offset: 0x000AD178
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PFC:LL", this.a);
		info.AddValue("PFC:UL", this.b);
		info.AddValue("PFC:I", this.c);
	}

	// Token: 0x0600201C RID: 8220 RVA: 0x000AEFCC File Offset: 0x000AD1CC
	public float? b()
	{
		return this.a;
	}

	// Token: 0x0600201D RID: 8221 RVA: 0x000AEFD4 File Offset: 0x000AD1D4
	public void b(float? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600201E RID: 8222 RVA: 0x000AEFE0 File Offset: 0x000AD1E0
	public float? a()
	{
		return this.b;
	}

	// Token: 0x0600201F RID: 8223 RVA: 0x000AEFE8 File Offset: 0x000AD1E8
	public void a(float? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002020 RID: 8224 RVA: 0x000AEFF4 File Offset: 0x000AD1F4
	public bool c()
	{
		return this.c;
	}

	// Token: 0x06002021 RID: 8225 RVA: 0x000AEFFC File Offset: 0x000AD1FC
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06002022 RID: 8226 RVA: 0x000AF008 File Offset: 0x000AD208
	public vb()
	{
	}

	// Token: 0x06002023 RID: 8227 RVA: 0x000AF014 File Offset: 0x000AD214
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		if (A_0 == null)
		{
			return this.c;
		}
		float num = cs1.a(A_0);
		if (this.a != null && num < this.a.Value)
		{
			return this.c;
		}
		if (this.b != null && num > this.b.Value)
		{
			return this.c;
		}
		return !this.c;
	}

	// Token: 0x040013FD RID: 5117
	private float? a;

	// Token: 0x040013FE RID: 5118
	private float? b;

	// Token: 0x040013FF RID: 5119
	private bool c;
}
