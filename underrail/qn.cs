using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001291 RID: 4753
[eiz("GSEAX")]
[Serializable]
public sealed class qn : Aspect<c5x>, ISerializable, cmm, chb
{
	// Token: 0x060067B4 RID: 26548 RVA: 0x002BF2B8 File Offset: 0x002BD4B8
	private qn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.c = A_0.GetBoolean("GSEAX:D");
		this.d = A_0.GetInt32("GSEAX:P");
		this.e = A_0.GetInt32("GSEAX:A");
		this.f = A_0.GetBoolean("GSEAX:C");
		this.g = A_0.GetDouble("GSEAX:R");
		this.h = A_0.GetDouble("GSEAX:H");
		this.i = (A_0.GetValue("GSEAX:U", typeof(int?)) as int?);
	}

	// Token: 0x060067B5 RID: 26549 RVA: 0x002BF370 File Offset: 0x002BD570
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("GSEAX:D", this.c);
		info.AddValue("GSEAX:P", this.d);
		info.AddValue("GSEAX:A", this.e);
		info.AddValue("GSEAX:C", this.f);
		info.AddValue("GSEAX:R", this.g);
		info.AddValue("GSEAX:H", this.h);
		info.AddValue("GSEAX:U", this.i);
	}

	// Token: 0x060067B6 RID: 26550 RVA: 0x002BF404 File Offset: 0x002BD604
	public int f()
	{
		return this.d;
	}

	// Token: 0x060067B7 RID: 26551 RVA: 0x002BF40C File Offset: 0x002BD60C
	public void b(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060067B8 RID: 26552 RVA: 0x002BF418 File Offset: 0x002BD618
	public int g()
	{
		return this.e;
	}

	// Token: 0x060067B9 RID: 26553 RVA: 0x002BF420 File Offset: 0x002BD620
	public void a(int A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060067BA RID: 26554 RVA: 0x002BF42C File Offset: 0x002BD62C
	public bool k()
	{
		return this.f;
	}

	// Token: 0x060067BB RID: 26555 RVA: 0x002BF434 File Offset: 0x002BD634
	public void a(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x060067BC RID: 26556 RVA: 0x002BF440 File Offset: 0x002BD640
	public double j()
	{
		return this.g;
	}

	// Token: 0x060067BD RID: 26557 RVA: 0x002BF448 File Offset: 0x002BD648
	public void b(double A_0)
	{
		this.g = A_0;
	}

	// Token: 0x060067BE RID: 26558 RVA: 0x002BF454 File Offset: 0x002BD654
	public int? i()
	{
		return this.i;
	}

	// Token: 0x060067BF RID: 26559 RVA: 0x002BF45C File Offset: 0x002BD65C
	public void a(int? A_0)
	{
		this.i = A_0;
	}

	// Token: 0x060067C0 RID: 26560 RVA: 0x002BF468 File Offset: 0x002BD668
	public int h()
	{
		int? num = this.i;
		if (num == null)
		{
			return qn.a;
		}
		return num.GetValueOrDefault();
	}

	// Token: 0x060067C1 RID: 26561 RVA: 0x002BF498 File Offset: 0x002BD698
	public qn(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060067C2 RID: 26562 RVA: 0x002BF4B8 File Offset: 0x002BD6B8
	public void c9(TimeSpan A_0)
	{
		double num = A_0.TotalMilliseconds;
		while (num > 0.0)
		{
			double num2 = Math.Max((double)d0u.b, num);
			num -= num2;
			this.a(num2);
		}
	}

	// Token: 0x060067C3 RID: 26563 RVA: 0x002BF4F8 File Offset: 0x002BD6F8
	public void da(TimeSpan A_0)
	{
	}

	// Token: 0x060067C4 RID: 26564 RVA: 0x002BF4FC File Offset: 0x002BD6FC
	public void r7(eds A_0)
	{
		if (this.c)
		{
			if (!dz6.e())
			{
				this.a(A_0.b.TotalMilliseconds);
				if ((this.h += A_0.b.TotalMilliseconds) >= (double)(d0u.b / 5))
				{
					this.h -= (double)(d0u.b / 5);
					this.e();
				}
			}
		}
		else
		{
			this.b();
			if (this.g <= 0.0)
			{
				this.d();
			}
		}
		this.a();
	}

	// Token: 0x060067C5 RID: 26565 RVA: 0x002BF5A0 File Offset: 0x002BD7A0
	public void c()
	{
		this.a((double)d0u.b);
		for (int i = 0; i < 5; i++)
		{
			this.e();
		}
	}

	// Token: 0x060067C6 RID: 26566 RVA: 0x002BF5D0 File Offset: 0x002BD7D0
	public void a(c5x A_0, bool A_1 = false)
	{
		if (this.f && (!A_1 || cuo.a.NextDouble() < 0.5) && A_0.h.b != null && A_0.IsPlayer)
		{
			double num = aw1.b(base.a8(), A_0);
			if (num <= (double)this.h())
			{
				double a_ = Math.Max(0.15, 1.0 - num / (double)this.h());
				cwt cwt = new cwt();
				cwt.i = new ap9("Geyser emissions", null);
				cwt.v = "выброс гейзера";
				cwt.f.Add(euf.a(qn.b, a_));
				cwt.l = true;
				cwt.b = true;
				cwt.w = true;
				A_0.h.b.aa().Defense.a(cwt);
			}
		}
	}

	// Token: 0x060067C7 RID: 26567 RVA: 0x002BF6C8 File Offset: 0x002BD8C8
	private void e()
	{
		if (this.f)
		{
			foreach (d4n d4n in bpo.GetServiceOrThrow<d02>().ahl())
			{
				if (d4n.b != null && d4n.b.a8() != null && d4n.b.a8().Area == base.a8().Area)
				{
					this.a(d4n.b.a8(), false);
				}
			}
		}
	}

	// Token: 0x060067C8 RID: 26568 RVA: 0x002BF778 File Offset: 0x002BD978
	private void a(double A_0)
	{
		if ((this.g -= A_0) <= 0.0)
		{
			this.f = !this.f;
			this.d();
		}
	}

	// Token: 0x060067C9 RID: 26569 RVA: 0x002BF7BC File Offset: 0x002BD9BC
	private void d()
	{
		if (this.f)
		{
			this.g = (double)this.e;
			return;
		}
		this.g = (double)this.d;
	}

	// Token: 0x060067CA RID: 26570 RVA: 0x002BF7E8 File Offset: 0x002BD9E8
	private void b()
	{
		this.c = true;
		for (int i = Math.Max(0, (int)base.a8().Location.X - this.h()); i <= (int)base.a8().Location.X + this.h(); i++)
		{
			for (int j = Math.Max(0, (int)base.a8().Location.Y - this.h()); j <= (int)base.a8().Location.Y + this.h(); j++)
			{
				ak1 ak = base.a8().Area.b(i, j);
				if (ak != null && aw1.a(base.a8(), ak) <= (double)this.h())
				{
					cmy cmy = new cmy(this);
					cmy.Location = ak.Location;
					cmy.Size = new esj(1, 1);
					cmy.Layer = aju.x;
					ak.Area.b(cmy);
				}
			}
		}
	}

	// Token: 0x060067CB RID: 26571 RVA: 0x002BF8F4 File Offset: 0x002BDAF4
	private void a()
	{
		h4 aspect = base.a8().GetAspect<h4>();
		if (aspect != null)
		{
			aspect.b(this.f);
		}
		aru aru = base.a8().c();
		if (this.f)
		{
			if (!aru.e().ContainsKey("geysir_steaming"))
			{
				aru.a("geysir_steaming", "Geysir", 1f, c9z.b, true, false);
				return;
			}
		}
		else if (aru.e().ContainsKey("geysir_steaming"))
		{
			aru.a("geysir_steaming", false);
		}
	}

	// Token: 0x04002AE8 RID: 10984
	private static readonly int a = 5;

	// Token: 0x04002AE9 RID: 10985
	private static readonly a1q b = new a1q(DamageType.Heat, 20, 40);

	// Token: 0x04002AEA RID: 10986
	private bool c;

	// Token: 0x04002AEB RID: 10987
	private int d = 120000;

	// Token: 0x04002AEC RID: 10988
	private int e = 30000;

	// Token: 0x04002AED RID: 10989
	private bool f;

	// Token: 0x04002AEE RID: 10990
	private double g;

	// Token: 0x04002AEF RID: 10991
	private double h;

	// Token: 0x04002AF0 RID: 10992
	private int? i;
}
