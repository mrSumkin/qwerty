using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020008E0 RID: 2272
[eiz("AW1UMG")]
[Serializable]
public sealed class a68 : bdw, ISerializable
{
	// Token: 0x0600386C RID: 14444 RVA: 0x0014E964 File Offset: 0x0014CB64
	private a68(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600386D RID: 14445 RVA: 0x0014E96C File Offset: 0x0014CB6C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x0600386E RID: 14446 RVA: 0x0014E970 File Offset: 0x0014CB70
	public a68()
	{
	}

	// Token: 0x0600386F RID: 14447 RVA: 0x0014E97C File Offset: 0x0014CB7C
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("lu-b13");
			if (aud != null)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null)
				{
					List<ar7> list = new List<ar7>
					{
						new ar7(new Guid("0a5f84f2-bdec-42f7-86b8-8a724a2c1406"), aud),
						new ar7(new Guid("8729dbc9-09ce-4d6e-9035-1cc8bac70579"), aud),
						new ar7(new Guid("3c9475d1-8c03-464d-8217-ed31bf9b2c52"), aud),
						new ar7(new Guid("5f984b0c-9e2a-46ae-9173-2e9a7a34ea94"), aud),
						new ar7(new Guid("c6460744-4a12-451e-8f1b-75e296061f90"), aud),
						new ar7(new Guid("07d48065-816b-4fad-b29f-db5aa75ed605"), aud)
					};
					int x;
					long a_;
					if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(bp5.f("aw1_gen"), new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_aw1_frontGate", new bool?(false)).Value)
					{
						x = 0;
						a_ = bcj.a(new byte[]
						{
							0,
							1,
							2
						});
					}
					else
					{
						x = 5;
						a_ = 0L;
					}
					foreach (ar7 ar in list)
					{
						if (ar.ao() != null)
						{
							c5x c5x = (c5x)ar.ao();
							c5x.o.b.b = new Point(x, 0);
							c5x.TileFormationModifiers = new bjp(a_);
						}
					}
				}
			}
		}
	}
}
