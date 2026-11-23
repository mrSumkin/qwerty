using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000933 RID: 2355
[eiz("LUPCIBSDIC")]
[Serializable]
public sealed class et1 : bdw, ISerializable
{
	// Token: 0x060039C2 RID: 14786 RVA: 0x00155A14 File Offset: 0x00153C14
	private et1(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060039C3 RID: 14787 RVA: 0x00155A1C File Offset: 0x00153C1C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060039C4 RID: 14788 RVA: 0x00155A20 File Offset: 0x00153C20
	public et1()
	{
	}

	// Token: 0x060039C5 RID: 14789 RVA: 0x00155A2C File Offset: 0x00153C2C
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("lup-a1");
			if (aud != null)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_blaine_dead", new bool?(false)).Value)
				{
					cnb cnb = new EntityAspectReference<cnb, bim>(aud, new Guid("63069ceb-fcb2-4785-945a-b72c38e9b181")).ao();
					if (cnb != null && cnb.q())
					{
						cnb.d(false);
					}
					d2b d2b = new EntityAspectReference<d2b, d2b>(aud, new Guid("63069ceb-fcb2-4785-945a-b72c38e9b181")).ao();
					if (d2b != null && !d2b.n())
					{
						d2b.e(true);
						d2b.a(0.0);
					}
				}
			}
		}
	}
}
