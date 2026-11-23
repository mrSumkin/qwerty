using System;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02002007 RID: 8199
public sealed class a8x : cao
{
	// Token: 0x0600C18E RID: 49550 RVA: 0x0043124C File Offset: 0x0042F44C
	public int e()
	{
		return this.a;
	}

	// Token: 0x0600C18F RID: 49551 RVA: 0x00431254 File Offset: 0x0042F454
	public void a(int A_0)
	{
		if (this.a != A_0)
		{
			this.a = A_0;
			this.a();
		}
	}

	// Token: 0x0600C190 RID: 49552 RVA: 0x00431270 File Offset: 0x0042F470
	public string c()
	{
		return this.d;
	}

	// Token: 0x0600C191 RID: 49553 RVA: 0x00431278 File Offset: 0x0042F478
	public void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600C192 RID: 49554 RVA: 0x00431284 File Offset: 0x0042F484
	public ecs d()
	{
		return this.b;
	}

	// Token: 0x0600C193 RID: 49555 RVA: 0x0043128C File Offset: 0x0042F48C
	public void c(ecs A_0)
	{
		if (this.b != A_0)
		{
			this.b = A_0;
			this.a();
		}
	}

	// Token: 0x0600C194 RID: 49556 RVA: 0x004312A8 File Offset: 0x0042F4A8
	public ecs b()
	{
		return this.c;
	}

	// Token: 0x0600C195 RID: 49557 RVA: 0x004312B0 File Offset: 0x0042F4B0
	public void b(ecs A_0)
	{
		if (this.c != A_0)
		{
			this.c = A_0;
			this.a();
		}
	}

	// Token: 0x0600C196 RID: 49558 RVA: 0x004312CC File Offset: 0x0042F4CC
	public a8x()
	{
		this.a();
	}

	// Token: 0x0600C197 RID: 49559 RVA: 0x004312F0 File Offset: 0x0042F4F0
	public override void iv(e6d A_0, cp9 A_1)
	{
		Point point = base.at();
		if ((this.IsMousedOver || base.Checked || euz.DesignMode) && !string.IsNullOrEmpty(this.d))
		{
			if (A_1.a != null)
			{
				Texture2D resource = A_1.a.GetResource<Texture2D>(this.d, null);
				if (resource != null)
				{
					as6.a(A_1.b(), resource, point, base.Size, base.Color, null, null);
				}
			}
			if (this.f != null)
			{
				this.f.a(new Point(point.X + this.a, point.Y + this.a), A_1, null, 1f);
			}
		}
		else if (this.e != null)
		{
			this.e.a(new Point(point.X + this.a, point.Y + this.a), A_1, null, 1f);
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x0600C198 RID: 49560 RVA: 0x00431414 File Offset: 0x0042F614
	private void a()
	{
		this.e = this.a(this.b);
		this.f = this.a(this.c);
	}

	// Token: 0x0600C199 RID: 49561 RVA: 0x0043143C File Offset: 0x0042F63C
	private dn3 a(ecs A_0)
	{
		dn3 result = null;
		if (this.b != null)
		{
			ecs ecs = Enumerable.FirstOrDefault<ecs>(A_0.a(base.Size.c - 2 * this.a, base.Size.d - 2 * this.e()));
			if (ecs != null)
			{
				result = ecs.b();
			}
		}
		return result;
	}

	// Token: 0x0600C19A RID: 49562 RVA: 0x00431498 File Offset: 0x0042F698
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.a();
	}

	// Token: 0x04004609 RID: 17929
	private new int a = 3;

	// Token: 0x0400460A RID: 17930
	private new ecs b;

	// Token: 0x0400460B RID: 17931
	private new ecs c;

	// Token: 0x0400460C RID: 17932
	private new string d = bo1.b;

	// Token: 0x0400460D RID: 17933
	private new dn3 e;

	// Token: 0x0400460E RID: 17934
	private new dn3 f;
}
