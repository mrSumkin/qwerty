using System;
using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x02002038 RID: 8248
public class cj5 : ec9
{
	// Token: 0x0600C368 RID: 50024 RVA: 0x0043A4F0 File Offset: 0x004386F0
	public new int e()
	{
		return this.a;
	}

	// Token: 0x0600C369 RID: 50025 RVA: 0x0043A4F8 File Offset: 0x004386F8
	public void b(int A_0)
	{
		if (this.a != A_0)
		{
			this.a = A_0;
			this.a();
		}
	}

	// Token: 0x0600C36A RID: 50026 RVA: 0x0043A514 File Offset: 0x00438714
	public int h()
	{
		return this.b;
	}

	// Token: 0x0600C36B RID: 50027 RVA: 0x0043A51C File Offset: 0x0043871C
	public new void e(int A_0)
	{
		if (this.b != A_0)
		{
			this.b = A_0;
			this.a();
		}
	}

	// Token: 0x0600C36C RID: 50028 RVA: 0x0043A538 File Offset: 0x00438738
	public new int c()
	{
		return this.c;
	}

	// Token: 0x0600C36D RID: 50029 RVA: 0x0043A540 File Offset: 0x00438740
	public new void c(int A_0)
	{
		if (this.c != A_0)
		{
			this.c = A_0;
			this.a();
		}
	}

	// Token: 0x0600C36E RID: 50030 RVA: 0x0043A55C File Offset: 0x0043875C
	public IList i()
	{
		return this.d;
	}

	// Token: 0x0600C36F RID: 50031 RVA: 0x0043A564 File Offset: 0x00438764
	public new int d()
	{
		return this.h;
	}

	// Token: 0x0600C370 RID: 50032 RVA: 0x0043A56C File Offset: 0x0043876C
	public void a(int A_0)
	{
		if (this.h != A_0)
		{
			this.h = A_0;
			this.a();
		}
	}

	// Token: 0x0600C371 RID: 50033 RVA: 0x0043A588 File Offset: 0x00438788
	public int f()
	{
		return this.g.l();
	}

	// Token: 0x0600C372 RID: 50034 RVA: 0x0043A598 File Offset: 0x00438798
	public new void d(int A_0)
	{
		this.g.e(A_0);
	}

	// Token: 0x0600C373 RID: 50035 RVA: 0x0043A5A8 File Offset: 0x004387A8
	public cj5(IList A_0, ctv A_1) : this(A_0, A_1, null)
	{
	}

	// Token: 0x0600C374 RID: 50036 RVA: 0x0043A5B4 File Offset: 0x004387B4
	public cj5(IList A_0, ctv A_1, Type A_2)
	{
		czh.a(A_0, "items");
		czh.a(A_1, "factory");
		this.f = A_2;
		this.d = A_0;
		this.e = A_1;
		this.b();
	}

	// Token: 0x0600C375 RID: 50037 RVA: 0x0043A618 File Offset: 0x00438818
	public void g()
	{
		this.a();
	}

	// Token: 0x0600C376 RID: 50038 RVA: 0x0043A620 File Offset: 0x00438820
	private void b()
	{
		this.c = bo1.r;
		if (this.f != null)
		{
			try
			{
				this.g = (Activator.CreateInstance(this.f) as cs9);
			}
			catch
			{
			}
		}
		if (this.g == null)
		{
			bdl bdl = new bdl();
			e4z.c(bdl.d());
			e4z.c(bdl.e());
			e4z.d(bdl.h());
			this.g = bdl;
		}
		this.g.Gravity = axy.c;
		this.g.c(1);
		this.g.d(5);
		this.g.e(0);
		this.g.f(new EventHandler<c1>(this.a));
		this.g.IsPrivateComponent = true;
		this.aox(this.g);
		base.Size = new esj(200, 200);
	}

	// Token: 0x0600C377 RID: 50039 RVA: 0x0043A728 File Offset: 0x00438928
	private void a()
	{
		wj wj = wj.a();
		int num = (base.Size.d - 2 * this.a + this.b) / (this.c + this.b);
		if (this.d.Count > num)
		{
			this.g.Visible = true;
			this.g.a(this.d.Count - num);
			this.g.Location = new Point(base.Size.c - this.h, 0);
			if (wj.c())
			{
				this.g.Size = new esj(this.h, base.Size.d - 1);
			}
			else
			{
				this.g.Size = new esj(this.h, base.Size.d);
			}
			this.g.b(0);
			if (this.g.l() > this.g.k())
			{
				this.g.e(this.g.k());
			}
		}
		else
		{
			this.g.e(0);
			this.g.Visible = false;
		}
		foreach (euz a_ in Enumerable.ToList<euz>(Enumerable.Where<euz>(base.Controls, new Func<euz, bool>(cj5.a.a.a))))
		{
			this.g(a_);
		}
		int num2 = 0;
		while (num2 < num && num2 + this.g.l() < this.d.Count)
		{
			euz euz = this.e.r5(this.d[num2 + this.g.l()]);
			if (euz != null)
			{
				euz.Location = new Point(this.a, this.a + num2 * (this.c + this.b));
				euz.Size = new esj(base.Size.c - 2 * this.a - (this.g.Visible ? this.h : 0), this.c);
				euz.v(new EventHandler<b25>(this.a));
				euz.t(new EventHandler<b25>(this.a));
				this.aox(euz);
			}
			num2++;
		}
	}

	// Token: 0x0600C378 RID: 50040 RVA: 0x0043A9E0 File Offset: 0x00438BE0
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.a();
	}

	// Token: 0x0600C379 RID: 50041 RVA: 0x0043A9F0 File Offset: 0x00438BF0
	private void a(object A_0, c1 A_1)
	{
		this.a();
	}

	// Token: 0x0600C37A RID: 50042 RVA: 0x0043A9F8 File Offset: 0x00438BF8
	protected override void it(object A_0, b25 A_1)
	{
		base.it(A_0, A_1);
		cs9 cs = this.g;
		cs.e(cs.l() - this.g.m() * Math.Sign(A_1.c()));
		this.a();
	}

	// Token: 0x0600C37B RID: 50043 RVA: 0x0043AA3C File Offset: 0x00438C3C
	private void a(object A_0, b25 A_1)
	{
		cs9 cs = this.g;
		cs.e(cs.l() - this.g.m() * Math.Sign(A_1.c()));
		this.a();
	}

	// Token: 0x040046F4 RID: 18164
	private new int a = 10;

	// Token: 0x040046F5 RID: 18165
	private new int b = 10;

	// Token: 0x040046F6 RID: 18166
	private new int c = 50;

	// Token: 0x040046F7 RID: 18167
	private new IList d;

	// Token: 0x040046F8 RID: 18168
	private new ctv e;

	// Token: 0x040046F9 RID: 18169
	private new Type f;

	// Token: 0x040046FA RID: 18170
	private new cs9 g;

	// Token: 0x040046FB RID: 18171
	private int h = 26;

	// Token: 0x02002039 RID: 8249
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600C37E RID: 50046 RVA: 0x0043AA8C File Offset: 0x00438C8C
		internal bool a(euz A_0)
		{
			return !A_0.IsPrivateComponent;
		}

		// Token: 0x040046FC RID: 18172
		public static readonly cj5.a a = new cj5.a();

		// Token: 0x040046FD RID: 18173
		public static Func<euz, bool> b;
	}
}
