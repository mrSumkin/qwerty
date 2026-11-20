using System;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000FDB RID: 4059
[eiz("SVHA")]
[Serializable]
public sealed class u0 : esc
{
	// Token: 0x06005389 RID: 21385 RVA: 0x00250B08 File Offset: 0x0024ED08
	private u0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("SVHA:C");
		this.b = A_0.GetInt32("SVHA:D");
		this.c = A_0.GetString("SVHA:F");
	}

	// Token: 0x0600538A RID: 21386 RVA: 0x00250B50 File Offset: 0x0024ED50
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SVHA:C", this.a);
		info.AddValue("SVHA:D", this.b);
		info.AddValue("SVHA:F", this.c);
	}

	// Token: 0x0600538B RID: 21387 RVA: 0x00250B98 File Offset: 0x0024ED98
	public string b()
	{
		return this.a;
	}

	// Token: 0x0600538C RID: 21388 RVA: 0x00250BA0 File Offset: 0x0024EDA0
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600538D RID: 21389 RVA: 0x00250BAC File Offset: 0x0024EDAC
	public int a()
	{
		return this.b;
	}

	// Token: 0x0600538E RID: 21390 RVA: 0x00250BB4 File Offset: 0x0024EDB4
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600538F RID: 21391 RVA: 0x00250BC0 File Offset: 0x0024EDC0
	public string c()
	{
		return this.c;
	}

	// Token: 0x06005390 RID: 21392 RVA: 0x00250BC8 File Offset: 0x0024EDC8
	public void b(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005391 RID: 21393 RVA: 0x00250BD4 File Offset: 0x0024EDD4
	public u0()
	{
	}

	// Token: 0x06005392 RID: 21394 RVA: 0x00250BE0 File Offset: 0x0024EDE0
	public override int d5(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			string name = aya.a(this.a);
			dic classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<dic>(name);
			if (classPropertyValue != null)
			{
				int a_;
				if (this.b == 0)
				{
					a_ = classPropertyValue.SellPriceWithIncrease0;
				}
				else if (this.b == 1)
				{
					a_ = classPropertyValue.SellPriceWithIncrease1;
				}
				else if (this.b == 2)
				{
					a_ = classPropertyValue.SellPriceWithIncrease2;
				}
				else
				{
					a_ = classPropertyValue.SellPriceWithIncrease3;
				}
				c5x c5x = classPropertyValue.b().ao() as c5x;
				if (c5x != null)
				{
					wv wv = c5x.GetAspect<bim>() as wv;
					if (wv != null && wv.g() != null)
					{
						wv.g().l().Clear();
						wv.g().l().Add(this.c);
						if (c5x.Zone != null)
						{
							d60 d = c5x.Zone.a();
							if (d != null)
							{
								c5x c5x2 = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
								{
									"vehicleSoldTrunkDump"
								})) as c5x;
								if (c5x2 != null && c5x2.s.b is c7j)
								{
									c7j c7j = c5x2.s.b as c7j;
									foreach (coh a_2 in wv.g().ap().z2())
									{
										c7j.ItemContainer.z3(a_2, false);
									}
									wv.g().ap().z7();
									wv.g().k();
								}
							}
						}
					}
					c3g c3g = c5x.GetAspect<c3g>();
					if (c3g == null)
					{
						c3g = new c3g(c5x);
						c5x.SetAspect<c3g>(c3g);
					}
					c3g.d().Clear();
					c3g.d().Add(this.c);
					d48 d2 = new d48(new LibraryItemDefinitionProvider<a54>("Currency\\StygianCoin"));
					d2.Stacks = a_;
					serviceOrThrow.aqu().v().Bag.z3(d2, true);
				}
			}
		}
		return 0;
	}

	// Token: 0x04002213 RID: 8723
	private string a;

	// Token: 0x04002214 RID: 8724
	private int b;

	// Token: 0x04002215 RID: 8725
	private string c;
}
