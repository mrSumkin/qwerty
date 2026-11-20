using System;
using Microsoft.Xna.Framework;

// Token: 0x02002091 RID: 8337
internal sealed class dh5 : bvr
{
	// Token: 0x0600C794 RID: 51092 RVA: 0x00464B68 File Offset: 0x00462D68
	public dh5(e3q A_0, a9m A_1) : base(A_0, A_1)
	{
		this.b();
		this.a();
	}

	// Token: 0x0600C795 RID: 51093 RVA: 0x00464B80 File Offset: 0x00462D80
	public void b(object A_0, EventArgs A_1)
	{
		this.a();
	}

	// Token: 0x0600C796 RID: 51094 RVA: 0x00464B8C File Offset: 0x00462D8C
	private void a(object A_0, EventArgs A_1)
	{
		b0a b0a = A_0 as b0a;
		if (this.d != null && b0a != null && b0a.j() is csn)
		{
			this.d.a(b0a.j().GetType());
		}
	}

	// Token: 0x0600C797 RID: 51095 RVA: 0x00464BD8 File Offset: 0x00462DD8
	private void a(object A_0, b25 A_1)
	{
		if (this.d != null)
		{
			this.d.a(null);
		}
	}

	// Token: 0x0600C798 RID: 51096 RVA: 0x00464BF4 File Offset: 0x00462DF4
	protected override void ik(object A_0, b25 A_1)
	{
		base.ik(A_0, A_1);
		if (this.d != null)
		{
			this.d.a(null);
		}
	}

	// Token: 0x0600C799 RID: 51097 RVA: 0x00464C18 File Offset: 0x00462E18
	private void b()
	{
		wj wj = wj.a();
		this.a = new bda(base.c().Skills, base.d() == a9m.a);
		this.d = new dsc();
		if (wj.c())
		{
			this.d.Location = new Point(520, 30);
			this.d.Size = new esj(410, 530);
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
		if (wj.c())
		{
			this.a.Location = new Point(30, 30);
			this.a.Size = new esj(470, 530);
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
		this.b.Color = adi.a;
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
		this.b.a(true);
		this.b.Text = dh9.c("CharScreen_RemainingPoints");
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

	// Token: 0x0600C79A RID: 51098 RVA: 0x00465068 File Offset: 0x00463268
	private void a()
	{
		if (this.b != null)
		{
			this.b.Visible = (base.d() > a9m.a);
			this.b.Color = ((base.c().h() > 0) ? adi.a : adi.b);
		}
		if (this.c != null)
		{
			this.c.Visible = (base.d() > a9m.a);
			this.c.Text = base.c().h().ToString();
			if (base.c().h() > 0)
			{
				this.c.Color = Color.White;
				return;
			}
			if (base.c().h() < 0)
			{
				this.c.Color = Color.OrangeRed;
				return;
			}
			this.c.Color = adi.b;
		}
	}

	// Token: 0x040049F8 RID: 18936
	private new bda a;

	// Token: 0x040049F9 RID: 18937
	private new avo b;

	// Token: 0x040049FA RID: 18938
	private new avo c;

	// Token: 0x040049FB RID: 18939
	private new dsc d;
}
