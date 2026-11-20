using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B6C RID: 2924
[eiz("FOCSSFJ")]
[Serializable]
public sealed class dud : cze, ISerializable
{
	// Token: 0x060042F3 RID: 17139 RVA: 0x001A2690 File Offset: 0x001A0890
	private dud(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060042F4 RID: 17140 RVA: 0x001A269C File Offset: 0x001A089C
	public dud()
	{
	}

	// Token: 0x060042F5 RID: 17141 RVA: 0x001A26A8 File Offset: 0x001A08A8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.Area != null)
		{
			aud a_ = A_1.Area;
			c5x c5x = new ar7(new Guid("e0ec9d7d-e551-4ebe-ac32-ae02c3fa1b66"), a_).ao() as c5x;
			if (c5x != null)
			{
				c7j c7j = c5x.s.b as c7j;
				if (c7j != null)
				{
					for (int i = 0; i < c7j.ItemContainer.z2().Count; i++)
					{
						fv fv = c7j.ItemContainer.z2()[i] as fv;
						if (fv != null && fv.Definition != null && fv.Definition.a5() == "supersteel")
						{
							string path = "components\\Armors\\SupersteelFiber";
							if (ez2.GetItemDefinition<a1k>(path, true) != null)
							{
								fv fv2 = new fv(ez2.CreateDefinitonProvider<a1k>(path));
								fv2.QualityLevel = fv.QualityLevel;
								c7j.ItemContainer.z3(fv2, true);
							}
							c7j.ItemContainer.z6(i);
							return;
						}
					}
				}
			}
		}
	}
}
