using System;
using System.Linq;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x020012FC RID: 4860
[eiz("FSEA2")]
[Serializable]
public sealed class b8b : Aspect<c5x>, cmm
{
	// Token: 0x06006C22 RID: 27682 RVA: 0x002D6248 File Offset: 0x002D4448
	private b8b(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("FSEA2:D");
		this.b = A_0.GetBoolean("FSEA2:F");
		this.c = A_0.GetInt32("FSEA2:MS");
		this.d = A_0.GetInt32("FSEA2:MT");
		this.e = A_0.GetBoolean("FSEA2:DE");
		this.f = (A_0.GetValue("FSEA2:DL", typeof(c9y)) as c9y);
		this.g = (A_0.GetValue("FSEA2:SL", typeof(dcw)) as dcw);
		this.h = A_0.GetDouble("FSEA2:DM");
		this.j = A_0.GetInt32("FSEA2:T");
		this.k = A_0.GetInt32("FSEA2:S");
		this.i = A_0.GetSingle("FSEA2:BR");
		if (ell.a() >= 148)
		{
			this.l = (A_0.GetValue("FSEA2:R", typeof(TimeSpan?)) as TimeSpan?);
			this.m = (TimeSpan)A_0.GetValue("FSEA2:RC", typeof(TimeSpan));
		}
	}

