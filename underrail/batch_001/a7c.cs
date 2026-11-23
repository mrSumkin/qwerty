using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02001212 RID: 4626
[eiz("JTR")]
[Serializable]
public sealed class a7c : ya, a8o, ISerializable
{
	// Token: 0x06006366 RID: 25446 RVA: 0x002AE194 File Offset: 0x002AC394
	private a7c(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("JTR:R");
		this.b = A_0.GetBoolean("JTR:U");
		this.c = (A_0.GetValue("JTR:C", typeof(dth)) as dth);
		this.d = A_0.GetBoolean("JTR:PO");
		this.e = (A_0.GetValue("JTR:CD", typeof(Dictionary<string, object>)) as Dictionary<string, object>);
		if (ell.a() >= 204)
		{
			di7.ReadList<cze>("JTR:EJ", ref this.f, A_0);
			di7.ReadList<cze>("JTR:XJ", ref this.g, A_0);
			di7.ReadList<cze>("JTR:MJ", ref this.h, A_0);
			di7.ReadList<cze>("JTR:TJ", ref this.i, A_0);
		}
		else
		{
			this.f = new List<cze>();
			this.g = new List<cze>();
			this.h = new List<cze>();
			this.i = new List<cze>();
			cze cze = A_0.GetValue("JTR:J", typeof(cze)) as cze;
			if (cze != null)
			{
				this.f.Add(cze);
			}
		}
		if (ell.a() >= 207)
		{
			this.j = A_0.GetString("JTR:CP");
		}
		if (ell.a() >= 214)
		{
			di7.ReadList<Guid>("JTR:A", ref this.k, A_0);
		}
		if (ell.a() >= 285)
		{
			this.l = A_0.GetBoolean("JTR:RE");
			return;
		}
		if (Enumerable.FirstOrDefault<cze>(this.f) is an6)
		{
			this.l = true;
		}
	}

