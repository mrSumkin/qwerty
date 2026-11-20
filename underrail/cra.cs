using System;
using Microsoft.Xna.Framework;

// Token: 0x0200208C RID: 8332
internal sealed class cra : bvr
{
	// Token: 0x0600C72B RID: 50987 RVA: 0x00460A54 File Offset: 0x0045EC54
	public cra(e3q A_0, a9m A_1) : base(A_0, A_1)
	{
		this.b();
		this.a();
	}

	// Token: 0x0600C72C RID: 50988 RVA: 0x00460A6C File Offset: 0x0045EC6C
	private void b()
	{
		wj wj = wj.a();
		this.d = new a4c();
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
		this.a = new eis(base.c().Feats, base.d() == a9m.a);
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
		this.a.b(new EventHandler(this.a));
		this.a.d(new EventHandler(this.b));
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
		this.b.Text = "Оставшиеся очки:";
		this.aox(this.b);
		this.c = new avo();
		if (wj.c())
		{
			this.c.a(egg.e);
			this.c.Location = new Point(320, 580);
			this.c.Size = new esj(50, this.b.Size.d);
		}
		else
		{
			this.c.a(wj.gc);
			this.c.Location = new Point(this.b.Location.X + this.b.Size.c + wj.fv.c, this.b.Location.Y);
			this.c.Size = new esj(3 * wj.fv.c, this.b.Size.d);
		}
		this.c.Color = adi.a;
		this.c.Text = "3";
		this.c.a(cab.c);
		this.aox(this.c);
	}

	// Token: 0x0600C72D RID: 50989 RVA: 0x00460EB4 File Offset: 0x0045F0B4
	private void a()
	{
		if (this.b != null)
		{
			this.b.Visible = (base.d() > a9m.a);
			this.b.Color = ((base.c().j() > 0) ? adi.a : adi.b);
		}
		if (this.c != null)
		{
			this.c.Visible = (base.d() > a9m.a);
			this.c.Text = base.c().j().ToString();
			this.c.Color = ((base.c().j() > 0) ? Color.White : adi.b);
		}
	}

	// Token: 0x0600C72E RID: 50990 RVA: 0x00460F74 File Offset: 0x0045F174
	private void b(object A_0, EventArgs A_1)
	{
		bdv bdv = A_0 as bdv;
		if (this.d != null && bdv != null)
		{
			this.d.a(bdv.FeatType);
		}
	}

	// Token: 0x0600C72F RID: 50991 RVA: 0x00460FAC File Offset: 0x0045F1AC
	private void a(object A_0, EventArgs A_1)
	{
		EventHandler eventHandler = this.e;
		if (eventHandler != null)
		{
			eventHandler(this, new EventArgs());
		}
		this.a();
	}

	// Token: 0x0600C730 RID: 50992 RVA: 0x00460FD4 File Offset: 0x0045F1D4
	private void a(object A_0, b25 A_1)
	{
		if (this.d != null)
		{
			this.d.a(null);
		}
	}

	// Token: 0x0600C731 RID: 50993 RVA: 0x00460FF0 File Offset: 0x0045F1F0
	protected override void ik(object A_0, b25 A_1)
	{
		base.ik(A_0, A_1);
		if (this.d != null)
		{
			this.d.a(null);
		}
	}

	// Token: 0x040049BA RID: 18874
	private new eis a;

	// Token: 0x040049BB RID: 18875
	private new avo b;

	// Token: 0x040049BC RID: 18876
	private new avo c;

	// Token: 0x040049BD RID: 18877
	private new a4c d;

	// Token: 0x040049BE RID: 18878
	public new EventHandler e;
}
