using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using Ouroboros.Playfield.References;
using Ouroboros.Playfield.Space;

// Token: 0x02001302 RID: 4866
[eiz("AEEA")]
[Serializable]
public sealed class cij : Aspect<c5x>, c98, bp1, chb
{
	// Token: 0x06006C95 RID: 27797 RVA: 0x002D79A0 File Offset: 0x002D5BA0
	private cij(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("AEEA:RT");
		this.b = A_0.GetBoolean("AEEA:ST");
		this.e = A_0.GetInt32("AEEA:TP");
		this.f = A_0.GetBoolean("AEEA:EA");
		this.g = A_0.GetBoolean("AEEA:UAD");
		this.c = A_0.GetBoolean("AEEA:PTS");
		this.d = A_0.GetString("AEEA:TS");
		this.i = (A_0.GetValue("AEEA:O", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
		if (ell.a() >= 205)
		{
			this.h = (A_0.GetValue("AEEA:E", typeof(c00)) as c00);
		}
		if (ell.a() >= 215)
		{
			di7.ReadList<cze>("AEEA:DJ", ref this.j, A_0);
			return;
		}
		this.j = new List<cze>();
	}

	// Token: 0x06006C96 RID: 27798 RVA: 0x002D7AD4 File Offset: 0x002D5CD4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("AEEA:RT", this.a);
		info.AddValue("AEEA:ST", this.b);
		info.AddValue("AEEA:TP", this.e);
		info.AddValue("AEEA:EA", this.f);
		info.AddValue("AEEA:UAD", this.g);
		info.AddValue("AEEA:PTS", this.c);
		info.AddValue("AEEA:TS", this.d);
		info.AddValue("AEEA:O", this.i);
		info.AddValue("AEEA:E", this.h);
		di7.WriteList<cze>("AEEA:DJ", this.j, info);
	}

	// Token: 0x06006C97 RID: 27799 RVA: 0x002D7B94 File Offset: 0x002D5D94
	public double m()
	{
		return this.a;
	}

	// Token: 0x06006C98 RID: 27800 RVA: 0x002D7B9C File Offset: 0x002D5D9C
	public void b(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006C99 RID: 27801 RVA: 0x002D7BA8 File Offset: 0x002D5DA8
	public bool g()
	{
		return this.b;
	}

	// Token: 0x06006C9A RID: 27802 RVA: 0x002D7BB0 File Offset: 0x002D5DB0
	public void b(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006C9B RID: 27803 RVA: 0x002D7BBC File Offset: 0x002D5DBC
	public bool e()
	{
		return this.c;
	}

	// Token: 0x06006C9C RID: 27804 RVA: 0x002D7BC4 File Offset: 0x002D5DC4
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006C9D RID: 27805 RVA: 0x002D7BD0 File Offset: 0x002D5DD0
	public string h()
	{
		return this.d;
	}

	// Token: 0x06006C9E RID: 27806 RVA: 0x002D7BD8 File Offset: 0x002D5DD8
	public void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006C9F RID: 27807 RVA: 0x002D7BE4 File Offset: 0x002D5DE4
	public int o()
	{
		return this.e;
	}

	// Token: 0x06006CA0 RID: 27808 RVA: 0x002D7BEC File Offset: 0x002D5DEC
	public void a(int A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006CA1 RID: 27809 RVA: 0x002D7BF8 File Offset: 0x002D5DF8
	public bool k()
	{
		return this.f;
	}

	// Token: 0x06006CA2 RID: 27810 RVA: 0x002D7C00 File Offset: 0x002D5E00
	public void c(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06006CA3 RID: 27811 RVA: 0x002D7C0C File Offset: 0x002D5E0C
	public bool l()
	{
		return this.g;
	}

	// Token: 0x06006CA4 RID: 27812 RVA: 0x002D7C14 File Offset: 0x002D5E14
	public void d(bool A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06006CA5 RID: 27813 RVA: 0x002D7C20 File Offset: 0x002D5E20
	public c00 j()
	{
		return this.h;
	}

	// Token: 0x06006CA6 RID: 27814 RVA: 0x002D7C28 File Offset: 0x002D5E28
	public void a(c00 A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06006CA7 RID: 27815 RVA: 0x002D7C34 File Offset: 0x002D5E34
	public amc f()
	{
		if (this.i != null)
		{
			return this.i.ao();
		}
		return null;
	}

	// Token: 0x06006CA8 RID: 27816 RVA: 0x002D7C50 File Offset: 0x002D5E50
	public List<cze> n()
	{
		return this.j;
	}

	// Token: 0x06006CA9 RID: 27817 RVA: 0x002D7C58 File Offset: 0x002D5E58
	public void a(List<cze> A_0)
	{
		this.j = A_0;
	}

	// Token: 0x06006CAA RID: 27818 RVA: 0x002D7C64 File Offset: 0x002D5E64
	public cij(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006CAB RID: 27819 RVA: 0x002D7C98 File Offset: 0x002D5E98
	public void c()
	{
		this.a((double)d0u.b);
	}

	// Token: 0x06006CAC RID: 27820 RVA: 0x002D7CA8 File Offset: 0x002D5EA8
	private void a(double A_0)
	{
		if (this.f)
		{
			if ((this.a -= A_0) <= 0.0)
			{
				this.i();
				return;
			}
			int num = this.b();
			if (num != this.k)
			{
				this.k = num;
				this.d();
			}
		}
	}

	// Token: 0x06006CAD RID: 27821 RVA: 0x002D7D08 File Offset: 0x002D5F08
	public void a(int? A_0 = null)
	{
		this.f = true;
		if (A_0 != null)
		{
			this.a = (double)A_0.Value;
		}
		this.k = this.b();
	}

	// Token: 0x06006CAE RID: 27822 RVA: 0x002D7D38 File Offset: 0x002D5F38
	public void r7(eds A_0)
	{
		if (!dz6.e())
		{
			this.a(A_0.b.TotalMilliseconds);
		}
	}

	// Token: 0x06006CAF RID: 27823 RVA: 0x002D7D58 File Offset: 0x002D5F58
	private void d()
	{
		bmj.a(base.a8(), new efj(this.k));
		base.a8().c().a("explosiveTick", "ExplosiveTick", 1f, c9z.a, false, false);
	}

	// Token: 0x06006CB0 RID: 27824 RVA: 0x002D7DA0 File Offset: 0x002D5FA0
	public void i()
	{
		this.f = false;
		if (this.h != null && this.h.b != null)
		{
			atw atw = this.h.b as atw;
			if (atw != null)
			{
				atw.ap3(base.a8().Location.a());
			}
			Vector3 vector = base.a8().aj();
			ak1 ak = base.a8().Area.b((int)vector.X, (int)vector.Y);
			if (ak != null)
			{
				eym.a(base.a8(), (double)aju.bs);
				cix cix = base.a8().Zone.ActionManager;
				if (this.g)
				{
					c7 c = new c7(base.a8(), false, false, true, false);
					c.a(true);
					cix.g9(c, atp.a);
				}
				if (!boj.c(ak.Area, ak.Location))
				{
					boj.a(ak);
					aud a_ = ak.Area;
					Vector3 a_2 = ak.Location.a() + new Vector3(0.4f, 0.4f, 0f);
					HorizontalDirection? a_3 = null;
					string a_4 = "BlurredSmokeSlow" + (cuo.a.Next(3) + 1).ToString();
					int a_5 = 1;
					double maxValue = double.MaxValue;
					float? a_6 = new float?(0.66f);
					boj.a(a_, a_2, a_3, a_4, a_5, maxValue, null, a_6, null, null);
				}
				awb awb = this.h.a(ak);
				awb.r = true;
				if (awb != null)
				{
					cix.g9(awb, atp.a);
				}
			}
		}
		if (this.j != null && this.j.Count > 0)
		{
			foreach (cze cze in this.j)
			{
				cze.ym(null, base.a8(), new Dictionary<string, object>());
			}
		}
	}

	// Token: 0x06006CB1 RID: 27825 RVA: 0x002D7FC0 File Offset: 0x002D61C0
	public void mx()
	{
		base.a8().e = true;
		if (this.f)
		{
			this.k = this.b();
		}
	}

	// Token: 0x06006CB2 RID: 27826 RVA: 0x002D7FE8 File Offset: 0x002D61E8
	public void my()
	{
	}

	// Token: 0x06006CB3 RID: 27827 RVA: 0x002D7FEC File Offset: 0x002D61EC
	private int b()
	{
		return (int)Math.Max(0.0, Math.Ceiling(this.a / (double)this.e));
	}

	// Token: 0x06006CB4 RID: 27828 RVA: 0x002D8010 File Offset: 0x002D6210
	private void a()
	{
	}

	// Token: 0x04002C8B RID: 11403
	private double a;

	// Token: 0x04002C8C RID: 11404
	private bool b = true;

	// Token: 0x04002C8D RID: 11405
	private bool c = true;

	// Token: 0x04002C8E RID: 11406
	private string d;

	// Token: 0x04002C8F RID: 11407
	private int e = 1000;

	// Token: 0x04002C90 RID: 11408
	private bool f;

	// Token: 0x04002C91 RID: 11409
	private bool g = true;

	// Token: 0x04002C92 RID: 11410
	private c00 h;

	// Token: 0x04002C93 RID: 11411
	public EntityAspectReference<amc, amc> i;

	// Token: 0x04002C94 RID: 11412
	private List<cze> j = new List<cze>();

	// Token: 0x04002C95 RID: 11413
	[NonSerialized]
	private int k;
}
