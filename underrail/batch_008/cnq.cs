using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200017C RID: 380
[dmo(DisplayName = "Classic Text Box", Description = "A classic text input control.", InitialWidth = 120, InitialHeight = 30)]
public class cnq : t3
{
	// Token: 0x06000A17 RID: 2583 RVA: 0x000296F4 File Offset: 0x000278F4
	public string b()
	{
		return this.f;
	}

	// Token: 0x06000A18 RID: 2584 RVA: 0x000296FC File Offset: 0x000278FC
	public void a(string A_0)
	{
		if (this.f != A_0)
		{
			this.e = true;
		}
		this.f = A_0;
		if (this.f != null)
		{
			this.g = Path.Combine(d7i.ai, this.f);
			return;
		}
		this.g = null;
	}

	// Token: 0x06000A19 RID: 2585 RVA: 0x00029754 File Offset: 0x00027954
	public cnq() : this("ClassicTextBox")
	{
	}

	// Token: 0x06000A1A RID: 2586 RVA: 0x00029764 File Offset: 0x00027964
	public cnq(string A_0)
	{
		this.c = new avo();
		this.c.a(false);
		this.c.a(cab.a);
		this.c.IsPrivateComponent = true;
		this.a(A_0);
		this.aox(this.c);
	}

	// Token: 0x06000A1B RID: 2587 RVA: 0x000297C4 File Offset: 0x000279C4
	protected override void j5(object A_0, c1 A_1)
	{
		base.j5(A_0, A_1);
		this.c.Text = (A_1.a() as string);
	}

	// Token: 0x06000A1C RID: 2588 RVA: 0x000297E4 File Offset: 0x000279E4
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.c.Size = base.Size;
	}

	// Token: 0x06000A1D RID: 2589 RVA: 0x00029800 File Offset: 0x00027A00
	public override void iv(e6d A_0, cp9 A_1)
	{
		Point point = base.at();
		string a_ = this.c.Text;
		try
		{
			cne cne = cnq.a();
			if (cne != null && this.g != null)
			{
				Texture2D resource = cne.GetResource<Texture2D>(this.g, null);
				esj a_2 = this.a(resource);
				c4o.b(A_1, resource, a_2, Point.Zero, new Rectangle(point.X, point.Y, base.Size.c, base.Size.d), Color.White, true, null);
			}
		}
		catch
		{
		}
		if (base.IsFocus)
		{
			if (this.c.Text == null)
			{
				this.c.Text = "|";
			}
			else
			{
				this.c.Text = this.c.Text.Insert(base.s(), "|");
			}
		}
		base.iv(A_0, A_1);
		this.c.Text = a_;
	}

	// Token: 0x06000A1E RID: 2590 RVA: 0x00029924 File Offset: 0x00027B24
	private esj a(Texture2D A_0)
	{
		if (this.e && A_0 != null)
		{
			this.d = c4o.a(A_0, 3, 3);
		}
		return this.d;
	}

	// Token: 0x06000A1F RID: 2591 RVA: 0x0002994C File Offset: 0x00027B4C
	private new static cne a()
	{
		return bpo.GetService<cne>();
	}

	// Token: 0x0400065C RID: 1628
	private new const int a = 3;

	// Token: 0x0400065D RID: 1629
	private new const int b = 3;

	// Token: 0x0400065E RID: 1630
	private new avo c;

	// Token: 0x0400065F RID: 1631
	private new esj d;

	// Token: 0x04000660 RID: 1632
	private new bool e = true;

	// Token: 0x04000661 RID: 1633
	private new string f;

	// Token: 0x04000662 RID: 1634
	private new string g;
}
