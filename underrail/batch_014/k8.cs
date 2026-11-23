using System;
using Microsoft.Xna.Framework;

// Token: 0x02002081 RID: 8321
internal sealed class k8 : bvr
{
	// Token: 0x0600C6AB RID: 50859 RVA: 0x00459470 File Offset: 0x00457670
	public k8(e3q A_0, a9m A_1) : base(A_0, A_1)
	{
		this.b();
		this.a();
	}

	// Token: 0x0600C6AC RID: 50860 RVA: 0x0045948C File Offset: 0x0045768C
	private void b()
	{
		wj wj = wj.a();
		this.d = new bcd();
		if (wj.c())
		{
			this.d.Location = new Point(620, 30);
			this.d.Size = new esj(310, 530);
		}
		else
		{
			this.d.Location = new Point(base.Size.c - wj.fv.c - (int)(3.2 * (double)wj.f3.c), wj.fv.d);
			esj a_ = new esj(base.Size.c - this.d.Location.X - wj.fv.c, base.Size.d - this.d.Location.Y - wj.fv.d * 2 - wj.f3.d);
			wj.a(ref a_.d);
			this.d.Size = a_;
		}
		this.d.j(new EventHandler<b25>(this.a));
		this.aox(this.d);
		this.a = new cea(base.c(), base.d() == a9m.a);
		if (wj.c())
		{
			this.a.Location = new Point(30, 30);
			this.a.Size = new esj(570, 530);
		}
		else
		{
			this.a.Location = new Point(wj.fv.c, wj.fv.d);
			this.a.Size = new esj(base.Size.c - this.d.Size.c - 3 * wj.fv.c, this.d.Size.d);
		}
		this.a.d(new EventHandler(this.b));
		this.a.a(new EventHandler(this.a));
		this.aox(this.a);
		this.b = new avo();
		if (wj.c())
		{
			this.b.a(egg.e);
			this.b.Location = new Point(40, 580);
		}
		else
		{
			this.b.a(wj.gc);
			this.b.Location = new Point(wj.fv.c, base.Size.d - wj.f3.d - wj.fv.d);
		}
		this.b.Color = adi.a;
		this.b.a(true);
		this.b.Text = "Remaining points";
		this.aox(this.b);
		this.c = new avo();
		if (wj.c())
		{
			this.c.a(egg.e);
			this.c.Location = new Point(320, 580);
			this.c.Size = new esj(70, this.b.Size.d);
		}
		else
		{
			this.c.a(wj.gc);
			this.c.Location = new Point(this.b.Location.X + this.b.Size.c + wj.fv.c, this.b.Location.Y);
			this.c.Size = new esj(3 * wj.fv.c, this.b.Size.d);
		}
		this.c.Color = adi.a;
		this.c.Text = "30";
		this.c.a(cab.c);
		this.aox(this.c);
	}

	// Token: 0x0600C6AD RID: 50861 RVA: 0x004598D0 File Offset: 0x00457AD0
	private void a()
	{
		if (this.b != null)
		{
			this.b.Visible = (base.d() > a9m.a);
			this.b.Color = ((base.c().f() > 0) ? adi.a : adi.b);
		}
		if (this.c != null)
		{
			this.c.Visible = (base.d() > a9m.a);
			this.c.Text = base.c().f().ToString();
			if (base.c().f() > 0)
			{
				this.c.Color = Color.White;
				return;
			}
			if (base.c().f() < 0)
			{
				this.c.Color = Color.OrangeRed;
				return;
			}
			this.c.Color = adi.b;
		}
	}

	// Token: 0x0600C6AE RID: 50862 RVA: 0x004599B8 File Offset: 0x00457BB8
	public void b(object A_0, EventArgs A_1)
	{
		base.c().bl();
		this.a();
	}

	// Token: 0x0600C6AF RID: 50863 RVA: 0x004599CC File Offset: 0x00457BCC
	private void a(object A_0, EventArgs A_1)
	{
		a53 a = A_0 as a53;
		if (this.d != null && a != null)
		{
			eoc eoc = a.j() as eoc;
			if (eoc != null)
			{
				apq apq = ac8.a(eoc.a());
				if (apq != null)
				{
					this.d.a(apq.GetType());
				}
			}
		}
	}

	// Token: 0x0600C6B0 RID: 50864 RVA: 0x00459A28 File Offset: 0x00457C28
	private void a(object A_0, b25 A_1)
	{
		if (this.d != null)
		{
			this.d.a(null);
		}
	}

	// Token: 0x0600C6B1 RID: 50865 RVA: 0x00459A44 File Offset: 0x00457C44
	protected override void ik(object A_0, b25 A_1)
	{
		base.ik(A_0, A_1);
		if (this.d != null)
		{
			this.d.a(null);
		}
	}

	// Token: 0x0400492B RID: 18731
	private new cea a;

	// Token: 0x0400492C RID: 18732
	private new avo b;

	// Token: 0x0400492D RID: 18733
	private new avo c;

	// Token: 0x0400492E RID: 18734
	private new bcd d;
}