	// Token: 0x06006367 RID: 25447 RVA: 0x002AE38C File Offset: 0x002AC58C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("JTR:R", this.a);
		info.AddValue("JTR:U", this.b);
		info.AddValue("JTR:C", this.c);
		info.AddValue("JTR:PO", this.d);
		info.AddValue("JTR:CD", this.e);
		info.AddValue("JTR:CP", this.j);
		info.AddValue("JTR:RE", this.l);
		di7.WriteList<cze>("JTR:EJ", this.f, info);
		di7.WriteList<cze>("JTR:XJ", this.g, info);
		di7.WriteList<cze>("JTR:MJ", this.h, info);
		di7.WriteList<cze>("JTR:TJ", this.i, info);
		di7.WriteList<Guid>("JTR:A", this.k, info);
	}

	// Token: 0x06006368 RID: 25448 RVA: 0x002AE470 File Offset: 0x002AC670
	public bool b()
	{
		return this.a;
	}

	// Token: 0x06006369 RID: 25449 RVA: 0x002AE478 File Offset: 0x002AC678
	public void b(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600636A RID: 25450 RVA: 0x002AE484 File Offset: 0x002AC684
	public bool d()
	{
		return this.b;
	}

	// Token: 0x0600636B RID: 25451 RVA: 0x002AE48C File Offset: 0x002AC68C
	public void c(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600636C RID: 25452 RVA: 0x002AE498 File Offset: 0x002AC698
	public dth e()
	{
		return this.c;
	}

	// Token: 0x0600636D RID: 25453 RVA: 0x002AE4A0 File Offset: 0x002AC6A0
	public void a(dth A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600636E RID: 25454 RVA: 0x002AE4AC File Offset: 0x002AC6AC
	public List<cze> h()
	{
		return this.f;
	}

	// Token: 0x0600636F RID: 25455 RVA: 0x002AE4B4 File Offset: 0x002AC6B4
	public void a(List<cze> A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06006370 RID: 25456 RVA: 0x002AE4C0 File Offset: 0x002AC6C0
	public List<cze> i()
	{
		return this.g;
	}

	// Token: 0x06006371 RID: 25457 RVA: 0x002AE4C8 File Offset: 0x002AC6C8
	public void b(List<cze> A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06006372 RID: 25458 RVA: 0x002AE4D4 File Offset: 0x002AC6D4
	public List<cze> k()
	{
		return this.h;
	}

	// Token: 0x06006373 RID: 25459 RVA: 0x002AE4DC File Offset: 0x002AC6DC
	public void d(List<cze> A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06006374 RID: 25460 RVA: 0x002AE4E8 File Offset: 0x002AC6E8
	public List<cze> a()
	{
		return this.i;
	}

	// Token: 0x06006375 RID: 25461 RVA: 0x002AE4F0 File Offset: 0x002AC6F0
	public void c(List<cze> A_0)
	{
		this.i = A_0;
	}

	// Token: 0x06006376 RID: 25462 RVA: 0x002AE4FC File Offset: 0x002AC6FC
	public bool j()
	{
		return this.d;
	}

	// Token: 0x06006377 RID: 25463 RVA: 0x002AE504 File Offset: 0x002AC704
	public void d(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006378 RID: 25464 RVA: 0x002AE510 File Offset: 0x002AC710
	public Dictionary<string, object> g()
	{
		return this.e;
	}

	// Token: 0x06006379 RID: 25465 RVA: 0x002AE518 File Offset: 0x002AC718
	public void a(Dictionary<string, object> A_0)
	{
		this.e = A_0;
	}

	// Token: 0x0600637A RID: 25466 RVA: 0x002AE524 File Offset: 0x002AC724
	public string c()
	{
		return this.j;
	}

	// Token: 0x0600637B RID: 25467 RVA: 0x002AE52C File Offset: 0x002AC72C
	public void a(string A_0)
	{
		this.j = A_0;
	}

	// Token: 0x0600637C RID: 25468 RVA: 0x002AE538 File Offset: 0x002AC738
	public List<Guid> f()
	{
		return this.k;
	}

	// Token: 0x0600637D RID: 25469 RVA: 0x002AE540 File Offset: 0x002AC740
	public void a(List<Guid> A_0)
	{
		this.k = A_0;
	}

	// Token: 0x0600637E RID: 25470 RVA: 0x002AE54C File Offset: 0x002AC74C
	public bool vk()
	{
		return this.l;
	}

	// Token: 0x0600637F RID: 25471 RVA: 0x002AE554 File Offset: 0x002AC754
	public void a(bool A_0)
	{
		this.l = A_0;
	}

	// Token: 0x06006380 RID: 25472 RVA: 0x002AE560 File Offset: 0x002AC760
	public a7c()
	{
	}

	// Token: 0x06006381 RID: 25473 RVA: 0x002AE5B8 File Offset: 0x002AC7B8
	protected override void jk(b0b A_0)
	{
		base.jk(A_0);
		if (this.a(A_0 as c5x))
		{
			if (!string.IsNullOrEmpty(this.j))
			{
				cnk service = bpo.GetService<cnk>();
				if (service != null && service.aqu() != null)
				{
					int num = service.aqu().r().GetPrimitivePropertyValue<int>(this.j, new int?(0)).Value;
					bool flag;
					if (bax.a() == null)
					{
						num++;
						flag = (num == 1);
					}
					else
					{
						flag = (num > 0);
					}
					if (flag)
					{
						this.a(A_0 as c5x, this.f);
					}
					service.aqu().r()[this.j] = num;
					return;
				}
			}
			this.a(A_0 as c5x, this.f);
		}
	}

	// Token: 0x06006382 RID: 25474 RVA: 0x002AE690 File Offset: 0x002AC890
	protected override void pq(b0b A_0)
	{
		base.pq(A_0);
		if (this.a(A_0 as c5x))
		{
			if (!string.IsNullOrEmpty(this.j))
			{
				cnk service = bpo.GetService<cnk>();
				if (service != null && service.aqu() != null)
				{
					int num = service.aqu().r().GetPrimitivePropertyValue<int>(this.j, new int?(0)).Value;
					num--;
					if (num <= 0)
					{
						this.a(A_0 as c5x, this.g);
					}
					service.aqu().r()[this.j] = num;
					return;
				}
			}
			this.a(A_0 as c5x, this.g);
		}
	}

	// Token: 0x06006383 RID: 25475 RVA: 0x002AE750 File Offset: 0x002AC950
	protected override void tk(b0b A_0)
	{
		base.tk(A_0);
		if (this.a(A_0 as c5x))
		{
			this.a(A_0 as c5x, this.h);
		}
	}

	// Token: 0x06006384 RID: 25476 RVA: 0x002AE77C File Offset: 0x002AC97C
	protected override void tl(b0b A_0)
	{
		base.tl(A_0);
		if (this.a(A_0 as c5x))
		{
			this.a(A_0 as c5x, this.i);
		}
	}

	// Token: 0x06006385 RID: 25477 RVA: 0x002AE7AC File Offset: 0x002AC9AC
	private void a(c5x A_0, List<cze> A_1)
	{
		if (this.k != null && this.k.Count > 0 && !this.k.Contains(A_0.qe()))
		{
			return;
		}
		if (this.c != null && !this.c.jh(this))
		{
			if (this.b)
			{
				base.o();
			}
			return;
		}
		foreach (cze cze in A_1)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>(this.e);
			if (!dictionary.ContainsKey("area"))
			{
				dictionary["area"] = base.Area;
			}
			if (base.Area != null && base.Area.Zone != null && !dictionary.ContainsKey("zone"))
			{
				dictionary["zone"] = base.Area.Zone;
			}
			cze.ym(A_0, null, dictionary);
		}
		if (A_1.Count > 0 && !this.a)
		{
			base.o();
		}
	}

	// Token: 0x06006386 RID: 25478 RVA: 0x002AE8F4 File Offset: 0x002ACAF4
	private bool a(c5x A_0)
	{
		return A_0 != null && (!this.d || (A_0.h != null && A_0.h.b != null && A_0.h.b.@as()));
	}

	// Token: 0x040029DC RID: 10716
	private bool a;

	// Token: 0x040029DD RID: 10717
	private bool b;

	// Token: 0x040029DE RID: 10718
	private dth c;

	// Token: 0x040029DF RID: 10719
	private new bool d;

	// Token: 0x040029E0 RID: 10720
	private new Dictionary<string, object> e = new Dictionary<string, object>();

	// Token: 0x040029E1 RID: 10721
	private new List<cze> f = new List<cze>();

	// Token: 0x040029E2 RID: 10722
	private new List<cze> g = new List<cze>();

	// Token: 0x040029E3 RID: 10723
	private new List<cze> h = new List<cze>();

	// Token: 0x040029E4 RID: 10724
	private List<cze> i = new List<cze>();

	// Token: 0x040029E5 RID: 10725
	private string j;

	// Token: 0x040029E6 RID: 10726
	private List<Guid> k = new List<Guid>();

	// Token: 0x040029E7 RID: 10727
	private bool l;
}
