using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B6A RID: 2922
[eiz("CCUTMRJ")]
[Serializable]
public sealed class el8 : cze, ISerializable
{
	// Token: 0x060042ED RID: 17133 RVA: 0x001A248C File Offset: 0x001A068C
	private el8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060042EE RID: 17134 RVA: 0x001A2498 File Offset: 0x001A0698
	public el8()
	{
	}

	// Token: 0x060042EF RID: 17135 RVA: 0x001A24A4 File Offset: 0x001A06A4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v().b() != null)
		{
			bool flag = false;
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				foreach (d4n d4n in service.ahl())
				{
					h h;
					if (d4n.b != null && !d4n.b.aa().Dead && d4n.b.aa().FactionId == asp.eb && d4n.b.aa().PersonalAttitudes.TryGetValue(asp.a, out h) && h == h.a)
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
					bv.a(asp.eb, asp.a, h.a, null, true, false, false);
					bv.a(asp.ec, asp.a, h.a, null, true, false, false);
					bv.a(asp.d0, asp.a, h.a, null, true, false, false);
				}
			}
		}
	}
}
