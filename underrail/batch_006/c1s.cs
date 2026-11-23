using System;
using System.Runtime.Serialization;

// Token: 0x0200187E RID: 6270
[eiz("TLA")]
[Serializable]
public abstract class c1s : btm, ISerializable
{
	// Token: 0x06008539 RID: 34105 RVA: 0x00375CBC File Offset: 0x00373EBC
	protected c1s(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (TimeSpan?)A_0.GetValue("TLA:T", typeof(TimeSpan?));
			this.b = (TimeSpan)A_0.GetValue("TLA:T1", typeof(TimeSpan));
			return;
		}
		if (base.GetType() == typeof(c1s))
		{
			this.a = (TimeSpan?)A_0.GetValue("_Timeout", typeof(TimeSpan?));
			this.b = (TimeSpan)A_0.GetValue("_Timer", typeof(TimeSpan));
			return;
		}
		this.a = (TimeSpan?)A_0.GetValue("TimeLimitedActivity+_Timeout", typeof(TimeSpan?));
		this.b = (TimeSpan)A_0.GetValue("TimeLimitedActivity+_Timer", typeof(TimeSpan));
	}

	// Token: 0x0600853A RID: 34106 RVA: 0x00375DB8 File Offset: 0x00373FB8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TLA:T", this.a);
		info.AddValue("TLA:T1", this.b);
	}

	// Token: 0x0600853B RID: 34107 RVA: 0x00375DF0 File Offset: 0x00373FF0
	public TimeSpan? i()
	{
		return this.a;
	}

	// Token: 0x0600853C RID: 34108 RVA: 0x00375DF8 File Offset: 0x00373FF8
	public void a(TimeSpan? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600853D RID: 34109 RVA: 0x00375E04 File Offset: 0x00374004
	public virtual TimeSpan ks()
	{
		return TimeSpan.MaxValue;
	}

	// Token: 0x0600853E RID: 34110 RVA: 0x00375E0C File Offset: 0x0037400C
	protected c1s() : base(null)
	{
	}

	// Token: 0x0600853F RID: 34111 RVA: 0x00375E18 File Offset: 0x00374018
	protected c1s(TimeSpan A_0) : base(null)
	{
		this.a = new TimeSpan?(A_0);
	}

	// Token: 0x06008540 RID: 34112 RVA: 0x00375E30 File Offset: 0x00374030
	protected override bool b4(e6d A_0)
	{
		this.b = TimeSpan.Zero;
		return false;
	}

	// Token: 0x06008541 RID: 34113 RVA: 0x00375E44 File Offset: 0x00374044
	protected override bool aen(e6d A_0)
	{
		if ((this.b += A_0.a().ElapsedGameTime) >= ((this.a != null) ? this.a.Value : this.ks()))
		{
			this.kt(this.b);
			return true;
		}
		return false;
	}

	// Token: 0x06008542 RID: 34114 RVA: 0x00375EB0 File Offset: 0x003740B0
	protected virtual void kt(TimeSpan A_0)
	{
	}

	// Token: 0x04003304 RID: 13060
	private TimeSpan? a;

	// Token: 0x04003305 RID: 13061
	private TimeSpan b;
}
