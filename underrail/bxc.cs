using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common;
using Ouroboros.Common.Aspects;

// Token: 0x02001300 RID: 4864
[eiz("GEA")]
[Serializable]
public sealed class bxc : Aspect<c5x>, ISerializable, cmm
{
	// Token: 0x06006C6C RID: 27756 RVA: 0x002D7104 File Offset: 0x002D5304
	private bxc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("GEA:GU");
		this.b = A_0.GetInt32("GEA:GP");
		this.c = A_0.GetBoolean("GEA:GIB");
		this.i = A_0.GetDouble("GEA:GC");
		this.d = A_0.GetInt32("GEA:ZSP");
		this.e = A_0.GetInt32("GEA:MSP");
		this.f = (Axis)A_0.GetValue("GEA:LGA", typeof(Axis));
		this.g = (A_0.GetValue("GEA:OGJ", typeof(List<cze>)) as List<cze>);
		this.h = (A_0.GetValue("GEA:OSJ", typeof(List<cze>)) as List<cze>);
	}

	// Token: 0x06006C6D RID: 27757 RVA: 0x002D721C File Offset: 0x002D541C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("GEA:GU", this.a);
		info.AddValue("GEA:GP", this.b);
		info.AddValue("GEA:GIB", this.c);
		info.AddValue("GEA:GC", this.i);
		info.AddValue("GEA:ZSP", this.d);
		info.AddValue("GEA:MSP", this.e);
		info.AddValue("GEA:LGA", this.f);
		info.AddValue("GEA:OGJ", this.g);
		info.AddValue("GEA:OSJ", this.h);
	}

	// Token: 0x06006C6E RID: 27758 RVA: 0x002D72D0 File Offset: 0x002D54D0
	public int k()
	{
		return this.a;
	}

	// Token: 0x06006C6F RID: 27759 RVA: 0x002D72D8 File Offset: 0x002D54D8
	public void d(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006C70 RID: 27760 RVA: 0x002D72E4 File Offset: 0x002D54E4
	public int l()
	{
		return this.b;
	}

	// Token: 0x06006C71 RID: 27761 RVA: 0x002D72EC File Offset: 0x002D54EC
	public void c(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006C72 RID: 27762 RVA: 0x002D72F8 File Offset: 0x002D54F8
	public bool n()
	{
		return this.c;
	}

	// Token: 0x06006C73 RID: 27763 RVA: 0x002D7300 File Offset: 0x002D5500
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006C74 RID: 27764 RVA: 0x002D730C File Offset: 0x002D550C
	public int p()
	{
		return this.e;
	}

	// Token: 0x06006C75 RID: 27765 RVA: 0x002D7314 File Offset: 0x002D5514
	public void g(int A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006C76 RID: 27766 RVA: 0x002D7320 File Offset: 0x002D5520
	public int h()
	{
		return this.d;
	}

	// Token: 0x06006C77 RID: 27767 RVA: 0x002D7328 File Offset: 0x002D5528
	public void e(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006C78 RID: 27768 RVA: 0x002D7334 File Offset: 0x002D5534
	public Axis g()
	{
		return this.f;
	}

	// Token: 0x06006C79 RID: 27769 RVA: 0x002D733C File Offset: 0x002D553C
	public void a(Axis A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06006C7A RID: 27770 RVA: 0x002D7348 File Offset: 0x002D5548
	public List<cze> m()
	{
		return this.g;
	}

	// Token: 0x06006C7B RID: 27771 RVA: 0x002D7350 File Offset: 0x002D5550
	public void b(List<cze> A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06006C7C RID: 27772 RVA: 0x002D735C File Offset: 0x002D555C
	public List<cze> o()
	{
		return this.h;
	}

	// Token: 0x06006C7D RID: 27773 RVA: 0x002D7364 File Offset: 0x002D5564
	public void a(List<cze> A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06006C7E RID: 27774 RVA: 0x002D7370 File Offset: 0x002D5570
	public bool j()
	{
		return this.b(this.d());
	}

	// Token: 0x06006C7F RID: 27775 RVA: 0x002D7380 File Offset: 0x002D5580
	public bool i()
	{
		return this.a(this.d());
	}

	// Token: 0x06006C80 RID: 27776 RVA: 0x002D7390 File Offset: 0x002D5590
	public bxc(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006C81 RID: 27777 RVA: 0x002D73E4 File Offset: 0x002D55E4
	public void r7(eds A_0)
	{
		if (!dz6.e() && base.a8().o.b != null)
		{
			this.a(A_0.b.TotalMilliseconds);
		}
	}

	// Token: 0x06006C82 RID: 27778 RVA: 0x002D7418 File Offset: 0x002D5618
	public bool f(int A_0)
	{
		if (base.a8().o.b == null)
		{
			return false;
		}
		if (this.a(this.d()))
		{
			return false;
		}
		for (int i = 0; i < A_0; i++)
		{
			this.i = 0.0;
			this.e();
		}
		this.a();
		return true;
	}

	// Token: 0x06006C83 RID: 27779 RVA: 0x002D747C File Offset: 0x002D567C
	public void c9(TimeSpan A_0)
	{
		if (this.c)
		{
			this.a(A_0.TotalMilliseconds);
		}
	}

	// Token: 0x06006C84 RID: 27780 RVA: 0x002D7498 File Offset: 0x002D5698
	public void da(TimeSpan A_0)
	{
	}

	// Token: 0x06006C85 RID: 27781 RVA: 0x002D749C File Offset: 0x002D569C
	private void a(double A_0)
	{
		if (this.b(this.d()))
		{
			this.i = 0.0;
			return;
		}
		this.i += A_0;
		bool flag = false;
		while (this.i >= (double)this.b)
		{
			if (kb.a(base.a8()))
			{
				this.i = 0.0;
				break;
			}
			this.i -= (double)this.b;
			this.f();
			flag = true;
			if (this.b(this.d()))
			{
				this.i = 0.0;
				break;
			}
		}
		if (flag)
		{
			this.b();
		}
	}

	// Token: 0x06006C86 RID: 27782 RVA: 0x002D7560 File Offset: 0x002D5760
	private void f()
	{
		Point point = base.a8().o.b.b;
		if (this.f == Axis.X)
		{
			point.X += this.a;
		}
		else
		{
			point.Y += this.a;
		}
		base.a8().o.b.b = point;
	}

	// Token: 0x06006C87 RID: 27783 RVA: 0x002D75CC File Offset: 0x002D57CC
	private void e()
	{
		Point point = base.a8().o.b.b;
		if (this.f == Axis.X)
		{
			point.X -= this.a;
		}
		else
		{
			point.Y -= this.a;
		}
		base.a8().o.b.b = point;
	}

	// Token: 0x06006C88 RID: 27784 RVA: 0x002D7638 File Offset: 0x002D5838
	private int d()
	{
		if (this.f == Axis.X)
		{
			return base.a8().o.b.b.X;
		}
		return base.a8().o.b.b.Y;
	}

	// Token: 0x06006C89 RID: 27785 RVA: 0x002D7688 File Offset: 0x002D5888
	private bool b(int A_0)
	{
		return A_0 == this.e || (this.a > 0 && A_0 > this.e) || (this.a < 0 && A_0 < this.e);
	}

	// Token: 0x06006C8A RID: 27786 RVA: 0x002D76C8 File Offset: 0x002D58C8
	private bool a(int A_0)
	{
		return A_0 == this.d || (this.a > 0 && A_0 < this.d) || (this.a < 0 && A_0 > this.d);
	}

	// Token: 0x06006C8B RID: 27787 RVA: 0x002D7708 File Offset: 0x002D5908
	private void b()
	{
		if (this.g != null)
		{
			foreach (cze cze in this.g)
			{
				cze.ym(null, base.a8(), null);
			}
		}
	}

	// Token: 0x06006C8C RID: 27788 RVA: 0x002D7774 File Offset: 0x002D5974
	private void a()
	{
		if (this.h != null)
		{
			foreach (cze cze in this.h)
			{
				cze.ym(null, base.a8(), null);
			}
		}
	}

	// Token: 0x04002C80 RID: 11392
	private int a = 1;

	// Token: 0x04002C81 RID: 11393
	private int b = 1000;

	// Token: 0x04002C82 RID: 11394
	private bool c = true;

	// Token: 0x04002C83 RID: 11395
	private int d;

	// Token: 0x04002C84 RID: 11396
	private int e = 1;

	// Token: 0x04002C85 RID: 11397
	private Axis f = Axis.Y;

	// Token: 0x04002C86 RID: 11398
	private List<cze> g = new List<cze>();

	// Token: 0x04002C87 RID: 11399
	private List<cze> h = new List<cze>();

	// Token: 0x04002C88 RID: 11400
	private double i;
}
