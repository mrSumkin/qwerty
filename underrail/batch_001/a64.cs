using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000711 RID: 1809
[eiz("IR")]
[Serializable]
public sealed class a64 : y8, ISerializable
{
	// Token: 0x06002EE5 RID: 12005 RVA: 0x001090FC File Offset: 0x001072FC
	private a64(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.b = (coh)A_0.GetValue("IR:I", typeof(coh));
			this.c = A_0.GetBoolean("IR:AMID");
			if (ell.a() >= 20)
			{
				this.d = A_0.GetBoolean("IR:TRQ");
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(a64))
			{
				this.b = (coh)A_0.GetValue("_Item", typeof(coh));
				this.c = A_0.GetBoolean("_AlwaysMakeIndependentDefinition");
				return;
			}
			this.b = (coh)A_0.GetValue("ItemReplicator+_Item", typeof(coh));
			this.c = A_0.GetBoolean("ItemReplicator+_AlwaysMakeIndependentDefinition");
		}
	}

	// Token: 0x06002EE6 RID: 12006 RVA: 0x001091E8 File Offset: 0x001073E8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("IR:I", this.b);
		info.AddValue("IR:AMID", this.c);
		info.AddValue("IR:TRQ", this.d);
	}

	// Token: 0x06002EE7 RID: 12007 RVA: 0x00109230 File Offset: 0x00107430
	public coh c()
	{
		return this.b;
	}

	// Token: 0x06002EE8 RID: 12008 RVA: 0x00109238 File Offset: 0x00107438
	public void a(coh A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002EE9 RID: 12009 RVA: 0x00109244 File Offset: 0x00107444
	public bool b()
	{
		return this.c;
	}

	// Token: 0x06002EEA RID: 12010 RVA: 0x0010924C File Offset: 0x0010744C
	public void b(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06002EEB RID: 12011 RVA: 0x00109258 File Offset: 0x00107458
	public bool a()
	{
		return this.d;
	}

	// Token: 0x06002EEC RID: 12012 RVA: 0x00109260 File Offset: 0x00107460
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06002EED RID: 12013 RVA: 0x0010926C File Offset: 0x0010746C
	public a64()
	{
	}

	// Token: 0x06002EEE RID: 12014 RVA: 0x00109274 File Offset: 0x00107474
	public a64(coh A_0, bool A_1 = false, bool A_2 = false)
	{
		this.b = A_0;
		this.c = A_1;
		this.d = A_2;
	}

	// Token: 0x06002EEF RID: 12015 RVA: 0x00109294 File Offset: 0x00107494
	protected override List<coh> a2()
	{
		List<coh> list = new List<coh>();
		if (this.b != null && this.b.Definition != null)
		{
			coh coh = this.b.fy();
			if (this.c)
			{
				coh.c();
			}
			if (this.d)
			{
				int num = base.i();
				int a_ = a64.a(num);
				eyk eyk = coh as eyk;
				if (eyk != null)
				{
					eyk.fw(a_);
				}
				btu service = bpo.GetService<btu>();
				if (service != null)
				{
					d6i d6i = service.wp(coh);
					if (d6i != null)
					{
						if (!this.c && d6i.atv())
						{
							coh.c();
						}
						d6i.mw(coh, num);
					}
				}
			}
			cd1 cd = coh as cd1;
			if (cd != null && euf.j(cd))
			{
				cd.LoadedAmmo.Add(AmmoType.Rocket_84_He);
			}
			list.Add(coh);
		}
		return list;
	}

	// Token: 0x06002EF0 RID: 12016 RVA: 0x00109388 File Offset: 0x00107588
	public override aw4 a1()
	{
		a64 a = new a64();
		this.rg(a);
		return a;
	}

	// Token: 0x06002EF1 RID: 12017 RVA: 0x001093A4 File Offset: 0x001075A4
	public override string ToString()
	{
		return "Item Replicator: " + ((this.c() != null) ? this.c().ToString() : "<null>");
	}

	// Token: 0x06002EF2 RID: 12018 RVA: 0x001093DC File Offset: 0x001075DC
	protected override void rg(y8 A_0)
	{
		base.rg(A_0);
		a64 a = (a64)A_0;
		if (this.b != null)
		{
			a.b = this.b.fy();
		}
		a.c = this.c;
		a.d = this.d;
	}

	// Token: 0x06002EF3 RID: 12019 RVA: 0x0010942C File Offset: 0x0010762C
	private new static int a(int A_0)
	{
		return 6 + A_0 * 5 + zp.a.Next(9);
	}

	// Token: 0x04001A10 RID: 6672
	private new const string a = "Item Replicator";

	// Token: 0x04001A11 RID: 6673
	private coh b;

	// Token: 0x04001A12 RID: 6674
	private bool c;

	// Token: 0x04001A13 RID: 6675
	private bool d;
}
