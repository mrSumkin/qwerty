using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x020012E0 RID: 4832
[eiz("A06")]
[Serializable]
public sealed class dm : Aspect<c5x>, cmm, chb
{
	// Token: 0x06006B02 RID: 27394 RVA: 0x002D04E4 File Offset: 0x002CE6E4
	private dm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetInt32("A06:T");
		this.a = A_0.GetDouble("A06:C");
		this.c = A_0.GetBoolean("A06:E");
		di7.ReadList<cze>("A06:J", ref this.d, A_0);
		if (ell.a() >= 217)
		{
			this.e = (A_0.GetValue("A06:P", typeof(int?)) as int?);
		}
		if (ell.a() >= 657)
		{
			this.f = A_0.GetSingle("A06:X");
			this.g = A_0.GetBoolean("A06:S");
			return;
		}
		if (this.e != null)
		{
			this.f = (float)this.b * ((float)this.e.Value / (float)d0u.b);
			return;
		}
		this.f = (float)this.b;
	}

	// Token: 0x06006B03 RID: 27395 RVA: 0x002D05F4 File Offset: 0x002CE7F4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("A06:T", this.b);
		info.AddValue("A06:C", this.a);
		info.AddValue("A06:E", this.c);
		info.AddValue("A06:P", this.e);
		di7.WriteList<cze>("A06:J", this.d, info);
		info.AddValue("A06:X", this.f);
		info.AddValue("A06:S", this.g);
	}

	// Token: 0x06006B04 RID: 27396 RVA: 0x002D0688 File Offset: 0x002CE888
	public List<cze> d()
	{
		return this.d;
	}

	// Token: 0x06006B05 RID: 27397 RVA: 0x002D0690 File Offset: 0x002CE890
	public void a(List<cze> A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006B06 RID: 27398 RVA: 0x002D069C File Offset: 0x002CE89C
	public bool g()
	{
		return this.c;
	}

	// Token: 0x06006B07 RID: 27399 RVA: 0x002D06A4 File Offset: 0x002CE8A4
	public void b(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006B08 RID: 27400 RVA: 0x002D06B0 File Offset: 0x002CE8B0
	public int f()
	{
		return this.b;
	}

	// Token: 0x06006B09 RID: 27401 RVA: 0x002D06B8 File Offset: 0x002CE8B8
	public int? e()
	{
		return this.e;
	}

	// Token: 0x06006B0A RID: 27402 RVA: 0x002D06C0 File Offset: 0x002CE8C0
	public void a(int? A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006B0B RID: 27403 RVA: 0x002D06CC File Offset: 0x002CE8CC
	public bool b()
	{
		return this.g;
	}

	// Token: 0x06006B0C RID: 27404 RVA: 0x002D06D4 File Offset: 0x002CE8D4
	public void c(bool A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06006B0D RID: 27405 RVA: 0x002D06E0 File Offset: 0x002CE8E0
	public dm(c5x A_0) : base(A_0)
	{
		this.a = 0.0;
	}

	// Token: 0x06006B0E RID: 27406 RVA: 0x002D070C File Offset: 0x002CE90C
	public void r7(eds A_0)
	{
		this.f += Convert.ToSingle(A_0.b.TotalMilliseconds / (double)d0u.b);
		double num = this.a();
		if (this.c && !dz6.e())
		{
			if ((this.a += A_0.b.TotalMilliseconds) >= num)
			{
				this.a -= num;
				this.a(false);
				return;
			}
		}
		else
		{
			this.a = 0.0;
		}
	}

	// Token: 0x06006B0F RID: 27407 RVA: 0x002D07A0 File Offset: 0x002CE9A0
	public void c()
	{
		if (this.c)
		{
			this.f += 1f;
			this.a(true);
		}
		this.a = 0.0;
	}

	// Token: 0x06006B10 RID: 27408 RVA: 0x002D07D8 File Offset: 0x002CE9D8
	public void c9(TimeSpan A_0)
	{
		if (this.g && this.c)
		{
			this.f += Convert.ToSingle(A_0.TotalMilliseconds / (double)d0u.b);
			this.a += A_0.TotalMilliseconds;
			double num = this.a();
			while (this.a >= num)
			{
				this.a -= num;
				this.a(false);
			}
		}
	}

	// Token: 0x06006B11 RID: 27409 RVA: 0x002D085C File Offset: 0x002CEA5C
	public void da(TimeSpan A_0)
	{
	}

	// Token: 0x06006B12 RID: 27410 RVA: 0x002D0860 File Offset: 0x002CEA60
	private double a()
	{
		return (double)((this.e != null) ? this.e.Value : d0u.b);
	}

	// Token: 0x06006B13 RID: 27411 RVA: 0x002D088C File Offset: 0x002CEA8C
	private void a(bool A_0 = false)
	{
		if (this.d.Count > 0)
		{
			int num = 1;
			if (A_0 && this.e != null)
			{
				if (this.e.Value < d0u.b)
				{
					num = Math.Max(1, d0u.b / this.e.Value);
				}
				else if (this.e.Value > d0u.b)
				{
					int num2 = this.e.Value / d0u.b;
					if ((int)this.f % num2 == 0)
					{
						num = 1;
					}
					else
					{
						num = 0;
					}
				}
			}
			for (int i = 0; i < num; i++)
			{
				this.b++;
				foreach (cze cze in this.d)
				{
					if (base.a8() == null || base.a8().j != cgy.b)
					{
						return;
					}
					int num3 = this.b * this.e.GetValueOrDefault(d0u.b);
					cze.ym(null, base.a8(), new Dictionary<string, object>
					{
						{
							"tickCount",
							this.b
						},
						{
							"customTickPeriod",
							this.e
						},
						{
							"totalTime",
							num3
						}
					});
				}
			}
		}
	}

	// Token: 0x04002BF4 RID: 11252
	private double a;

	// Token: 0x04002BF5 RID: 11253
	private int b;

	// Token: 0x04002BF6 RID: 11254
	private bool c = true;

	// Token: 0x04002BF7 RID: 11255
	private List<cze> d = new List<cze>();

	// Token: 0x04002BF8 RID: 11256
	private int? e;

	// Token: 0x04002BF9 RID: 11257
	private float f;

	// Token: 0x04002BFA RID: 11258
	private bool g;
}
