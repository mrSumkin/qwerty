using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000FD8 RID: 4056
[eiz("ASMA")]
[Serializable]
public sealed class byg : esc
{
	// Token: 0x06005379 RID: 21369 RVA: 0x002507D0 File Offset: 0x0024E9D0
	private byg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600537A RID: 21370 RVA: 0x002507DC File Offset: 0x0024E9DC
	public byg()
	{
	}

	// Token: 0x0600537B RID: 21371 RVA: 0x002507E8 File Offset: 0x0024E9E8
	public override int d5(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			List<int> classPropertyValue = A_0.GetClassPropertyValue<List<int>>("SpecialMercandiseLevels");
			if (classPropertyValue != null && classPropertyValue.Count > 0)
			{
				string text = evt.a(A_0);
				if (!string.IsNullOrWhiteSpace(text))
				{
					int num = serviceOrThrow.aqu().v().Skills.Get<e70>().g();
					string name = string.Format("SpecialMerchandiseLevel_{0}", text);
					int num2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>(name, new int?(-1)).Value;
					for (int i = classPropertyValue.Count - 1; i > num2; i--)
					{
						int num3 = classPropertyValue[i];
						if (num >= num3)
						{
							num2 = i;
							break;
						}
					}
					serviceOrThrow.aqu().r()[name] = num2;
				}
			}
		}
		return 0;
	}
}
