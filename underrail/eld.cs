using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02001FEB RID: 8171
public sealed class eld : euz
{
	// Token: 0x0600BFFB RID: 49147 RVA: 0x004291CC File Offset: 0x004273CC
	public string c()
	{
		return this.a;
	}

	// Token: 0x0600BFFC RID: 49148 RVA: 0x004291D4 File Offset: 0x004273D4
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600BFFD RID: 49149 RVA: 0x004291E0 File Offset: 0x004273E0
	public double b()
	{
		return this.b;
	}

	// Token: 0x0600BFFE RID: 49150 RVA: 0x004291E8 File Offset: 0x004273E8
	public void a(double A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600BFFF RID: 49151 RVA: 0x004291F4 File Offset: 0x004273F4
	public double d()
	{
		return this.c;
	}

	// Token: 0x0600C000 RID: 49152 RVA: 0x004291FC File Offset: 0x004273FC
	public void b(double A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600C001 RID: 49153 RVA: 0x00429208 File Offset: 0x00427408
	public eld()
	{
		this.a();
	}

	// Token: 0x0600C002 RID: 49154 RVA: 0x00429240 File Offset: 0x00427440
	public void a()
	{
		if (!string.IsNullOrEmpty(this.a))
		{
			cne service = bpo.GetService<cne>();
			if (service != null)
			{
				Texture2D resource = service.GetResource<Texture2D>(this.a, null);
				if (resource != null)
				{
					base.Size = new esj(resource.Width, resource.Height / 2);
				}
			}
		}
	}

	// Token: 0x0600C003 RID: 49155 RVA: 0x004292A0 File Offset: 0x004274A0
	public override void iv(e6d A_0, cp9 A_1)
	{
		this.b += A_0.a().ElapsedGameTime.TotalMilliseconds / 1000.0;
		if (this.b >= 1.0)
		{
			this.b -= 1.0;
		}
		if (!string.IsNullOrEmpty(this.a))
		{
			cne service = bpo.GetService<cne>();
			if (service != null)
			{
				Texture2D resource = service.GetResource<Texture2D>(this.a, null);
				if (resource != null)
				{
					Vector2 vector = base.at().b();
					A_1.b().w5(resource, vector, new Rectangle?(new Rectangle(0, 0, resource.Width, resource.Height / 2)), Color.White);
					int num = (int)((double)resource.Width * this.d());
					int num2 = (int)((double)resource.Width * this.b);
					int num3 = Math.Min(num, resource.Width - num2);
					if (num3 > 0)
					{
						A_1.b().w5(resource, new Vector2(vector.X + (float)num2, vector.Y), new Rectangle?(new Rectangle(num2, resource.Height / 2, num3, resource.Height / 2)), Color.White);
					}
					int num4 = num2 + num - resource.Width;
					if (num4 > 0)
					{
						A_1.b().w5(resource, vector, new Rectangle?(new Rectangle(0, resource.Height / 2, num4, resource.Height / 2)), Color.White);
					}
				}
			}
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x0600C004 RID: 49156 RVA: 0x00429444 File Offset: 0x00427644
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
	}

	// Token: 0x04004557 RID: 17751
	private new string a = bo1.e;

	// Token: 0x04004558 RID: 17752
	private new double b = 0.4;

	// Token: 0x04004559 RID: 17753
	private new double c = 0.2;
}
