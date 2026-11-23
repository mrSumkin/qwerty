using System;
using System.Runtime.Serialization;

// Token: 0x020018C7 RID: 6343
[eiz("DI")]
[Serializable]
public sealed class erl : ISerializable
{
	// Token: 0x06008698 RID: 34456 RVA: 0x0037C834 File Offset: 0x0037AA34
	private erl(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (cem)A_0.GetValue("DI:DS", typeof(cem));
			this.b = A_0.GetDouble("DI:DSB");
			this.c = A_0.GetBoolean("DI:IH");
			return;
		}
		if (base.GetType() == typeof(erl))
		{
			this.a = (cem)A_0.GetValue("_DetectionStage", typeof(cem));
			this.b = A_0.GetDouble("_DetectionStageBuffer");
			this.c = A_0.GetBoolean("_IsHiding");
			return;
		}
		this.a = (cem)A_0.GetValue("DetectionInfo+_DetectionStage", typeof(cem));
		this.b = A_0.GetDouble("DetectionInfo+_DetectionStageBuffer");
		this.c = A_0.GetBoolean("DetectionInfo+_IsHiding");
	}

	// Token: 0x06008699 RID: 34457 RVA: 0x0037C934 File Offset: 0x0037AB34
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("DI:DS", this.a);
		info.AddValue("DI:DSB", this.b);
		info.AddValue("DI:IH", this.c);
	}

	// Token: 0x0600869A RID: 34458 RVA: 0x0037C970 File Offset: 0x0037AB70
	public cem f()
	{
		return this.a;
	}

	// Token: 0x0600869B RID: 34459 RVA: 0x0037C978 File Offset: 0x0037AB78
	public void a(cem A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600869C RID: 34460 RVA: 0x0037C984 File Offset: 0x0037AB84
	public double c()
	{
		return this.b;
	}

	// Token: 0x0600869D RID: 34461 RVA: 0x0037C98C File Offset: 0x0037AB8C
	public void a(double A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600869E RID: 34462 RVA: 0x0037C998 File Offset: 0x0037AB98
	public bool d()
	{
		return this.c;
	}

	// Token: 0x0600869F RID: 34463 RVA: 0x0037C9A0 File Offset: 0x0037ABA0
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060086A0 RID: 34464 RVA: 0x0037C9AC File Offset: 0x0037ABAC
	public erl(bool A_0)
	{
		if (A_0)
		{
			this.a = cem.a;
			this.b = 0.0;
			return;
		}
		this.a = cem.d;
		this.b = aiy.b3[this.a];
	}

	// Token: 0x060086A1 RID: 34465 RVA: 0x0037C9FC File Offset: 0x0037ABFC
	public void c(double A_0)
	{
		if (A_0 <= 0.0)
		{
			return;
		}
		double num = A_0;
		while (num > 0.0)
		{
			this.b += num;
			if (this.b >= aiy.b3[this.a])
			{
				if (this.a == cem.d)
				{
					this.b = aiy.b3[this.a];
					return;
				}
				num = this.b - aiy.b3[this.a];
				this.a++;
				if (this.a == cem.d)
				{
					this.b = aiy.b3[this.a];
					num = 0.0;
				}
				else
				{
					this.b = 0.0;
				}
			}
			else
			{
				num = 0.0;
			}
		}
	}

	// Token: 0x060086A2 RID: 34466 RVA: 0x0037CAF0 File Offset: 0x0037ACF0
	public void b(double A_0)
	{
		if (A_0 <= 0.0)
		{
			return;
		}
		double num = A_0;
		while (num > 0.0)
		{
			this.b -= num;
			if (this.b < 0.0)
			{
				if (this.a == cem.a)
				{
					this.b = 0.0;
					return;
				}
				num = -this.b;
				this.a--;
				this.b = aiy.b3[this.a];
			}
			else
			{
				num = 0.0;
			}
		}
	}

	// Token: 0x060086A3 RID: 34467 RVA: 0x0037CB9C File Offset: 0x0037AD9C
	public void b()
	{
		this.a = cem.d;
		this.b = aiy.b3[this.a];
	}

	// Token: 0x060086A4 RID: 34468 RVA: 0x0037CBBC File Offset: 0x0037ADBC
	public void a()
	{
		this.a = cem.a;
		this.b = 0.0;
	}

	// Token: 0x060086A5 RID: 34469 RVA: 0x0037CBD4 File Offset: 0x0037ADD4
	public erl e()
	{
		return new erl(this.c)
		{
			a = this.a,
			b = this.b
		};
	}

	// Token: 0x040033D8 RID: 13272
	private cem a;

	// Token: 0x040033D9 RID: 13273
	private double b;

	// Token: 0x040033DA RID: 13274
	private bool c;
}
