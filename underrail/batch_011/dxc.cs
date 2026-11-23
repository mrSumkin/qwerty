using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000FBE RID: 4030
[eiz("CISMLC")]
[Serializable]
public sealed class dxc : dnh, ISerializable
{
	// Token: 0x0600529D RID: 21149 RVA: 0x0024E3E0 File Offset: 0x0024C5E0
	private dxc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600529E RID: 21150 RVA: 0x0024E3EC File Offset: 0x0024C5EC
	public dxc()
	{
	}

	// Token: 0x0600529F RID: 21151 RVA: 0x0024E3F8 File Offset: 0x0024C5F8
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		List<int> classPropertyValue = A_0.GetClassPropertyValue<List<int>>("SpecialMercandiseLevels");
		if (classPropertyValue != null && classPropertyValue.Count > 0)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				string text = evt.a(A_0);
				if (!string.IsNullOrWhiteSpace(text))
				{
					int num = serviceOrThrow.aqu().v().Skills.Get<e70>().g();
					string name = string.Format("SpecialMerchandiseLevel_{0}", text);
					int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>(name, new int?(-1)).Value;
					if (value >= 0)
					{
						for (int i = value + 1; i < classPropertyValue.Count; i++)
						{
							int num2 = classPropertyValue[i];
							if (num >= num2)
							{
								return true;
							}
						}
					}
				}
			}
		}
		return false;
	}
}
