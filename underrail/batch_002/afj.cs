using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x02000979 RID: 2425
[eiz("FOSSSC")]
[Serializable]
public sealed class afj : bdw, ISerializable
{
	// Token: 0x06003ADF RID: 15071 RVA: 0x0015D6A0 File Offset: 0x0015B8A0
	private afj(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003AE0 RID: 15072 RVA: 0x0015D6A8 File Offset: 0x0015B8A8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003AE1 RID: 15073 RVA: 0x0015D6AC File Offset: 0x0015B8AC
	public afj()
	{
	}

	// Token: 0x06003AE2 RID: 15074 RVA: 0x0015D6B4 File Offset: 0x0015B8B4
	public void av(c1a A_0, cyt A_1)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null && A_0 != null)
		{
			aud aud = A_0.n("lu-b24");
			if (aud != null && !A_1.r().GetPrimitivePropertyValue<bool>("npc_fo_leonie_superSteelFootlocker_present", new bool?(false)).Value && !(new ar7(new Guid("e0ec9d7d-e551-4ebe-ac32-ae02c3fa1b66"), aud).ao() is c5x))
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "lu-b24_l2") + ".uzl");
				A_0.a(a_, 1, null);
				A_1.r()["npc_fo_leonie_superSteelFootlocker_present"] = true;
			}
		}
	}
}
