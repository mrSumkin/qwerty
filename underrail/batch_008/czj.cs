using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200103D RID: 4157
[eiz("CIYCPTJ")]
[Serializable]
public sealed class czj : cze
{
	// Token: 0x060055F3 RID: 22003 RVA: 0x0025D600 File Offset: 0x0025B800
	private czj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("CIYCPTJ:R");
		this.b = (Point)A_0.GetValue("CIYCPTJ:T", typeof(Point));
		this.c = A_0.GetString("CIYCPTJ:A");
		this.d = A_0.GetBoolean("CIYCPTJ:D");
		this.e = A_0.GetBoolean("CIYCPTJ:P");
		di7.ReadList<Guid>("CIYCPTJ:M", ref this.f, A_0);
	}

	// Token: 0x060055F4 RID: 22004 RVA: 0x0025D6A0 File Offset: 0x0025B8A0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CIYCPTJ:R", this.a);
		info.AddValue("CIYCPTJ:T", this.b);
		info.AddValue("CIYCPTJ:A", this.c);
		info.AddValue("CIYCPTJ:D", this.d);
		info.AddValue("CIYCPTJ:P", this.e);
		di7.WriteList<Guid>("CIYCPTJ:M", this.f, info);
	}

	// Token: 0x060055F5 RID: 22005 RVA: 0x0025D720 File Offset: 0x0025B920
	public string d()
	{
		return this.a;
	}

	// Token: 0x060055F6 RID: 22006 RVA: 0x0025D728 File Offset: 0x0025B928
	public void b(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060055F7 RID: 22007 RVA: 0x0025D734 File Offset: 0x0025B934
	public Point c()
	{
		return this.b;
	}

	// Token: 0x060055F8 RID: 22008 RVA: 0x0025D73C File Offset: 0x0025B93C
	public void a(Point A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060055F9 RID: 22009 RVA: 0x0025D748 File Offset: 0x0025B948
	public string e()
	{
		return this.c;
	}

	// Token: 0x060055FA RID: 22010 RVA: 0x0025D750 File Offset: 0x0025B950
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060055FB RID: 22011 RVA: 0x0025D75C File Offset: 0x0025B95C
	public bool b()
	{
		return this.d;
	}

	// Token: 0x060055FC RID: 22012 RVA: 0x0025D764 File Offset: 0x0025B964
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060055FD RID: 22013 RVA: 0x0025D770 File Offset: 0x0025B970
	public bool a()
	{
		return this.e;
	}

	// Token: 0x060055FE RID: 22014 RVA: 0x0025D778 File Offset: 0x0025B978
	public void b(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060055FF RID: 22015 RVA: 0x0025D784 File Offset: 0x0025B984
	public List<Guid> f()
	{
		return this.f;
	}

	// Token: 0x06005600 RID: 22016 RVA: 0x0025D78C File Offset: 0x0025B98C
	public void a(List<Guid> A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06005601 RID: 22017 RVA: 0x0025D798 File Offset: 0x0025B998
	public czj()
	{
	}

	// Token: 0x06005602 RID: 22018 RVA: 0x0025D7B8 File Offset: 0x0025B9B8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		bool? flag = null;
		if (!string.IsNullOrEmpty(this.a))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				if (serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && serviceOrThrow.aqu().v().b().j == cgy.b && serviceOrThrow.aqu().v().b().Zone != null && serviceOrThrow.aqu().v().b().Area != null && !string.IsNullOrEmpty(this.c))
				{
					aud aud = serviceOrThrow.aqu().v().b().Zone.n(this.c);
					if (aud != null)
					{
						ak1 ak = aud.a(this.b);
						if (ak != null)
						{
							ale aspect = serviceOrThrow.aqu().v().b().GetAspect<ale>();
							if (aspect != null)
							{
								fk fk = new fk(aspect, ak, null, false, 0);
								fk.l();
								czp czp = fk.g();
								czp.n.a = false;
								czp.p = this.d;
								czp.q = this.e;
								d25 d = czp.l as d25;
								if (d == null)
								{
									d = new d25();
									czp.l = d;
								}
								d.b = this.d;
								d.c = this.e;
								if (this.f.Count > 0)
								{
									if (d.h == null)
									{
										d.h = new HashSet<Guid>();
									}
									foreach (Guid guid in this.f)
									{
										d.h.Add(guid);
									}
								}
								c5w c5w = bpo.GetServiceOrThrow<wu>().aki(czp, aspect.a8().Playfield.PathProcessor, eso.d);
								c5w.au1();
								flag = new bool?(c5w.aun() == dv8.d);
							}
						}
					}
				}
				if (flag != null)
				{
					serviceOrThrow.aqu().r()[this.a] = flag.Value;
					return;
				}
				serviceOrThrow.aqu().r().RemoveProperty(this.a);
			}
		}
	}

	// Token: 0x040022EC RID: 8940
	private new string a = "";

	// Token: 0x040022ED RID: 8941
	private Point b;

	// Token: 0x040022EE RID: 8942
	private string c;

	// Token: 0x040022EF RID: 8943
	private bool d;

	// Token: 0x040022F0 RID: 8944
	private bool e;

	// Token: 0x040022F1 RID: 8945
	private List<Guid> f = new List<Guid>();
}
