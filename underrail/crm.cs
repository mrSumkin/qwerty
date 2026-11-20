using System;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02001194 RID: 4500
public static class crm
{
	// Token: 0x0600600A RID: 24586 RVA: 0x0029D778 File Offset: 0x0029B978
	public static void a(b0b A_0, string A_1)
	{
		czh.a(A_0, "entity");
		czh.a(A_1, "storageProperty");
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			if (A_0.Area != null)
			{
				A_0.an();
			}
			serviceOrThrow.aqu().r()[A_1] = A_0;
		}
	}

	// Token: 0x0600600B RID: 24587 RVA: 0x0029D7D0 File Offset: 0x0029B9D0
	public static b0b a(string A_0, bt4 A_1)
	{
		czh.a(A_0, "storageProperty");
		czh.a(A_1, "location");
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			b0b classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<b0b>(A_0);
			serviceOrThrow.aqu().r().RemoveProperty(A_0);
			if (classPropertyValue != null)
			{
				aud aud;
				Vector3 a_;
				HorizontalDirection a_2;
				A_1.a(serviceOrThrow.aqw(), out aud, out a_, out a_2);
				if (aud != null)
				{
					classPropertyValue.Location = a_;
					classPropertyValue.VisualDirection = a_2;
					aud.a(classPropertyValue);
					return classPropertyValue;
				}
			}
		}
		return null;
	}
}
