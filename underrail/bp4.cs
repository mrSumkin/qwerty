using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000905 RID: 2309
[eiz("CCFTFG")]
[Serializable]
public sealed class bp4 : bdw, ISerializable
{
	// Token: 0x06003903 RID: 14595 RVA: 0x00151D68 File Offset: 0x0014FF68
	private bp4(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003904 RID: 14596 RVA: 0x00151D70 File Offset: 0x0014FF70
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003905 RID: 14597 RVA: 0x00151D74 File Offset: 0x0014FF74
	public bp4()
	{
	}

	// Token: 0x06003906 RID: 14598 RVA: 0x00151D80 File Offset: 0x0014FF80
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0 != null)
		{
			aud aud = A_0.n("cc_enterGauntlet");
			if (aud != null)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null)
				{
					List<Guid> list = new List<Guid>();
					list.Add(new Guid("d22f0fc1-3298-4063-8f35-d112fca36793"));
					list.Add(new Guid("f0ced5e3-775f-4714-8e2a-5eaeb4f1954e"));
					list.Add(new Guid("43f34641-88b9-4c5f-b9cf-3e1c0470d8f5"));
					list.Add(new Guid("9c869d6a-86be-4e92-84ce-f90f02fc74f2"));
					crx crx = new crx();
					crx.a(aud.y8());
					crx.a(bbo.b);
					crx.a(list);
					crx.ym(c5x, null, null);
					c7j c7j = (new ar7(new Guid("5662474d-b5a7-439e-9808-e9d2f04095c9"), aud).ao() as c5x).s.b as c7j;
					c7j c7j2 = (new ar7(new Guid("c9b25e11-c8a8-4b69-81b0-ce6012168a1a"), aud).ao() as c5x).s.b as c7j;
					c7j c7j3 = (new ar7(new Guid("676e4ff4-4f13-4521-b374-d09f397db353"), aud).ao() as c5x).s.b as c7j;
					if (c7j != null)
					{
						c7j.ItemContainer.z7();
					}
					if (c7j2 != null)
					{
						c7j2.ItemContainer.z7();
					}
					if (c7j3 != null)
					{
						c7j3.ItemContainer.z7();
					}
				}
			}
		}
	}
}
