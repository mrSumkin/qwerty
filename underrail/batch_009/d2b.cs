using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02001308 RID: 4872
[eiz("LEA")]
[Serializable]
public sealed class d2b : Aspect<c5x>, ISerializable
{
	// Token: 0x06006CEA RID: 27882 RVA: 0x002D904C File Offset: 0x002D724C
	private d2b(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			this.a = A_0.GetBoolean("_Locked");
			this.b = (LockType)A_0.GetValue("_LockType", typeof(LockType));
			this.c = A_0.GetBoolean("_Lockpickable");
			this.d = A_0.GetInt32("_RequiredLockpickingSkill");
			this.e = A_0.GetString("_KeyCode");
			this.f = A_0.GetBoolean("_ConsumesKey");
			this.g = A_0.GetBoolean("_Relockable");
			this.i = A_0.GetDouble("_ExperienceModifier");
			try
			{
				this.n = (d1c)A_0.GetValue("LEA_LPM", typeof(d1c));
			}
			catch
			{
			}
			di7.ReadList<cze>("_OnLockedJobs", ref this.k, A_0);
			di7.ReadList<cze>("_OnUnlockedJobs", ref this.j, A_0);
			di7.ReadList<cze>("_OnLockpickedJobs", ref this.l, A_0);
			return;
		}
		this.a = A_0.GetBoolean("LEA:L");
		this.b = (LockType)A_0.GetValue("LEA:LT", typeof(LockType));
		this.c = A_0.GetBoolean("LEA:L1");
		this.d = A_0.GetInt32("LEA:RLS");
		this.e = A_0.GetString("LEA:KC");
		this.f = A_0.GetBoolean("LEA:CK");
		this.g = A_0.GetBoolean("LEA:R");
		this.i = A_0.GetDouble("LEA:EM");
		di7.ReadList<cze>("LEA:OUJ", ref this.j, A_0);
		di7.ReadList<cze>("LEA:OLJ", ref this.k, A_0);
		di7.ReadList<cze>("LEA:OLJ1", ref this.l, A_0);
		this.n = (d1c)A_0.GetValue("LEA:LPM", typeof(d1c));
		if (ell.a() >= 227)
		{
			this.h = A_0.GetBoolean("LEA:P");
		}
		if (ell.a() >= 249)
		{
			this.o = A_0.GetString("LEA:C");
		}
		if (ell.a() >= 492)
		{
			di7.ReadList<cze>("LEA:LPCJ", ref this.m, A_0);
			return;
		}
		this.m = new List<cze>();
	}

	// Token: 0x06006CEB RID: 27883 RVA: 0x002D930C File Offset: 0x002D750C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("LEA:L", this.a);
		info.AddValue("LEA:LT", this.b);
		info.AddValue("LEA:L1", this.c);
		info.AddValue("LEA:RLS", this.d);
		info.AddValue("LEA:KC", this.e);
		info.AddValue("LEA:CK", this.f);
		info.AddValue("LEA:R", this.g);
		info.AddValue("LEA:EM", this.i);
		di7.WriteList<cze>("LEA:OUJ", this.j, info);
		di7.WriteList<cze>("LEA:OLJ", this.k, info);
		di7.WriteList<cze>("LEA:OLJ1", this.l, info);
		di7.WriteList<cze>("LEA:LPCJ", this.m, info);
		info.AddValue("LEA:LPM", this.n);
		info.AddValue("LEA:P", this.h);
		info.AddValue("LEA:C", this.o);
	}

	// Token: 0x06006CEC RID: 27884 RVA: 0x002D942C File Offset: 0x002D762C
	public bool n()
	{
		return this.a;
	}

	// Token: 0x06006CED RID: 27885 RVA: 0x002D9434 File Offset: 0x002D7634
	public void e(bool A_0)
	{
		if (this.a != A_0)
		{
			this.a = A_0;
			this.a();
		}
	}

	// Token: 0x06006CEE RID: 27886 RVA: 0x002D9450 File Offset: 0x002D7650
	public LockType j()
	{
		return this.b;
	}

	// Token: 0x06006CEF RID: 27887 RVA: 0x002D9458 File Offset: 0x002D7658
	public void a(LockType A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006CF0 RID: 27888 RVA: 0x002D9464 File Offset: 0x002D7664
	public bool e()
	{
		return this.c;
	}

	// Token: 0x06006CF1 RID: 27889 RVA: 0x002D946C File Offset: 0x002D766C
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006CF2 RID: 27890 RVA: 0x002D9478 File Offset: 0x002D7678
	public int p()
	{
		return this.d;
	}

	// Token: 0x06006CF3 RID: 27891 RVA: 0x002D9480 File Offset: 0x002D7680
	public void a(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006CF4 RID: 27892 RVA: 0x002D948C File Offset: 0x002D768C
	public string g()
	{
		return this.e;
	}

	// Token: 0x06006CF5 RID: 27893 RVA: 0x002D9494 File Offset: 0x002D7694
	public void b(string A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006CF6 RID: 27894 RVA: 0x002D94A0 File Offset: 0x002D76A0
	public bool k()
	{
		return this.f;
	}

	// Token: 0x06006CF7 RID: 27895 RVA: 0x002D94A8 File Offset: 0x002D76A8
	public void b(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06006CF8 RID: 27896 RVA: 0x002D94B4 File Offset: 0x002D76B4
	public bool h()
	{
		return this.g;
	}

	// Token: 0x06006CF9 RID: 27897 RVA: 0x002D94BC File Offset: 0x002D76BC
	public void d(bool A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06006CFA RID: 27898 RVA: 0x002D94C8 File Offset: 0x002D76C8
	public double b()
	{
		return this.i;
	}

	// Token: 0x06006CFB RID: 27899 RVA: 0x002D94D0 File Offset: 0x002D76D0
	public void a(double A_0)
	{
		this.i = A_0;
	}

	// Token: 0x06006CFC RID: 27900 RVA: 0x002D94DC File Offset: 0x002D76DC
	public List<cze> q()
	{
		return this.l;
	}

	// Token: 0x06006CFD RID: 27901 RVA: 0x002D94E4 File Offset: 0x002D76E4
	public void c(List<cze> A_0)
	{
		this.l = A_0;
	}

	// Token: 0x06006CFE RID: 27902 RVA: 0x002D94F0 File Offset: 0x002D76F0
	public List<cze> d()
	{
		return this.k;
	}

	// Token: 0x06006CFF RID: 27903 RVA: 0x002D94F8 File Offset: 0x002D76F8
	public void b(List<cze> A_0)
	{
		this.k = A_0;
	}

	// Token: 0x06006D00 RID: 27904 RVA: 0x002D9504 File Offset: 0x002D7704
	public List<cze> m()
	{
		return this.j;
	}

	// Token: 0x06006D01 RID: 27905 RVA: 0x002D950C File Offset: 0x002D770C
	public void a(List<cze> A_0)
	{
		this.j = A_0;
	}

	// Token: 0x06006D02 RID: 27906 RVA: 0x002D9518 File Offset: 0x002D7718
	public List<cze> l()
	{
		if (this.m == null)
		{
			this.m = new List<cze>();
		}
		return this.m;
	}

	// Token: 0x06006D03 RID: 27907 RVA: 0x002D9538 File Offset: 0x002D7738
	public void d(List<cze> A_0)
	{
		this.m = A_0;
	}

	// Token: 0x06006D04 RID: 27908 RVA: 0x002D9544 File Offset: 0x002D7744
	public d1c o()
	{
		return this.n;
	}

	// Token: 0x06006D05 RID: 27909 RVA: 0x002D954C File Offset: 0x002D774C
	public void a(d1c A_0)
	{
		this.n = A_0;
	}

	// Token: 0x06006D06 RID: 27910 RVA: 0x002D9558 File Offset: 0x002D7758
	public bool f()
	{
		return this.h;
	}

	// Token: 0x06006D07 RID: 27911 RVA: 0x002D9560 File Offset: 0x002D7760
	public void c(bool A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06006D08 RID: 27912 RVA: 0x002D956C File Offset: 0x002D776C
	public string i()
	{
		return this.o;
	}

	// Token: 0x06006D09 RID: 27913 RVA: 0x002D9574 File Offset: 0x002D7774
	public void a(string A_0)
	{
		this.o = A_0;
	}

	// Token: 0x06006D0A RID: 27914 RVA: 0x002D9580 File Offset: 0x002D7780
	public d2b(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006D0B RID: 27915 RVA: 0x002D95D8 File Offset: 0x002D77D8
	public bool b(bool A_0, bool A_1 = true)
	{
		if (!this.a)
		{
			this.a(true, new bool?(false));
			if (A_1)
			{
				aru aru = base.a8().c();
				if (aru != null)
				{
					if (this.b == LockType.Mechanical)
					{
						aru.a("lock_unlock", "LockMech", 1f, c9z.a, false, false);
					}
					else
					{
						aru.a("lock_unlock", "LockDigi", 1f, c9z.a, false, false);
					}
				}
			}
			if (A_0)
			{
				this.c(null);
			}
			return true;
		}
		return false;
	}

	// Token: 0x06006D0C RID: 27916 RVA: 0x002D9668 File Offset: 0x002D7868
	public bool a(bool A_0, bool A_1 = true)
	{
		if (this.a)
		{
			this.a(false, null);
			if (A_1)
			{
				aru aru = base.a8().c();
				if (aru != null)
				{
					if (this.b == LockType.Mechanical)
					{
						aru.a("lock_unlock", "UnlockMech", 1f, c9z.a, false, false);
					}
					else
					{
						aru.a("lock_unlock", "UnlockDigi", 1f, c9z.a, false, false);
					}
				}
			}
			if (A_0)
			{
				this.b(null);
			}
			return true;
		}
		return false;
	}

	// Token: 0x06006D0D RID: 27917 RVA: 0x002D96FC File Offset: 0x002D78FC
	public c9b a(amc A_0, bool A_1 = false)
	{
		if (A_0 == null || A_0.aa() == null)
		{
			return c9b.h;
		}
		if (this.j() == LockType.Electronic && !base.a8().a() && (A_0.a8().s.b == null || !A_0.a8().s.b.z()))
		{
			return c9b.g;
		}
		if (!this.a)
		{
			return c9b.d;
		}
		if (string.IsNullOrEmpty(this.e))
		{
			return c9b.c;
		}
		coh coh = this.a(A_0.aa());
		if (coh != null)
		{
			if (!A_1)
			{
				this.a(true, true);
				if (this.f)
				{
					bool flag = (A_0.a8().g & e2b.d) > (e2b)0;
					if (coh.Stacks > 1)
					{
						coh coh2 = coh;
						int num = coh2.Stacks;
						coh2.Stacks = num - 1;
						coh coh3 = coh.fy();
						coh3.Stacks = 1;
						if (flag)
						{
							a7v.a(new aub(coh3));
						}
					}
					else
					{
						A_0.aa().Bag.z5(coh);
						if (flag)
						{
							a7v.a(new aub(coh));
						}
					}
				}
				this.b(A_0);
			}
			return c9b.a;
		}
		return c9b.b;
	}

	// Token: 0x06006D0E RID: 27918 RVA: 0x002D9834 File Offset: 0x002D7A34
	public c9b c(amc A_0)
	{
		if (A_0 == null || A_0.aa() == null)
		{
			return c9b.h;
		}
		if (this.j() == LockType.Electronic && !base.a8().a() && (A_0.a8().s.b == null || !A_0.a8().s.b.z()))
		{
			return c9b.g;
		}
		if (this.a)
		{
			return c9b.d;
		}
		if (base.a8() != null)
		{
			b0e b0e = base.a8().s.b as b0e;
			if (b0e != null && b0e.q())
			{
				return c9b.f;
			}
		}
		if (string.IsNullOrEmpty(this.e) || !this.g)
		{
			return c9b.c;
		}
		if (this.a(A_0.aa()) != null)
		{
			this.b(true, true);
			this.b(A_0);
			return c9b.a;
		}
		return c9b.b;
	}

	// Token: 0x06006D0F RID: 27919 RVA: 0x002D9924 File Offset: 0x002D7B24
	public c9b a(amc A_0, LockType A_1, int A_2)
	{
		if (A_0 == null || A_0.aa() == null)
		{
			return c9b.h;
		}
		if (this.b != A_1)
		{
			return c9b.e;
		}
		if (this.j() == LockType.Electronic && !base.a8().a() && (A_0.a8().s.b == null || !A_0.a8().s.b.z()))
		{
			return c9b.g;
		}
		if (!this.a)
		{
			return c9b.d;
		}
		if (!this.c)
		{
			return c9b.c;
		}
		c9b result;
		try
		{
			int num;
			if (this.b == LockType.Mechanical)
			{
				num = A_0.aa().Skills.b(typeof(dca)).g();
			}
			else
			{
				num = A_0.aa().Skills.b(typeof(adx)).g();
			}
			num += A_2;
			if (num >= this.d)
			{
				this.a(false, new bool?(true));
				this.a(A_0.a8());
				result = c9b.a;
			}
			else
			{
				result = c9b.b;
			}
		}
		finally
		{
			this.a(A_0);
		}
		return result;
	}

	// Token: 0x06006D10 RID: 27920 RVA: 0x002D9A5C File Offset: 0x002D7C5C
	public void b(amc A_0)
	{
		if (this.n == d1c.c && base.a8() != null && A_0 != null)
		{
			c3g aspect = base.a8().GetAspect<c3g>();
			if (aspect != null)
			{
				d2b.a(A_0, aspect);
			}
		}
	}

	// Token: 0x06006D11 RID: 27921 RVA: 0x002D9AA0 File Offset: 0x002D7CA0
	private static void a(amc A_0, c3g A_1)
	{
		if (A_1.a(A_0) && A_1.e())
		{
			a7v.a(new ehr("Ваши действия спровоцировали враждебность."));
		}
	}

	// Token: 0x06006D12 RID: 27922 RVA: 0x002D9ACC File Offset: 0x002D7CCC
	private void a(amc A_0)
	{
		if (this.n != d1c.a && base.a8() != null && A_0 != null)
		{
			c3g aspect = base.a8().GetAspect<c3g>();
			if (aspect != null)
			{
				d2b.a(A_0, aspect);
			}
		}
	}

	// Token: 0x06006D13 RID: 27923 RVA: 0x002D9B10 File Offset: 0x002D7D10
	private void c(b0b A_0)
	{
		foreach (cze cze in this.k)
		{
			if (cze != null)
			{
				cze.ym(A_0, base.a8(), a3f.a(base.a8()));
			}
		}
	}

	// Token: 0x06006D14 RID: 27924 RVA: 0x002D9B80 File Offset: 0x002D7D80
	private void b(b0b A_0)
	{
		foreach (cze cze in this.j)
		{
			if (cze != null)
			{
				cze.ym(A_0, base.a8(), a3f.a(base.a8()));
			}
		}
	}

	// Token: 0x06006D15 RID: 27925 RVA: 0x002D9BF0 File Offset: 0x002D7DF0
	private void a(b0b A_0)
	{
		foreach (cze cze in this.l)
		{
			if (cze != null)
			{
				cze.ym(A_0, base.a8(), a3f.a(base.a8()));
			}
		}
	}

	// Token: 0x06006D16 RID: 27926 RVA: 0x002D9C60 File Offset: 0x002D7E60
	private coh a(efk A_0)
	{
		if (A_0 == null)
		{
			return null;
		}
		return A_0.a(this.e, false);
	}

	// Token: 0x06006D17 RID: 27927 RVA: 0x002D9C78 File Offset: 0x002D7E78
	private void a(bool A_0, bool? A_1 = null)
	{
		this.e(A_0);
		if (A_1 != null)
		{
			this.h = A_1.Value;
		}
		if (A_0)
		{
			this.i = 0.0;
		}
		if (base.a8() != null)
		{
			cnb cnb = base.a8().GetAspect<bim>() as cnb;
			if (cnb != null && cnb.b() != null)
			{
				c5x c5x = new ar7(cnb.b().Value, cnb.a8().Area).ao() as c5x;
				if (c5x != null)
				{
					d2b aspect = c5x.GetAspect<d2b>();
					if (aspect != null)
					{
						aspect.e(A_0);
						if (A_1 != null)
						{
							aspect.h = A_1.Value;
						}
						if (A_0)
						{
							aspect.i = 0.0;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006D18 RID: 27928 RVA: 0x002D9D60 File Offset: 0x002D7F60
	private void a()
	{
		if (this.m == null)
		{
			this.m = new List<cze>();
			return;
		}
		foreach (cze cze in this.m)
		{
			if (cze != null)
			{
				cze.ym(null, base.a8(), a3f.a(base.a8()));
			}
		}
	}

	// Token: 0x04002CA6 RID: 11430
	private bool a;

	// Token: 0x04002CA7 RID: 11431
	private LockType b;

	// Token: 0x04002CA8 RID: 11432
	private bool c = true;

	// Token: 0x04002CA9 RID: 11433
	private int d;

	// Token: 0x04002CAA RID: 11434
	private string e;

	// Token: 0x04002CAB RID: 11435
	private bool f;

	// Token: 0x04002CAC RID: 11436
	private bool g;

	// Token: 0x04002CAD RID: 11437
	private bool h;

	// Token: 0x04002CAE RID: 11438
	private double i = 1.0;

	// Token: 0x04002CAF RID: 11439
	private List<cze> j = new List<cze>();

	// Token: 0x04002CB0 RID: 11440
	private List<cze> k = new List<cze>();

	// Token: 0x04002CB1 RID: 11441
	private List<cze> l = new List<cze>();

	// Token: 0x04002CB2 RID: 11442
	private List<cze> m = new List<cze>();

	// Token: 0x04002CB3 RID: 11443
	private d1c n;

	// Token: 0x04002CB4 RID: 11444
	private string o;
}
