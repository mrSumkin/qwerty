using System;
using System.ComponentModel;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200201B RID: 8219
public class zt : cao
{
	// Token: 0x170002DB RID: 731
	// (get) Token: 0x0600C27B RID: 49787 RVA: 0x004358D0 File Offset: 0x00433AD0
	// (set) Token: 0x0600C27C RID: 49788 RVA: 0x004358D8 File Offset: 0x00433AD8
	[Category("Appearance")]
	public string Font
	{
		get
		{
			return this.i;
		}
		set
		{
			if (this.i != value)
			{
				this.i = value;
				this.wt();
			}
		}
	}

	// Token: 0x170002DC RID: 732
	// (get) Token: 0x0600C27D RID: 49789 RVA: 0x004358F8 File Offset: 0x00433AF8
	// (set) Token: 0x0600C27E RID: 49790 RVA: 0x00435908 File Offset: 0x00433B08
	[Category("Layout")]
	public cab HorizontalAlignment
	{
		get
		{
			return this.j.f();
		}
		set
		{
			this.j.a(value);
		}
	}

	// Token: 0x170002DD RID: 733
	// (get) Token: 0x0600C27F RID: 49791 RVA: 0x00435918 File Offset: 0x00433B18
	// (set) Token: 0x0600C280 RID: 49792 RVA: 0x00435928 File Offset: 0x00433B28
	[Category("Layout")]
	public ad4 VerticalAlignment
	{
		get
		{
			return this.j.e();
		}
		set
		{
			this.j.a(value);
		}
	}

	// Token: 0x170002DE RID: 734
	// (get) Token: 0x0600C281 RID: 49793 RVA: 0x00435938 File Offset: 0x00433B38
	// (set) Token: 0x0600C282 RID: 49794 RVA: 0x00435940 File Offset: 0x00433B40
	[Category("Layout")]
	public Point TextLabelOffset
	{
		get
		{
			return this.g;
		}
		set
		{
			this.g = value;
			this.wt();
		}
	}

	// Token: 0x170002DF RID: 735
	// (get) Token: 0x0600C283 RID: 49795 RVA: 0x00435950 File Offset: 0x00433B50
	public virtual bool VisuallyEnabled
	{
		get
		{
			return this.Enabled;
		}
	}

	// Token: 0x0600C284 RID: 49796 RVA: 0x0043595C File Offset: 0x00433B5C
	public zt()
	{
		this.a();
	}

	// Token: 0x0600C285 RID: 49797 RVA: 0x004359B8 File Offset: 0x00433BB8
	public override void iv(e6d A_0, cp9 A_1)
	{
		if (this.VisuallyEnabled)
		{
			if (this.IsMousedOver || base.Checked || euz.DesignMode)
			{
				this.j.Color = this.b;
			}
			else
			{
				this.j.Color = this.a;
			}
			if ((this.IsMousedOver || base.Checked || euz.DesignMode) && !string.IsNullOrEmpty(this.d) && A_1.a != null)
			{
				Texture2D resource = A_1.a.GetResource<Texture2D>(this.d, null);
				if (resource != null)
				{
					Point a_ = base.at();
					as6.a(A_1.b(), resource, a_, base.Size, base.Color, new Point?(this.e), this.f);
				}
			}
		}
		else
		{
			this.j.Color = this.c;
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x0600C286 RID: 49798 RVA: 0x00435AC4 File Offset: 0x00433CC4
	protected override void j5(object A_0, c1 A_1)
	{
		base.j5(A_0, A_1);
		this.j.Text = base.Text;
	}

	// Token: 0x0600C287 RID: 49799 RVA: 0x00435AE0 File Offset: 0x00433CE0
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.wt();
	}

	// Token: 0x0600C288 RID: 49800 RVA: 0x00435AF4 File Offset: 0x00433CF4
	protected virtual void wt()
	{
		if (this.j != null)
		{
			this.j.a(this.i);
			this.j.Location = this.g;
			this.j.Size = base.Size;
		}
	}

	// Token: 0x0600C289 RID: 49801 RVA: 0x00435B40 File Offset: 0x00433D40
	private void a()
	{
		this.j = new avo();
		this.j.IsPrivateComponent = true;
		this.j.a(false);
		this.aox(this.j);
	}

	// Token: 0x04004668 RID: 18024
	public new Color a = Color.White;

	// Token: 0x04004669 RID: 18025
	public new Color b = Color.White;

	// Token: 0x0400466A RID: 18026
	public new Color c = Color.DarkGray;

	// Token: 0x0400466B RID: 18027
	public new string d = bo1.b;

	// Token: 0x0400466C RID: 18028
	public new Point e;

	// Token: 0x0400466D RID: 18029
	public new esj? f;

	// Token: 0x0400466E RID: 18030
	private new Point g;

	// Token: 0x0400466F RID: 18031
	public Color h = Color.White;

	// Token: 0x04004670 RID: 18032
	private string i = egg.b;

	// Token: 0x04004671 RID: 18033
	private new avo j;
}
