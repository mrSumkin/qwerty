using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x02000289 RID: 649
[eiz("AM")]
[Serializable]
public sealed class ix : cix, dcm, ISerializable
{
	// Token: 0x060012EF RID: 4847 RVA: 0x0004E968 File Offset: 0x0004CB68
	private ix(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (c1a)A_0.GetValue("AM:Z", typeof(c1a));
			di7.ReadList<e36>("AM:A", ref this.b, A_0);
			return;
		}
		if (base.GetType() == typeof(ix))
		{
			this.a = (c1a)A_0.GetValue("_Zone", typeof(c1a));
			this.b = (List<e36>)A_0.GetValue("_Actions", typeof(List<e36>));
			return;
		}
		this.a = (c1a)A_0.GetValue("ActionManager+_Zone", typeof(c1a));
		this.b = (List<e36>)A_0.GetValue("ActionManager+_Actions", typeof(List<e36>));
	}

	// Token: 0x060012F0 RID: 4848 RVA: 0x0004EA60 File Offset: 0x0004CC60
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("AM:Z", this.a);
		di7.WriteList<e36>("AM:A", this.b, info);
	}

	// Token: 0x060012F1 RID: 4849 RVA: 0x0004EA84 File Offset: 0x0004CC84
	public c1a g7()
	{
		return this.a;
	}

	// Token: 0x060012F2 RID: 4850 RVA: 0x0004EA8C File Offset: 0x0004CC8C
	public bool bb()
	{
		return this.c;
	}

	// Token: 0x060012F3 RID: 4851 RVA: 0x0004EA94 File Offset: 0x0004CC94
	public List<e36> g8()
	{
		return this.b;
	}

	// Token: 0x060012F4 RID: 4852 RVA: 0x0004EA9C File Offset: 0x0004CC9C
	public ix(c1a A_0)
	{
		this.a = A_0;
		this.bc(true);
	}

	// Token: 0x060012F5 RID: 4853 RVA: 0x0004EAC0 File Offset: 0x0004CCC0
	public void a(TimeSpan A_0, TimeSpan A_1)
	{
		foreach (e36 e in Enumerable.ToList<e36>(this.b))
		{
			if (!e.c)
			{
				auv auv = e.a;
				dc4 dc = auv.n(A_0, A_1);
				if (dc != dc4.b && !e.c)
				{
					if (e.b == atp.a || (dc == dc4.e && e.b == atp.c))
					{
						this.b.Remove(e);
					}
					else
					{
						this.b(auv);
					}
				}
			}
		}
	}

	// Token: 0x060012F6 RID: 4854 RVA: 0x0004EB7C File Offset: 0x0004CD7C
	public void g9(auv A_0, atp A_1 = atp.a)
	{
		czh.a(A_0, "action");
		if (this.b(A_0))
		{
			this.b.Add(new e36(A_0, A_1));
		}
	}

	// Token: 0x060012F7 RID: 4855 RVA: 0x0004EBA8 File Offset: 0x0004CDA8
	public void ha(auv A_0)
	{
		czh.a(A_0, "action");
		e36 e = this.a(A_0);
		if (e != null)
		{
			this.a(e);
		}
	}

	// Token: 0x060012F8 RID: 4856 RVA: 0x0004EBD8 File Offset: 0x0004CDD8
	public void hb(Guid A_0)
	{
		e36 e = this.a(A_0);
		if (e != null)
		{
			this.a(e);
		}
	}

	// Token: 0x060012F9 RID: 4857 RVA: 0x0004EBFC File Offset: 0x0004CDFC
	public bool hc(Guid A_0, atp A_1)
	{
		e36 e = this.a(A_0);
		if (e != null)
		{
			e.b = A_1;
			return true;
		}
		return false;
	}

	// Token: 0x060012FA RID: 4858 RVA: 0x0004EC24 File Offset: 0x0004CE24
	public bool hd(auv A_0, atp A_1)
	{
		e36 e = this.a(A_0);
		if (e != null)
		{
			e.b = A_1;
			return true;
		}
		return false;
	}

	// Token: 0x060012FB RID: 4859 RVA: 0x0004EC4C File Offset: 0x0004CE4C
	public atp? he(auv A_0)
	{
		e36 e = this.a(A_0);
		if (e != null)
		{
			return new atp?(e.b);
		}
		return null;
	}

	// Token: 0x060012FC RID: 4860 RVA: 0x0004EC7C File Offset: 0x0004CE7C
	public az0 a()
	{
		if (this.c)
		{
			throw new Exception("Must uninitialize zone first before exporting actions.");
		}
		az0 az = new az0();
		foreach (e36 e in this.b)
		{
			if (!e.c)
			{
				az.b.Add(e);
			}
		}
		return az;
	}

	// Token: 0x060012FD RID: 4861 RVA: 0x0004ED04 File Offset: 0x0004CF04
	public void a(az0 A_0)
	{
		if (this.c)
		{
			throw new Exception("Must uninitialize zone first before importing actions.");
		}
		if (A_0 != null && A_0.b != null)
		{
			foreach (e36 item in A_0.b)
			{
				this.b.Add(item);
			}
		}
	}

	// Token: 0x060012FE RID: 4862 RVA: 0x0004ED8C File Offset: 0x0004CF8C
	public bool bc(bool A_0)
	{
		if (this.c)
		{
			return false;
		}
		if (A_0)
		{
			foreach (e36 e in this.b)
			{
				dvv dvv = e.a as dvv;
				if (dvv != null)
				{
					dvv.z(this);
				}
				dcm dcm = e.a as dcm;
				if (dcm != null)
				{
					dcm.bc(true);
				}
			}
		}
		this.c = true;
		return true;
	}

	// Token: 0x060012FF RID: 4863 RVA: 0x0004EE2C File Offset: 0x0004D02C
	public bool bd(bool A_0)
	{
		if (!this.c)
		{
			return false;
		}
		if (A_0)
		{
			foreach (e36 e in this.b)
			{
				dcm dcm = e.a as dcm;
				if (dcm != null)
				{
					dcm.bd(true);
				}
			}
		}
		this.c = false;
		return true;
	}

	// Token: 0x06001300 RID: 4864 RVA: 0x0004EEB4 File Offset: 0x0004D0B4
	public void hf(az0 A_0)
	{
		if (A_0 != null)
		{
			foreach (e36 item in A_0.b)
			{
				this.b.Add(item);
			}
		}
	}

	// Token: 0x06001301 RID: 4865 RVA: 0x0004EF18 File Offset: 0x0004D118
	public auv hg(Guid A_0)
	{
		foreach (e36 e in this.b)
		{
			if (e.a != null && e.a.Id == A_0)
			{
				return e.a;
			}
		}
		return null;
	}

	// Token: 0x06001302 RID: 4866 RVA: 0x0004EF9C File Offset: 0x0004D19C
	private void a(e36 A_0)
	{
		A_0.c = true;
		if (this.b.Remove(A_0))
		{
			A_0.a.k();
		}
	}

	// Token: 0x06001303 RID: 4867 RVA: 0x0004EFC4 File Offset: 0x0004D1C4
	private bool b(auv A_0)
	{
		return A_0.v(this);
	}

	// Token: 0x06001304 RID: 4868 RVA: 0x0004EFD0 File Offset: 0x0004D1D0
	private e36 a(Guid A_0)
	{
		ix.a a = new ix.a();
		a.a = A_0;
		return Enumerable.FirstOrDefault<e36>(Enumerable.Where<e36>(this.b, new Func<e36, bool>(a.a)));
	}

	// Token: 0x06001305 RID: 4869 RVA: 0x0004F008 File Offset: 0x0004D208
	private e36 a(auv A_0)
	{
		ix.b b = new ix.b();
		b.a = A_0;
		return Enumerable.FirstOrDefault<e36>(Enumerable.Where<e36>(this.b, new Func<e36, bool>(b.a)));
	}

	// Token: 0x04000A60 RID: 2656
	private c1a a;

	// Token: 0x04000A61 RID: 2657
	private List<e36> b = new List<e36>();

	// Token: 0x04000A62 RID: 2658
	[NonSerialized]
	private bool c;

	// Token: 0x0200028B RID: 651
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x06001311 RID: 4881 RVA: 0x0004F048 File Offset: 0x0004D248
		internal bool a(e36 A_0)
		{
			return A_0.a.Id == this.a;
		}

		// Token: 0x04000A63 RID: 2659
		public Guid a;
	}

	// Token: 0x0200028C RID: 652
	[CompilerGenerated]
	private sealed class b
	{
		// Token: 0x06001313 RID: 4883 RVA: 0x0004F068 File Offset: 0x0004D268
		internal bool a(e36 A_0)
		{
			return A_0.a == this.a;
		}

		// Token: 0x04000A64 RID: 2660
		public auv a;
	}
}
