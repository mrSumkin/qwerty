using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001096 RID: 4246
[eiz("SOECAJ")]
[Serializable]
public sealed class dn0 : cze
{
	// Token: 0x060058E9 RID: 22761 RVA: 0x0026875C File Offset: 0x0026695C
	private dn0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetSingle("SOECAJ:MN");
		this.b = A_0.GetSingle("SOECAJ:MX");
		this.c = A_0.GetSingle("SOECAJ:S");
		this.d = A_0.GetInt32("SOECAJ:D");
		this.e = A_0.GetInt32("SOECAJ:I");
		this.f = A_0.GetDouble("SOECAJ:C");
		this.g = A_0.GetString("SOECAJ:E");
		if (ell.a() >= 356)
		{
			this.h = A_0.GetBoolean("SOECAJ:R");
		}
	}

	// Token: 0x060058EA RID: 22762 RVA: 0x00268818 File Offset: 0x00266A18
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SOECAJ:MN", this.a);
		info.AddValue("SOECAJ:MX", this.b);
		info.AddValue("SOECAJ:S", this.c);
		info.AddValue("SOECAJ:D", this.d);
		info.AddValue("SOECAJ:I", this.e);
		info.AddValue("SOECAJ:C", this.f);
		info.AddValue("SOECAJ:E", this.g);
		info.AddValue("SOECAJ:R", this.h);
	}

	// Token: 0x060058EB RID: 22763 RVA: 0x002688B8 File Offset: 0x00266AB8
	public float d()
	{
		return this.a;
	}

	// Token: 0x060058EC RID: 22764 RVA: 0x002688C0 File Offset: 0x00266AC0
	public void c(float A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060058ED RID: 22765 RVA: 0x002688CC File Offset: 0x00266ACC
	public float h()
	{
		return this.b;
	}

	// Token: 0x060058EE RID: 22766 RVA: 0x002688D4 File Offset: 0x00266AD4
	public void b(float A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060058EF RID: 22767 RVA: 0x002688E0 File Offset: 0x00266AE0
	public float e()
	{
		return this.c;
	}

	// Token: 0x060058F0 RID: 22768 RVA: 0x002688E8 File Offset: 0x00266AE8
	public void a(float A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060058F1 RID: 22769 RVA: 0x002688F4 File Offset: 0x00266AF4
	public int b()
	{
		return this.d;
	}

	// Token: 0x060058F2 RID: 22770 RVA: 0x002688FC File Offset: 0x00266AFC
	public void a(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060058F3 RID: 22771 RVA: 0x00268908 File Offset: 0x00266B08
	public int g()
	{
		return this.e;
	}

	// Token: 0x060058F4 RID: 22772 RVA: 0x00268910 File Offset: 0x00266B10
	public void b(int A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060058F5 RID: 22773 RVA: 0x0026891C File Offset: 0x00266B1C
	public double f()
	{
		return this.f;
	}

	// Token: 0x060058F6 RID: 22774 RVA: 0x00268924 File Offset: 0x00266B24
	public void a(double A_0)
	{
		this.f = A_0;
	}

	// Token: 0x060058F7 RID: 22775 RVA: 0x00268930 File Offset: 0x00266B30
	public string c()
	{
		return this.g;
	}

	// Token: 0x060058F8 RID: 22776 RVA: 0x00268938 File Offset: 0x00266B38
	public void a(string A_0)
	{
		this.g = A_0;
	}

	// Token: 0x060058F9 RID: 22777 RVA: 0x00268944 File Offset: 0x00266B44
	public bool a()
	{
		return this.h;
	}

	// Token: 0x060058FA RID: 22778 RVA: 0x0026894C File Offset: 0x00266B4C
	public void a(bool A_0)
	{
		this.h = A_0;
	}

	// Token: 0x060058FB RID: 22779 RVA: 0x00268958 File Offset: 0x00266B58
	public dn0()
	{
	}

	// Token: 0x060058FC RID: 22780 RVA: 0x00268970 File Offset: 0x00266B70
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (!string.IsNullOrEmpty(this.g))
		{
			c1a c1a;
			if (A_0 != null)
			{
				c1a = A_0.Zone;
			}
			else if (A_1 != null)
			{
				c1a = A_1.Zone;
			}
			else
			{
				c1a = null;
			}
			if (c1a != null)
			{
				c5x c5x2 = new ar7(new Guid(this.g), A_0.Area).ao() as c5x;
				if (c5x2 != null)
				{
					c5x = c5x2;
				}
			}
		}
		else if (A_1 != null)
		{
			c5x = (A_1 as c5x);
		}
		else if (A_0 != null)
		{
			c5x = (A_0 as c5x);
		}
		if (c5x != null && c5x.Zone != null)
		{
			float a_;
			int a_2;
			if (this.h)
			{
				a_ = (float)((double)this.a + cuo.a.NextDouble() * (double)(this.b - this.a));
				a_2 = ((cuo.a.NextDouble() < 0.5) ? -1 : 1);
			}
			else
			{
				a_ = this.c;
				a_2 = this.d;
			}
			b1m a_3 = new b1m(c5x, this.a, this.b, a_, a_2, this.f, this.e);
			c5x.Zone.ActionManager.g9(a_3, atp.a);
		}
	}

	// Token: 0x040023CB RID: 9163
	private new float a;

	// Token: 0x040023CC RID: 9164
	private float b;

	// Token: 0x040023CD RID: 9165
	private float c;

	// Token: 0x040023CE RID: 9166
	private int d = 1;

	// Token: 0x040023CF RID: 9167
	private int e = -1;

	// Token: 0x040023D0 RID: 9168
	private double f;

	// Token: 0x040023D1 RID: 9169
	private string g;

	// Token: 0x040023D2 RID: 9170
	private bool h;
}
