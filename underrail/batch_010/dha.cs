using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;

// Token: 0x02001315 RID: 4885
[a(typeof(dha))]
[eiz("EEA")]
[Serializable]
public class dha : Aspect<c5x>, bp1, ISerializable
{
	// Token: 0x06006D86 RID: 28038 RVA: 0x002DC2E0 File Offset: 0x002DA4E0
	protected dha(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetDouble("EEA:PC");
			this.b = A_0.GetInt32("EEA:PS");
			this.c = A_0.GetInt32("EEA:F");
			this.d = A_0.GetBoolean("EEA:S");
			this.e = (ar7)A_0.GetValue("EEA:CR", typeof(ar7));
			this.f = A_0.GetInt32("EEA:MC");
			this.g = A_0.GetDouble("EEA:MD");
			this.h = A_0.GetInt32("EEA:CC");
			this.i = A_0.GetDouble("EEA:TP");
			this.j = (Vector3)A_0.GetValue("EEA:LCL", typeof(Vector3));
			this.k = (ccp)A_0.GetValue("EEA:IA", typeof(ccp));
			if (ell.a() >= 426)
			{
				this.l = A_0.GetBoolean("EEA:M");
			}
			if (ell.a() >= 685)
			{
				this.m = A_0.GetBoolean("EEA:R");
				return;
			}
		}
		else
		{
			this.a = A_0.GetDouble("_PhaseCache");
			this.b = A_0.GetInt32("_PhaseStep");
			this.c = A_0.GetInt32("_Frames");
			this.d = A_0.GetBoolean("_Started");
			this.e = (A_0.GetValue("_CarrierRef", typeof(ar7)) as ar7);
			this.f = A_0.GetInt32("_MaxCycles");
			this.g = A_0.GetDouble("_MaxDuration");
			this.h = A_0.GetInt32("_CyclesCompleted");
			this.i = A_0.GetDouble("_TimePassed");
			this.j = (Vector3)A_0.GetValue("_LastCarrierLocation", typeof(Vector3));
			this.k = (A_0.GetValue("IA", typeof(bdi)) as bdi);
		}
	}

	// Token: 0x06006D87 RID: 28039 RVA: 0x002DC510 File Offset: 0x002DA710
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("EEA:PC", this.a);
		info.AddValue("EEA:PS", this.b);
		info.AddValue("EEA:F", this.c);
		info.AddValue("EEA:S", this.d);
		info.AddValue("EEA:CR", this.e);
		info.AddValue("EEA:MC", this.f);
		info.AddValue("EEA:MD", this.g);
		info.AddValue("EEA:CC", this.h);
		info.AddValue("EEA:TP", this.i);
		info.AddValue("EEA:LCL", this.j);
		info.AddValue("EEA:IA", this.k);
		info.AddValue("EEA:M", this.l);
		info.AddValue("EEA:R", this.m);
	}

	// Token: 0x06006D88 RID: 28040 RVA: 0x002DC608 File Offset: 0x002DA808
	public c5x i()
	{
		if (this.e != null)
		{
			return this.e.ao() as c5x;
		}
		return null;
	}

	// Token: 0x06006D89 RID: 28041 RVA: 0x002DC628 File Offset: 0x002DA828
	public int d()
	{
		return this.b;
	}

	// Token: 0x06006D8A RID: 28042 RVA: 0x002DC630 File Offset: 0x002DA830
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006D8B RID: 28043 RVA: 0x002DC63C File Offset: 0x002DA83C
	public bool e()
	{
		return this.l;
	}

	// Token: 0x06006D8C RID: 28044 RVA: 0x002DC644 File Offset: 0x002DA844
	public void b(bool A_0)
	{
		this.l = A_0;
	}

	// Token: 0x06006D8D RID: 28045 RVA: 0x002DC650 File Offset: 0x002DA850
	public bool f()
	{
		return this.m;
	}

	// Token: 0x06006D8E RID: 28046 RVA: 0x002DC658 File Offset: 0x002DA858
	public void a(bool A_0)
	{
		this.m = A_0;
	}

	// Token: 0x06006D8F RID: 28047 RVA: 0x002DC664 File Offset: 0x002DA864
	public dha(c5x A_0, ccp A_1, int A_2, int A_3) : base(A_0)
	{
		this.k = A_1;
		this.c = A_2;
		this.b = A_3;
		this.a = (double)this.b;
	}

	// Token: 0x06006D90 RID: 28048 RVA: 0x002DC694 File Offset: 0x002DA894
	public bool a(c5x A_0, int A_1, double A_2)
	{
		if (this.d || base.a8() == null || base.a8().Zone == null)
		{
			return false;
		}
		this.e = new ar7(A_0);
		this.f = A_1;
		this.g = A_2;
		this.b();
		e3t a_ = new e3t(this);
		base.a8().Zone.ActionManager.g9(a_, atp.a);
		this.d = true;
		return true;
	}

	// Token: 0x06006D91 RID: 28049 RVA: 0x002DC710 File Offset: 0x002DA910
	public bool h()
	{
		if (!this.d)
		{
			this.d = true;
			return true;
		}
		return false;
	}

	// Token: 0x06006D92 RID: 28050 RVA: 0x002DC728 File Offset: 0x002DA928
	public bool g()
	{
		if (this.d)
		{
			this.d = false;
			return true;
		}
		return false;
	}

	// Token: 0x06006D93 RID: 28051 RVA: 0x002DC744 File Offset: 0x002DA944
	public bool a(double A_0)
	{
		if (this.k != null && this.d)
		{
			if ((this.a -= A_0) <= 0.0)
			{
				if (this.m)
				{
					if (this.k.p8().X <= 0)
					{
						int num = this.h + 1;
						this.h = num;
						if (num >= this.f && this.f != 0)
						{
							return true;
						}
					}
				}
				else if (this.k.p8().X >= this.c - 1)
				{
					int num = this.h + 1;
					this.h = num;
					if (num >= this.f && this.f != 0)
					{
						return true;
					}
				}
				this.k.qb(this.c, this.m);
				this.a = (double)this.b;
			}
			if ((this.i += A_0) >= this.g && this.g != 0.0)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06006D94 RID: 28052 RVA: 0x002DC870 File Offset: 0x002DAA70
	public void mx()
	{
		base.a8().d = true;
		this.a();
		this.b();
	}

	// Token: 0x06006D95 RID: 28053 RVA: 0x002DC88C File Offset: 0x002DAA8C
	public void my()
	{
		this.a();
	}

	// Token: 0x06006D96 RID: 28054 RVA: 0x002DC898 File Offset: 0x002DAA98
	private void b()
	{
		if (this.i() != null)
		{
			this.i().k(new EventHandler<c1>(this.a));
			this.j = this.i().Location;
		}
	}

	// Token: 0x06006D97 RID: 28055 RVA: 0x002DC8D8 File Offset: 0x002DAAD8
	private void a()
	{
		if (this.i() != null)
		{
			this.i().f(new EventHandler<c1>(this.a));
		}
	}

	// Token: 0x06006D98 RID: 28056 RVA: 0x002DC8FC File Offset: 0x002DAAFC
	[dcc("EEA:mCLC")]
	private void a(object A_0, c1 A_1)
	{
		Vector3 value = this.i().Location - this.j;
		if (base.a8() != null)
		{
			base.a8().Location += value;
		}
		this.j = this.i().Location;
	}

	// Token: 0x04002CC9 RID: 11465
	private double a;

	// Token: 0x04002CCA RID: 11466
	private int b;

	// Token: 0x04002CCB RID: 11467
	private int c;

	// Token: 0x04002CCC RID: 11468
	private bool d;

	// Token: 0x04002CCD RID: 11469
	private ar7 e;

	// Token: 0x04002CCE RID: 11470
	private int f;

	// Token: 0x04002CCF RID: 11471
	private double g;

	// Token: 0x04002CD0 RID: 11472
	private int h;

	// Token: 0x04002CD1 RID: 11473
	private double i;

	// Token: 0x04002CD2 RID: 11474
	private Vector3 j;

	// Token: 0x04002CD3 RID: 11475
	private ccp k;

	// Token: 0x04002CD4 RID: 11476
	private bool l;

	// Token: 0x04002CD5 RID: 11477
	private bool m;
}
