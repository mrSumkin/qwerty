using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TimelapseVertigo.Common.Settings;

// Token: 0x02001FEA RID: 8170
public sealed class apt : euz
{
	// Token: 0x0600BFF4 RID: 49140 RVA: 0x00428EEC File Offset: 0x004270EC
	public apt()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		wj wj = wj.a();
		if (wj.d != UiSize.Classic)
		{
			this.d = wj.a2;
			this.e = wj.f;
			this.f = wj.a3;
		}
		base.Size = new esj(this.f.Width * (serviceOrThrow.aq7() + 1) + this.d * serviceOrThrow.aq7(), this.f.Height);
	}

	// Token: 0x0600BFF5 RID: 49141 RVA: 0x00428F9C File Offset: 0x0042719C
	public void a(bool A_0 = true)
	{
		if (A_0)
		{
			e4z.a();
		}
		this.g = 1.0;
		this.h = (double)apt.b;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		int num = serviceOrThrow.aq5();
		serviceOrThrow.aq6(num + 1);
	}

	// Token: 0x0600BFF6 RID: 49142 RVA: 0x00428FE4 File Offset: 0x004271E4
	public void b(bool A_0 = true)
	{
		if (A_0)
		{
			e4z.a();
		}
		this.g = 1.0;
		this.h = (double)apt.b;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		int num = serviceOrThrow.aq5();
		serviceOrThrow.aq6(num - 1);
	}

	// Token: 0x0600BFF7 RID: 49143 RVA: 0x0042902C File Offset: 0x0042722C
	public override void iv(e6d A_0, cp9 A_1)
	{
		base.iv(A_0, A_1);
		if (this.g > 0.0)
		{
			Texture2D resource = A_1.a.GetResource<Texture2D>(this.e, null);
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			for (int i = 0; i <= serviceOrThrow.aq7(); i++)
			{
				Vector2 value = base.at().b();
				Color value2 = (serviceOrThrow.aq5() >= i) ? adi.c : adi.b;
				A_1.b().w7(resource, value + (float)i * new Vector2((float)(this.f.Width + this.d), 0f), new Rectangle?(this.f), value2 * (float)this.g * 0.75f, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
			}
		}
	}

	// Token: 0x0600BFF8 RID: 49144 RVA: 0x00429128 File Offset: 0x00427328
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
		double totalMilliseconds = A_0.a().ElapsedGameTime.TotalMilliseconds;
		if (this.h > 0.0)
		{
			this.h -= totalMilliseconds;
			return;
		}
		if (this.g > 0.0)
		{
			this.g = Math.Max(0.0, this.g - totalMilliseconds * apt.c);
		}
	}

	// Token: 0x0600BFF9 RID: 49145 RVA: 0x004291AC File Offset: 0x004273AC
	public override bool iz(MouseState A_0)
	{
		return false;
	}

	// Token: 0x0400454F RID: 17743
	private new const int a = 200;

	// Token: 0x04004550 RID: 17744
	private new static readonly int b = 1500;

	// Token: 0x04004551 RID: 17745
	private new static readonly double c = 0.001;

	// Token: 0x04004552 RID: 17746
	private new int d = 5;

	// Token: 0x04004553 RID: 17747
	private new string e = bo1.ad;

	// Token: 0x04004554 RID: 17748
	private new Rectangle f = new Rectangle(0, 218, 19, 30);

	// Token: 0x04004555 RID: 17749
	private new double g;

	// Token: 0x04004556 RID: 17750
	private double h;
}
