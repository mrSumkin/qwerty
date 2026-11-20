using System;

// Token: 0x02000459 RID: 1113
public sealed class aqs : afa
{
	// Token: 0x06001D02 RID: 7426 RVA: 0x000A0EFC File Offset: 0x0009F0FC
	public override bool rt()
	{
		return false;
	}

	// Token: 0x06001D03 RID: 7427 RVA: 0x000A0F00 File Offset: 0x0009F100
	public aqs(string A_0) : base(A_0)
	{
	}

	// Token: 0x06001D04 RID: 7428 RVA: 0x000A0F20 File Offset: 0x0009F120
	public override bool acj(TimeSpan A_0, double A_1)
	{
		return this.Subject.a8().k != null && this.Subject.a8().k.b != null && base.h().aa().IsInControl && this.b() != null && (this.c() + this.b < this.a() || (base.d() != null && base.d().State == dc4.b && this.c() - this.b < this.a()));
	}

	// Token: 0x06001D05 RID: 7429 RVA: 0x000A0FD0 File Offset: 0x0009F1D0
	protected override cst ru(TimeSpan A_0, double A_1)
	{
		b0b b0b = this.b();
		if (b0b != null)
		{
			return this.Subject.a8().k.b.a(b0b, Math.Max(0f, this.c() - this.b), 1, 0);
		}
		return null;
	}

	// Token: 0x06001D06 RID: 7430 RVA: 0x000A1020 File Offset: 0x0009F220
	private new float c()
	{
		return this.Subject.y6().GetPrimitivePropertyValue<float>(ddq.b0, new float?(this.a)).Value;
	}

	// Token: 0x06001D07 RID: 7431 RVA: 0x000A1058 File Offset: 0x0009F258
	private b0b b()
	{
		string classPropertyValue = this.Subject.y6().GetClassPropertyValue<string>(ddq.bz);
		if (!string.IsNullOrEmpty(classPropertyValue))
		{
			if (!(classPropertyValue == "player"))
			{
				return this.Subject.a8().Zone.a().ab5(classPropertyValue);
			}
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				return serviceOrThrow.aqu().v().b();
			}
		}
		return null;
	}

	// Token: 0x06001D08 RID: 7432 RVA: 0x000A10E8 File Offset: 0x0009F2E8
	private float a()
	{
		b0b b0b = this.b();
		if (b0b == null || b0b.Area == null)
		{
			return 0f;
		}
		if (b0b.Area != this.Subject.a8().Area)
		{
			return float.MaxValue;
		}
		bpo.GetServiceOrThrow<d02>();
		ak1 a_ = b0b.Area.a(b0b.aj().a());
		if (!this.Subject.a(a_))
		{
			return float.MaxValue;
		}
		return (float)aw1.b(b0b, this.Subject.a8());
	}

	// Token: 0x04001005 RID: 4101
	public float a = 3f;

	// Token: 0x04001006 RID: 4102
	public new float b = 1f;
}
