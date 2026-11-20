using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TimelapseVertigo.Common.Settings;

// Token: 0x0200200A RID: 8202
public sealed class ejl : cao, amj
{
	// Token: 0x170002C4 RID: 708
	// (get) Token: 0x0600C1B3 RID: 49587 RVA: 0x004321D4 File Offset: 0x004303D4
	public int Number
	{
		get
		{
			return this.d;
		}
	}

	// Token: 0x170002C5 RID: 709
	// (get) Token: 0x0600C1B4 RID: 49588 RVA: 0x004321DC File Offset: 0x004303DC
	public ecs OriginalText
	{
		get
		{
			return this.g;
		}
	}

	// Token: 0x0600C1B5 RID: 49589 RVA: 0x004321E8 File Offset: 0x004303E8
	public ejl(int A_0, string A_1, int A_2, bool A_3, object A_4 = null)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		this.h = serviceOrThrow.aq1().b().h();
		this.d = A_0;
		base.Text = A_1;
		base.Size = new esj(A_2, 10);
		this.Enabled = !A_3;
		this.j = A_4;
		this.b();
	}

	// Token: 0x0600C1B6 RID: 49590 RVA: 0x0043224C File Offset: 0x0043044C
	private void b()
	{
		this.i = 25;
		if (this.h == InterfaceElementSize2.Huge)
		{
			this.i += 20;
		}
		else if (this.h == InterfaceElementSize2.ExtraLarge)
		{
			this.i += 16;
		}
		else if (this.h == InterfaceElementSize2.Large)
		{
			this.i += 8;
		}
		ecs ecs = new ecs(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(new d22(cm3.a(this.h, false), Color.White), this.d.ToString() + ".", null)
			})
		});
		this.e = ecs.b();
		this.f = null;
		if (!string.IsNullOrEmpty(base.Text))
		{
			if (!this.Enabled)
			{
				this.g = cm3.a(this.h, base.Text, new Color?(Color.DarkGray), new Color?(Color.Gray), cm3.a(this.h, false), null);
			}
			else
			{
				this.g = cm3.a(this.h, base.Text, null, null, null, null);
			}
			ecs ecs2 = Enumerable.FirstOrDefault<ecs>(this.g.a(base.Size.c - (this.i + 10 + 6), 0));
			coh coh = this.j as coh;
			if (coh != null && ecs2.a.Count > 0 && ecs2.a[0].a.Count > 0)
			{
				ecs2.a[0].a[0].c = coh.Definition.a3();
			}
			if (ecs2 != null)
			{
				this.f = ecs2.b();
			}
		}
		else
		{
			this.f = new ecs().b();
		}
		base.Size = new esj(base.Size.c, this.f.b.d + 6);
	}

	// Token: 0x0600C1B7 RID: 49591 RVA: 0x00432484 File Offset: 0x00430684
	public override void iv(e6d A_0, cp9 A_1)
	{
		Point point = base.at();
		if (this.Enabled && (this.IsMousedOver || base.Checked || euz.DesignMode) && A_1.a != null)
		{
			Texture2D resource = A_1.a.GetResource<Texture2D>(bo1.ab, null);
			if (resource != null)
			{
				as6.a(A_1.b(), resource, point, base.Size, base.Color, null, null);
			}
		}
		if (this.e != null)
		{
			this.e.a(new Point(point.X + this.i - this.e.b.c, point.Y + 3), A_1, null, 1f);
		}
		if (this.f != null)
		{
			this.f.a(new Point(point.X + this.i + 10 + 3, point.Y + 3), A_1, null, 1f);
		}
		if (this.k != null)
		{
			this.k.a(A_0);
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x0600C1B8 RID: 49592 RVA: 0x004325C0 File Offset: 0x004307C0
	public override void ag5(e6d A_0)
	{
		if (this.k == null)
		{
			this.k = this.a();
		}
		base.ag5(A_0);
	}

	// Token: 0x0600C1B9 RID: 49593 RVA: 0x004325E0 File Offset: 0x004307E0
	protected override void ik(object A_0, b25 A_1)
	{
		base.ik(A_0, A_1);
		if (this.k != null)
		{
			this.k.b();
		}
	}

	// Token: 0x0600C1BA RID: 49594 RVA: 0x00432600 File Offset: 0x00430800
	protected override void nr(object A_0, b25 A_1)
	{
		base.nr(A_0, A_1);
		if (this.k != null)
		{
			this.k.b();
		}
	}

	// Token: 0x0600C1BB RID: 49595 RVA: 0x00432624 File Offset: 0x00430824
	private dsy a()
	{
		if (this.j is coh && base.Parent != null)
		{
			Point point = base.Parent.at();
			Rectangle value = new Rectangle(point.X, point.Y, base.Parent.Size.c, base.Parent.Size.d);
			dsy dsy = bd1.a(this, this, new Rectangle?(value));
			dsy.a(new Point?(Point.Zero));
			return dsy;
		}
		return null;
	}

	// Token: 0x0600C1BC RID: 49596 RVA: 0x004326AC File Offset: 0x004308AC
	public ecs yf(euz A_0)
	{
		coh coh = this.j as coh;
		if (coh != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			ps serviceOrThrow2 = bpo.GetServiceOrThrow<ps>();
			return cq4.a(coh, (serviceOrThrow.aqu() != null) ? serviceOrThrow.aqu().v() : null, this, true, serviceOrThrow2.ak7(), serviceOrThrow2.ak8(), null, null, false);
		}
		return null;
	}

	// Token: 0x0600C1BD RID: 49597 RVA: 0x00432714 File Offset: 0x00430914
	protected override void j5(object A_0, c1 A_1)
	{
		base.j5(A_0, A_1);
		this.b();
	}

	// Token: 0x04004622 RID: 17954
	private new const int a = 25;

	// Token: 0x04004623 RID: 17955
	private new const int b = 10;

	// Token: 0x04004624 RID: 17956
	private new const int c = 3;

	// Token: 0x04004625 RID: 17957
	private new int d;

	// Token: 0x04004626 RID: 17958
	private new dn3 e;

	// Token: 0x04004627 RID: 17959
	private new dn3 f;

	// Token: 0x04004628 RID: 17960
	private new ecs g;

	// Token: 0x04004629 RID: 17961
	private InterfaceElementSize2 h;

	// Token: 0x0400462A RID: 17962
	private int i;

	// Token: 0x0400462B RID: 17963
	private new object j;

	// Token: 0x0400462C RID: 17964
	private new dsy k;
}
