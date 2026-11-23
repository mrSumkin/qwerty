using System;
using System.Runtime.Serialization;

// Token: 0x02001AC7 RID: 6855
[eiz("VSSE9")]
[Serializable]
public sealed class ely : els, ISerializable
{
	// Token: 0x0600949F RID: 38047 RVA: 0x003A714C File Offset: 0x003A534C
	private ely(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetSingle("VSSE9:MSI");
		this.c = A_0.GetSingle("VSSE9:ARTD");
		this.d = A_0.GetSingle("VSSE9:DAEI");
		this.f = A_0.GetInt32("VSSE9:EFT");
		this.e = A_0.GetInt32("VSSE9:A");
		this.g = A_0.GetInt32("VSSE9:S");
	}

	// Token: 0x060094A0 RID: 38048 RVA: 0x003A71C8 File Offset: 0x003A53C8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("VSSE9:MSI", this.b);
		info.AddValue("VSSE9:ARTD", this.c);
		info.AddValue("VSSE9:DAEI", this.d);
		info.AddValue("VSSE9:EFT", this.f);
		info.AddValue("VSSE9:A", this.e);
		info.AddValue("VSSE9:S", this.g);
	}

	// Token: 0x060094A1 RID: 38049 RVA: 0x003A7244 File Offset: 0x003A5444
	public float c()
	{
		return this.b;
	}

	// Token: 0x060094A2 RID: 38050 RVA: 0x003A724C File Offset: 0x003A544C
	public float d()
	{
		return this.c;
	}

	// Token: 0x060094A3 RID: 38051 RVA: 0x003A7254 File Offset: 0x003A5454
	public int a()
	{
		return this.e;
	}

	// Token: 0x060094A4 RID: 38052 RVA: 0x003A725C File Offset: 0x003A545C
	public int b()
	{
		return this.f;
	}

	// Token: 0x060094A5 RID: 38053 RVA: 0x003A7264 File Offset: 0x003A5464
	public void a(int A_0)
	{
		this.f = A_0;
	}

	// Token: 0x060094A6 RID: 38054 RVA: 0x003A7270 File Offset: 0x003A5470
	public ely(float A_0, float A_1, float A_2, int A_3, int A_4, int A_5, int A_6) : base(ely.a, "Всплеск жизни", ci8.b)
	{
		base.Duration = A_3;
		base.Icon = "Status.VitalitySurge";
		base.MaxStacks = 1;
		base.Stacking = axm.b;
		base.ExpiredAction = "VitalitySurgeExpiresAction";
		base.RemovedAction = "VitalitySurgeExpiresAction";
		this.g = A_6;
		this.b = A_0;
		this.c = A_1;
		this.d = A_2;
		this.f = A_4;
		this.e = A_5;
		base.StaticEffects.Add(new ax6("Strength", this.g));
		base.StaticEffects.Add(new i0(this.b, false, false, false));
		base.StaticEffects.Add(new bjo(-this.c, 0, null));
		base.StaticEffects.Add(new d19(this.d)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new e15(this.d)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new d9(this.e, false, false));
	}

	// Token: 0x060094A7 RID: 38055 RVA: 0x003A739C File Offset: 0x003A559C
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/VitalitySurge", new object[]
		{
			this.e,
			(int)(this.d * 100f),
			this.g
		});
	}

	// Token: 0x0400393B RID: 14651
	public new static readonly string a = "vitalitySurge";

	// Token: 0x0400393C RID: 14652
	private float b;

	// Token: 0x0400393D RID: 14653
	private new float c;

	// Token: 0x0400393E RID: 14654
	private new float d;

	// Token: 0x0400393F RID: 14655
	private new int e;

	// Token: 0x04003940 RID: 14656
	private int f;

	// Token: 0x04003941 RID: 14657
	private int g;
}
