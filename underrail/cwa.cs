using System;
using System.Runtime.Serialization;

// Token: 0x02001B34 RID: 6964
[eiz("PH")]
[Serializable]
public sealed class cwa : els, ISerializable
{
	// Token: 0x17000280 RID: 640
	// (get) Token: 0x0600969A RID: 38554 RVA: 0x003AE2BC File Offset: 0x003AC4BC
	// (set) Token: 0x0600969B RID: 38555 RVA: 0x003AE2C4 File Offset: 0x003AC4C4
	public Guid TargetId
	{
		get
		{
			return this.c;
		}
		set
		{
			this.c = value;
		}
	}

	// Token: 0x0600969C RID: 38556 RVA: 0x003AE2D0 File Offset: 0x003AC4D0
	private cwa(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.c = (Guid)A_0.GetValue("PH:T", typeof(Guid));
	}

	// Token: 0x0600969D RID: 38557 RVA: 0x003AE2FC File Offset: 0x003AC4FC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PH:T", this.c);
	}

	// Token: 0x0600969E RID: 38558 RVA: 0x003AE320 File Offset: 0x003AC520
	public cwa(Guid A_0, int A_1) : base("packHunting", "Охота стаей", ci8.b)
	{
		base.Icon = "Status.9";
		base.MaxStacks = 5;
		base.Stacking = axm.b;
		this.c = A_0;
		base.Duration = A_1;
	}

	// Token: 0x0600969F RID: 38559 RVA: 0x003AE368 File Offset: 0x003AC568
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/PackHunting", new object[]
		{
			(int)(this.c() * 100.0),
			this.b()
		});
	}

	// Token: 0x060096A0 RID: 38560 RVA: 0x003AE3AC File Offset: 0x003AC5AC
	public double c()
	{
		return (double)base.Stacks * cwa.a;
	}

	// Token: 0x060096A1 RID: 38561 RVA: 0x003AE3BC File Offset: 0x003AC5BC
	public int b()
	{
		return base.Stacks * cwa.b;
	}

	// Token: 0x040039EF RID: 14831
	private new static readonly double a = 0.2;

	// Token: 0x040039F0 RID: 14832
	private static readonly int b = 10;

	// Token: 0x040039F1 RID: 14833
	private new Guid c;
}
