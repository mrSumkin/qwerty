using System;
using System.Runtime.Serialization;

// Token: 0x02000110 RID: 272
[eiz("DA")]
[Serializable]
public sealed class os : btm, ISerializable
{
	// Token: 0x06000678 RID: 1656 RVA: 0x0001B91C File Offset: 0x00019B1C
	private os(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (TimeSpan)A_0.GetValue("DA:A", typeof(TimeSpan));
			this.b = (TimeSpan)A_0.GetValue("DA:TP", typeof(TimeSpan));
			return;
		}
		if (base.GetType() == typeof(os))
		{
			this.a = (TimeSpan)A_0.GetValue("_Amount", typeof(TimeSpan));
			this.b = (TimeSpan)A_0.GetValue("_TimePassed", typeof(TimeSpan));
			return;
		}
		this.a = (TimeSpan)A_0.GetValue("DelayActivity+_Amount", typeof(TimeSpan));
		this.b = (TimeSpan)A_0.GetValue("DelayActivity+_TimePassed", typeof(TimeSpan));
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x0001BA18 File Offset: 0x00019C18
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DA:A", this.a);
		info.AddValue("DA:TP", this.b);
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x0001BA50 File Offset: 0x00019C50
	public TimeSpan a()
	{
		return this.a;
	}

	// Token: 0x0600067B RID: 1659 RVA: 0x0001BA58 File Offset: 0x00019C58
	public void a(TimeSpan A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600067C RID: 1660 RVA: 0x0001BA64 File Offset: 0x00019C64
	public os() : base(null)
	{
	}

	// Token: 0x0600067D RID: 1661 RVA: 0x0001BA70 File Offset: 0x00019C70
	public os(TimeSpan A_0) : base(null)
	{
		this.a = A_0;
	}

	// Token: 0x0600067E RID: 1662 RVA: 0x0001BA80 File Offset: 0x00019C80
	protected override bool b4(e6d A_0)
	{
		this.b = TimeSpan.Zero;
		return false;
	}

	// Token: 0x0600067F RID: 1663 RVA: 0x0001BA94 File Offset: 0x00019C94
	protected override bool aen(e6d A_0)
	{
		return (this.b += A_0.a().ElapsedGameTime) >= this.a;
	}

	// Token: 0x0400051D RID: 1309
	private TimeSpan a;

	// Token: 0x0400051E RID: 1310
	private TimeSpan b;
}
