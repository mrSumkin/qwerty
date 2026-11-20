using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;

// Token: 0x0200131B RID: 4891
[eiz("SEA1")]
[Serializable]
public class su : Aspect<c5x>, c98, bp1, ISerializable
{
	// Token: 0x06006E2C RID: 28204 RVA: 0x002E0954 File Offset: 0x002DEB54
	protected su(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetDouble("SEA1:SV");
			this.b = A_0.GetInt32("SEA1:P");
			this.c = A_0.GetDouble("SEA1:PC");
			this.d = A_0.GetDouble("SEA1:SHC");
			this.e = (rw)A_0.GetValue("SEA1:SS", typeof(rw));
			this.g = (Color)A_0.GetValue("SEA1:SC", typeof(Color));
			this.h = (Color)A_0.GetValue("SEA1:SHC1", typeof(Color));
			this.i = A_0.GetString("SEA1:SM");
			return;
		}
		this.a = A_0.GetDouble("_ShieldVisibility");
		this.b = A_0.GetInt32("_Phase");
		this.c = A_0.GetDouble("_PhaseCache");
		this.d = A_0.GetDouble("_ShieldHitCache");
		this.e = (rw)A_0.GetValue("_ShieldState", typeof(rw));
		this.g = (Color)A_0.GetValue("_ShieldColor", typeof(Color));
		this.h = (Color)A_0.GetValue("_ShieldHitColor", typeof(Color));
		this.i = A_0.GetString("_ShieldModel");
	}

	// Token: 0x06006E2D RID: 28205 RVA: 0x002E0AE0 File Offset: 0x002DECE0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SEA1:SV", this.a);
		info.AddValue("SEA1:P", this.b);
		info.AddValue("SEA1:PC", this.c);
		info.AddValue("SEA1:SHC", this.d);
		info.AddValue("SEA1:SS", this.e);
		info.AddValue("SEA1:SC", this.g);
		info.AddValue("SEA1:SHC1", this.h);
		info.AddValue("SEA1:SM", this.i);
	}

	// Token: 0x06006E2E RID: 28206 RVA: 0x002E0B8C File Offset: 0x002DED8C
	public int g()
	{
		return this.b;
	}

	// Token: 0x06006E2F RID: 28207 RVA: 0x002E0B94 File Offset: 0x002DED94
	public Color o()
	{
		if (this.d > 0.0)
		{
			return this.h * 0.5f;
		}
		return this.g * (float)this.a * 0.5f;
	}

	// Token: 0x06006E30 RID: 28208 RVA: 0x002E0BE4 File Offset: 0x002DEDE4
	public bool m()
	{
		return this.e > rw.a;
	}

	// Token: 0x06006E31 RID: 28209 RVA: 0x002E0BF0 File Offset: 0x002DEDF0
	public string j()
	{
		return this.i;
	}

	// Token: 0x06006E32 RID: 28210 RVA: 0x002E0BF8 File Offset: 0x002DEDF8
	public amr p()
	{
		if (base.a8().h.b != null)
		{
			return base.a8().h.b.aa().Defense;
		}
		return null;
	}

	// Token: 0x06006E33 RID: 28211 RVA: 0x002E0C2C File Offset: 0x002DEE2C
	public double k()
	{
		return this.f;
	}

	// Token: 0x06006E34 RID: 28212 RVA: 0x002E0C34 File Offset: 0x002DEE34
	public su(c5x A_0) : base(A_0)
	{
		this.f();
	}

	// Token: 0x06006E35 RID: 28213 RVA: 0x002E0C44 File Offset: 0x002DEE44
	private void f()
	{
		this.a();
		if (this.p().i4() && (int)this.p().i5() > 0)
		{
			this.e = rw.b;
			this.a = 1.0;
			return;
		}
		this.e = rw.a;
		this.a = 0.0;
	}

	// Token: 0x06006E36 RID: 28214 RVA: 0x002E0CA8 File Offset: 0x002DEEA8
	private void e()
	{
		this.e = rw.d;
		this.a = 0.0;
		base.a8().c().a("EnergyShield", false);
		base.a8().c().a("EnergyShield", "EnergyShield", 1f, c9z.b, true, false);
	}

	// Token: 0x06006E37 RID: 28215 RVA: 0x002E0D08 File Offset: 0x002DEF08
	private void d()
	{
		this.e = rw.c;
	}

	// Token: 0x06006E38 RID: 28216 RVA: 0x002E0D14 File Offset: 0x002DEF14
	private void b()
	{
		if ((this.e == rw.b || this.e == rw.d) && ((int)this.p().i5() <= 0 || !this.p().i4()))
		{
			this.d();
			return;
		}
		if ((this.e == rw.c || this.e == rw.a) && (int)this.p().i5() > 0 && this.p().i4())
		{
			this.e();
		}
	}

	// Token: 0x06006E39 RID: 28217 RVA: 0x002E0DA4 File Offset: 0x002DEFA4
	private void a()
	{
		if (this.p().i6() != null)
		{
			this.g = this.p().i6().Value;
		}
		if (this.p().i7() != null)
		{
			this.h = this.p().i7().Value;
		}
		if (this.p().i8() != null)
		{
			this.i = this.p().i8();
		}
	}

	// Token: 0x06006E3A RID: 28218 RVA: 0x002E0E34 File Offset: 0x002DF034
	public void r7(eds A_0)
	{
		double totalMilliseconds = A_0.b.TotalMilliseconds;
		if (this.e == rw.d)
		{
			if (this.a < 1.0)
			{
				this.a += totalMilliseconds * aju.j;
			}
			if (this.a >= 1.0)
			{
				this.e = rw.b;
				this.a = 1.0;
			}
		}
		else if (this.e == rw.c)
		{
			if (this.a > 0.0)
			{
				this.a -= totalMilliseconds * aju.j;
			}
			if (this.a <= 0.0)
			{
				this.a = 0.0;
				this.e = rw.a;
				base.a8().c().a("EnergyShield", false);
			}
		}
		if ((this.c -= totalMilliseconds) <= 0.0)
		{
			this.c = (double)aju.f;
			int num = this.b + 1;
			this.b = num;
			if (num >= aju.i)
			{
				this.b = 0;
			}
		}
		if (this.d > 0.0)
		{
			this.d -= totalMilliseconds;
		}
		if (this.f > 0.0)
		{
			if (this.e == rw.a)
			{
				this.f = 0.0;
				return;
			}
			this.f = Math.Max(0.0, this.f - aju.h * totalMilliseconds);
		}
	}

	// Token: 0x06006E3B RID: 28219 RVA: 0x002E0FE8 File Offset: 0x002DF1E8
	public void h()
	{
		this.d = (double)aju.g;
	}

	// Token: 0x06006E3C RID: 28220 RVA: 0x002E0FF8 File Offset: 0x002DF1F8
	public void i()
	{
		this.f = 1.0;
	}

	// Token: 0x06006E3D RID: 28221 RVA: 0x002E100C File Offset: 0x002DF20C
	public void n()
	{
		this.p().jb(new EventHandler<EventArgs>(this.b));
		this.p().i9(new EventHandler<c1>(this.a));
		this.p().jd(new EventHandler<c1>(this.b));
		this.p().jf(new EventHandler<EventArgs>(this.a));
	}

	// Token: 0x06006E3E RID: 28222 RVA: 0x002E1078 File Offset: 0x002DF278
	public void l()
	{
		this.p().jc(new EventHandler<EventArgs>(this.b));
		this.p().ja(new EventHandler<c1>(this.a));
		this.p().je(new EventHandler<c1>(this.b));
		this.p().jg(new EventHandler<EventArgs>(this.a));
	}

	// Token: 0x06006E3F RID: 28223 RVA: 0x002E10E4 File Offset: 0x002DF2E4
	[dcc("SEA1:mOSVC")]
	private void b(object A_0, c1 A_1)
	{
		this.b();
	}

	// Token: 0x06006E40 RID: 28224 RVA: 0x002E10F0 File Offset: 0x002DF2F0
	[dcc("SEA1:mOST")]
	private void a(object A_0, c1 A_1)
	{
		this.b();
		if (A_1.a() is bool && (bool)A_1.a())
		{
			this.a();
			if (base.a8() != null && !base.a8().IsPlayer && base.a8().t.b != null)
			{
				base.a8().t.b.y6().RemoveProperty(ddq.br);
			}
		}
		base.a8().c().a("ShieldEmitterToggle", "ShieldEmitterToggle", 1f, c9z.a, false, false);
	}

	// Token: 0x06006E41 RID: 28225 RVA: 0x002E119C File Offset: 0x002DF39C
	[dcc("SEA1:mOSH")]
	private void b(object A_0, EventArgs A_1)
	{
		this.h();
		base.a8().c().a("EnergyShieldHit");
	}

	// Token: 0x06006E42 RID: 28226 RVA: 0x002E11BC File Offset: 0x002DF3BC
	[dcc("SEA1:mOSC")]
	private void a(object A_0, EventArgs A_1)
	{
		this.b();
	}

	// Token: 0x06006E43 RID: 28227 RVA: 0x002E11C4 File Offset: 0x002DF3C4
	public void mx()
	{
		base.a8().g |= e2b.b;
		this.n();
	}

	// Token: 0x06006E44 RID: 28228 RVA: 0x002E11E0 File Offset: 0x002DF3E0
	public void my()
	{
		base.a8().g &= ~e2b.b;
		this.l();
	}

	// Token: 0x04002D0F RID: 11535
	private double a;

	// Token: 0x04002D10 RID: 11536
	private int b;

	// Token: 0x04002D11 RID: 11537
	private double c;

	// Token: 0x04002D12 RID: 11538
	private double d;

	// Token: 0x04002D13 RID: 11539
	private rw e;

	// Token: 0x04002D14 RID: 11540
	private double f;

	// Token: 0x04002D15 RID: 11541
	private Color g;

	// Token: 0x04002D16 RID: 11542
	private Color h;

	// Token: 0x04002D17 RID: 11543
	private string i;
}