	// Token: 0x06006C23 RID: 27683 RVA: 0x002D63C4 File Offset: 0x002D45C4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FSEA2:D", this.a);
		info.AddValue("FSEA2:F", this.b);
		info.AddValue("FSEA2:MS", this.c);
		info.AddValue("FSEA2:MT", this.d);
		info.AddValue("FSEA2:DE", this.e);
		info.AddValue("FSEA2:DL", this.f);
		info.AddValue("FSEA2:SL", this.g);
		info.AddValue("FSEA2:DM", this.h);
		info.AddValue("FSEA2:T", this.j);
		info.AddValue("FSEA2:S", this.k);
		info.AddValue("FSEA2:BR", this.i);
		info.AddValue("FSEA2:R", this.l);
		info.AddValue("FSEA2:RC", this.m);
	}

	// Token: 0x06006C24 RID: 27684 RVA: 0x002D64C0 File Offset: 0x002D46C0
	public bool e()
	{
		return this.a;
	}

	// Token: 0x06006C25 RID: 27685 RVA: 0x002D64C8 File Offset: 0x002D46C8
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006C26 RID: 27686 RVA: 0x002D64D4 File Offset: 0x002D46D4
	public int m()
	{
		return this.c;
	}

	// Token: 0x06006C27 RID: 27687 RVA: 0x002D64DC File Offset: 0x002D46DC
	public void b(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006C28 RID: 27688 RVA: 0x002D64E8 File Offset: 0x002D46E8
	public int l()
	{
		return this.d;
	}

	// Token: 0x06006C29 RID: 27689 RVA: 0x002D64F0 File Offset: 0x002D46F0
	public void a(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006C2A RID: 27690 RVA: 0x002D64FC File Offset: 0x002D46FC
	public bool g()
	{
		return this.e;
	}

	// Token: 0x06006C2B RID: 27691 RVA: 0x002D6504 File Offset: 0x002D4704
	public void c(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006C2C RID: 27692 RVA: 0x002D6510 File Offset: 0x002D4710
	public c9y j()
	{
		return this.f;
	}

	// Token: 0x06006C2D RID: 27693 RVA: 0x002D6518 File Offset: 0x002D4718
	public void a(c9y A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06006C2E RID: 27694 RVA: 0x002D6524 File Offset: 0x002D4724
	public dcw h()
	{
		return this.g;
	}

	// Token: 0x06006C2F RID: 27695 RVA: 0x002D652C File Offset: 0x002D472C
	public void a(dcw A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06006C30 RID: 27696 RVA: 0x002D6538 File Offset: 0x002D4738
	public double d()
	{
		return this.h;
	}

	// Token: 0x06006C31 RID: 27697 RVA: 0x002D6540 File Offset: 0x002D4740
	public void a(double A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06006C32 RID: 27698 RVA: 0x002D654C File Offset: 0x002D474C
	public bool i()
	{
		return this.b;
	}

	// Token: 0x06006C33 RID: 27699 RVA: 0x002D6554 File Offset: 0x002D4754
	public void b(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006C34 RID: 27700 RVA: 0x002D6560 File Offset: 0x002D4760
	public float f()
	{
		return this.i;
	}

	// Token: 0x06006C35 RID: 27701 RVA: 0x002D6568 File Offset: 0x002D4768
	public void a(float A_0)
	{
		this.i = A_0;
	}

	// Token: 0x06006C36 RID: 27702 RVA: 0x002D6574 File Offset: 0x002D4774
	public bool b()
	{
		return (this.c != 0 && this.k >= this.c) || (this.d != 0 && this.j >= this.d);
	}

	// Token: 0x06006C37 RID: 27703 RVA: 0x002D65B4 File Offset: 0x002D47B4
	public TimeSpan? k()
	{
		return this.l;
	}

	// Token: 0x06006C38 RID: 27704 RVA: 0x002D65BC File Offset: 0x002D47BC
	public void a(TimeSpan? A_0)
	{
		this.l = A_0;
	}

	// Token: 0x06006C39 RID: 27705 RVA: 0x002D65C8 File Offset: 0x002D47C8
	public b8b(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006C3A RID: 27706 RVA: 0x002D6608 File Offset: 0x002D4808
	public coh b(efk A_0)
	{
		bool flag = zp.a(this.a(A_0));
		coh coh = null;
		if (flag || this.e)
		{
			if (this.g.z2().Count > 0)
			{
				coh coh2 = this.a();
				if (flag)
				{
					coh = coh2;
				}
			}
			else if (flag)
			{
				bmd bmd = Enumerable.FirstOrDefault<bmd>(this.f.c());
				if (bmd != null)
				{
					coh = bmd.Item;
				}
			}
		}
		this.j++;
		if (coh != null)
		{
			this.k++;
		}
		return coh;
	}

	// Token: 0x06006C3B RID: 27707 RVA: 0x002D66A8 File Offset: 0x002D48A8
	public void r7(eds A_0)
	{
		this.a(A_0.b);
	}

	// Token: 0x06006C3C RID: 27708 RVA: 0x002D66B8 File Offset: 0x002D48B8
	public void c9(TimeSpan A_0)
	{
		this.a(A_0);
	}

	// Token: 0x06006C3D RID: 27709 RVA: 0x002D66C4 File Offset: 0x002D48C4
	public void da(TimeSpan A_0)
	{
	}

	// Token: 0x06006C3E RID: 27710 RVA: 0x002D66C8 File Offset: 0x002D48C8
	private coh a()
	{
		int num = zp.a.Next(this.g.z2().Count);
		coh result = this.g.z2()[num];
		this.g.z6(num);
		return result;
	}

	// Token: 0x06006C3F RID: 27711 RVA: 0x002D6710 File Offset: 0x002D4910
	private double a(efk A_0)
	{
		double result;
		if (A_0.Feats.Contains<b>())
		{
			result = 1.0;
		}
		else
		{
			result = d05.b(0.25, (0.5 + (double)(A_0.BaseAbilities.Dexterity - 3) / 20.0) / this.h, 0.85);
		}
		return result;
	}

	// Token: 0x06006C40 RID: 27712 RVA: 0x002D6780 File Offset: 0x002D4980
	private void a(TimeSpan A_0)
	{
		if (this.l != null && (this.j != 0 || this.k != 0))
		{
			this.m += A_0;
			while (this.m >= this.l.Value)
			{
				this.m -= this.l.Value;
				this.j = Math.Max(0, this.j - 1);
				this.k = Math.Max(0, this.k - 1);
			}
		}
	}

	// Token: 0x04002C64 RID: 11364
	private bool a;

	// Token: 0x04002C65 RID: 11365
	private bool b = true;

	// Token: 0x04002C66 RID: 11366
	private int c;

	// Token: 0x04002C67 RID: 11367
	private int d;

	// Token: 0x04002C68 RID: 11368
	private bool e;

	// Token: 0x04002C69 RID: 11369
	private c9y f = new c9y();

	// Token: 0x04002C6A RID: 11370
	private dcw g = new dcw();

	// Token: 0x04002C6B RID: 11371
	private double h = 1.0;

	// Token: 0x04002C6C RID: 11372
	private float i = 0.35f;

	// Token: 0x04002C6D RID: 11373
	private int j;

	// Token: 0x04002C6E RID: 11374
	private int k;

	// Token: 0x04002C6F RID: 11375
	private TimeSpan? l;

	// Token: 0x04002C70 RID: 11376
	private TimeSpan m;
}
