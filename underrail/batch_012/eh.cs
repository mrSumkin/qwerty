using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02001055 RID: 4181
[eiz("SSCSJ0")]
[Serializable]
public sealed class eh : cze
{
	// Token: 0x060056D1 RID: 22225 RVA: 0x00260854 File Offset: 0x0025EA54
	private eh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("SSCSJ0:B");
	}

	// Token: 0x060056D2 RID: 22226 RVA: 0x00260870 File Offset: 0x0025EA70
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SSCSJ0:B", this.a);
	}

	// Token: 0x060056D3 RID: 22227 RVA: 0x0026088C File Offset: 0x0025EA8C
	public eh(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060056D4 RID: 22228 RVA: 0x002608A0 File Offset: 0x0025EAA0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null && A_0.GetAspect<amc>() != null)
		{
			c3n c3n = dgk.Get<cxy>();
			if (c3n != null)
			{
				eu7 eu = ecf.a(c3n, new eru(new EntityAspectReference<amc, amc>(A_0.GetAspect<amc>())), null) as eu7;
				if (eu != null)
				{
					cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
					if (serviceOrThrow.aqu() != null)
					{
						serviceOrThrow.aqu().r()["xpbl_skerderGraveSearchedBodyPart"] = this.a;
					}
					cp.b(eu, A_0 as c5x, A_0 as c5x);
				}
			}
		}
	}

	// Token: 0x04002335 RID: 9013
	private new string a;
}
