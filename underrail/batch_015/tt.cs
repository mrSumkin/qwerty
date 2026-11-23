using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02002010 RID: 8208
public sealed class tt : ant, ta
{
	// Token: 0x0600C1F8 RID: 49656 RVA: 0x004332E4 File Offset: 0x004314E4
	protected override bool ln()
	{
		return base.c().Offense.au() == this.a;
	}

	// Token: 0x0600C1F9 RID: 49657 RVA: 0x00433300 File Offset: 0x00431500
	protected override coh lo()
	{
		return base.c().Offense.b(this.a);
	}

	// Token: 0x0600C1FA RID: 49658 RVA: 0x00433318 File Offset: 0x00431518
	coh ta.a()
	{
		return base.c().Offense.b(this.a);
	}

	// Token: 0x0600C1FB RID: 49659 RVA: 0x00433330 File Offset: 0x00431530
	bool ta.b()
	{
		return true;
	}

	// Token: 0x0600C1FC RID: 49660 RVA: 0x00433334 File Offset: 0x00431534
	protected override bool lp()
	{
		return !base.c().IsInControl;
	}

	// Token: 0x0600C1FD RID: 49661 RVA: 0x00433344 File Offset: 0x00431544
	public tt(efk A_0, WeaponKey A_1) : base(A_0)
	{
		this.a = A_1;
	}

	// Token: 0x0600C1FE RID: 49662 RVA: 0x00433360 File Offset: 0x00431560
	public tt(efk A_0, WeaponKey A_1, esj A_2, esj A_3) : base(A_0, A_2, A_3)
	{
		this.a = A_1;
	}

	// Token: 0x0600C1FF RID: 49663 RVA: 0x00433380 File Offset: 0x00431580
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
		if (base.c().Offense.au() == this.a)
		{
			base.Text = base.c().Offense.av().ToString();
			return;
		}
		base.Text = null;
	}

	// Token: 0x0600C200 RID: 49664 RVA: 0x004333D8 File Offset: 0x004315D8
	public override void iv(e6d A_0, cp9 A_1)
	{
		base.iv(A_0, A_1);
		SpriteFont resource = A_1.a.GetResource<SpriteFont>(this.b, null);
		if (resource != null && !string.IsNullOrEmpty(base.Text))
		{
			int num = (int)Math.Max(5f, resource.MeasureString("0").X) - 2;
			Vector2 vector = base.at().b();
			Vector2 vector2 = resource.MeasureString(base.Text);
			Vector2 a_ = new Vector2(vector.X + ((float)base.Size.c - vector2.X - (float)num), vector.Y + ((float)base.Size.d - vector2.Y - (float)num) + (float)egg.b(this.b));
			A_1.b().xb(resource, base.Text, a_, Color.White);
		}
	}

	// Token: 0x0600C201 RID: 49665 RVA: 0x004334C0 File Offset: 0x004316C0
	protected override void lq(object A_0, b25 A_1)
	{
		base.lq(A_0, A_1);
		if (d4f.b())
		{
			if (A_1.b() == eoo.b)
			{
				ta ta = A_0 as ta;
				if (ta != null && ta.zf())
				{
					d4f.b(ta);
					return;
				}
			}
			else if (A_1.b() == eoo.d)
			{
				d4f.a();
				return;
			}
		}
		else if (A_1.b() == eoo.b)
		{
			e4z.e();
			try
			{
				if (base.c().IsInControl)
				{
					base.c().Offense.a(this.a);
				}
			}
			catch
			{
			}
		}
	}

	// Token: 0x04004637 RID: 17975
	private new WeaponKey a;

	// Token: 0x04004638 RID: 17976
	public new string b = egg.n;
}
