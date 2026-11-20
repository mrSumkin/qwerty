using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000A18 RID: 2584
[eiz("XPBLPGTJ")]
[Serializable]
public sealed class au : bdw, ISerializable
{
	// Token: 0x06003D82 RID: 15746 RVA: 0x001708D8 File Offset: 0x0016EAD8
	private au(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D83 RID: 15747 RVA: 0x001708E0 File Offset: 0x0016EAE0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D84 RID: 15748 RVA: 0x001708E4 File Offset: 0x0016EAE4
	public au()
	{
	}

	// Token: 0x06003D85 RID: 15749 RVA: 0x001708F0 File Offset: 0x0016EAF0
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (serviceOrThrow != null && c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("939c37bb-b75c-439c-a535-262aa36c02ed"), A_0.n("xpbl_e3")).ao() as c5x;
				if (c5x2 != null)
				{
					c7j c7j = c5x2.s.b as c7j;
					d2b aspect = c5x2.GetAspect<d2b>();
					if (c7j != null)
					{
						ke.a(c5x.h.b.aa(), c7j.ItemContainer, false, true);
						if (c5x.h.b.aa().Gear.l().Item == null)
						{
							c5x.h.b.aa().Gear.l().a(new c8d(new LibraryItemDefinitionProvider<c43>("Armor\\Robe")), true);
						}
					}
					if (aspect != null && !aspect.n())
					{
						aspect.e(true);
					}
				}
				foreach (aud aud in Enumerable.ToList<aud>(A_0.Areas))
				{
					foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
					{
						c5x c5x3 = (c5x)b0b;
						if (c5x3 != null)
						{
							if (c5x3.qe() == new Guid("4c8da977-29e8-4eb7-b765-737f18d3c786"))
							{
								if (c5x3.t.b != null)
								{
									c5x3.t.b.y6()[ddq.k] = new List<string>
									{
										"pc1",
										"pc3"
									};
								}
							}
							else if (c5x3.qe() == new Guid("ddcf0026-3691-4d73-b3df-ed96068b2654"))
							{
								a0l.a(c5x3, "jailer_pa1", true);
							}
						}
					}
				}
				doq a_ = doq.a(Path.Combine(d5x.q(), "xpbl_e3_L2") + ".uzl");
				A_0.a(a_, 1, null);
			}
		}
	}
}
