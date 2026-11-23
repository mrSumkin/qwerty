using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x020012EF RID: 4847
[eiz("EJ2")]
[Serializable]
public class t6 : Aspect<c5x>, c98, ISerializable
{
	// Token: 0x06006BB0 RID: 27568 RVA: 0x002D3810 File Offset: 0x002D1A10
	protected t6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<cze>("EJ2:J", ref this.a, A_0);
		this.b = A_0.GetInt32("EJ2:E");
		this.c = A_0.GetInt32("EJ2:M");
		this.d = A_0.GetInt32("EJ2:D");
		this.e = A_0.GetInt32("EJ2:P");
		this.f = (A_0.GetValue("EJ2:C", typeof(double?)) as double?);
		if (ell.a() >= 502)
		{
			this.g = (b2m)A_0.GetValue("EJ2:X", typeof(b2m));
		}
		if (ell.a() >= 555)
		{
			this.h = A_0.GetBoolean("EJ2:EN");
			return;
		}
		this.h = true;
	}

	// Token: 0x06006BB1 RID: 27569 RVA: 0x002D3908 File Offset: 0x002D1B08
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<cze>("EJ2:J", this.a, info);
		info.AddValue("EJ2:E", this.b);
		info.AddValue("EJ2:M", this.c);
		info.AddValue("EJ2:D", this.d);
		info.AddValue("EJ2:P", this.e);
		info.AddValue("EJ2:C", this.f);
		info.AddValue("EJ2:X", this.g);
		info.AddValue("EJ2:EN", this.h);
	}

	// Token: 0x06006BB2 RID: 27570 RVA: 0x002D39B0 File Offset: 0x002D1BB0
	public List<cze> d()
	{
		return this.a;
	}

	// Token: 0x06006BB3 RID: 27571 RVA: 0x002D39B8 File Offset: 0x002D1BB8
	public void a(List<cze> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006BB4 RID: 27572 RVA: 0x002D39C4 File Offset: 0x002D1BC4
	public int e()
	{
		return this.c;
	}

	// Token: 0x06006BB5 RID: 27573 RVA: 0x002D39CC File Offset: 0x002D1BCC
	public void b(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006BB6 RID: 27574 RVA: 0x002D39D8 File Offset: 0x002D1BD8
	public int g()
	{
		return this.d;
	}

	// Token: 0x06006BB7 RID: 27575 RVA: 0x002D39E0 File Offset: 0x002D1BE0
	public void c(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006BB8 RID: 27576 RVA: 0x002D39EC File Offset: 0x002D1BEC
	public int f()
	{
		return this.e;
	}

	// Token: 0x06006BB9 RID: 27577 RVA: 0x002D39F4 File Offset: 0x002D1BF4
	public void a(int A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006BBA RID: 27578 RVA: 0x002D3A00 File Offset: 0x002D1C00
	public b2m b()
	{
		return this.g;
	}

	// Token: 0x06006BBB RID: 27579 RVA: 0x002D3A08 File Offset: 0x002D1C08
	public void a(b2m A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06006BBC RID: 27580 RVA: 0x002D3A14 File Offset: 0x002D1C14
	public bool h()
	{
		return this.h;
	}

	// Token: 0x06006BBD RID: 27581 RVA: 0x002D3A1C File Offset: 0x002D1C1C
	public void a(bool A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06006BBE RID: 27582 RVA: 0x002D3A28 File Offset: 0x002D1C28
	public t6(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006BBF RID: 27583 RVA: 0x002D3A44 File Offset: 0x002D1C44
	public void r7(eds A_0)
	{
		if (this.h && (this.c <= 0 || this.b < this.c))
		{
			if (this.f == null)
			{
				this.f = new double?((double)this.d);
			}
			double? num = this.f -= A_0.b.TotalMilliseconds;
			double num2 = 0.0;
			if (num.GetValueOrDefault() <= num2 & num != null)
			{
				this.b++;
				this.a();
				this.f = new double?((double)this.f());
			}
		}
	}

	// Token: 0x06006BC0 RID: 27584 RVA: 0x002D3B2C File Offset: 0x002D1D2C
	private void a()
	{
		if (this.a != null && this.a.Count > 0)
		{
			foreach (cze cze in this.a)
			{
				if (this.g == b2m.c)
				{
					cze.ym(null, base.a8(), null);
				}
				else
				{
					cze.ym(base.a8(), null, null);
				}
			}
		}
	}

	// Token: 0x04002C33 RID: 11315
	private List<cze> a = new List<cze>();

	// Token: 0x04002C34 RID: 11316
	private int b;

	// Token: 0x04002C35 RID: 11317
	private int c;

	// Token: 0x04002C36 RID: 11318
	private int d;

	// Token: 0x04002C37 RID: 11319
	private int e;

	// Token: 0x04002C38 RID: 11320
	private double? f;

	// Token: 0x04002C39 RID: 11321
	private b2m g;

	// Token: 0x04002C3A RID: 11322
	private bool h = true;
}
