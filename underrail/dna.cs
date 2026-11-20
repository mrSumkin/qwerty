using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A61 RID: 2657
[eiz("TACTNPC")]
[Serializable]
public sealed class dna : cze, ISerializable
{
	// Token: 0x06003EC3 RID: 16067 RVA: 0x0017B1D4 File Offset: 0x001793D4
	private dna(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid?)A_0.GetValue("TACTNPC:TID", typeof(Guid?));
		this.b = A_0.GetString("TACTNPC:OA");
	}

	// Token: 0x06003EC4 RID: 16068 RVA: 0x0017B210 File Offset: 0x00179410
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TACTNPC:TID", this.a);
		info.AddValue("TACTNPC:OA", this.b);
	}

	// Token: 0x06003EC5 RID: 16069 RVA: 0x0017B244 File Offset: 0x00179444
	public Guid? b()
	{
		return this.a;
	}

	// Token: 0x06003EC6 RID: 16070 RVA: 0x0017B24C File Offset: 0x0017944C
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003EC7 RID: 16071 RVA: 0x0017B258 File Offset: 0x00179458
	public string a()
	{
		return this.b;
	}

	// Token: 0x06003EC8 RID: 16072 RVA: 0x0017B260 File Offset: 0x00179460
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06003EC9 RID: 16073 RVA: 0x0017B26C File Offset: 0x0017946C
	public dna()
	{
	}

	// Token: 0x06003ECA RID: 16074 RVA: 0x0017B274 File Offset: 0x00179474
	public dna(Guid A_0, string A_1)
	{
		this.a = new Guid?(A_0);
		this.b = A_1;
	}

	// Token: 0x06003ECB RID: 16075 RVA: 0x0017B294 File Offset: 0x00179494
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
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
		if (c5x != null && c5x.h.b != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow != null)
			{
				c5x c5x2 = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x2 != null && c5x2.h.b != null)
				{
					efk efk = c5x2.h.b.aa();
					if (efk != null)
					{
						foreach (coh coh in Enumerable.ToList<coh>(efk.Bag.z2()))
						{
							if (coh.Definition is a54)
							{
								efk.Bag.z5(coh);
								c5x.h.b.aa().Bag.z3(coh, true);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x04001BC8 RID: 7112
	private new Guid? a;

	// Token: 0x04001BC9 RID: 7113
	private string b;
}
