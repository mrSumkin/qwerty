using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001053 RID: 4179
[eiz("SFCPJ")]
[Serializable]
public sealed class dkz : cze, ISerializable
{
	// Token: 0x060056A1 RID: 22177 RVA: 0x0025FC24 File Offset: 0x0025DE24
	private dkz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("SFCPJ:I");
		this.b = A_0.GetBoolean("SFCPJ:R");
		this.c = A_0.GetBoolean("SFCPJ:CO");
		this.d = A_0.GetBoolean("SFCPJ:COF");
		this.e = A_0.GetBoolean("SFCPJ:CP");
		this.f = A_0.GetBoolean("SFCPJ:CPF");
		this.g = (A_0.GetValue("SFCPJ:OTA", typeof(List<string>)) as List<string>);
		this.h = (A_0.GetValue("SFCPJ:OTR", typeof(List<string>)) as List<string>);
		this.i = (A_0.GetValue("SFCPJ:OFTA", typeof(List<string>)) as List<string>);
		this.j = (A_0.GetValue("SFCPJ:OFTR", typeof(List<string>)) as List<string>);
		this.k = (A_0.GetValue("SFCPJ:PTA", typeof(List<string>)) as List<string>);
		this.l = (A_0.GetValue("SFCPJ:PTR", typeof(List<string>)) as List<string>);
		this.m = (A_0.GetValue("SFCPJ:PFTA", typeof(List<string>)) as List<string>);
		this.n = (A_0.GetValue("SFCPJ:PFTR", typeof(List<string>)) as List<string>);
		this.o = (A_0.GetValue("SFCPJ:BM", typeof(c2n?)) as c2n?);
		this.q = (A_0.GetValue("SFCPJ:CPM", typeof(ctz?)) as ctz?);
		this.p = (A_0.GetValue("SFCPJ:PE", typeof(bool?)) as bool?);
	}

	// Token: 0x060056A2 RID: 22178 RVA: 0x0025FE74 File Offset: 0x0025E074
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SFCPJ:I", this.a);
		info.AddValue("SFCPJ:R", this.b);
		info.AddValue("SFCPJ:CO", this.c);
		info.AddValue("SFCPJ:COF", this.d);
		info.AddValue("SFCPJ:CP", this.e);
		info.AddValue("SFCPJ:CPF", this.f);
		info.AddValue("SFCPJ:OTA", this.g);
		info.AddValue("SFCPJ:OTR", this.h);
		info.AddValue("SFCPJ:OFTA", this.i);
		info.AddValue("SFCPJ:OFTR", this.j);
		info.AddValue("SFCPJ:PTA", this.k);
		info.AddValue("SFCPJ:PTR", this.l);
		info.AddValue("SFCPJ:PFTA", this.m);
		info.AddValue("SFCPJ:PFTR", this.n);
		info.AddValue("SFCPJ:BM", this.o);
		info.AddValue("SFCPJ:CPM", this.q);
		info.AddValue("SFCPJ:PE", this.p);
	}

	// Token: 0x060056A3 RID: 22179 RVA: 0x0025FFBC File Offset: 0x0025E1BC
	public string f()
	{
		return this.a;
	}

	// Token: 0x060056A4 RID: 22180 RVA: 0x0025FFC4 File Offset: 0x0025E1C4
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060056A5 RID: 22181 RVA: 0x0025FFD0 File Offset: 0x0025E1D0
	public bool k()
	{
		return this.b;
	}

	// Token: 0x060056A6 RID: 22182 RVA: 0x0025FFD8 File Offset: 0x0025E1D8
	public void d(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060056A7 RID: 22183 RVA: 0x0025FFE4 File Offset: 0x0025E1E4
	public bool b()
	{
		return this.c;
	}

	// Token: 0x060056A8 RID: 22184 RVA: 0x0025FFEC File Offset: 0x0025E1EC
	public void c(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060056A9 RID: 22185 RVA: 0x0025FFF8 File Offset: 0x0025E1F8
	public bool q()
	{
		return this.d;
	}

	// Token: 0x060056AA RID: 22186 RVA: 0x00260000 File Offset: 0x0025E200
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060056AB RID: 22187 RVA: 0x0026000C File Offset: 0x0025E20C
	public bool g()
	{
		return this.e;
	}

	// Token: 0x060056AC RID: 22188 RVA: 0x00260014 File Offset: 0x0025E214
	public void b(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060056AD RID: 22189 RVA: 0x00260020 File Offset: 0x0025E220
	public bool n()
	{
		return this.f;
	}

	// Token: 0x060056AE RID: 22190 RVA: 0x00260028 File Offset: 0x0025E228
	public void e(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x060056AF RID: 22191 RVA: 0x00260034 File Offset: 0x0025E234
	public List<string> m()
	{
		return this.g;
	}

	// Token: 0x060056B0 RID: 22192 RVA: 0x0026003C File Offset: 0x0025E23C
	public void a(List<string> A_0)
	{
		this.g = A_0;
	}

	// Token: 0x060056B1 RID: 22193 RVA: 0x00260048 File Offset: 0x0025E248
	public List<string> d()
	{
		return this.h;
	}

	// Token: 0x060056B2 RID: 22194 RVA: 0x00260050 File Offset: 0x0025E250
	public void e(List<string> A_0)
	{
		this.h = A_0;
	}

	// Token: 0x060056B3 RID: 22195 RVA: 0x0026005C File Offset: 0x0025E25C
	public List<string> p()
	{
		return this.i;
	}

	// Token: 0x060056B4 RID: 22196 RVA: 0x00260064 File Offset: 0x0025E264
	public void h(List<string> A_0)
	{
		this.i = A_0;
	}

	// Token: 0x060056B5 RID: 22197 RVA: 0x00260070 File Offset: 0x0025E270
	public List<string> j()
	{
		return this.j;
	}

	// Token: 0x060056B6 RID: 22198 RVA: 0x00260078 File Offset: 0x0025E278
	public void c(List<string> A_0)
	{
		this.j = A_0;
	}

	// Token: 0x060056B7 RID: 22199 RVA: 0x00260084 File Offset: 0x0025E284
	public List<string> e()
	{
		return this.k;
	}

	// Token: 0x060056B8 RID: 22200 RVA: 0x0026008C File Offset: 0x0025E28C
	public void d(List<string> A_0)
	{
		this.k = A_0;
	}

	// Token: 0x060056B9 RID: 22201 RVA: 0x00260098 File Offset: 0x0025E298
	public List<string> a()
	{
		return this.l;
	}

	// Token: 0x060056BA RID: 22202 RVA: 0x002600A0 File Offset: 0x0025E2A0
	public void f(List<string> A_0)
	{
		this.l = A_0;
	}

	// Token: 0x060056BB RID: 22203 RVA: 0x002600AC File Offset: 0x0025E2AC
	public List<string> o()
	{
		return this.m;
	}

	// Token: 0x060056BC RID: 22204 RVA: 0x002600B4 File Offset: 0x0025E2B4
	public void g(List<string> A_0)
	{
		this.m = A_0;
	}

	// Token: 0x060056BD RID: 22205 RVA: 0x002600C0 File Offset: 0x0025E2C0
	public List<string> i()
	{
		return this.n;
	}

	// Token: 0x060056BE RID: 22206 RVA: 0x002600C8 File Offset: 0x0025E2C8
	public void b(List<string> A_0)
	{
		this.n = A_0;
	}

	// Token: 0x060056BF RID: 22207 RVA: 0x002600D4 File Offset: 0x0025E2D4
	public c2n? c()
	{
		return this.o;
	}

	// Token: 0x060056C0 RID: 22208 RVA: 0x002600DC File Offset: 0x0025E2DC
	public void a(c2n? A_0)
	{
		this.o = A_0;
	}

	// Token: 0x060056C1 RID: 22209 RVA: 0x002600E8 File Offset: 0x0025E2E8
	public ctz? h()
	{
		return this.q;
	}

	// Token: 0x060056C2 RID: 22210 RVA: 0x002600F0 File Offset: 0x0025E2F0
	public void a(ctz? A_0)
	{
		this.q = A_0;
	}

	// Token: 0x060056C3 RID: 22211 RVA: 0x002600FC File Offset: 0x0025E2FC
	public bool? l()
	{
		return this.p;
	}

	// Token: 0x060056C4 RID: 22212 RVA: 0x00260104 File Offset: 0x0025E304
	public void a(bool? A_0)
	{
		this.p = A_0;
	}

	// Token: 0x060056C5 RID: 22213 RVA: 0x00260110 File Offset: 0x0025E310
	public dkz()
	{
	}

	// Token: 0x060056C6 RID: 22214 RVA: 0x00260188 File Offset: 0x0025E388
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (!string.IsNullOrEmpty(this.a))
		{
			aud aud = cze.a(null, A_0, A_1, A_2);
			if (aud != null && aud.Zone != null)
			{
				d60 d = aud.Zone.a();
				if (d != null)
				{
					foreach (b0b b0b in d.ab4(new string[]
					{
						"FactionCorpse_" + this.a
					}))
					{
						c5x c5x = (c5x)b0b;
						if (c5x != null)
						{
							if (this.b)
							{
								c5x.RemoveAspect<c3g>();
							}
							else
							{
								c3g c3g = c5x.GetAspect<c3g>();
								if (c3g == null)
								{
									c3g = new c3g(c5x);
									c5x.SetAspect<c3g>(c3g);
								}
								if (this.o != null)
								{
									c3g.a(this.o.Value);
								}
								if (this.p != null)
								{
									c3g.a(this.p.Value);
								}
								if (this.c)
								{
									c3g.f().Clear();
								}
								if (this.d)
								{
									c3g.b().Clear();
								}
								if (this.e)
								{
									c3g.g().Clear();
								}
								if (this.f)
								{
									c3g.d().Clear();
								}
								foreach (string item in this.h)
								{
									c3g.f().Remove(item);
								}
								foreach (string item2 in this.j)
								{
									c3g.b().Remove(item2);
								}
								foreach (string item3 in this.l)
								{
									c3g.g().Remove(item3);
								}
								foreach (string item4 in this.n)
								{
									c3g.d().Remove(item4);
								}
								foreach (string item5 in this.g)
								{
									c3g.f().Contains(item5);
									c3g.f().Add(item5);
								}
								foreach (string item6 in this.i)
								{
									c3g.b().Contains(item6);
									c3g.b().Add(item6);
								}
								foreach (string item7 in this.k)
								{
									c3g.g().Contains(item7);
									c3g.g().Add(item7);
								}
								foreach (string item8 in this.m)
								{
									c3g.d().Contains(item8);
									c3g.d().Add(item8);
								}
							}
							if (this.q != null)
							{
								c7j c7j = c5x.GetAspect<bim>() as c7j;
								if (c7j != null)
								{
									c7j.ContainerProtectionMode = this.q.Value;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x04002321 RID: 8993
	private new string a;

	// Token: 0x04002322 RID: 8994
	private bool b;

	// Token: 0x04002323 RID: 8995
	private bool c;

	// Token: 0x04002324 RID: 8996
	private bool d;

	// Token: 0x04002325 RID: 8997
	private bool e;

	// Token: 0x04002326 RID: 8998
	private bool f;

	// Token: 0x04002327 RID: 8999
	private List<string> g = new List<string>();

	// Token: 0x04002328 RID: 9000
	private List<string> h = new List<string>();

	// Token: 0x04002329 RID: 9001
	private List<string> i = new List<string>();

	// Token: 0x0400232A RID: 9002
	private List<string> j = new List<string>();

	// Token: 0x0400232B RID: 9003
	private List<string> k = new List<string>();

	// Token: 0x0400232C RID: 9004
	private List<string> l = new List<string>();

	// Token: 0x0400232D RID: 9005
	private List<string> m = new List<string>();

	// Token: 0x0400232E RID: 9006
	private List<string> n = new List<string>();

	// Token: 0x0400232F RID: 9007
	private c2n? o;

	// Token: 0x04002330 RID: 9008
	private bool? p = new bool?(true);

	// Token: 0x04002331 RID: 9009
	private ctz? q;
}
