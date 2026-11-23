using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x020012E9 RID: 4841
[eiz("GEA2")]
[Serializable]
public sealed class d0c : Aspect<c5x>, ISerializable, cmm
{
	// Token: 0x06006B63 RID: 27491 RVA: 0x002D233C File Offset: 0x002D053C
	private d0c(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.d = A_0.GetInt32("GEA2:GA");
		this.b = A_0.GetInt32("GEA2:GP");
		this.c = A_0.GetBoolean("GEA2:GIB");
		this.g = A_0.GetDouble("GEA2:GC");
		this.e = (A_0.GetValue("GEA2:OGJ", typeof(List<cze>)) as List<cze>);
		this.a = A_0.GetBoolean("GEA2:E");
		this.f = A_0.GetInt32("GEA2:AG");
		if (ell.a() >= 435)
		{
			this.h = A_0.GetBoolean("GEA2:D");
			this.i = A_0.GetDouble("GEA2:DC");
		}
	}

	// Token: 0x06006B64 RID: 27492 RVA: 0x002D242C File Offset: 0x002D062C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("GEA2:GA", this.d);
		info.AddValue("GEA2:GP", this.b);
		info.AddValue("GEA2:GIB", this.c);
		info.AddValue("GEA2:GC", this.g);
		info.AddValue("GEA2:OGJ", this.e);
		info.AddValue("GEA2:E", this.a);
		info.AddValue("GEA2:AG", this.f);
		info.AddValue("GEA2:D", this.h);
		info.AddValue("GEA2:DC", this.i);
	}

	// Token: 0x06006B65 RID: 27493 RVA: 0x002D24DC File Offset: 0x002D06DC
	public bool g()
	{
		return this.a;
	}

	// Token: 0x06006B66 RID: 27494 RVA: 0x002D24E4 File Offset: 0x002D06E4
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006B67 RID: 27495 RVA: 0x002D24F0 File Offset: 0x002D06F0
	public int e()
	{
		return this.d;
	}

	// Token: 0x06006B68 RID: 27496 RVA: 0x002D24F8 File Offset: 0x002D06F8
	public void a(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006B69 RID: 27497 RVA: 0x002D2504 File Offset: 0x002D0704
	public int d()
	{
		return this.b;
	}

	// Token: 0x06006B6A RID: 27498 RVA: 0x002D250C File Offset: 0x002D070C
	public void b(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006B6B RID: 27499 RVA: 0x002D2518 File Offset: 0x002D0718
	public bool f()
	{
		return this.c;
	}

	// Token: 0x06006B6C RID: 27500 RVA: 0x002D2520 File Offset: 0x002D0720
	public void b(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006B6D RID: 27501 RVA: 0x002D252C File Offset: 0x002D072C
	public List<cze> b()
	{
		return this.e;
	}

	// Token: 0x06006B6E RID: 27502 RVA: 0x002D2534 File Offset: 0x002D0734
	public void a(List<cze> A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006B6F RID: 27503 RVA: 0x002D2540 File Offset: 0x002D0740
	public d0c(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006B70 RID: 27504 RVA: 0x002D2570 File Offset: 0x002D0770
	public void a(int? A_0 = null)
	{
		if (A_0 != null)
		{
			this.d = A_0.Value;
		}
		this.f = 0;
		this.a = true;
		this.g = 0.0;
	}

	// Token: 0x06006B71 RID: 27505 RVA: 0x002D25A8 File Offset: 0x002D07A8
	public void r7(eds A_0)
	{
		this.b(A_0.b.TotalMilliseconds);
		this.a(A_0.b.TotalMilliseconds);
	}

	// Token: 0x06006B72 RID: 27506 RVA: 0x002D25D8 File Offset: 0x002D07D8
	public void c9(TimeSpan A_0)
	{
		if (this.c)
		{
			this.b(A_0.TotalMilliseconds);
		}
	}

	// Token: 0x06006B73 RID: 27507 RVA: 0x002D25F4 File Offset: 0x002D07F4
	public void da(TimeSpan A_0)
	{
	}

	// Token: 0x06006B74 RID: 27508 RVA: 0x002D25F8 File Offset: 0x002D07F8
	private void b(double A_0)
	{
		if (this.a && !dz6.e())
		{
			this.g += A_0;
			while (this.g >= (double)this.b)
			{
				if (this.d > 0 && this.f >= this.d)
				{
					this.a = false;
					this.g = 0.0;
					return;
				}
				this.g -= (double)this.b;
				this.f++;
				this.a();
			}
		}
	}

	// Token: 0x06006B75 RID: 27509 RVA: 0x002D2698 File Offset: 0x002D0898
	private void a(double A_0)
	{
		if (!this.h && !string.IsNullOrWhiteSpace(base.a8().y8()) && (this.i -= A_0) <= 0.0)
		{
			this.i = 1000.0;
			if (base.a8() != null && base.a8().j == cgy.b && base.a8().Area != null && base.a8().c(dm9.b))
			{
				string text = base.a8().y8().Replace(" ", "");
				if (text.Length > 1)
				{
					text = text.Substring(0, 1).ToLowerInvariant() + text.Substring(1);
				}
				else
				{
					text = text.ToLowerInvariant();
				}
				bpo.GetServiceOrThrow<e5f>().ash(text, null);
				this.h = true;
			}
		}
	}

	// Token: 0x06006B76 RID: 27510 RVA: 0x002D2794 File Offset: 0x002D0994
	private void a()
	{
		if (this.e != null)
		{
			foreach (cze cze in this.e)
			{
				cze.ym(null, base.a8(), null);
			}
		}
	}

	// Token: 0x04002C17 RID: 11287
	private bool a;

	// Token: 0x04002C18 RID: 11288
	private int b = 1000;

	// Token: 0x04002C19 RID: 11289
	private bool c = true;

	// Token: 0x04002C1A RID: 11290
	private int d = -1;

	// Token: 0x04002C1B RID: 11291
	private List<cze> e = new List<cze>();

	// Token: 0x04002C1C RID: 11292
	private int f;

	// Token: 0x04002C1D RID: 11293
	private double g;

	// Token: 0x04002C1E RID: 11294
	private bool h;

	// Token: 0x04002C1F RID: 11295
	private double i;
}
