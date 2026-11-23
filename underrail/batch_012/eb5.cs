using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000B3F RID: 2879
[eiz("TCHSTP")]
[Serializable]
public sealed class eb5 : cze, ISerializable
{
	// Token: 0x0600423A RID: 16954 RVA: 0x0019A838 File Offset: 0x00198A38
	private eb5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600423B RID: 16955 RVA: 0x0019A844 File Offset: 0x00198A44
	public eb5()
	{
	}

	// Token: 0x0600423C RID: 16956 RVA: 0x0019A850 File Offset: 0x00198A50
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			aud aud = serviceOrThrow.aqw().n("tch-util2");
			if (aud != null)
			{
				dxv dxv = new EntityAspectReference<dxv, dxv>(aud, new Guid("15f96734-5120-40a9-9871-c8dbf0aae4ba")).ao();
				dxv dxv2 = new EntityAspectReference<dxv, dxv>(aud, new Guid("9429d7df-00f2-4620-8d75-25f6302158ac")).ao();
				dxv dxv3 = new EntityAspectReference<dxv, dxv>(aud, new Guid("b435a8ce-cd85-4b22-8d42-a485a7d2d6ea")).ao();
				dxv dxv4 = new EntityAspectReference<dxv, dxv>(aud, new Guid("dff6c9f3-a034-4466-a63d-fe550d140c0e")).ao();
				if (dxv != null)
				{
					dxv.a(true);
				}
				if (dxv2 != null)
				{
					dxv2.a(true);
				}
				if (dxv3 != null)
				{
					dxv3.a(true);
				}
				if (dxv4 != null)
				{
					dxv4.a(true);
				}
			}
		}
	}
}
