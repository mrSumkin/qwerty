using System;
using System.Runtime.Serialization;

// Token: 0x02000292 RID: 658
[eiz("SA")]
[Serializable]
public sealed class bm3 : dvv, ISerializable
{
	// Token: 0x06001348 RID: 4936 RVA: 0x00050AC4 File Offset: 0x0004ECC4
	private bm3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetInt32("SA:P");
			this.b = A_0.GetDouble("SA:TP");
			return;
		}
		if (base.GetType() == typeof(bm3))
		{
			this.a = A_0.GetInt32("_Period");
			this.b = A_0.GetDouble("_TimePassed");
			return;
		}
		this.a = A_0.GetInt32("SleepAction+_Period");
		this.b = A_0.GetDouble("SleepAction+_TimePassed");
	}

	// Token: 0x06001349 RID: 4937 RVA: 0x00050B68 File Offset: 0x0004ED68
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SA:P", this.a);
		info.AddValue("SA:TP", this.b);
	}

	// Token: 0x0600134A RID: 4938 RVA: 0x00050B94 File Offset: 0x0004ED94
	public int a()
	{
		return this.a;
	}

	// Token: 0x0600134B RID: 4939 RVA: 0x00050B9C File Offset: 0x0004ED9C
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600134C RID: 4940 RVA: 0x00050BA8 File Offset: 0x0004EDA8
	public bm3(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600134D RID: 4941 RVA: 0x00050BB8 File Offset: 0x0004EDB8
	protected override dc4 dt()
	{
		this.b = 0.0;
		if (this.a <= 0)
		{
			return dc4.c;
		}
		return dc4.b;
	}

	// Token: 0x0600134E RID: 4942 RVA: 0x00050BDC File Offset: 0x0004EDDC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if ((this.b += A_1.TotalMilliseconds) > (double)this.a)
		{
			return dc4.c;
		}
		return dc4.b;
	}

	// Token: 0x04000A84 RID: 2692
	private new int a;

	// Token: 0x04000A85 RID: 2693
	private double b;
}
