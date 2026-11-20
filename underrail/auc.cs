using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020008E2 RID: 2274
[eiz("CCUTFRCLNP")]
[Serializable]
public sealed class auc : bdw, ISerializable
{
	// Token: 0x06003874 RID: 14452 RVA: 0x0014EBE4 File Offset: 0x0014CDE4
	private auc(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003875 RID: 14453 RVA: 0x0014EBEC File Offset: 0x0014CDEC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003876 RID: 14454 RVA: 0x0014EBF0 File Offset: 0x0014CDF0
	public auc()
	{
	}

	// Token: 0x06003877 RID: 14455 RVA: 0x0014EBFC File Offset: 0x0014CDFC
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("cc_utility2_upHideout");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("6c165339-ee32-4c69-90c6-e50531441ed0"), aud).ao() as c5x;
				if (c5x != null)
				{
					uk uk = new uk();
					uk.a(new Guid?(new Guid("6c165339-ee32-4c69-90c6-e50531441ed0")));
					uk.a(bvl.e);
					uk.a(true);
					uk.ym(c5x, c5x, null);
				}
				c5x c5x2 = new ar7(new Guid("985e5557-de0f-42de-9949-d430c1470284"), aud).ao() as c5x;
				if (c5x2 != null)
				{
					c5x2.o.b.b = new Point(0, 0);
				}
				if (!A_1.r().GetPrimitivePropertyValue<bool>("npc_forger_dead", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_forger_learnOrangeBox", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_forger_orangeBoxSpawned", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_forger_orangeBoxStolen", new bool?(false)).Value)
				{
					c5x c5x3 = new ar7(new Guid("321ed979-cb29-4f6e-aed4-04458784e318"), aud).ao() as c5x;
					if (c5x3 != null)
					{
						coh coh = new d48(ez2.CreateDefinitonProvider<dj3>("plot\\orangebox"));
						if (coh != null)
						{
							c7j c7j = c5x3.s.b as c7j;
							if (c7j != null)
							{
								c7j.ItemContainer.z3(coh, false);
								A_1.r()["npc_forger_orangeBoxSpawned"] = true;
							}
						}
					}
				}
			}
		}
	}
}
