using System;
using System.Runtime.Serialization;

// Token: 0x02000A2F RID: 2607
[eiz("CVWPOR")]
[Serializable]
public sealed class dhk : bdw, ISerializable
{
	// Token: 0x06003DF2 RID: 15858 RVA: 0x001752A4 File Offset: 0x001734A4
	private dhk(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003DF3 RID: 15859 RVA: 0x001752AC File Offset: 0x001734AC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003DF4 RID: 15860 RVA: 0x001752B0 File Offset: 0x001734B0
	public dhk()
	{
	}

	// Token: 0x06003DF5 RID: 15861 RVA: 0x001752BC File Offset: 0x001734BC
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0 != null)
		{
			bool flag = false;
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				foreach (d4n d4n in service.ahl())
				{
					h h;
					if (d4n.b != null && !d4n.b.aa().Dead && d4n.b.aa().FactionId == asp.bf && d4n.b.aa().PersonalAttitudes.TryGetValue(asp.a, out h) && h == h.a)
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				bv9 bv = serviceOrThrow.aqu().ac() as bv9;
				if (bv != null)
				{
					bv.a(asp.bg, asp.a, h.a, null, true, false, false);
					bv.a(asp.bf, asp.a, h.a, null, true, false, false);
				}
			}
		}
	}
}
