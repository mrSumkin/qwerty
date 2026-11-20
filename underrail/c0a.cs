using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000B40 RID: 2880
[eiz("TMU1SGL")]
[Serializable]
public sealed class c0a : cze, ISerializable
{
	// Token: 0x0600423D RID: 16957 RVA: 0x0019A924 File Offset: 0x00198B24
	private c0a(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600423E RID: 16958 RVA: 0x0019A930 File Offset: 0x00198B30
	public c0a()
	{
	}

	// Token: 0x0600423F RID: 16959 RVA: 0x0019A938 File Offset: 0x00198B38
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			aud aud = serviceOrThrow.aqw().n("tch_mu1");
			if (aud != null)
			{
				dxv dxv = new EntityAspectReference<dxv, dxv>(aud, new Guid("76865e97-69e0-4517-924a-f11cb517a4e9")).ao();
				dxv dxv2 = new EntityAspectReference<dxv, dxv>(aud, new Guid("8197abfa-eb8c-4b91-8759-23aeddb75662")).ao();
				dxv dxv3 = new EntityAspectReference<dxv, dxv>(aud, new Guid("2634ba22-d8fe-4c1d-bdf7-da14028e5801")).ao();
				dxv dxv4 = new EntityAspectReference<dxv, dxv>(aud, new Guid("6ebfb81f-12e1-4a6f-b8dc-a041a2ed4601")).ao();
				dxv dxv5 = new EntityAspectReference<dxv, dxv>(aud, new Guid("e533a32a-387c-4226-bde5-3944229fc425")).ao();
				cnb cnb = new EntityAspectReference<cnb, bim>(aud, new Guid("9060fec4-b3d6-45f5-a16e-2893a5724a1d")).ao();
				d2b d2b = new EntityAspectReference<d2b, d2b>(aud, new Guid("9060fec4-b3d6-45f5-a16e-2893a5724a1d")).ao();
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
				if (dxv5 != null)
				{
					dxv5.a(true);
				}
				if (cnb != null)
				{
					if (cnb.q())
					{
						cnb.d(false);
					}
					d2b.e(true);
				}
			}
		}
	}
}
