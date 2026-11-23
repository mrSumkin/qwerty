using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010EE RID: 4334
[eiz("UOP")]
[Serializable]
public sealed class aql : cze, ISerializable
{
	// Token: 0x06005BA2 RID: 23458 RVA: 0x002757D0 File Offset: 0x002739D0
	private aql(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid?)A_0.GetValue("UOP:I", typeof(Guid?));
		this.b = A_0.GetString("UOP:A");
		this.c = A_0.GetBoolean("UOP:R");
		this.d = A_0.GetBoolean("UOP:CO");
		this.e = A_0.GetBoolean("UOP:COF");
		this.f = A_0.GetBoolean("UOP:CP");
		this.g = A_0.GetBoolean("UOP:CPF");
		this.h = (A_0.GetValue("UOP:OTA", typeof(List<string>)) as List<string>);
		this.i = (A_0.GetValue("UOP:OTR", typeof(List<string>)) as List<string>);
		this.j = (A_0.GetValue("UOP:OFTA", typeof(List<string>)) as List<string>);
		this.k = (A_0.GetValue("UOP:OFTR", typeof(List<string>)) as List<string>);
		this.l = (A_0.GetValue("UOP:PTA", typeof(List<string>)) as List<string>);
		this.m = (A_0.GetValue("UOP:PTR", typeof(List<string>)) as List<string>);
		this.n = (A_0.GetValue("UOP:PFTA", typeof(List<string>)) as List<string>);
		this.o = (A_0.GetValue("UOP:PFTR", typeof(List<string>)) as List<string>);
		this.p = (A_0.GetValue("UOP:BM", typeof(c2n?)) as c2n?);
		this.q = (A_0.GetValue("UOP:PE", typeof(bool?)) as bool?);
	}

	// Token: 0x06005BA3 RID: 23459 RVA: 0x00275A1C File Offset: 0x00273C1C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("UOP:I", this.a);
		info.AddValue("UOP:A", this.b);
		info.AddValue("UOP:R", this.c);
		info.AddValue("UOP:CO", this.d);
		info.AddValue("UOP:COF", this.e);
		info.AddValue("UOP:CP", this.f);
		info.AddValue("UOP:CPF", this.g);
		info.AddValue("UOP:OTA", this.h);
		info.AddValue("UOP:OTR", this.i);
		info.AddValue("UOP:OFTA", this.j);
		info.AddValue("UOP:OFTR", this.k);
		info.AddValue("UOP:PTA", this.l);
		info.AddValue("UOP:PTR", this.m);
		info.AddValue("UOP:PFTA", this.n);
		info.AddValue("UOP:PFTR", this.o);
		info.AddValue("UOP:BM", this.p);
		info.AddValue("UOP:PE", this.q);
	}

	// Token: 0x06005BA4 RID: 23460 RVA: 0x00275B64 File Offset: 0x00273D64
	public string g()
	{
		return this.b;
	}

	// Token: 0x06005BA5 RID: 23461 RVA: 0x00275B6C File Offset: 0x00273D6C
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005BA6 RID: 23462 RVA: 0x00275B78 File Offset: 0x00273D78
	public Guid? p()
	{
		return this.a;
	}

	// Token: 0x06005BA7 RID: 23463 RVA: 0x00275B80 File Offset: 0x00273D80
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005BA8 RID: 23464 RVA: 0x00275B8C File Offset: 0x00273D8C
	public bool j()
	{
		return this.c;
	}

	// Token: 0x06005BA9 RID: 23465 RVA: 0x00275B94 File Offset: 0x00273D94
	public void d(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005BAA RID: 23466 RVA: 0x00275BA0 File Offset: 0x00273DA0
	public bool b()
	{
		return this.d;
	}

	// Token: 0x06005BAB RID: 23467 RVA: 0x00275BA8 File Offset: 0x00273DA8
	public void c(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005BAC RID: 23468 RVA: 0x00275BB4 File Offset: 0x00273DB4
	public bool q()
	{
		return this.e;
	}

	// Token: 0x06005BAD RID: 23469 RVA: 0x00275BBC File Offset: 0x00273DBC
	public void a(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06005BAE RID: 23470 RVA: 0x00275BC8 File Offset: 0x00273DC8
	public bool f()
	{
		return this.f;
	}

	// Token: 0x06005BAF RID: 23471 RVA: 0x00275BD0 File Offset: 0x00273DD0
	public void b(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06005BB0 RID: 23472 RVA: 0x00275BDC File Offset: 0x00273DDC
	public bool m()
	{
		return this.g;
	}

	// Token: 0x06005BB1 RID: 23473 RVA: 0x00275BE4 File Offset: 0x00273DE4
	public void e(bool A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06005BB2 RID: 23474 RVA: 0x00275BF0 File Offset: 0x00273DF0
	public List<string> l()
	{
		return this.h;
	}

	// Token: 0x06005BB3 RID: 23475 RVA: 0x00275BF8 File Offset: 0x00273DF8
	public void a(List<string> A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06005BB4 RID: 23476 RVA: 0x00275C04 File Offset: 0x00273E04
	public List<string> d()
	{
		return this.i;
	}

	// Token: 0x06005BB5 RID: 23477 RVA: 0x00275C0C File Offset: 0x00273E0C
	public void e(List<string> A_0)
	{
		this.i = A_0;
	}

	// Token: 0x06005BB6 RID: 23478 RVA: 0x00275C18 File Offset: 0x00273E18
	public List<string> o()
	{
		return this.j;
	}

	// Token: 0x06005BB7 RID: 23479 RVA: 0x00275C20 File Offset: 0x00273E20
	public void h(List<string> A_0)
	{
		this.j = A_0;
	}

	// Token: 0x06005BB8 RID: 23480 RVA: 0x00275C2C File Offset: 0x00273E2C
	public List<string> i()
	{
		return this.k;
	}

	// Token: 0x06005BB9 RID: 23481 RVA: 0x00275C34 File Offset: 0x00273E34
	public void c(List<string> A_0)
	{
		this.k = A_0;
	}

	// Token: 0x06005BBA RID: 23482 RVA: 0x00275C40 File Offset: 0x00273E40
	public List<string> e()
	{
		return this.l;
	}

	// Token: 0x06005BBB RID: 23483 RVA: 0x00275C48 File Offset: 0x00273E48
	public void d(List<string> A_0)
	{
		this.l = A_0;
	}

	// Token: 0x06005BBC RID: 23484 RVA: 0x00275C54 File Offset: 0x00273E54
	public List<string> a()
	{
		return this.m;
	}

	// Token: 0x06005BBD RID: 23485 RVA: 0x00275C5C File Offset: 0x00273E5C
	public void f(List<string> A_0)
	{
		this.m = A_0;
	}

	// Token: 0x06005BBE RID: 23486 RVA: 0x00275C68 File Offset: 0x00273E68
	public List<string> n()
	{
		return this.n;
	}

	// Token: 0x06005BBF RID: 23487 RVA: 0x00275C70 File Offset: 0x00273E70
	public void g(List<string> A_0)
	{
		this.n = A_0;
	}

	// Token: 0x06005BC0 RID: 23488 RVA: 0x00275C7C File Offset: 0x00273E7C
	public List<string> h()
	{
		return this.o;
	}

	// Token: 0x06005BC1 RID: 23489 RVA: 0x00275C84 File Offset: 0x00273E84
	public void b(List<string> A_0)
	{
		this.o = A_0;
	}

	// Token: 0x06005BC2 RID: 23490 RVA: 0x00275C90 File Offset: 0x00273E90
	public c2n? c()
	{
		return this.p;
	}

	// Token: 0x06005BC3 RID: 23491 RVA: 0x00275C98 File Offset: 0x00273E98
	public void a(c2n? A_0)
	{
		this.p = A_0;
	}

	// Token: 0x06005BC4 RID: 23492 RVA: 0x00275CA4 File Offset: 0x00273EA4
	public bool? k()
	{
		return this.q;
	}

	// Token: 0x06005BC5 RID: 23493 RVA: 0x00275CAC File Offset: 0x00273EAC
	public void a(bool? A_0)
	{
		this.q = A_0;
	}

	// Token: 0x06005BC6 RID: 23494 RVA: 0x00275CB8 File Offset: 0x00273EB8
	public aql()
	{
	}

	// Token: 0x06005BC7 RID: 23495 RVA: 0x00275D30 File Offset: 0x00273F30
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.a != null)
		{
			aud aud = null;
			if (this.b != null)
			{
				aud = A_1.Zone.n(this.b);
			}
			else if (A_1 != null)
			{
				aud = A_1.Area;
			}
			if (aud != null)
			{
				c5x = (new ar7(this.a.Value, aud).ao() as c5x);
			}
		}
		else
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null)
		{
			c3g aspect = c5x.GetAspect<c3g>();
			if (aspect != null)
			{
				if (this.c)
				{
					c5x.RemoveAspect<c3g>();
					return;
				}
				if (this.p != null)
				{
					aspect.a(this.p.Value);
				}
				if (this.q != null)
				{
					aspect.a(this.q.Value);
				}
				if (this.d)
				{
					aspect.f().Clear();
				}
				if (this.e)
				{
					aspect.b().Clear();
				}
				if (this.f)
				{
					aspect.g().Clear();
				}
				if (this.g)
				{
					aspect.d().Clear();
				}
				foreach (string item in this.i)
				{
					aspect.f().Remove(item);
				}
				foreach (string item2 in this.k)
				{
					aspect.b().Remove(item2);
				}
				foreach (string item3 in this.m)
				{
					aspect.g().Remove(item3);
				}
				foreach (string item4 in this.o)
				{
					aspect.d().Remove(item4);
				}
				foreach (string item5 in this.h)
				{
					aspect.f().Add(item5);
				}
				foreach (string item6 in this.j)
				{
					aspect.b().Add(item6);
				}
				foreach (string item7 in this.l)
				{
					aspect.g().Add(item7);
				}
				foreach (string item8 in this.n)
				{
					aspect.d().Add(item8);
				}
			}
		}
	}

	// Token: 0x0400249D RID: 9373
	private new Guid? a;

	// Token: 0x0400249E RID: 9374
	private string b;

	// Token: 0x0400249F RID: 9375
	private bool c;

	// Token: 0x040024A0 RID: 9376
	private bool d;

	// Token: 0x040024A1 RID: 9377
	private bool e;

	// Token: 0x040024A2 RID: 9378
	private bool f;

	// Token: 0x040024A3 RID: 9379
	private bool g;

	// Token: 0x040024A4 RID: 9380
	private List<string> h = new List<string>();

	// Token: 0x040024A5 RID: 9381
	private List<string> i = new List<string>();

	// Token: 0x040024A6 RID: 9382
	private List<string> j = new List<string>();

	// Token: 0x040024A7 RID: 9383
	private List<string> k = new List<string>();

	// Token: 0x040024A8 RID: 9384
	private List<string> l = new List<string>();

	// Token: 0x040024A9 RID: 9385
	private List<string> m = new List<string>();

	// Token: 0x040024AA RID: 9386
	private List<string> n = new List<string>();

	// Token: 0x040024AB RID: 9387
	private List<string> o = new List<string>();

	// Token: 0x040024AC RID: 9388
	private c2n? p;

	// Token: 0x040024AD RID: 9389
	private bool? q = new bool?(true);
}
