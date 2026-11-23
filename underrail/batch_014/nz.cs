using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B6D RID: 2925
[eiz("FOCSSSJ")]
[Serializable]
public sealed class nz : cze, ISerializable
{
	// Token: 0x060042F6 RID: 17142 RVA: 0x001A27B8 File Offset: 0x001A09B8
	private nz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060042F7 RID: 17143 RVA: 0x001A27C4 File Offset: 0x001A09C4
	public nz()
	{
	}

	// Token: 0x060042F8 RID: 17144 RVA: 0x001A27D0 File Offset: 0x001A09D0
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
							string path = "components\\Armors\\SupersteelSheet";
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
