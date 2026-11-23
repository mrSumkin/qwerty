using System;
using System.Runtime.Serialization;

// Token: 0x020004F6 RID: 1270
[eiz("MPFA")]
[Serializable]
public sealed class bnb : esc
{
	// Token: 0x060020C9 RID: 8393 RVA: 0x000B07B4 File Offset: 0x000AE9B4
	private bnb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.c = A_0.GetSingle("MPFA:V");
		this.a = (A_0.GetValue("MPFA:LL", typeof(float?)) as float?);
		this.b = (A_0.GetValue("MPFA:UL", typeof(float?)) as float?);
	}

	// Token: 0x060020CA RID: 8394 RVA: 0x000B0840 File Offset: 0x000AEA40
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MPFA:V", this.c);
		info.AddValue("MPFA:LL", this.a);
		info.AddValue("MPFA:UL", this.b);
	}

	// Token: 0x060020CB RID: 8395 RVA: 0x000B0894 File Offset: 0x000AEA94
	public float c()
	{
		return this.c;
	}

	// Token: 0x060020CC RID: 8396 RVA: 0x000B089C File Offset: 0x000AEA9C
	public void a(float A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060020CD RID: 8397 RVA: 0x000B08A8 File Offset: 0x000AEAA8
	public float? b()
	{
		return this.a;
	}

	// Token: 0x060020CE RID: 8398 RVA: 0x000B08B0 File Offset: 0x000AEAB0
	public void b(float? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060020CF RID: 8399 RVA: 0x000B08BC File Offset: 0x000AEABC
	public float? a()
	{
		return this.b;
	}

	// Token: 0x060020D0 RID: 8400 RVA: 0x000B08C4 File Offset: 0x000AEAC4
	public void a(float? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060020D1 RID: 8401 RVA: 0x000B08D0 File Offset: 0x000AEAD0
	public bnb()
	{
	}

	// Token: 0x060020D2 RID: 8402 RVA: 0x000B08F4 File Offset: 0x000AEAF4
	public override int d5(bq8 A_0, bq8 A_1)
	{
		if (A_0 != null)
		{
			cs1.a(A_0, this.c, this.b, this.a);
		}
		return 0;
	}

	// Token: 0x04001429 RID: 5161
	private float? a = new float?((float)-2);

	// Token: 0x0400142A RID: 5162
	private float? b = new float?((float)2);

	// Token: 0x0400142B RID: 5163
	private float c;
}
