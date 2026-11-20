using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02002008 RID: 8200
public sealed class e4c : cao
{
	// Token: 0x0600C19B RID: 49563 RVA: 0x004314A8 File Offset: 0x0042F6A8
	public Point c()
	{
		return this.d;
	}

	// Token: 0x0600C19C RID: 49564 RVA: 0x004314B0 File Offset: 0x0042F6B0
	public void a(Point A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600C19D RID: 49565 RVA: 0x004314BC File Offset: 0x0042F6BC
	public e4c()
	{
		this.b();
	}

	// Token: 0x0600C19E RID: 49566 RVA: 0x004314DC File Offset: 0x0042F6DC
	public override void iv(e6d A_0, cp9 A_1)
	{
		int y = 0;
		Color black;
		if (base.Checked || this.IsMousedOver)
		{
			y = 1;
			black = Color.Black;
		}
		else
		{
			black = adi.a;
		}
		if (A_1.a != null)
		{
			Texture2D resource = A_1.a.GetResource<Texture2D>(bo1.an, null);
			Point point = base.at();
			if (resource != null)
			{
				c4o.b(A_1, resource, new esj(43, 10), new Point(0, y), new Rectangle(point.X, point.Y, base.Size.c, base.Size.d), Color.White, true, null);
			}
		}
		this.c.Color = black;
		base.iv(A_0, A_1);
	}

	// Token: 0x0600C19F RID: 49567 RVA: 0x004315AC File Offset: 0x0042F7AC
	private void b()
	{
		this.c = new avo();
		this.c.IsPrivateComponent = true;
		this.c.a(egg.a);
		this.c.a(cab.a);
		this.c.a(ad4.b);
		this.aox(this.c);
		this.a();
	}

	// Token: 0x0600C1A0 RID: 49568 RVA: 0x0043160C File Offset: 0x0042F80C
	private void a()
	{
		if (this.c != null)
		{
			this.c.Text = base.Text;
			this.c.Location = this.d;
			this.c.Size = new esj(base.Size.c - this.d.X, base.Size.d);
		}
	}

	// Token: 0x0600C1A1 RID: 49569 RVA: 0x00431678 File Offset: 0x0042F878
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.a();
	}

	// Token: 0x0600C1A2 RID: 49570 RVA: 0x00431688 File Offset: 0x0042F888
	protected override void j5(object A_0, c1 A_1)
	{
		base.j5(A_0, A_1);
		this.a();
	}

	// Token: 0x0400460F RID: 17935
	private new const int a = 43;

	// Token: 0x04004610 RID: 17936
	private new const int b = 10;

	// Token: 0x04004611 RID: 17937
	private new avo c;

	// Token: 0x04004612 RID: 17938
	private new Point d = new Point(10, 5);
}
