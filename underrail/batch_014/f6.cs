using System;
using Microsoft.Xna.Framework;

// Token: 0x02000775 RID: 1909
public class f6 : a2f
{
	// Token: 0x06003063 RID: 12387 RVA: 0x00128C14 File Offset: 0x00126E14
	public override void f3(cp9 A_0, bkx A_1)
	{
		if (this.d != null)
		{
			this.d.avv(A_0, this, A_1);
			Vector2 a_ = default(Vector2);
			float val = 0f;
			bym n = this.n;
			float? num;
			if (n == null)
			{
				num = null;
			}
			else
			{
				b0b b0b = n.b;
				num = ((b0b != null) ? new float?(b0b.ac) : null);
			}
			float? num2 = num;
			a_.X = Math.Max(val, num2.GetValueOrDefault(1f));
			float val2 = 0f;
			bym n2 = this.n;
			float? num3;
			if (n2 == null)
			{
				num3 = null;
			}
			else
			{
				b0b b0b2 = n2.b;
				num3 = ((b0b2 != null) ? new float?(b0b2.ad) : null);
			}
			num2 = num3;
			a_.Y = Math.Max(val2, num2.GetValueOrDefault(1f));
			bym n3 = this.n;
			byte a_2 = (n3 != null && n3.f) ? 2 : 1;
			if (this.a)
			{
				a_2 = 0;
			}
			this.d.avw(A_0, this.m, this.c, this.e.Value, this.i, Vector2.Zero, this.k, 0f, a_2, a_);
		}
	}

	// Token: 0x06003064 RID: 12388 RVA: 0x00128D6C File Offset: 0x00126F6C
	public override void f4()
	{
		if (!this.b)
		{
			cnk service = bpo.GetService<cnk>();
			float num;
			if (service != null)
			{
				num = service.aq1().b().i();
			}
			else
			{
				num = 0.4f;
			}
			if (this.h != null)
			{
				this.h = new float?(this.h.Value * num);
			}
			else
			{
				this.h = new float?(num);
			}
			this.e = new Color?(this.e.Value * this.h.Value);
		}
	}

	// Token: 0x06003065 RID: 12389 RVA: 0x00128E0C File Offset: 0x0012700C
	public override a2f f5()
	{
		f6 f = new f6();
		this.f6(f);
		return f;
	}

	// Token: 0x06003066 RID: 12390 RVA: 0x00128E28 File Offset: 0x00127028
	protected override void f6(a2f A_0)
	{
		base.f6(A_0);
		f6 f = (f6)A_0;
		f.a = this.a;
		f.b = this.b;
	}

	// Token: 0x04001A9F RID: 6815
	public new bool a;

	// Token: 0x04001AA0 RID: 6816
	public new bool b;
}
