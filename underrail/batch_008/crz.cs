using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000AB1 RID: 2737
[eiz("TJ")]
[Serializable]
public class crz : cze, ISerializable
{
	// Token: 0x06003FF3 RID: 16371 RVA: 0x00184358 File Offset: 0x00182558
	protected crz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003FF4 RID: 16372 RVA: 0x00184364 File Offset: 0x00182564
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06003FF5 RID: 16373 RVA: 0x00184370 File Offset: 0x00182570
	public crz()
	{
	}

	// Token: 0x06003FF6 RID: 16374 RVA: 0x00184378 File Offset: 0x00182578
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null && A_0.Area != null)
		{
			ka ka = new EntityAspectReference<ka, ka>(A_0.Area, new Guid("75cdc640-c0de-4286-a030-bd56e0a5fb48")).ao();
			if (ka != null)
			{
				ka.b("mv 1");
				c6y a_ = new c6y(ka, 50, 0, 8, 30);
				A_0.Zone.ActionManager.g9(a_, atp.a);
			}
		}
	}
}
