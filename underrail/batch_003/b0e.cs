using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020012B4 RID: 4788
[a(typeof(bim))]
[eiz("OCUEA")]
[Serializable]
public class b0e : bim, ISerializable
{
	// Token: 0x06006936 RID: 26934 RVA: 0x002C64C0 File Offset: 0x002C46C0
	protected b0e(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetBoolean("OCUEA:O");
			this.b = A_0.GetBoolean("OCUEA:SS");
			this.c = (int?)A_0.GetValue("OCUEA:OSF", typeof(int?));
			this.d = (int?)A_0.GetValue("OCUEA:CSF", typeof(int?));
			di7.ReadList<cze>("OCUEA:OOJ", ref this.e, A_0);
			di7.ReadList<cze>("OCUEA:OCJ", ref this.f, A_0);
			if (ell.a() >= 8)
			{
				this.h = A_0.GetString("OCUEA:OS");
				this.i = A_0.GetString("OCUEA:CS");
			}
			if (ell.a() >= 347)
			{
				di7.ReadList<cze>("OCUEA:OOFT", ref this.g, A_0);
				this.j = A_0.GetBoolean("OCUEA:FTO");
				return;
			}
		}
		else
		{
			this.a = A_0.GetBoolean("_Opened");
			this.b = A_0.GetBoolean("_SimpleStates");
			this.c = (A_0.GetValue("_OpenedStateFrame", typeof(int?)) as int?);
			this.d = (A_0.GetValue("_ClosedStateFrame", typeof(int?)) as int?);
			try
			{
				di7.ReadList<cze>("_OnOpenedJobs", ref this.e, A_0);
				di7.ReadList<cze>("_OnClosedJobs", ref this.f, A_0);
			}
			catch
			{
			}
		}
	}

	// Token: 0x06006937 RID: 26935 RVA: 0x002C668C File Offset: 0x002C488C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("OCUEA:O", this.a);
		info.AddValue("OCUEA:SS", this.b);
		info.AddValue("OCUEA:OSF", this.c);
		info.AddValue("OCUEA:CSF", this.d);
		di7.WriteList<cze>("OCUEA:OOJ", this.e, info);
		di7.WriteList<cze>("OCUEA:OCJ", this.f, info);
		di7.WriteList<cze>("OCUEA:OOFT", this.g, info);
		info.AddValue("OCUEA:OS", this.h);
		info.AddValue("OCUEA:CS", this.i);
		info.AddValue("OCUEA:FTO", this.j);
	}

	// Token: 0x06006938 RID: 26936 RVA: 0x002C6758 File Offset: 0x002C4958
	public new bool q()
	{
		return this.a;
	}

	// Token: 0x06006939 RID: 26937 RVA: 0x002C6760 File Offset: 0x002C4960
	public void d(bool A_0)
	{
		this.af3(A_0);
	}

	// Token: 0x0600693A RID: 26938 RVA: 0x002C676C File Offset: 0x002C496C
	public bool o()
	{
		return this.b;
	}

	// Token: 0x0600693B RID: 26939 RVA: 0x002C6774 File Offset: 0x002C4974
	public void c(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600693C RID: 26940 RVA: 0x002C6780 File Offset: 0x002C4980
	public new int? j()
	{
		return this.c;
	}

	// Token: 0x0600693D RID: 26941 RVA: 0x002C6788 File Offset: 0x002C4988
	public void a(int? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600693E RID: 26942 RVA: 0x002C6794 File Offset: 0x002C4994
	public new int? l()
	{
		return this.d;
	}

	// Token: 0x0600693F RID: 26943 RVA: 0x002C679C File Offset: 0x002C499C
	public void b(int? A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006940 RID: 26944 RVA: 0x002C67A8 File Offset: 0x002C49A8
	public new List<cze> p()
	{
		return this.f;
	}

	// Token: 0x06006941 RID: 26945 RVA: 0x002C67B0 File Offset: 0x002C49B0
	public void a(List<cze> A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06006942 RID: 26946 RVA: 0x002C67BC File Offset: 0x002C49BC
	public List<cze> i()
	{
		return this.e;
	}

	// Token: 0x06006943 RID: 26947 RVA: 0x002C67C4 File Offset: 0x002C49C4
	public void b(List<cze> A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006944 RID: 26948 RVA: 0x002C67D0 File Offset: 0x002C49D0
	public List<cze> m()
	{
		return this.g;
	}

	// Token: 0x06006945 RID: 26949 RVA: 0x002C67D8 File Offset: 0x002C49D8
	public void c(List<cze> A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06006946 RID: 26950 RVA: 0x002C67E4 File Offset: 0x002C49E4
	public string n()
	{
		return this.h;
	}

	// Token: 0x06006947 RID: 26951 RVA: 0x002C67EC File Offset: 0x002C49EC
	public void c(string A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06006948 RID: 26952 RVA: 0x002C67F8 File Offset: 0x002C49F8
	public new string k()
	{
		return this.i;
	}

	// Token: 0x06006949 RID: 26953 RVA: 0x002C6800 File Offset: 0x002C4A00
	public void d(string A_0)
	{
		this.i = A_0;
	}

	// Token: 0x0600694A RID: 26954 RVA: 0x002C680C File Offset: 0x002C4A0C
	public b0e(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x0600694B RID: 26955 RVA: 0x002C6838 File Offset: 0x002C4A38
	public void b(bool A_0)
	{
		if (this.a != A_0)
		{
			this.mz(null, null);
		}
	}

	// Token: 0x0600694C RID: 26956 RVA: 0x002C6850 File Offset: 0x002C4A50
	protected override void mz(c5x A_0, string A_1 = null)
	{
		this.d(!this.q());
		if (this.q())
		{
			this.af4(A_0);
			return;
		}
		this.af5(A_0);
	}

	// Token: 0x0600694D RID: 26957 RVA: 0x002C6888 File Offset: 0x002C4A88
	protected virtual void af4(c5x A_0)
	{
		if (!string.IsNullOrEmpty(this.h))
		{
			aru aru = base.a8().c();
			if (aru != null)
			{
				aru.a("open_close", false);
				aru.a("open_close", this.h, 1f, c9z.a, false, false);
			}
		}
		if (this.e != null)
		{
			foreach (cze cze in this.e)
			{
				if (cze != null)
				{
					cze.ym(A_0, base.a8(), a3f.a(base.a8()));
				}
			}
		}
		if (!this.j && this.g != null)
		{
			this.j = true;
			foreach (cze cze2 in this.g)
			{
				if (cze2 != null)
				{
					cze2.ym(A_0, base.a8(), a3f.a(base.a8()));
				}
			}
		}
	}

	// Token: 0x0600694E RID: 26958 RVA: 0x002C69C8 File Offset: 0x002C4BC8
	protected virtual void af5(c5x A_0)
	{
		if (!string.IsNullOrEmpty(this.i))
		{
			aru aru = base.a8().c();
			if (aru != null)
			{
				aru.a("open_close", false);
				aru.a("open_close", this.i, 1f, c9z.a, false, false);
			}
		}
		if (this.f != null)
		{
			foreach (cze cze in this.f)
			{
				if (cze != null)
				{
					cze.ym(A_0, base.a8(), a3f.a(base.a8()));
				}
			}
		}
	}

	// Token: 0x0600694F RID: 26959 RVA: 0x002C6A8C File Offset: 0x002C4C8C
	protected override void m0(c5x A_0, c3g A_1, string A_2)
	{
		if (base.a8() == null)
		{
			base.m0(A_0, A_1, A_2);
			return;
		}
		d2b aspect = base.a8().GetAspect<d2b>();
		if (aspect != null)
		{
			aspect.b(A_0.h.b);
			return;
		}
		base.m0(A_0, A_1, A_2);
	}

	// Token: 0x06006950 RID: 26960 RVA: 0x002C6ADC File Offset: 0x002C4CDC
	protected virtual void af3(bool A_0)
	{
		if (A_0)
		{
			if (this.b && this.c != null)
			{
				this.b(this.c.Value);
			}
		}
		else if (this.b && this.d != null)
		{
			this.b(this.d.Value);
		}
		this.a = A_0;
	}

	// Token: 0x06006951 RID: 26961 RVA: 0x002C6B54 File Offset: 0x002C4D54
	protected virtual void b(int A_0)
	{
		cd0 cd = base.a8().o.b;
		if (cd != null)
		{
			cd.b = new Point(A_0, cd.b.Y);
		}
	}

	// Token: 0x04002B62 RID: 11106
	private new bool a;

	// Token: 0x04002B63 RID: 11107
	private bool b;

	// Token: 0x04002B64 RID: 11108
	private int? c;

	// Token: 0x04002B65 RID: 11109
	private int? d;

	// Token: 0x04002B66 RID: 11110
	private List<cze> e = new List<cze>();

	// Token: 0x04002B67 RID: 11111
	private List<cze> f = new List<cze>();

	// Token: 0x04002B68 RID: 11112
	private List<cze> g = new List<cze>();

	// Token: 0x04002B69 RID: 11113
	private string h;

	// Token: 0x04002B6A RID: 11114
	private string i;

	// Token: 0x04002B6B RID: 11115
	private new bool j;
}
