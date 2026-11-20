using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02002005 RID: 8197
public sealed class afg : cao
{
	// Token: 0x170002C2 RID: 706
	// (get) Token: 0x0600C17D RID: 49533 RVA: 0x00430EE8 File Offset: 0x0042F0E8
	// (set) Token: 0x0600C17E RID: 49534 RVA: 0x00430EF8 File Offset: 0x0042F0F8
	public cab HorizontalTextAlignment
	{
		get
		{
			return this.f.f();
		}
		set
		{
			this.f.a(value);
		}
	}

	// Token: 0x170002C3 RID: 707
	// (get) Token: 0x0600C17F RID: 49535 RVA: 0x00430F08 File Offset: 0x0042F108
	// (set) Token: 0x0600C180 RID: 49536 RVA: 0x00430F18 File Offset: 0x0042F118
	public ad4 VerticalTextAlignment
	{
		get
		{
			return this.f.e();
		}
		set
		{
			this.f.a(value);
		}
	}

	// Token: 0x0600C181 RID: 49537 RVA: 0x00430F28 File Offset: 0x0042F128
	public afg()
	{
		wj wj = wj.a();
		if (!wj.c())
		{
			this.a = wj.f;
			this.b = wj.g0;
			this.c = wj.g1;
			this.d = wj.gm;
			this.e = new Point(0, wj.gn);
		}
		this.CheckOnClick = true;
		this.f = new avo();
		this.f.IsPrivateComponent = true;
		this.f.a(this.d);
		this.f.a(cab.a);
		this.f.a(ad4.b);
		this.f.Color = adi.a;
		this.aox(this.f);
		this.a();
	}

	// Token: 0x0600C182 RID: 49538 RVA: 0x0043102C File Offset: 0x0042F22C
	public override void iv(e6d A_0, cp9 A_1)
	{
		int y;
		if (base.Checked || this.IsMousedOver)
		{
			y = 1;
			this.f.Color = Color.Black;
		}
		else
		{
			y = 0;
			this.f.Color = adi.a;
		}
		if (A_1.a != null)
		{
			Texture2D resource = A_1.a.GetResource<Texture2D>(this.a, null);
			Point point = base.at();
			if (resource != null)
			{
				c4o.b(A_1, resource, this.c, new Point(0, y), new Rectangle(point.X, point.Y, base.Size.c, base.Size.d), Color.White, true, new Point?(this.b));
			}
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x0600C183 RID: 49539 RVA: 0x00431100 File Offset: 0x0042F300
	private void a()
	{
		if (this.f != null)
		{
			this.f.Location = this.e;
			this.f.Size = new esj(base.Size.c, base.Size.d);
			this.f.Text = base.Text;
		}
	}

	// Token: 0x0600C184 RID: 49540 RVA: 0x00431160 File Offset: 0x0042F360
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.a();
	}

	// Token: 0x0600C185 RID: 49541 RVA: 0x00431170 File Offset: 0x0042F370
	protected override void j5(object A_0, c1 A_1)
	{
		base.j5(A_0, A_1);
		this.a();
	}

	// Token: 0x04004602 RID: 17922
	private new string a = bo1.a;

	// Token: 0x04004603 RID: 17923
	private new Point b;

	// Token: 0x04004604 RID: 17924
	private new esj c = new esj(43, 18);

	// Token: 0x04004605 RID: 17925
	private new string d = egg.b;

	// Token: 0x04004606 RID: 17926
	public new Point e = new Point(0, 8);

	// Token: 0x04004607 RID: 17927
	private new avo f;
}
