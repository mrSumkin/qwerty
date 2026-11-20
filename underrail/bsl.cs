using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020012FF RID: 4863
[eiz("PSWEA")]
[a(typeof(bim))]
[Serializable]
public sealed class bsl : bim, g3
{
	// Token: 0x06006C57 RID: 27735 RVA: 0x002D6D48 File Offset: 0x002D4F48
	private bsl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("PSWEA:S");
		this.b = A_0.GetBoolean("PSWEA:UEP");
		this.c = (A_0.GetValue("PSWEA:ONSF", typeof(Point?)) as Point?);
		this.d = (A_0.GetValue("PSWEA:OFSF", typeof(Point?)) as Point?);
		this.e = (A_0.GetValue("PSWEA:SSONJ", typeof(cze)) as cze);
		this.f = (A_0.GetValue("PSWEA:SSOFJ", typeof(cze)) as cze);
		if (ell.a() >= 39)
		{
			this.g = A_0.GetBoolean("PSWEA:SA");
		}
	}

	// Token: 0x06006C58 RID: 27736 RVA: 0x002D6E28 File Offset: 0x002D5028
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PSWEA:S", this.a);
		info.AddValue("PSWEA:UEP", this.b);
		info.AddValue("PSWEA:ONSF", this.c);
		info.AddValue("PSWEA:OFSF", this.d);
		info.AddValue("PSWEA:SSONJ", this.e);
		info.AddValue("PSWEA:SSOFJ", this.f);
		info.AddValue("PSWEA:SA", this.g);
	}

	// Token: 0x06006C59 RID: 27737 RVA: 0x002D6EC0 File Offset: 0x002D50C0
	public bool b()
	{
		return this.a;
	}

	// Token: 0x06006C5A RID: 27738 RVA: 0x002D6EC8 File Offset: 0x002D50C8
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006C5B RID: 27739 RVA: 0x002D6ED4 File Offset: 0x002D50D4
	public bool g()
	{
		return this.g;
	}

	// Token: 0x06006C5C RID: 27740 RVA: 0x002D6EDC File Offset: 0x002D50DC
	public void c(bool A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06006C5D RID: 27741 RVA: 0x002D6EE8 File Offset: 0x002D50E8
	public bool f()
	{
		return this.b;
	}

	// Token: 0x06006C5E RID: 27742 RVA: 0x002D6EF0 File Offset: 0x002D50F0
	public void b(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006C5F RID: 27743 RVA: 0x002D6EFC File Offset: 0x002D50FC
	public Point? a()
	{
		return this.c;
	}

	// Token: 0x06006C60 RID: 27744 RVA: 0x002D6F04 File Offset: 0x002D5104
	public void b(Point? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006C61 RID: 27745 RVA: 0x002D6F10 File Offset: 0x002D5110
	public Point? d()
	{
		return this.d;
	}

	// Token: 0x06006C62 RID: 27746 RVA: 0x002D6F18 File Offset: 0x002D5118
	public void a(Point? A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006C63 RID: 27747 RVA: 0x002D6F24 File Offset: 0x002D5124
	public cze e()
	{
		return this.e;
	}

	// Token: 0x06006C64 RID: 27748 RVA: 0x002D6F2C File Offset: 0x002D512C
	public void a(cze A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006C65 RID: 27749 RVA: 0x002D6F38 File Offset: 0x002D5138
	public cze h()
	{
		return this.f;
	}

	// Token: 0x06006C66 RID: 27750 RVA: 0x002D6F40 File Offset: 0x002D5140
	public void b(cze A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06006C67 RID: 27751 RVA: 0x002D6F4C File Offset: 0x002D514C
	public bsl(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006C68 RID: 27752 RVA: 0x002D6F58 File Offset: 0x002D5158
	public void aal(c5x A_0, bool A_1, bool A_2)
	{
		bool flag = this.a;
		this.a = (this.b ? A_2 : A_1);
		if (this.a != flag)
		{
			if (this.a)
			{
				if (this.e != null)
				{
					this.a(this.e, A_0);
				}
				if (this.c != null)
				{
					this.a(this.c.Value);
					return;
				}
			}
			else
			{
				if (this.f != null)
				{
					this.a(this.f, A_0);
				}
				if (this.d != null)
				{
					this.a(this.d.Value);
				}
			}
		}
	}

	// Token: 0x06006C69 RID: 27753 RVA: 0x002D7010 File Offset: 0x002D5210
	protected override void mz(c5x A_0, string A_1 = null)
	{
		axh aspect = base.a8().GetAspect<axh>();
		if (aspect != null)
		{
			aspect.a(A_0);
		}
	}

	// Token: 0x06006C6A RID: 27754 RVA: 0x002D7038 File Offset: 0x002D5238
	private void a(Point A_0)
	{
		alv alv = base.a8().p.b;
		if (alv != null && alv.a.Count > 0)
		{
			if (this.g)
			{
				using (List<cd0>.Enumerator enumerator = alv.a.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						cd0 cd = enumerator.Current;
						cd.b = A_0;
					}
					return;
				}
			}
			alv.a[0].b = A_0;
			return;
		}
		cd0 cd2 = base.a8().o.b;
		if (cd2 != null)
		{
			cd2.b = A_0;
		}
	}

	// Token: 0x06006C6B RID: 27755 RVA: 0x002D70F4 File Offset: 0x002D52F4
	private void a(cze A_0, c5x A_1)
	{
		A_0.ym(A_1, base.a8(), null);
	}

	// Token: 0x04002C79 RID: 11385
	private new bool a;

	// Token: 0x04002C7A RID: 11386
	private bool b;

	// Token: 0x04002C7B RID: 11387
	private Point? c;

	// Token: 0x04002C7C RID: 11388
	private Point? d;

	// Token: 0x04002C7D RID: 11389
	private cze e;

	// Token: 0x04002C7E RID: 11390
	private cze f;

	// Token: 0x04002C7F RID: 11391
	private bool g;
}
