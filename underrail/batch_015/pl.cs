using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework.Audio;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02001458 RID: 5208
[eiz("CA3")]
[Serializable]
public abstract class pl : a6k, bgn, v2, ISerializable, cst
{
	// Token: 0x06007529 RID: 29993 RVA: 0x0031A610 File Offset: 0x00318810
	protected pl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetInt32("CA3:IP");
			this.b = A_0.GetDouble("CA3:IPC");
			this.c = A_0.GetInt32("CA3:PS");
			this.d = A_0.GetDouble("CA3:TP");
			this.e = A_0.GetDouble("CA3:ACC");
			this.f = A_0.GetInt32("CA3:MP");
			this.g = A_0.GetInt32("CA3:P");
			if (ell.a() >= 125)
			{
				this.h = (m7)A_0.GetValue("CA3:C", typeof(m7));
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(pl))
			{
				this.a = A_0.GetInt32("_InvokerPhase");
				this.b = A_0.GetDouble("_InvokerPhaseCache");
				this.c = A_0.GetInt32("_PhaseStep");
				this.d = A_0.GetDouble("_TimePassed");
				this.e = A_0.GetDouble("_AvailabilityCheckCache");
				this.f = A_0.GetInt32("_MaxPushback");
				this.g = A_0.GetInt32("_Pushback");
				return;
			}
			this.a = A_0.GetInt32("CastingAction+_InvokerPhase");
			this.b = A_0.GetDouble("CastingAction+_InvokerPhaseCache");
			this.c = A_0.GetInt32("CastingAction+_PhaseStep");
			this.d = A_0.GetDouble("CastingAction+_TimePassed");
			this.e = A_0.GetDouble("CastingAction+_AvailabilityCheckCache");
			this.f = A_0.GetInt32("CastingAction+_MaxPushback");
			this.g = A_0.GetInt32("CastingAction+_Pushback");
		}
	}

	// Token: 0x0600752A RID: 29994 RVA: 0x0031A7DC File Offset: 0x003189DC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CA3:IP", this.a);
		info.AddValue("CA3:IPC", this.b);
		info.AddValue("CA3:PS", this.c);
		info.AddValue("CA3:TP", this.d);
		info.AddValue("CA3:ACC", this.e);
		info.AddValue("CA3:MP", this.f);
		info.AddValue("CA3:P", this.g);
		info.AddValue("CA3:C", this.h);
	}

	// Token: 0x0600752B RID: 29995 RVA: 0x0031A880 File Offset: 0x00318A80
	public m7 kh()
	{
		return this.h;
	}

	// Token: 0x0600752C RID: 29996 RVA: 0x0031A888 File Offset: 0x00318A88
	public void a(m7 A_0)
	{
		this.h = A_0;
	}

	// Token: 0x0600752D RID: 29997 RVA: 0x0031A894 File Offset: 0x00318A94
	public int f()
	{
		int num = base.vg().e().a(base.vg().h());
		if (num != 0 && dz6.e())
		{
			return dz6.b(1000);
		}
		return num;
	}

	// Token: 0x0600752E RID: 29998 RVA: 0x0031A8DC File Offset: 0x00318ADC
	public double e()
	{
		return this.d;
	}

	// Token: 0x0600752F RID: 29999 RVA: 0x0031A8E4 File Offset: 0x00318AE4
	public virtual int? tm()
	{
		return new int?(this.a);
	}

	// Token: 0x06007530 RID: 30000 RVA: 0x0031A8F4 File Offset: 0x00318AF4
	public virtual CharacterState? q1()
	{
		if (this.f() > 0)
		{
			return this.m3();
		}
		return null;
	}

	// Token: 0x06007531 RID: 30001
	public abstract CharacterState? m3();

	// Token: 0x06007532 RID: 30002 RVA: 0x0031A920 File Offset: 0x00318B20
	public virtual double j2()
	{
		return as3.be;
	}

	// Token: 0x06007533 RID: 30003 RVA: 0x0031A928 File Offset: 0x00318B28
	public pl(ad5 A_0) : base(A_0)
	{
	}

	// Token: 0x06007534 RID: 30004 RVA: 0x0031A934 File Offset: 0x00318B34
	public void j3(int A_0)
	{
		if (this.g < this.f)
		{
			int num = (int)Math.Min(this.d, (double)Math.Min(this.f - this.g, A_0));
			this.g += num;
			this.d -= (double)num;
		}
	}

	// Token: 0x06007535 RID: 30005 RVA: 0x0031A990 File Offset: 0x00318B90
	protected override dc4 dt()
	{
		this.c = this.ade();
		this.d = 0.0;
		this.b = (double)this.c;
		this.e = 0.0;
		this.f = (int)((double)this.f() * as3.bg);
		this.c();
		return dc4.b;
	}

	// Token: 0x06007536 RID: 30006 RVA: 0x0031A9F0 File Offset: 0x00318BF0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		base.vg().i();
		if (this.f() != 0)
		{
			this.a(A_1.TotalMilliseconds);
		}
		if ((this.e += A_1.TotalMilliseconds) >= (double)dz6.b(cux.d))
		{
			this.e = 0.0;
			if (this.d())
			{
				return dc4.e;
			}
		}
		if ((this.d += A_1.TotalMilliseconds) < (double)this.f())
		{
			this.b();
			return dc4.b;
		}
		this.a();
		if (this.d())
		{
			return dc4.e;
		}
		return dc4.c;
	}

	// Token: 0x06007537 RID: 30007 RVA: 0x0031AAA4 File Offset: 0x00318CA4
	protected override void j4()
	{
		base.j4();
		if (base.vg().q().v.b != null)
		{
			base.vg().q().v.b.a("casting", false);
		}
	}

	// Token: 0x06007538 RID: 30008 RVA: 0x0031AAF4 File Offset: 0x00318CF4
	protected virtual int ade()
	{
		return dz6.b(cux.c);
	}

	// Token: 0x06007539 RID: 30009 RVA: 0x0031AB04 File Offset: 0x00318D04
	private void a(double A_0)
	{
		if ((this.b -= A_0) < 0.0)
		{
			if (base.vg().l() != null && base.vg().l().Value > 0f)
			{
				eym.a(base.vg().q(), (double)base.vg().l().Value);
			}
			this.b = (double)this.c;
			int num = this.a + 1;
			this.a = num;
			if (num == 2147483647)
			{
				this.a = 0;
			}
		}
	}

	// Token: 0x0600753A RID: 30010 RVA: 0x0031ABB8 File Offset: 0x00318DB8
	private bool d()
	{
		return !base.vg().b() || !base.vg().d();
	}

	// Token: 0x0600753B RID: 30011 RVA: 0x0031ABE0 File Offset: 0x00318DE0
	private void c()
	{
		if (base.vg().q().v.b != null)
		{
			if (base.vg().n() != null)
			{
				base.vg().q().v.b.a(Guid.NewGuid().ToString(), base.vg().n(), 1f, c9z.a, false, false);
			}
			if (base.vg().g() != null)
			{
				base.vg().q().v.b.a("casting", false);
				base.vg().q().v.b.a("casting", base.vg().g(), 1f, c9z.a, true, false);
			}
		}
	}

	// Token: 0x0600753C RID: 30012 RVA: 0x0031ACBC File Offset: 0x00318EBC
	private void b()
	{
		if (base.vg().g() != null && base.vg().q().v.b != null)
		{
			SoundState? soundState = base.vg().q().v.b.b("casting");
			if (soundState == null)
			{
				base.vg().q().v.b.a("casting", base.vg().g(), 1f, c9z.a, true, false);
				return;
			}
			if (soundState.GetValueOrDefault() == SoundState.Paused)
			{
				base.vg().q().v.b.c("casting");
			}
		}
	}

	// Token: 0x0600753D RID: 30013 RVA: 0x0031AD80 File Offset: 0x00318F80
	private void a()
	{
		if (base.vg().q().v.b != null)
		{
			base.vg().q().v.b.a("casting", false);
		}
	}

	// Token: 0x04002FFB RID: 12283
	private new int a;

	// Token: 0x04002FFC RID: 12284
	private double b;

	// Token: 0x04002FFD RID: 12285
	private int c;

	// Token: 0x04002FFE RID: 12286
	private double d;

	// Token: 0x04002FFF RID: 12287
	private double e;

	// Token: 0x04003000 RID: 12288
	private int f;

	// Token: 0x04003001 RID: 12289
	private int g;

	// Token: 0x04003002 RID: 12290
	private m7 h;
}
