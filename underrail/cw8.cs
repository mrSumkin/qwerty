using System;
using System.Runtime.Serialization;

// Token: 0x02001896 RID: 6294
[eiz("SA4")]
[Serializable]
public sealed class cw8 : btm, ISerializable
{
	// Token: 0x06008590 RID: 34192 RVA: 0x00376B10 File Offset: 0x00374D10
	private cw8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (TimeSpan)A_0.GetValue("SA4:D", typeof(TimeSpan));
		this.b = A_0.GetDouble("SA4:R");
	}

	// Token: 0x06008591 RID: 34193 RVA: 0x00376B4C File Offset: 0x00374D4C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SA4:D", this.a);
		info.AddValue("SA4:R", this.b);
	}

	// Token: 0x06008592 RID: 34194 RVA: 0x00376B80 File Offset: 0x00374D80
	public TimeSpan a()
	{
		return this.a;
	}

	// Token: 0x06008593 RID: 34195 RVA: 0x00376B88 File Offset: 0x00374D88
	public void a(TimeSpan A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008594 RID: 34196 RVA: 0x00376B94 File Offset: 0x00374D94
	public cw8() : base(null)
	{
	}

	// Token: 0x06008595 RID: 34197 RVA: 0x00376BA0 File Offset: 0x00374DA0
	protected override bool b4(e6d A_0)
	{
		this.b = this.a.TotalMilliseconds;
		return this.b == 0.0;
	}

	// Token: 0x06008596 RID: 34198 RVA: 0x00376BC8 File Offset: 0x00374DC8
	protected override bool aen(e6d A_0)
	{
		return (this.b -= A_0.a().ElapsedGameTime.TotalMilliseconds) <= 0.0;
	}

	// Token: 0x04003328 RID: 13096
	private TimeSpan a;

	// Token: 0x04003329 RID: 13097
	private double b;
}
