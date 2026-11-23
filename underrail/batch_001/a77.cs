using System;
using System.Runtime.Serialization;

// Token: 0x020009F1 RID: 2545
[eiz("XPBLLUXDHCIAIDOF")]
[Serializable]
public sealed class a77 : bdw, ISerializable
{
	// Token: 0x06003CCD RID: 15565 RVA: 0x00169080 File Offset: 0x00167280
	private a77(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003CCE RID: 15566 RVA: 0x00169088 File Offset: 0x00167288
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003CCF RID: 15567 RVA: 0x0016908C File Offset: 0x0016728C
	public a77()
	{
	}

	// Token: 0x06003CD0 RID: 15568 RVA: 0x00169098 File Offset: 0x00167298
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null && A_1.r().GetPrimitivePropertyValue<bool>("npc_rc_dude_askedToKeepAcorn", new bool?(false)).Value)
		{
			foreach (aud aud in A_0.Areas)
			{
				c5x c5x = new ar7(new Guid("8a730b46-fcc6-4fdb-9ada-4b614101f9c0"), aud).ao() as c5x;
				c7j c7j = c5x.GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					foreach (b0b b0b in aud.Entities)
					{
						c5x c5x2 = (c5x)b0b;
						if (c5x2.Layer == aju.x && c5x2 != c5x && !c5x2.IsPlayer)
						{
							c7j c7j2 = c5x2.GetAspect<bim>() as c7j;
							if (c7j2 != null)
							{
								foreach (coh coh in c7j2.ItemContainer.z2())
								{
									if (coh.Definition != null && coh.Definition.a5() == "plot.xpbl_acorn")
									{
										c7j.ItemContainer.z3(coh, true);
										c7j2.ItemContainer.z5(coh);
										A_1.r()["npc_rc_dude_threwAcornInTrash"] = true;
										return;
									}
								}
							}
							amc aspect = c5x2.GetAspect<amc>();
							if (aspect != null)
							{
								foreach (coh coh2 in aspect.aa().Bag.z2())
								{
									if (coh2.Definition != null && coh2.Definition.a5() == "plot.xpbl_acorn")
									{
										c7j.ItemContainer.z3(coh2, true);
										aspect.aa().Bag.z5(coh2);
										A_1.r()["npc_rc_dude_threwAcornInTrash"] = true;
										return;
									}
								}
							}
						}
					}
				}
			}
		}
	}
}
